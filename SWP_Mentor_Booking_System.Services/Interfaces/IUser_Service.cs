using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Mentor_Booking_System.Services.Interfaces
{
    public class IUser_Service
    {
        public int UserID;
        public string UserName;
        public string Fullname;
        public string Password;
        public string Email;
        public string PhoneNumber;
        public IUser_Service() { }
    }
}
