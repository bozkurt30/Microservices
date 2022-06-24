using Microservices.UI.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Microservices.UI.Models.Entities
{
    public class Company : IEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(100)]
        public string CompanyType { get; set; }
        [Required]
        public int CompanyNo { get; set; }
        [Required]
        public int ComapnyTaxNo { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string County { get; set; }
        [Required]
        [StringLength(500)]
        public string Address { get; set; }
    }
}
