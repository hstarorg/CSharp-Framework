/*********************************************************
 * CreateBy：Hstar
 * CreateOn：14/05/24 23:16:21
 * Description：
 * *******************************************************/

using System;
using System.IO;
using log4net;
using log4net.Config;

namespace Hstar.Framework.Log 
{
    /// <summary>
    /// Log4Net日志框架的的帮助类
    /// </summary>
    public static class Log4NetHelper
    {
        /// <summary>
        /// [单例]默认日志记录器
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger("DefaultAppender");

        /// <summary>
        /// 记录Info级别的日志信息
        /// </summary>
        /// <param name="msg">日志信息</param>
        /// <param name="ex">[可选，默认null]异常对象</param>
        /// <param name="loggerName">[可选，默认""]日志名称</param>
        public static void Info(string msg, Exception ex = null, string loggerName = "")
        {
            var privateLog = string.IsNullOrEmpty(loggerName) ? Log : LogManager.GetLogger(loggerName);
            if (ex == null)
            {
                privateLog.Info(msg);
            }
            else
            {
                privateLog.Info(msg, ex);
            }
        }

        /// <summary>
        /// 初始化日志组件（Log4Net初始化）
        /// </summary>
        /// <param name="configFilePath">Log4Net配置文件地址</param>
        /// <param name="isWacth">[可选,默认true]是否监视配置文件变化</param>
        public static void InitLog4Net(string configFilePath, bool isWacth = true)
        {
            if (isWacth)
            {
                XmlConfigurator.ConfigureAndWatch(new FileInfo(configFilePath));
            }
            else
            {
                XmlConfigurator.Configure(new FileInfo(configFilePath));
            }
        }
    }
}