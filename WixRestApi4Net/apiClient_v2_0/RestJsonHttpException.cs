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
        private readonly HttpStatusCode httpStatusCode;

        public WixHttpException(string title,
            string Information,
            HttpStatusCode httpStatusCode,
            string exceptionLink):base($"StatusCode {httpStatusCode} Error:{title}. {Information}. (see:{exceptionLink})")
        {
            Information = Information;
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
