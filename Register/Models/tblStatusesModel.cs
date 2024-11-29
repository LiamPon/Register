using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class tblStatusesModel
    {
        public int statID { get; set; }
        public string statName { get; set; }
        public int isActive { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}