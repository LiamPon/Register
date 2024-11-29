using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class tblStatusesMap : EntityTypeConfiguration<tblStatusesModel>
    {
        public tblStatusesMap() {
            HasKey(x => x.statID);
            ToTable("tblstatuses");
        }
    }
}