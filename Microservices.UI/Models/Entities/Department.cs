using Microservices.UI.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Microservices.UI.Models.Entities
{
    public class Department : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ParentId { get; set; }
        [Required]
        [StringLength(100)]
        public string Department_Name { get; set; }
    }
}
