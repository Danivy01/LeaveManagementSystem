using LeaveManagementSystem.Interfaces;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Repository {
    public class LeaveRepo : ILeaveRepo {
        private readonly List<Leave> leaves = [
            new Leave{ ID = 1, EmployeeName = "Daniella Yvette Rimas", LeaveType = "Sick", Status = "Pending"},
            new Leave{ ID = 2, EmployeeName = "John Doe Cruz", LeaveType = "Sick", Status = "Pending"},
            new Leave{ ID = 3, EmployeeName = "Danivy Maris Jasmin", LeaveType = "Vacation Leave", Status = "Approved"}
        ];
        public List<Leave> GetLeaveList() {
            return leaves;
        }
    }
}
