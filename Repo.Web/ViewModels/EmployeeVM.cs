using System.ComponentModel.DataAnnotations.Schema;

namespace Repo.Web.ViewModels
{
    public class EmployeeVM
    {
        public string? EmployeeName { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public int? DepartmentId { get; set; }
    }
}
