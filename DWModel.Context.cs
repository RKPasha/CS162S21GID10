//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DukoWheelsDBEntities1 : DbContext
    {
        public DukoWheelsDBEntities1()
            : base("name=DukoWheelsDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ManagerDBTable> ManagerDBTables { get; set; }
        public virtual DbSet<UserDBTable> UserDBTables { get; set; }
        public virtual DbSet<ContactTable> ContactTables { get; set; }
        public virtual DbSet<UsedCarsTable> UsedCarsTables { get; set; }
    }
}
