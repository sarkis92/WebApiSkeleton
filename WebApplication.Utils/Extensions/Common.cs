using System;

namespace WebApplication.Utils.Extensions
{
    public static class Common
    {
        public static string EnsureLeadingSlash(this string s)
        {
            if (!s.StartsWith("/"))
            {
                s = $"/{s}";
            }
            return s;
        }

        public static void ThrowIfNull(this object o, string msg)
        {
            if (o == null)
            {
                throw new ArgumentNullException(msg);
            }
        }
    }
}