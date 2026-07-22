using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models {
    public class Leave {
        public int ID { get; set; }

        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string LeaveType { get; set; }

        public string Status { get; set; }
    }
}
