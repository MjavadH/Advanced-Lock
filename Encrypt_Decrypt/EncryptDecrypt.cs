using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt
{
    public static class Progress_status
    {
        public static long progressBar_MaxValue = 100;
        public static long progressBar_Value = 0;
        public static string Information = "";
        public enum Mode
        {
            none,
            Encrypt,
            Decrypt
        }
        public static Mode GetMode = Mode.none;
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
                Information = "Canceling";
                switch (operation)
                {
                    case Operation.none:
                        break;
                    case Operation.Encryption_Text:
                        break;
                    case Operation.Decryption_Text:
                        break;
                    case Operation.Encryption_File:
                        break;
                    case Operation.Decryption_File:
                        break;
                    case Operation.Encryption_Folder:
                        break;
                    case Operation.Decryption_Folder:
                        break;
                }
            }
        }
    }
    internal class I_O
    {
        public static byte[] toEncryptedArray;
        public static byte[] toEncryptArray;
        public static byte[] resultArray;

        public static void minimizeMemory()
        {
            resultArray.Initialize();
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
                I_O.toEncryptedArray = UTF8Encoding.UTF8.GetBytes(Text);

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
                        I_O.resultArray = objCrytpoTransform.TransformFinalBlock(I_O.toEncryptedArray, 0, I_O.toEncryptedArray.Length);
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
                I_O.toEncryptArray = Convert.FromBase64String(Text);
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
                        I_O.resultArray = objCrytpoTransform.TransformFinalBlock(I_O.toEncryptArray, 0, I_O.toEncryptArray.Length);
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
        private static bool CheckPassword(string encryptedPassword, string password)
        {
            string decrypted_Password = Encryption__Decryption__Text.Decryption(encryptedPassword, password);
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
        private static async Task<string> Encryption_method(string path, string password, bool isFolder)
        {
            string resultFilePath = path + ".alo";
            string resultFolderPath = path.Remove(path.Length - 3, 3) + "alf";
            try
            {
                Progress_status.Information = "Get File...";
                I_O.toEncryptedArray = File.ReadAllBytes(path);
                Progress_status.progressBar_MaxValue = I_O.toEncryptedArray.Length;
                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(password));
                objMD5CryptoService.Clear();
                using (var objTripleDESCryptoService = new TripleDESCryptoServiceProvider())
                {
                    objTripleDESCryptoService.Key = securityKeyArray;
                    objTripleDESCryptoService.Mode = CipherMode.ECB;
                    objTripleDESCryptoService.Padding = PaddingMode.PKCS7;
                    using (var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor())
                    {
                        Progress_status.Information = "Encryption...";
                        I_O.resultArray = objCrytpoTransform.TransformFinalBlock(I_O.toEncryptedArray, 0, I_O.toEncryptedArray.Length);
                        securityKeyArray.Initialize();
                        Progress_status.Information = "Create File";
                        string tempPath = Path.GetTempFileName();
                        using (FileStream fs = File.Create(tempPath))
                        {
                            await fs.WriteAsync(I_O.resultArray, 0, I_O.resultArray.Length);
                            fs.Close();
                        }
                        if (isFolder)
                        {

                            string newFolderName = await Task.Run(() => CheckPathName(resultFolderPath));
                            File.WriteAllText(newFolderName, Encryption__Decryption__Text.Encryption(password, password) + "\n" + Convert.ToBase64String(File.ReadAllBytes(tempPath)));
                        }
                        else
                        {
                            string newFileName = await Task.Run(() => CheckPathName(resultFilePath));
                            File.WriteAllText(newFileName, Encryption__Decryption__Text.Encryption(password, password) + "\n" + Convert.ToBase64String(File.ReadAllBytes(tempPath)));
                        }
                        File.Delete(tempPath);
                        Progress_status.Information = "File Encrpted";
                        return "File Encrpted";
                    }
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
        private static async Task<string> Decryption_method(string path, string password, bool isFolder)
        {
            try
            {
                Progress_status.Information = "Checking Password...";
                string password_Lines = File.ReadLines(path).First();
                if (!CheckPassword(password_Lines, password))
                {
                    return "incorect password";
                }
                I_O.toEncryptArray = Convert.FromBase64String(File.ReadAllText(path).Split('\n')[1]);
                Progress_status.Information = "Get File...";
                I_O.minimizeMemory();
                Progress_status.progressBar_MaxValue = I_O.toEncryptedArray.Length;
                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(password));
                objMD5CryptoService.Clear();
                objMD5CryptoService.Dispose();
                using (var objTripleDESCryptoService = new TripleDESCryptoServiceProvider())
                {
                    objTripleDESCryptoService.Key = securityKeyArray;
                    objTripleDESCryptoService.Mode = CipherMode.ECB;
                    objTripleDESCryptoService.Padding = PaddingMode.PKCS7;
                    using (var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor())
                    {
                        Progress_status.Information = "Decryption...";
                        I_O.resultArray = objCrytpoTransform.TransformFinalBlock(I_O.toEncryptArray, 0, I_O.toEncryptArray.Length);
                        securityKeyArray.Initialize();
                        if (isFolder)
                        {
                            Progress_status.Information = "Create Folder...";
                            string Fpath = path.Remove(path.Length - 3, 3) + "zip";
                            using (FileStream fs = File.Create(Fpath))
                            {
                                fs.Write(I_O.resultArray, 0, I_O.resultArray.Length);
                            }
                            return Fpath;
                        }
                        else
                        {
                            Progress_status.Information = "Create File...";
                            string newPathName = await Task.Run(() => CheckPathName(path.Remove(path.Length - 4, 4)));
                            using (FileStream fs = File.Create(newPathName))
                            {
                                await fs.WriteAsync(I_O.resultArray, 0, I_O.resultArray.Length);
                                Progress_status.progressBar_Value = fs.Length;
                            }
                        }
                        Progress_status.Information = "File Decrypted";
                        return "File Decrypted";
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
        /// <summary>
        /// Encryption File
        /// </summary>
        /// <param name="filePath">File full path. example:c:/text.txt</param>
        /// <param name="key">Password</param>
        /// <param name="Folder"></param>
        /// <returns>Result:'File Encrpted' or 'Error'</returns>
        public static string Encryption(string filePath, string key, in bool Folder = false)
        {
            if (File.Exists(filePath))
            {
                Progress_status.operation = Progress_status.Operation.Encryption_File;
                Task<string> result = Encryption_method(filePath, key, Folder);
                return result.Result;
            }
            else
            {
                return "not found file";
            }
        }
        /// <summary>
        /// Decryption File
        /// </summary>
        /// <param name="filePath">File full path. example:c:/text.[file extension]</param>
        /// <param name="key">Password</param>
        /// <param name="Folder"></param>
        /// <returns>Result:'File Encrpted' or 'Error'</returns>
        public static string Decryption(string filePath, string key, bool Folder = false)
        {
            if (File.Exists(filePath))
            {
                Progress_status.operation = Progress_status.Operation.Decryption_File;
                Task<string> result = Decryption_method(filePath, key, Folder);
                return result.Result;
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
                if (DecryptResult.EndsWith(".zip"))
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
    public class Compress_Decompress
    {
        public static string Compress(string path)
        {
            try
            {
                using (var zip = new ZipFile())
                {
                    zip.AddDirectory(path);
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zip.Save(path + ".zip");
                    zip.Dispose();
                    return path + ".zip";
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