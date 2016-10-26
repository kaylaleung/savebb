using Microsoft.Azure.Mobile.Server;
using System;

namespace SaveBBService.DataObjects
{
    public class AlertItem : EntityData
    {
        //public string Text { get; set; }

        //public bool Complete { get; set; }

        public DateTimeOffset AlertTime { get; set; }
        
        public string AlertValue { get; set; }
        public string AlertType { get; set; }

        public string PhoneNum { get; set; }

        public decimal? Humidity { get; set; }

        public decimal? Temp { get; set; }

        public decimal? HeartRate { get; set; }



    }
}