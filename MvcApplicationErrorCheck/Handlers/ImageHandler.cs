using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplicationErrorCheck.Handlers
{
    public class ImageHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            throw new HttpException(403, "Throw 404");
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}