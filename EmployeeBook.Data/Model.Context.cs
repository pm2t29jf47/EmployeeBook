﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeBook.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmployeeBookEntities : DbContext
    {
        public EmployeeBookEntities()
            : base("name=EmployeeBookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeePosition> EmployeePositions { get; set; }
        public virtual DbSet<EmployeePositionSkill> EmployeePositionSkills { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<PositionSkill> PositionSkills { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
    }
}
