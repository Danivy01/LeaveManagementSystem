using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Interfaces {
    public interface ILeaveService {
        List<Leave> GetLeaveList();
        void Add(Leave leave);
    }
}
