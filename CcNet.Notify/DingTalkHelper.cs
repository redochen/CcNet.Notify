using System;
using System.Collections.Concurrent;
using System.Linq;
using DingTalk.Api;
using DingTalk.Api.Request;
using CcNet.Utils.Extensions;

namespace CcNet.Notify
{
    /// <summary>
    /// 钉钉帮助类
    /// </summary>
    public class DingTalkHelper
    {
        /// <summary>
        /// 发送钉钉消息
        /// </summary>
        /// <param name="serverUrl">服务地址</param>
        /// <param name="message">消息内容</param>
        /// <param name="atMobiles">@手机号</param>
        /// <returns></returns>
        public static string SendMessage(string serverUrl, string message, params string[] atMobiles)
        {
            try
            {
                if (!message.IsValid())
                {
                    return "消息内容不能为空";
                }

                var client = GetClient(serverUrl);
                if (null == client)
                {
                    return "获取客户端实例失败";
                }

                var textDomain = new OapiRobotSendRequest.TextDomain
                {
                    Content = message.GetValue(),
                };

                var request = new OapiRobotSendRequest
                {
                    Msgtype = "text",
                    Text_ = textDomain,
                };

                if (!atMobiles.IsEmpty())
                {
                    request.At_ = new OapiRobotSendRequest.AtDomain
                    {
                        AtMobiles = atMobiles.ToList(),
                    };
                }

                var response = client.Execute(request);
                if (null == response || response.IsError)
                {
                    return $"发送消息失败：{(response?.ErrMsg).GetValue("未知")}";
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 获取客户端实例
        /// </summary>
        /// <param name="serverUrl">服务地址</param>
        /// <returns></returns>
        private static IDingTalkClient GetClient(string serverUrl)
        {
            if (!serverUrl.IsValid())
            {
                throw new Exception("服务地址不能为空");
            }

            serverUrl = serverUrl.LowerCase(trimSapce: true);

            if (!_DingTalkClients.TryGetValue(serverUrl, out IDingTalkClient client))
            {
                client = new DefaultDingTalkClient(serverUrl);
                _DingTalkClients[serverUrl] = client;
            }

            return client;
        }

        /// <summary>
        /// 客户端实例列表
        /// </summary>
        private static ConcurrentDictionary<string, IDingTalkClient> _DingTalkClients
            = new ConcurrentDictionary<string, IDingTalkClient>();
    }
}
