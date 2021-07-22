using System;
using System.Collections.Generic;

namespace dot_net_api_rpg.Models
{
    public class ServiceResponse<T>
    {

        public T Data { get; set; }

        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;


    }
}