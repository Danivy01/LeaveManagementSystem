using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Interfaces {
    public interface ILeaveService {
        List<Leave> GetLeaveList();
        void Add(Leave leave);
        Leave GetID(int ID);
        void Edit(Leave leave);
    }
}
