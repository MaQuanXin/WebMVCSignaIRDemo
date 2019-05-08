/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：马全鑫                                             
*│　版   本：V1.0                                              
*│　创建时间：2019/5/8 9:35:23 
*│　修改者：***
*│　修改说明：......                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: WebMVCSignaIRDemo.SignalR                                   
*│　类   名：Startup                                      
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebMVCSignaIRDemo.SignalR.Startup))]

namespace WebMVCSignaIRDemo.SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
            //配置集线器
            app.MapSignalR();
        }
    }
}
