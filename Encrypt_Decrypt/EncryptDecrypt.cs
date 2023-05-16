using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt_Decrypt
{
    public class ProgressBar_Value
    {
        public int MaxValue = 100;
        public int Value = 0;
    }
    internal class I_O
    {
        public static byte[] toEncryptedArray;
        public static byte[] toEncryptArray;
        public static byte[] resultArray;
    };

    /*Encryption__Decryption__Text*/
    public class Encryption__Decryption__Text
    {
        private string SecurityKey = "Adv@n3eD KeY!";
        /*Encryption_method*/
        private string Encryption_method(string Text, string key)
        {
            try
            {
                SecurityKey = key;
                byte[] toEncryptedArray = UTF8Encoding.UTF8.GetBytes(Text);

                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();

                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));

                objMD5CryptoService.Clear();
                objMD5CryptoService.Dispose();

                var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();

                objTripleDESCryptoService.Key = securityKeyArray;

                objTripleDESCryptoService.Mode = CipherMode.ECB;

                objTripleDESCryptoService.Padding = PaddingMode.PKCS7;


                using (var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor())
                {
                    byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptedArray, 0, toEncryptedArray.Length);
                    objTripleDESCryptoService.Clear();
                    objTripleDESCryptoService.Dispose();
                    objCrytpoTransform.Dispose();
                    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
                }


            }
            catch (Exception)
            {
                return "Error";
            }
        }
        /*Decryption_method*/
        private string Decryption_method(string Text, string key)
        {
            try
            {
                SecurityKey = key;
                byte[] toEncryptArray = Convert.FromBase64String(Text);
                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();

                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKey));
                objMD5CryptoService.Clear();
                objMD5CryptoService.Dispose();

                var objTripleDESCryptoService = new TripleDESCryptoServiceProvider();

                objTripleDESCryptoService.Key = securityKeyArray;

                objTripleDESCryptoService.Mode = CipherMode.ECB;

                objTripleDESCryptoService.Padding = PaddingMode.PKCS7;

                using (var objCrytpoTransform = objTripleDESCryptoService.CreateDecryptor())
                {
                    byte[] resultArray = objCrytpoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                    objTripleDESCryptoService.Clear();
                    objTripleDESCryptoService.Dispose();
                    objCrytpoTransform.Dispose();
                    return UTF8Encoding.UTF8.GetString(resultArray);
                }


            }
            catch (Exception)
            {
                return "Error incorent input";
            }
        }
        /*Encryption Text*/
        public static string Encryption(string Text, string key)
        {
            string cypher = string.Empty;
            if (!string.IsNullOrEmpty(Text))
            {
                cypher = new Encryption__Decryption__Text().Encryption_method(Text, key);
            }
            return cypher;
        }
        /*Decryption Text*/
        public static string Decryption(string Text, string key)
        {
            string cypher = string.Empty;
            if (!string.IsNullOrEmpty(Text))
            {
                cypher = new Encryption__Decryption__Text().Decryption_method(Text, key);
            }
            return cypher;
        }
    }

    /*Encryption__Decryption__File*/
    public class Encryption__Decryption__File
    {
        private static string SecurityKeyF = "Adv@n3eD KeY!";

        private static string Encryption_method(string path, string password, bool isFolder)
        {
            try
            {
                SecurityKeyF = password;
                I_O.toEncryptedArray = File.ReadAllBytes(path);
                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKeyF));
                objMD5CryptoService.Clear();
                using (var objTripleDESCryptoService = new TripleDESCryptoServiceProvider())
                {
                    objTripleDESCryptoService.Key = securityKeyArray;
                    objTripleDESCryptoService.Mode = CipherMode.ECB;
                    objTripleDESCryptoService.Padding = PaddingMode.PKCS7;
                    using (var objCrytpoTransform = objTripleDESCryptoService.CreateEncryptor())
                    {
                        I_O.resultArray = objCrytpoTransform.TransformFinalBlock(I_O.toEncryptedArray, 0, I_O.toEncryptedArray.Length);
                        securityKeyArray.Initialize();
                        if (isFolder)
                        {
                            string Fpath = path.Remove(path.Length - 3, 3);
                            using (FileStream fs = File.Create(Fpath + "alf"))
                            {
                                fs.Write(I_O.resultArray, 0, I_O.resultArray.Length);
                                File.Delete(path);
                            }
                        }
                        else
                        {
                            using (FileStream fs = File.Create(path + ".alo"))
                            {
                                fs.Write(I_O.resultArray, 0, I_O.resultArray.Length);
                            }
                        }

                        return "File Encrpted";
                    }
                }
            }
            catch (Exception)
            {
                return "Error";
            }
            finally
            {
                minimizeMemory();
            }
        }
        private static string Decryption_method(string path, string password, bool isFolder)
        {
            try
            {
                SecurityKeyF = password;

                I_O.toEncryptArray = File.ReadAllBytes(path);

                MD5CryptoServiceProvider objMD5CryptoService = new MD5CryptoServiceProvider();
                byte[] securityKeyArray = objMD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SecurityKeyF));
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
                        if (isFolder)
                        {

                            string Fpath = path.Remove(path.Length - 3, 3) + "zip";
                            using (FileStream fs = File.Create(Fpath))
                            {
                                fs.Write(I_O.resultArray, 0, I_O.resultArray.Length);
                                File.Delete(path);
                            }
                            return Fpath;
                        }
                        else
                        {
                            using (FileStream fs = File.Create(path.Remove(path.Length - 3, 3)))
                            {
                                fs.Write(I_O.resultArray, 0, I_O.resultArray.Length);
                            }
                        }
                        return "File Decrypted";
                    }
                }


            }
            catch (Exception)
            {
                return "incorect password";
            }

            finally
            {
                minimizeMemory();
            }
        }
        public static string Encryption(string filePath, string key, bool Folder = false)
        {
            if (File.Exists(filePath))
            {
                string result = Encryption_method(filePath, key, Folder);
                return result;
            }
            else
            {
                return "not found file";
            }
        }
        public static string Decryption(string filePath, string key, bool Folder = false)
        {
            if (File.Exists(filePath))
            {
                string result = Decryption_method(filePath, key, Folder);
                return result;
            }
            else
            {
                return "not found file";
            }
        }

        private static void minimizeMemory()
        {
            I_O.resultArray.Initialize();
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle,
                (UIntPtr)0xFFFFFFFF, (UIntPtr)0xFFFFFFFF);
        }

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetProcessWorkingSetSize(IntPtr process,
            UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);
    }

    /*Encryption__Decryption__Folder*/
    public class Encryption__Decryption__Folder
    {
        public static string Encryption(string folderPath, string key)
        {
            if (Directory.Exists(folderPath))
            {
                string CompResult = Compress_Decompress.Compress(folderPath);
                if (CompResult.EndsWith(".zip"))
                {
                    string MainResult = Encryption__Decryption__File.Encryption(CompResult, key, true);
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
    }

}
