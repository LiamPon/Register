using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class tblEmployeesMap : EntityTypeConfiguration<tblEmployeesModel>
    {
        public tblEmployeesMap()
        {
            HasKey(x => x.empID);
            ToTable("tblemployees");
        }
    }
}