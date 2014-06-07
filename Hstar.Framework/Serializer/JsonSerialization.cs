/*********************************************************
 * CreateBy：Hstar
 * CreateOn：14/05/25 16:05:54
 * Description：
 * *******************************************************/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hstar.Framework.Serializer
{
    public static class JsonSerialization
    {
        /// <summary>
        /// 将对象序列化为JSON格式的字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="dateTimeFomat">日期格式</param>
        /// <returns></returns>
        public static string Serialize(object obj, string dateTimeFomat = "yyyy/MM/dd")
        {
            IsoDateTimeConverter dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = dateTimeFomat };
            return JsonConvert.SerializeObject(obj, dateTimeConverter);
        }

        /// <summary>
        /// 将JSON格式字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}