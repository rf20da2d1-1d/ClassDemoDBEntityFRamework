// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClassDemoDBEntityFRamework.model
{
    [Table("Student")]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [Column("E-Mail")]
        [StringLength(40)]
        public string EMail { get; set; }
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        [InverseProperty(nameof(SchoolClass.Students))]
        public virtual SchoolClass Class { get; set; }
    }
}