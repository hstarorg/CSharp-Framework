/*********************************************************
 * CreateBy：Hstar
 * CreateOn：14/05/25 16:14:46
 * Description：
 * *******************************************************/

using Hstar.Framework.Serializer;

namespace Hstar.Framework.Extension
{
    public static class JsonExtension
    {
        /// <summary>
        /// 将对象序列化为JSON字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJsonString(this object obj)
        {
            return JsonSerialization.Serialize(obj);
        }

        /// <summary>
        /// 将JSON字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T ToJsonObject<T>(this string jsonString)
        {
            return JsonSerialization.Deserialize<T>(jsonString);
        }
    }
}