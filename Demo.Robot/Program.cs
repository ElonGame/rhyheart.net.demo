using System;
using System.Net;
using System.Text;
using System.Web;
using Demo.Robot.Model;
using Newtonsoft.Json;

namespace Demo.Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入Msg：");
            var msg = Console.ReadLine();

            //调用网络接口获取回复数据
            //接口调试地址：http://open.drea.cc/swagger
            //示例：http://open.drea.cc/chat/get?KeyWord=%E4%BD%A0%E5%A5%BD
            var url = "http://open.drea.cc/chat/get?KeyWord="+HttpUtility.UrlEncode(msg,Encoding.UTF8);
            var wc = new WebClient();
            var html = wc.DownloadString(url);
            Console.WriteLine("\n回复：");

            //序列号Json消息
            var replyInfo = JsonConvert.DeserializeObject<ResultModel<ReplyInfo>>(html);
            var reply = replyInfo.Data.Reply;
            Console.WriteLine(reply);

            //更多接口自行调试
            Console.ReadKey();
        }
    }
}
