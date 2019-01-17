using System;
using System.IO;
using System.Net;
using Json.Net;
using Newtonsoft.Json;

namespace MagicBotCodeCombiner
{
    public static class CodeingameIdeSync
    {
        public static void SendCommandToIde(CodingameIdeSyncCommandType commandtype, string code)
        {
            var command = new CodingameIdeCommand()
            {
                Command = commandtype,
                Code = code
            };

            SendCommandToIde(command);
        }

        public static void SendCommandToIde(CodingameIdeCommand command)
        {
            var _listener = new HttpListener();
            _listener.Prefixes.Add("http://localhost:60581/");
            _listener.Start();

            _listener.BeginGetContext(delegate(IAsyncResult ar)
            {
                var context = _listener.EndGetContext(ar);

                var serializedResult = JsonConvert.SerializeObject(command);

                var response = context.Response;
                response.ContentType = "application/json";
                response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, X-Requested-With");
                response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
                response.AddHeader("Access-Control-Max-Age", "1728000");
                response.AppendHeader("Access-Control-Allow-Origin", "*");

                var buffer = System.Text.Encoding.UTF8.GetBytes(serializedResult);
                response.ContentLength64 = buffer.Length;
                var output = response.OutputStream;

                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }, null);
        }
    }
}
