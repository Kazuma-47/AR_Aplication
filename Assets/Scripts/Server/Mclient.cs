using System;
using WebSocketSharp;
using Newtonsoft.Json.Linq;


public class Client
    {
        private WebSocket ws;

        public class MessageArgs: EventArgs
        {
            public MessageArgs(string sender, string data)
            {
                this.sender = sender;
                this.data = data;
            }

            public string sender;
            public string data;
        }

        public delegate void MessageHandler(object sender, MessageArgs e);
        public event MessageHandler OnMessage;

        public Client(string url, string id)
        {
            this.ws = new WebSocket(url);
            this.ws.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Default;
            this.ws.Connect();

            this.ws.OnMessage += (sender, e) =>
            {
                JObject data = JObject.Parse(e.Data);

                switch(data["type"].ToString())
                {
                    case "message":
                    {
                        MessageHandler handler = OnMessage;
                        handler?.Invoke(this, new MessageArgs(data["sender"].ToString(), data["data"].ToString()));
                        break;
                    }

                    default:
                    {
                        break;
                    }
                }
            };

            ws.OnClose += (sender, e) => {
                Console.WriteLine("uhoh");
            };
            this.ws.Send("{ \"type\": \"identify\", \"id\": \"" + id + "\"}");
        }

        public void Send(string recipient, string data)
        {
            ws.Send("{\"type\": \"message\", \"recipient\": \"" + recipient + "\", \"data\": \"" + data + "\"}");
        }
    }