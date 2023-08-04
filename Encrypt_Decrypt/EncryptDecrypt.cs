using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt_Decrypt
{
    public class Progress_status
    {
        public static long progressBar_MaxValue = 0;
        public static long progressBar_Value = 0;
        public static string Information { get; internal set; }
        public static bool working { get; internal set; }
        public enum Operation
        {
            none,
            Encryption_Text,
            Decryption_Text,
            Encryption_File,
            Decryption_File,
            Encryption_Folder,
            Decryption_Folder
        }
        public static Operation operation = Operation.none;
        public static void Cancel_Progress()
        {
            if (operation != Operation.none)
            {
                working = false;
                Information = "Canceling";
            }
        }
    }
    internal class I_O
    {
        public static byte[] resultArray;

        public static void minimizeMemory()
        {
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle,
                (UIntPtr)0xFFFFFFFF, (UIntPtr)0xFFFFFFFF);
        }
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetProcessWorkingSetSize(IntPtr process,
            UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);
    };

    /*Encryption__Decryption__Text*/
    public class Encryption__Decryption__Text
    {
        /*Encryption_method*/
        private static string Encryption_method(string Text, string key)
        {
            try
            {
                byte[] toEncryptedArray = UTF8Encoding.UTF8.GetBytes(Text);

                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();

                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                objMD5CryptoService.Clear();
                objMD5CryptoService.Dispose();

                using (var objTripleDESCryptoService = new TripleDESCryptoServiceProvider())
                {
                    objTripleDESCryptoService.Key = securityKeyArray;
                    objTripleDESCryptoService.Mode = CipherMode.ECB;
                    objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

                    using (var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor())
                    {
                        I_O.resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);
                        securityKeyArray.Initialize();
                        return Convert.ToBase64String(I_O.resultArray, 0, I_O.resultArray.Length);
                    }
                }

            }
            catch (Exception)
            {
                return "Error";
            }
            finally
            {
                I_O.minimizeMemory();
            }
        }
        /*Decryption_method*/
        private static string Decryption_method(string Text, string key)
        {
            try
            {
                byte[] toEncryptArray = Convert.FromBase64String(Text);
                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();

                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                objMD5CryptoService.Clear();
                objMD5CryptoService.Dispose();
                using (var objTripleDESCryptoService = new TripleDESCryptoServiceProvider())
                {
                    objTripleDESCryptoService.Key = securityKeyArray;
                    objTripleDESCryptoService.Mode = CipherMode.ECB;
                    objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

                    using (var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor())
                    {
                        I_O.resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                        securityKeyArray.Initialize();
                        return UTF8Encoding.UTF8.GetString(I_O.resultArray);
                    }
                }
            }
            catch (Exception)
            {
                return "Error incorent input";
            }
            finally
            {
                I_O.minimizeMemory();
            }
        }
        /*Encryption Text*/
        public static string Encryption(string Text, string key)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(key))
            {
                Progress_status.operation = Progress_status.Operation.Encryption_Text;
                result = Encryption_method(Text, key);
            }
            else
            {
                result = "Text or Key is NullOrEmpty";
            }
            return result;
        }
        /*Decryption Text*/
        public static string Decryption(string Text, string key)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(key))
            {
                Progress_status.operation = Progress_status.Operation.Decryption_Text;
                result = Decryption_method(Text, key);
            }
            else
            {
                result = "Text or Key is NullOrEmpty";
            }
            return result;
        }
    }

    /*Encryption__Decryption__File*/
    public class Encryption__Decryption__File
    {
        private static bool CheckPassword(string path, byte[] Encrypted_Password, string password)
        {
            string decrypted_Password = null;
            using (BinaryReader fs = new BinaryReader(File.OpenRead(path)))
            {
                decrypted_Password = Encryption__Decryption__Text.Decryption(Convert.ToBase64String(Encrypted_Password), password);
            }
            if (decrypted_Password != "Error incorent input")
            {
                return true; // if password is not incorent
            }
            else return false;
        }
        private static string CheckPathName(string path)
        {
            for (int i = 1; File.Exists(path); i++)
            {
                string fileName = Path.GetFileName(path);
                if (fileName.StartsWith(string.Format("Copy({0})", i - 1)))
                {
                    path = path.Replace(string.Format("Copy({0})", i - 1), string.Format("Copy({0})", i));
                }
                else
                {
                    path = path.Replace(fileName, string.Format("Copy({0})", i) + fileName);
                }
            }
            return path;
        }
        private static string Encryption_method(string path, string password, bool isFolder)
        {
            string resultFilePath = path + ".alo";
            string resultFolderPath = path.Remove(path.Length - 3, 3) + "alf";
            string outputName;
            Progress_status.working = true;
            if (isFolder)
            {
                outputName = CheckPathName(resultFolderPath);
            }
            else outputName = CheckPathName(resultFilePath);

            byte[] Encrypted_Password = Convert.FromBase64String(Encryption__Decryption__Text.Encryption(password, password));
            try
            {
                Progress_status.Information = "Get File...";

                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(password));
                objMD5CryptoService.Clear();

                using (var objTripleDESCryptoService = new TripleDESCryptoServiceProvider())
                {
                    objTripleDESCryptoService.Key = securityKeyArray;
                    objTripleDESCryptoService.Mode = CipherMode.ECB;
                    objTripleDESCryptoService.Padding = PaddingMode.Zeros;

                    using (var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor())
                    using (FileStream fs = new FileStream(outputName, FileMode.OpenOrCreate, FileAccess.Write))
                    using (FileStream fsR = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        Progress_status.Information = "Encryption...";
                        fs.Write(Encrypted_Password, 0, Encrypted_Password.Length);
                        Progress_status.progressBar_MaxValue = fsR.Length;
                        int totalSize = (int)fsR.Length;
                        int chunkSize = 1024 * 1024 * 64;// 64MB
                        int index = 0;

                        byte[] blockbyte = new byte[chunkSize];
                        int bytesRead = 0;
                        while (index < totalSize && Progress_status.working)
                        {
                            if (totalSize - index < chunkSize)
                            {
                                chunkSize = totalSize - index;
                            }
                            blockbyte = new byte[chunkSize];
                            bytesRead = fsR.Read(blockbyte, 0, blockbyte.Length);

                            I_O.resultArray = objCrytpoTransform.TransformFinalBlock(blockbyte, 0, blockbyte.Length);
                            fs.Write(I_O.resultArray, 0, I_O.resultArray.Length);
                            Progress_status.progressBar_Value = fs.Length;
                            index += chunkSize;
                        }
                        fsR.Flush();
                        fsR.Close();
                        fs.Flush();
                        fs.Close();
                    }
                    if (!Progress_status.working)
                    {
                        return outputName;
                    }
                    Progress_status.Information = "File Encrpted";
                    return "File Encrpted";
                }
            }
            catch (Exception)
            {
                if (File.Exists(resultFilePath))
                {
                    File.Delete(resultFilePath);
                }
                return "Error";
            }
            finally
            {
                I_O.minimizeMemory();
            }
        }
        private static string Decryption_method(string path, string password, bool isFolder)
        {
            try
            {
                Progress_status.working = true;

                string newPathName;
                using (FileStream fsR = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fsR))
                {
                    Progress_status.Information = "Checking Password...";
                    byte[] Encrypted_Password = Convert.FromBase64String(Encryption__Decryption__Text.Encryption(password, password));
                    if (!CheckPassword(path, br.ReadBytes(Encrypted_Password.Length), password))
                    {
                        return "incorect password";
                    }
                    Progress_status.Information = "Get File...";
                    if (isFolder)
                    {
                        newPathName = path.Remove(path.Length - 3, 3) + "zip";
                    }
                    else newPathName = CheckPathName(path.Remove(path.Length - 4, 4));

                    MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
                    byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(password));
                    objMD5CryptoService.Clear();
                    objMD5CryptoService.Dispose();

                    using (var objTripleDESCryptoService = new TripleDESCryptoServiceProvider())
                    {
                        objTripleDESCryptoService.Key = securityKeyArray;
                        objTripleDESCryptoService.Mode = CipherMode.ECB;
                        objTripleDESCryptoService.Padding = PaddingMode.Zeros;
                        using (var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor())
                        using (FileStream fs = new FileStream(newPathName, FileMode.Create, FileAccess.Write))
                        {
                            Progress_status.Information = "Decryption...";

                            int totalSize = (int)fsR.Length;
                            int chunkSize = 1024 * 1024 * 64;// 64MB

                            byte[] blockbyte = new byte[chunkSize];
                            int bytesRead = 0;
                            fsR.Seek(Encrypted_Password.Length, SeekOrigin.Begin);
                            int index = Encrypted_Password.Length;

                            while (index < totalSize && Progress_status.working)
                            {
                                if (totalSize - index < chunkSize)
                                {
                                    chunkSize = totalSize - index;
                                }
                                blockbyte = new byte[chunkSize];
                                bytesRead = fsR.Read(blockbyte, 0, blockbyte.Length);

                                I_O.resultArray = objCrytpoTransform.TransformFinalBlock(blockbyte, 0, blockbyte.Length);
                                fs.Write(I_O.resultArray, 0, I_O.resultArray.Length);

                                I_O.resultArray = null;
                                index += chunkSize;
                            }
                            fsR.Flush();
                            fsR.Close();
                            fs.Flush();
                            fs.Close();

                            if (isFolder || !Progress_status.working)
                            {
                                return newPathName;
                            }
                        }
                    }
                    Progress_status.Information = "File Decrypted";
                    return "File Decrypted";
                }
            }
            catch (Exception)
            {
                return "Error";
            }
            finally
            {
                I_O.minimizeMemory();
            }
        }
        /// <summary>
        /// Encryption File
        /// </summary>
        /// <param name="Path">Full path. example:c:\text.[file extension] Or c:\Folder </param>
        /// <param name="key">Password</param>
        /// <param name="Folder"></param>
        /// <returns>Result:'File Encrpted' or 'Error' or 'Cancel'</returns>
        public static string Encryption(string path, string key, in bool Folder = false)
        {
            if (File.Exists(path))
            {
                Progress_status.operation = Progress_status.Operation.Encryption_File;
                string result = Encryption_method(path, key, Folder);
                Progress_status.progressBar_MaxValue = 0;
                Progress_status.progressBar_Value = 0;
                if (!Progress_status.working)
                {
                    File.Delete(result);
                    return "Cancel";
                }
                return result;
            }
            else
            {
                return "not found file";
            }
        }
        /// <summary>
        /// Decryption File
        /// </summary>
        /// <param name="Path">Full path. example:c:\text.[file extension]</param>
        /// <param name="key">Password</param>
        /// <param name="Folder"></param>
        /// <returns>Result:'File Decrypted' or 'Error' or 'incorect password'</returns>
        public static string Decryption(string path, string key, bool Folder = false)
        {
            if (File.Exists(path))
            {
                
                Progress_status.operation = Progress_status.Operation.Decryption_File;
                string result = Decryption_method(path, key, Folder);
                Progress_status.progressBar_MaxValue = 0;
                Progress_status.progressBar_Value = 0;
                if (!Progress_status.working)
                {
                    File.Delete(result);
                    return "Cancel";
                }
                return result;
            }
            else
            {
                return "not found file";
            }
        }
    }

    /*Encryption__Decryption__Folder*/
    public class Encryption__Decryption__Folder
    {
        public static string Encryption(string folderPath, string key)
        {
            if (Directory.Exists(folderPath))
            {
                Progress_status.operation = Progress_status.Operation.Encryption_Folder;
                string CompResult = Compress_Decompress.Compress(folderPath);
                if (CompResult.EndsWith(".zip"))
                {
                    string MainResult = Encryption__Decryption__File.Encryption(CompResult, key, true);
                    if (!Progress_status.working)
                    {
                        return "Cancel";
                    }
                    File.Delete(CompResult);
                    if (MainResult == "File Encrpted")
                    {
                        return "Folder Encrpted";
                    }
                    else
                    {
                        return MainResult;
                    }
                }
                else
                {
                    return CompResult;
                }
            }
            else
            {
                return "not found folder";
            }
        }
        public static string Decryption(string filePath, string key)
        {
            if (File.Exists(filePath))
            {
                Progress_status.operation = Progress_status.Operation.Decryption_Folder;
                string DecryptResult = Encryption__Decryption__File.Decryption(filePath, key, true);
                if (!Progress_status.working)
                {
                    return "Cancel";
                }
                else if (DecryptResult.EndsWith(".zip"))
                {
                    string extResult = Compress_Decompress.Decompress(DecryptResult);
                    if (extResult == "Extracted")
                    {
                        return "Folder Decrypted";
                    }
                    else
                    {
                        return extResult;
                    }
                }
                else
                {
                    return DecryptResult;
                }
            }
            else
            {
                return "not found file";
            }
        }
    }
    /*Compress_Decompress*/
    internal class Compress_Decompress
    {
        public static string Compress(string path)
        {
            try
            {
                using (var zip = new ZipFile(new FileInfo(path).Name))
                {
                    string outputPath = path + ".zip";
                    zip.AddDirectory(path);
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
                    zip.Save(outputPath);
                    zip.Dispose();
                    return outputPath;
                }
            }
            catch (Exception)
            {
                return "Error";
            }
        }
        public static string Decompress(string path)
        {
            try
            {
                using (var zip = ZipFile.Read(path))
                {
                    string FolderName = path.Remove(path.Length - 3, 3);
                    Directory.CreateDirectory(FolderName);
                    zip.ExtractAll(FolderName, ExtractExistingFileAction.OverwriteSilently);
                    zip.Dispose();
                    File.Delete(path);
                    return "Extracted";
                }
            }
            catch (Exception)
            {
                return "Error";
            }
        }
        public static void CompressFile(string inputPath, string outputPath)
        {
            using (FileStream originalFileStream = File.OpenRead(inputPath))
            {
                using (FileStream compressedFileStream = File.Create(outputPath))
                {
                    using (DeflateStream compressionStream = new DeflateStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }
        public static void DecompressFile(string inputPath, string outputPath)
        {
            using (FileStream compressedFileStream = File.OpenRead(inputPath))
            {
                using (FileStream originalFileStream = File.Create(outputPath))
                {
                    using (DeflateStream decompressionStream = new DeflateStream(compressedFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(originalFileStream);
                    }
                }
            }
        }
    }
}