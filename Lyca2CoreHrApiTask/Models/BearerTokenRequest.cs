﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyca2CoreHrApiTask.Models
{
    public class BearerTokenRequest
    {
        public string grant_type { get; set; } = "client_credentials";
    }
}
