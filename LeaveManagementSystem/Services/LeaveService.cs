using LeaveManagementSystem.Interfaces;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Services {
    public class LeaveService : ILeaveService {
        private readonly ILeaveRepo leaveRepo;

        public LeaveService(ILeaveRepo leaveRepo) {
            this.leaveRepo = leaveRepo;
        }
        public List<Leave> GetLeaveList() {
            return leaveRepo.GetLeaveList();
        }
    }
}
