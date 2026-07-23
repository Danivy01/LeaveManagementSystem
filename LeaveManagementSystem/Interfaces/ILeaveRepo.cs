using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Interfaces {
    public interface ILeaveRepo {
        List<Leave> GetLeaveList();
        void Add(Leave leave);
    }
}
