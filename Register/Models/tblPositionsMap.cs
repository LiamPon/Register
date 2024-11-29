using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Register.Models
{
    public class tblPositionsMap : EntityTypeConfiguration<tblPositionsModel>
    {
        public tblPositionsMap()
        {
            HasKey(x => x.posID);
            ToTable("tblpositions");
        }
    }
}