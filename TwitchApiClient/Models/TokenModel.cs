﻿// ReSharper disable InconsistentNaming

namespace TwitchApiClient.Models
{
    public class TokenModel
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string expires_in { get; set; }
    }
}