using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseMangar.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "用户账号")]
        public string Account { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name="用户名")]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "用户密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}