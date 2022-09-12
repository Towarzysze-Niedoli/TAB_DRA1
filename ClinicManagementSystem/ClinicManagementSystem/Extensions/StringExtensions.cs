using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Extensions
{
    public static class StringExtensions
    {
        public static string WordWrap(this string s, int maxLength, string indent = "")
        {
            if (s is null)
                return null;

            string[] words = s.Split(' ');
            int l = 0;
            StringBuilder sb = new StringBuilder(s.Length);
            
            for (int i = 0; i < words.Length; i++)
            {
                if (l + words[i].Length > maxLength)
                {
                    sb.Append('\n');
                    sb.Append(indent);
                }
                sb.Append(words[i]);
                sb.Append(' ');
            }

            return sb.ToString();
        }
    }
}
