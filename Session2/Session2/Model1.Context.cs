﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class strajnikEntities : DbContext
    {
        public strajnikEntities()
            : base("name=strajnikEntities")
        {
        }

        public static strajnikEntities Instance { get; set; }

        public static strajnikEntities GetContext()
        {
            if (Instance == null)
                Instance= new strajnikEntities();
            return Instance;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Audit_pc> Audit_pc { get; set; }
        public virtual DbSet<goods> goods { get; set; }
        public virtual DbSet<permissons> permissons { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}