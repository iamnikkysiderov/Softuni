using HandmadeHTTPServer.Server.Http.Contracts;
using System.Net;
using System.Text;

namespace HandmadeHTTPServer.Server.Http.Response
{
    public abstract class HttpResponse : IHttpResponse
    {
        private string statusCodeMessage => this.StatusCode.ToString();

        protected HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
        }

        public HttpHeaderCollection Headers { get; }

        public HttpStatusCode StatusCode { get; protected set; }
        
        public override string ToString()
        {
            var response = new StringBuilder();

            var statusCodeNumber = (int)this.StatusCode;

            response.AppendLine($"HTTP/1.1 {statusCodeNumber} {this.statusCodeMessage}");
            response.AppendLine(this.Headers.ToString());
            response.AppendLine();
            
            return response.ToString();
        }
    }
}
