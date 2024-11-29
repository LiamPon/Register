using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Register.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CompaniesContext : DbContext
    {
        static CompaniesContext()
        {
            Database.SetInitializer<CompaniesContext>(null);
        }
        public CompaniesContext() : base("Name=dbcompanyh")
        {

        }

        public virtual DbSet<tblEmployeesModel> tblemployees { get; set; }
        public virtual DbSet<tblPositionsModel> tblpositions { get; set; }
        public virtual DbSet<tblDepartmentsModel> tbldepartments { get; set; }
        public virtual DbSet<tblStatusesModel> tblstatuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new tblEmployeesMap());
            modelBuilder.Configurations.Add(new tblDepartmentsMap());
            modelBuilder.Configurations.Add(new tblPositionsMap());
            modelBuilder.Configurations.Add(new tblStatusesMap());
        }
    }
}