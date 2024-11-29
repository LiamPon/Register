using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class tblEmployeesModel
    {
        public int empID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string address { get; set; }
        public int deptID { get; set; }
        public int posID { get; set; }
        public int statID { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}