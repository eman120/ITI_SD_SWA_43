using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCWebAppWith3Areas.Models
{
    public enum Gender { Male, Female }
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="You have to enter your name")]
        [MaxLength(20 , ErrorMessage ="Too Long Name Characters")]
        [Display(Name = "EmployeeName")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You have to enter your name")]
        [MaxLength(20, ErrorMessage = "Too Long Name Characters")]
        [Display(Name = "UserName")]
        public string Username { get; set; }

        [Required(ErrorMessage ="You must Enter Passwor")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Range(4000 , 20000 , ErrorMessage ="Enter your salary within range 4000 to 20000")]
        public decimal Salary { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        public DateTime JoinDate { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Enter your Email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a valid 10-digit phone number")]
        public string PhoneNum { get; set; }
    }
}