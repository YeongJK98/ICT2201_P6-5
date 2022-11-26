using PharmacyShopWorkloadManagementSystem.Models.UserModel;

namespace PharmacyShopWorkloadManagementSystem.Interfaces
{
    public interface IUser
    {
        public User GetUser(string employeeID);
    }
}
