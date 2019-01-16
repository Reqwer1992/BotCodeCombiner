using System;
using System.IO;
using System.Net;

namespace MagicBotCodeCombiner
{
    public static class CodeingameIdeSync
    {
        private static HttpListener _listener;

        static CodeingameIdeSync()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://localhost:60581/");
            _listener.Start();
        }

        public static void SendCodeToIde(string code)
        {                        
            _listener.BeginGetContext(delegate(IAsyncResult ar)
            {
                var context = _listener.EndGetContext(ar);

                var responseString = code;

                var response = context.Response;
                response.ContentType = "text/html";
                response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept, X-Requested-With");
                response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
                response.AddHeader("Access-Control-Max-Age", "1728000");
                response.AppendHeader("Access-Control-Allow-Origin", "*");

                var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                var output = response.OutputStream;

                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }, null);
        }
    }
}
