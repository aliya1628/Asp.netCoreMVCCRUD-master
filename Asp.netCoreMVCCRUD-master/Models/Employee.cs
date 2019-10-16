using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage = "This Field is Required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("EMP Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
