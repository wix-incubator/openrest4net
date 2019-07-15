using System;
using System.IO;
using System.Net;

namespace wixrest.v2_0
{
    /**
     * An exception thrown by a RESTful HTTP server, with an optional returned value.
     * @author DL
     */
    public class WixHttpException : IOException
    {

        public WixHttpException(string title,
            string information,
            HttpStatusCode httpStatusCode,
            string exceptionLink,Exception innerException = null)
            :base($"StatusCode {httpStatusCode} " +
                  $"Error:{title}. {information}. " +
                  $"(see:{exceptionLink})",innerException)
        {
            Information = information;
            HttpStatusCode = httpStatusCode;
            HelpLink = exceptionLink;
        }

        public HttpStatusCode HttpStatusCode { get;}
        public string Information { get;}

        public override string ToString()
        {
            return $"StatusCode {HttpStatusCode} Error:{Message}. {Information}. (see:{HelpLink})";
        }
    }

}
