﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthenticationDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Auth_Dotnet_80648Entities : DbContext
    {
        public Auth_Dotnet_80648Entities()
            : base("name=Auth_Dotnet_80648Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<UserRolesMapping> UserRolesMappings { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<AuthenticationDemo.Models.UserModel> UserModels { get; set; }
    }
}
