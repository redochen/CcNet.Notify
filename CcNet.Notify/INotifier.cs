namespace CcNet.Notify
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="level">日志级别</param>
    /// <param name="content">日志内容</param>
    public delegate void WriteLogDelegate(string level, string content);

    /// <summary>
    /// 通知器接口
    /// </summary>
    public interface INotifier
    {
        /// <summary>
        /// 设置日志
        /// </summary>
        /// <param name="writeLog"></param>
        void SetLogger(WriteLogDelegate writeLog);

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="uri">接口地址</param>
        /// <param name="message">消息内容</param>
        /// <param name="mobiles">接收手机号</param>
        /// <returns>错误信息</returns>
        string SendMessage(string uri, string message, string[] mobiles);
    }
}