using CcNet.Utils;
using CcNet.Utils.Extensions;

namespace CcNet.Notify
{
    /// <summary>
    /// 钉钉通知器类
    /// </summary>
    public class DingTalkNotifier : INotifier
    {
        private WriteLogDelegate m_WriteLog = null;

        /// <summary>
        /// 设置日志记录器
        /// </summary>
        /// <param name="writeLog"></param>
        public void SetLogger(WriteLogDelegate writeLog) => m_WriteLog = writeLog;

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="uri">接口地址</param>
        /// <param name="message">消息内容</param>
        /// <param name="mobiles">接收手机号</param>
        /// <returns>错误信息</returns>
        public string SendMessage(string uri, string message, string[] mobiles)
        {
            var phones = string.Join(Chars.逗号.ToString(), mobiles);
            var error = DingTalkHelper.SendMessage(uri, message, mobiles);

            if (error.IsValid())
            {
                m_WriteLog?.Invoke("ERR", $"调用接口 {uri.GetValue()} 发送消息给 {phones} 失败：{error}");
            }
            else
            {
                m_WriteLog?.Invoke("INF", $"调用接口 {uri.GetValue()} 发送消息给 {phones} 成功");
            }

            return error;
        }
    }
}