using System;
using System.Collections.Generic;

namespace EFantasySports.Models.Utility
{
    // Response object wrapper 
    public class Response {
        public bool succeeded {get;set;}
        public List<string> messages = new List<string>();
        public Response(bool succeeded) {
            this.succeeded = succeeded ; 
        }
    }
}