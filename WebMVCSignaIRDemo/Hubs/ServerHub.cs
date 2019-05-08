/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：马全鑫                                             
*│　版   本：V1.0                                              
*│　创建时间：2019/5/8 9:37:01 
*│　修改者：***
*│　修改说明：......                           
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: WebMVCSignaIRDemo.Hubs                                   
*│　类   名：ServerHub                                      
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebMVCSignaIRDemo.Hubs
{
    [HubName("ServerHub")]
    public class ServerHub : Hub
    {
        //========================1.1=========================
        public void SendMsg(string message)
        {
            //调用所有客户端的sendMessage方法（sendMessage有两个参数）
            Clients.All.sendMessage(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), message);//Clients.All.sendMessage是调用所有客户端的sendMessage函数，属于群发。
        }




        //========================2.1=========================
        public void AddToRoom(string groupName, string userName)
        {
            //将连接添加到指定的组（Groups为HubBase中的接口属性）
            Groups.Add(Context.ConnectionId, groupName);
            //根据组名称获取对应客户端的组,调用该组的addUserIn方法
            Clients.Group(groupName, new string[0]).addUserIn(groupName, userName);
        }
        public void Send(string groupId, string detail, string userName)
        {
            Clients.Group(groupId).addSomeMessage(groupId, detail,userName);
        }

    }
}