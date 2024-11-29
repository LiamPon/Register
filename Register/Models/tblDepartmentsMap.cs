using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class tblDepartmentsMap : EntityTypeConfiguration<tblDepartmentsModel>
    {
        public tblDepartmentsMap()
        {
            HasKey(x => x.deptID);
            ToTable("tbldepartments");
        }
    }
}