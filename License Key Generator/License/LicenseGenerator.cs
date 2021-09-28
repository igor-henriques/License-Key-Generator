using System;
using System.Security.Cryptography;
using System.Text;

namespace License_Key_Generator.License
{
    public class LicenseGenerator
    {
        private static Random random = new Random();

        public static string GenerateKey(string pattern)
        {
            string LicenseKey = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                LicenseKey += GenerateRandomKeyPart() + EncryptedStringPattern(pattern);
            }

            return LicenseKey;
        }

        private static string GenerateRandomKeyPart()
        {
            string alphabet = "AaBbCcDdEeFfGgHhKkMmNnPpQqRrTtUuVvXxZz";
            string RandomAlphanumericPart = string.Empty;

            for (int i = 0; i <= 2; i++)
            {
                int index = random.Next(0, alphabet.Length);
                RandomAlphanumericPart += alphabet[index];
            }
            return RandomAlphanumericPart;
        }

        private static string EncryptedStringPattern(string pattern)
        {
            RNGCryptoServiceProvider randomizeIt = new RNGCryptoServiceProvider();

            byte[] encodedPattern = Encoding.ASCII.GetBytes(pattern);

            for (int i = 0; i < encodedPattern.Length; i++)
            {
                randomizeIt.GetBytes(encodedPattern);
            }
            int index = random.Next(0, encodedPattern.Length);
            return encodedPattern[index].ToString();
        }
    }
}
