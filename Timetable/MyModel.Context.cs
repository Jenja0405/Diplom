﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Timetable
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyEntities : DbContext
    {
        public MyEntities()
            : base("name=MyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kabinet> Kabinet { get; set; }
        public virtual DbSet<Klass> Klass { get; set; }
        public virtual DbSet<KlassPredmet> KlassPredmet { get; set; }
        public virtual DbSet<Predmet> Predmet { get; set; }
        public virtual DbSet<Uchitel> Uchitel { get; set; }
        public virtual DbSet<Urok> Urok { get; set; }
    }
}
