using LeaveManagementSystem.Interfaces;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Services {
    public class LeaveService : ILeaveService {
        private readonly ILeaveRepo leaveRepo;

        public LeaveService(ILeaveRepo leaveRepo) {
            this.leaveRepo = leaveRepo;
        }

        public void Add(Leave leave) {
            leaveRepo.Add(leave);
        }

        public void Delete(Leave leave) {
            leaveRepo.Delete(leave);
        }

        public void Edit(Leave leave) {
            leaveRepo.Edit(leave);
        }

        public Leave GetID(int ID) {
            return leaveRepo.GetID(ID);
        }

        public List<Leave> GetLeaveList() {
            return leaveRepo.GetLeaveList();
        }
    }
}
