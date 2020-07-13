using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TestCPU
{
    public class TestsCPU
    {
        public enum typeTest
        {
            hash,
            crypt,
            compress,
            image
        }
        public bool cancel = false;
        public TestsCPU()
        {
        }
        public void StartTest(BackgroundWorker backgroundWorker, typeTest test)
        {
            if (test == typeTest.hash)
                HashTest(backgroundWorker);
            if (test == typeTest.crypt)
                CryptTest(backgroundWorker);
            if (test == typeTest.compress)
                CompressTest(backgroundWorker);
            if (test == typeTest.image)
                ImageTest(backgroundWorker);
            
        }
        void HashTest(BackgroundWorker backgroundWorker)
        {
            byte[] arr = new byte[0xFFFFFF];
            Random rand = new Random();
            rand.NextBytes(arr);
            for (int i = 0; i < 1000; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    this.cancel = true;
                    return;
                }
                var hash = new SHA1CryptoServiceProvider().ComputeHash(arr);
                backgroundWorker.ReportProgress(i / 10 + 1);
            }
            this.cancel = false;
        }
        void CryptTest(BackgroundWorker backgroundWorker)
        {
            byte[] arr = new byte[0xFFFFFF];
            Random rand = new Random();
            rand.NextBytes(arr);
            var key = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            var iv = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            var crypto = new AesCryptographyService();
            for (int i = 0; i < 400; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    this.cancel = true;
                    return;
                }
                var encrypted = crypto.Encrypt(arr, key, iv);
                crypto.Decrypt(encrypted, key, iv);
                backgroundWorker.ReportProgress(i / 4  + 1);
            }
            this.cancel = false;
        }
        void CompressTest(BackgroundWorker backgroundWorker)
        {
            byte[] arr = new byte[0xFFFFFF];
            Random rand = new Random();
            rand.NextBytes(arr);
            string sourceFile = "unzipped";
            string zipFile = "zipped";
            using (FileStream fs = File.Create(sourceFile, 4096))
            {
                fs.Write(arr, 0, arr.Length);
            }
            for (int i = 0; i < 100; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    File.Delete(sourceFile);
                    File.Delete(zipFile);
                    this.cancel = true;
                    return;
                }
                CompressService.Compress(sourceFile, zipFile);
                CompressService.Decompress(zipFile, sourceFile);
                backgroundWorker.ReportProgress(i + 1);
            }
            File.Delete(sourceFile);
            File.Delete(zipFile);
            this.cancel = false;
        }
        void ImageTest(BackgroundWorker backgroundWorker)
        {
            Random rand = new Random(); 
            for (int i = 0; i < 100; i++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    this.cancel = true;
                    return;
                }
                Bitmap bitmap = new Bitmap(512, 512);
                for (int x = 0; x < 512; x++)
                {
                    for (int y = 0; y < 512; y++)
                    {
                        bitmap.SetPixel(x, y, Color.FromArgb(rand.Next()));
                    }
                }
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipXY);
                for (int x = 0; x < 512; x++)
                {
                    for (int y = 0; y < 512; y++)
                    {
                        bitmap.GetPixel(x, y).ToKnownColor();
                    }
                }
                backgroundWorker.ReportProgress(i + 1);
            }
            this.cancel = false;
        }
    }



    public class CompressService
    {
        public static void Compress(string sourceFile, string compressedFile)
        {
            // поток для чтения исходного файла
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                // поток для записи сжатого файла
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    // поток архивации
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        public static void Decompress(string compressedFile, string targetFile)
        {
            // поток для чтения из сжатого файла
            using (FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate))
            {
                // поток для записи восстановленного файла
                using (FileStream targetStream = File.Create(targetFile))
                {
                    // поток разархивации
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                    }
                }
            }
        }
    }
    public class AesCryptographyService
    {
        public byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.Zeros;

                aes.Key = key;
                aes.IV = iv;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(data, encryptor);
                }
            }
        }

        public byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.Zeros;

                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(data, decryptor);
                }
            }
        }

        private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                return ms.ToArray();
            }
        }
    }
}







