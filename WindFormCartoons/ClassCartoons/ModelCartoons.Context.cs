﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassCartoons
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBCartoonsEntities : DbContext
    {
        public DBCartoonsEntities()
            : base("name=DBCartoonsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CARTOONS> CARTOONS { get; set; }
        public DbSet<COMPANY_CARTOONS> COMPANY_CARTOONS { get; set; }
        public DbSet<DIC_CARTOON_STATUSES> DIC_CARTOON_STATUSES { get; set; }
        public DbSet<DIC_COMPANY> DIC_COMPANY { get; set; }
        public DbSet<DIC_COUNRTY> DIC_COUNRTY { get; set; }
        public DbSet<DIC_DIRACTORS> DIC_DIRACTORS { get; set; }
        public DbSet<DIC_GENRE> DIC_GENRE { get; set; }
        public DbSet<DIRACTORS_CARTOONS> DIRACTORS_CARTOONS { get; set; }
        public DbSet<GENRE_CARTOONS> GENRE_CARTOONS { get; set; }
        public DbSet<LOGIN> LOGIN { get; set; }
    }
}