﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookmaster3000.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookmasterEntities : DbContext
    {
        public BookmasterEntities()
            : base("name=BookmasterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<author> author { get; set; }
        public virtual DbSet<book> book { get; set; }
        public virtual DbSet<bookAuthor> bookAuthor { get; set; }
        public virtual DbSet<client> client { get; set; }
    }
}
