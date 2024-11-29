using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class tblPositionsModel
    {
        public int posID { get; set; }
        public string posName { get; set; }
        public int isActive { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}