using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReliabilityRegistration.Models
{
    public class Registeration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Day1 { get; set; }
        public bool Day2 { get; set; }
        public bool Day3 { get; set; }
    }
}