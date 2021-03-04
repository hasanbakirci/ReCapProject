﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        public string Audience { get; set; } //token kullanici kitlesi
        public string Issuer { get; set; } // imzalayan
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
