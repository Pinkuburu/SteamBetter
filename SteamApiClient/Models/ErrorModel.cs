// ReSharper disable InconsistentNaming

namespace SteamApiClient.Models
{
    public class ErrorModel
    {
        public Results result { get; set; }

        public class Results
        {
            public string error { get; set; }
        }

    }
}