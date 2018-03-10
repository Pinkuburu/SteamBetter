// ReSharper disable InconsistentNaming

namespace SteamApiClient.Models
{
    public class ScheduleModel
    {
        public Results result { get; set; }

        public class Results
        {
            public string error { get; set; }
        }

    }
}