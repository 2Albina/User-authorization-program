using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;

namespace DP1
{
    public static class PasswordManager
    {
        public static string Hash(string password)
        {
            // Хеширование-шифрование перестановкой строки "12345678" на ключе-пароле
            string key = password;
            string text = "12345678";//password;
            string hashPW = "";
            string block = "";
            int countOfBlocks = 1;
            
            if (key.Length > text.Length) {
                key = key.Substring(0, text.Length);
            }
            else if (key.Length < text.Length) {
                if (key.Length == 0)
                    return hashPW;                 
                else if (text.Length % key.Length != 0)
                    text += String.Concat(Enumerable.Repeat(" ", key.Length - text.Length % key.Length));
                countOfBlocks = text.Length / key.Length;
            }

            for (int i = 0; i < countOfBlocks; i++) {
                List<int> k = GenerateKey(key);
                block = text.Substring(i*key.Length, key.Length);
                hashPW += HashingBlock(k, block);                
            }

            return hashPW;
        }
        private static List<int> GenerateKey(string key)
        {
            List<char> t = key.ToList();
            List<char> n_key = key.ToList();
            t.Sort();
            List<int> k = new List<int>();
            for (int i = 0; i < t.Count; i++)
            {
                int cr = n_key.IndexOf(t[i]);
                k.Add(cr);
                n_key[cr] = '\n';
            }
            return k;
        }
        private static string HashingBlock(List<int> key, string text)
        {
            string hashedText = "";
            for (int i = 0; i < key.Count; i++)
                hashedText += text[key[i]];
            return hashedText;
        }
        public static bool ComparePasswords(string TrueHasedPassword, string inputPassword)
        {
            return TrueHasedPassword == Hash(inputPassword);
        }

        public static bool HasLimitations(string password)
        {
            var hasLower = false;
            var hasUpper = false;
            foreach (var symbol in password)
            {
                hasLower |= char.IsLower(symbol);
                hasUpper |= char.IsUpper(symbol);
            }

            return hasLower && hasUpper;
        }
    }
}