﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class tblDepartmentsModel
    {
        public int deptID { get; set; }
        public string deptName { get; set; }
        public int isActive { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}