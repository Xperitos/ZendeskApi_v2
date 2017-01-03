using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZendeskApi_v2_Pcl.Responses;

namespace ZendeskApi_v2_Pcl.Exceptions
{
    public class ZendeskWebException : WebException
    {
        public HttpStatusCode StatusCode
        {
            get
            {
                var response = Response as HttpWebResponse;

                if (response == null)
                    return HttpStatusCode.RequestTimeout;

                return response.StatusCode;
            }
        }

        public ErrorResponse Error { get; internal set; }

        public ZendeskWebException(string message, Exception inner, WebExceptionStatus status, WebResponse response) : base(message, inner, status, response)
        {
            
        }

        public ZendeskWebException(string message, WebExceptionStatus status) : base(message, status)
        {
            
        }
    }
}
