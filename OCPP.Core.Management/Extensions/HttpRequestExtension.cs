using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCPP.Core.Management.Extensions
{
    public static class HttpRequestExtension
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return (request.Headers != null) && (request.Headers["X-Requested-With"] == "XMLHttpRequest");
        }
    }
}
