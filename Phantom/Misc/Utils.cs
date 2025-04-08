using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace Phantom
{
    // Either Encryption Mode (XOR or AES) By default AES Is chosen, but as said below you can add XOR back :o
    internal enum EncryptionMode
    {
        AES,
        XOR
    }

    internal class Utils
    {
        // Find Embedded Resource Function
        internal static byte[] GetEmbeddedResource(string name)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            MemoryStream ms = new MemoryStream();
            Stream stream = asm.GetManifestResourceStream(name);
            stream.CopyTo(ms);
            stream.Dispose();
            byte[] ret = ms.ToArray();
            ms.Dispose();
            return ret;
        }

        // Get Embedded Resource Function
        internal static string GetEmbeddedString(string name)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            StreamReader stream = new StreamReader(asm.GetManifestResourceStream(name));
            string ret = stream.ReadToEnd();
            stream.Close();
            stream.Dispose();
            return ret;
        }

        // AES Encryptor (XOR is still here from the old Jlaive, you can implement that back in :o) [I might implement XOR soon]
        internal static byte[] Encrypt(EncryptionMode type, byte[] input, byte[] key, byte[] iv)
        {
            switch (type)
            {
                case EncryptionMode.AES:
                    {
                        AesManaged aes = new AesManaged();
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;
                        ICryptoTransform encryptor = aes.CreateEncryptor(key, iv);
                        byte[] encrypted = encryptor.TransformFinalBlock(input, 0, input.Length);
                        encryptor.Dispose();
                        aes.Dispose();
                        return encrypted;
                    }
                case EncryptionMode.XOR:
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            input[i] = (byte)(input[i] ^ key[i % key.Length]);
                        }
                        return input;
                    }
            }
            return null;
        }

        // Compress files Function
        internal static byte[] Compress(byte[] bytes)
        {
            MemoryStream msi = new MemoryStream(bytes);
            MemoryStream mso = new MemoryStream();
            GZipStream gs = new GZipStream(mso, CompressionMode.Compress);
            msi.CopyTo(gs);
            gs.Dispose();
            mso.Dispose();
            msi.Dispose();
            return mso.ToArray();
        }

        // RandomString Generator (Very crucial to this project, don't mess with it)
        internal static string RandomString(int length, Random rng)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[rng.Next(s.Length)]).ToArray());
        }
    }
}
