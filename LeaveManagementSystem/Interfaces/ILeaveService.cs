using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Interfaces {
    public interface ILeaveService {
        List<Leave> GetLeaveList();
    }
}
