using System;
using Hprose.Server;
using CcNet.Utils.Extensions;
using CcNet.Notify;

namespace CcNet.NotifySvc
{
    /// <summary>
    /// RPC服务类
    /// </summary>
    internal class RpcService
    {
        /// <summary>
        /// 单例实例
        /// </summary>
        public static readonly RpcService Singleton = new RpcService();

        /// <summary>
        /// 服务实例
        /// </summary>
        private HproseService m_Service = null;

        /// <summary>
        /// 服务是否已启动
        /// </summary>
        /// <returns></returns>
        public bool IsStarted => m_Service?.IsStarted() ?? false;

        private RpcService() { }

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="protocol">网络协议</param>
        /// <param name="port">监听端口</param>
        /// <param name="notifierName">通知器名称</param>
        /// <returns>错误信息</returns>
        public string Start(string protocol, int port, string notifierName, WriteLogDelegate writeLog = null)
        {
            try
            {
                if (m_Service != null)
                {
                    if (m_Service.IsStarted())
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    //var notifierName = ConfigHelper.GetValue("Notifier");
                    var notifier = GetNotifier(notifierName);
                    if (null == notifier)
                    {
                        throw new Exception("创建通知器实例失败");
                    }

                    if (writeLog != null)
                    {
                        notifier.SetLogger(writeLog);
                    }

                    //var port = ConfigHelper.GetInt32("ListenPort");
                    //var protocol = ConfigHelper.GetValue("NetProtocol").LowerCase();

                    m_Service = GetServer(protocol, port);
                    m_Service.Add("SendMessage", notifier);
                }

                m_Service.Start();

                return m_Service.IsStarted() ? string.Empty : "服务启动失败";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 停止服务 
        /// </summary>
        /// <returns>错误信息</returns>
        public string Stop()
        {
            try
            {
                if (null == m_Service)
                {
                    return "服务实例为空";
                }

                if (m_Service.IsStarted())
                {
                    m_Service.Stop();
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 获取通知器实例
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        private static INotifier GetNotifier(string className)
        {
            var handle = Activator.CreateInstance("CcNet.Notify", $"CcNet.Notify.{className}");
            return handle?.Unwrap() as INotifier;
        }

        /// <summary>
        /// 获取服务实例
        /// </summary>
        /// <param name="protocol"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        private static HproseService GetServer(string protocol, int port)
        {
            if (protocol.Equals("http"))
            {
                return new HproseHttpListenerServer($"http://127.0.0.1:{port}/");
            }

            return new HproseTcpListenerServer($"{protocol}://127.0.0.1:{port}/");
        }
    }

    /// <summary>
    /// HproseService扩展类
    /// </summary>
    public static class HproseServiceExtension
    {
        /// <summary>
        /// 服务是否已启动
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public static bool IsStarted(this HproseService service)
        {
            if (null == service)
            {
                return false;
            }

            var value = service.GetValue("IsStarted");
            if (null == value)
            {
                return false;
            }

            return value.ToBool();
        }

        /// <summary>
        /// 启动服务 
        /// </summary>
        /// <param name="service"></param>
        public static void Start(this HproseService service)
            => service?.Invoke("Start");

        /// <summary>
        /// 停止服务 
        /// </summary>
        /// <param name="service"></param>
        public static void Stop(this HproseService service)
            => service?.Invoke("Stop");
    }
}