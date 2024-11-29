using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class RegistrationModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public int phoneNumber { get; set; }
    }
}