﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PracticeProjectManageSchoolData.Models
{
    public partial class Subject
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "Name is required")]
        [Display(Name = "Subject Name")]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
    }
}