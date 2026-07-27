using LeaveManagementSystem.Interfaces;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Repository {
    public class LeaveRepo : ILeaveRepo {
        private readonly List<Leave> leaves = [
            new Leave{ ID = 1, EmployeeName = "Daniella Yvette Rimas", LeaveType = "Sick", Status = "Pending"},
            new Leave{ ID = 2, EmployeeName = "John Doe Cruz", LeaveType = "Sick", Status = "Pending"},
            new Leave{ ID = 3, EmployeeName = "Danivy Maris Jasmin", LeaveType = "Vacation Leave", Status = "Approved"}
        ];

        public void Add(Leave leave) {
            leave.ID = leaves.Count ==  0 ? 1 : leaves.Max(x => x.ID) + 1;
            leave.Status = "Pending";

            leaves.Add(leave);
        }

        public void Delete(Leave leave) {
            var item = GetID(leave.ID);

            if (item == null) {
                return;
            }

            leaves.Remove(item);
        }

        public void Edit(Leave leave) {
            var item = GetID(leave.ID);

            if (item == null) {
                return;
            }

            item.EmployeeName = leave.EmployeeName;
            item.LeaveType = leave.LeaveType;
            item.Status = leave.Status;
        }

        public Leave? GetID(int ID) {
            return leaves.FirstOrDefault(x => x.ID == ID);     
        }

        public List<Leave> GetLeaveList() {
            return leaves;
        }
    }
}
