using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDari.Models
{
    public class Appointment
    {
        public long id { get; set; }
        public DateTime inscriptionstart { get; set; }
        public DateTime isncriptionend { get; set; }
        public int inscriptionlength { get; set; }
        public float price { get; set; }
       
        public string Atype { get; set; }


    }
}