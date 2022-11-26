using PharmacyShopWorkloadManagementSystem.Models.UserModel;
using PharmacyShopWorkloadManagementSystem.Models.OTPModel;

namespace PharmacyShopWorkloadManagementSystem.Models
{
    public class LoginViewModel
    {
        public User? User { get; set; }
        public OTP? OTP { get; set; }
    }
}
