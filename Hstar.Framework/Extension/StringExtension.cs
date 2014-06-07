/*********************************************************
 * CreateBy：Hstar
 * CreateOn：14/06/02 14:19:55
 * Description：
 * *******************************************************/

namespace Hstar.Framework.Extension
{
    public static class StringExtension
    {
        public static string GetStringWithLen(this string str, int maxLen, string prefix = "...")
        {
            str = str ?? "";
            return str.Length > maxLen ? str.Substring(0, maxLen - prefix.Length) + prefix : str;
        }
    }
}