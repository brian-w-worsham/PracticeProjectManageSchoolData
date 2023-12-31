﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PracticeProjectManageSchoolData.Models
{
    public partial class Student
    {
        [Column("ID")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Student Name")]
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100)]
        [Unicode(false)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(75)]
        [Unicode(false)]
        [Display(Name = "Student Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Class is required")]
        [StringLength(5)]
        [Unicode(false)]
        [Display(Name = "Which class")]
        public string Class { get; set; }
    }
}