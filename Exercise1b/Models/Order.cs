using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise1b.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderedOn { get; set; }
        public DateTime DeliveredOn { get; set; }
        public double Value { get; set; }
        [Range(0,5)]
        public int FeedbackRating { get; set; }
    }
}