using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRClient
{
    public class App01
    {

        public void Run()
        {
            var hubConnection = new HubConnectionBuilder()
                .WithUrl($"https://dd37927.store/Chat")
                .Build();


            Task task = new Task(async () =>
            {
                await hubConnection.StartAsync();
                hubConnection.On<string, string>("ReceiveMessage", async (user, message) =>
                {
                    Console.WriteLine($"{user} : {message}");
                });

                hubConnection.On<DateTime>("ReceiveHeartBeat", async (dateTime) =>
                {
                    Console.WriteLine($"{dateTime}");

                    await hubConnection.InvokeAsync("ReceiveHearBeatFromClient");

                });
                await hubConnection.InvokeAsync("LoginUser", 20);
                await hubConnection.InvokeAsync("SendMessageAll", 20, "AA");

            });

            task.Start();
            task.Wait();

            while (true) ;
           
        }
    }
}
