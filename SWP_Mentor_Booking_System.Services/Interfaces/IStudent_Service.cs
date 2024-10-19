using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Mentor_Booking_System.Services.Interfaces
{
    public class IStudent_Service : IUser_Service
    {
        public IStudent_Service() { }
        public int StudentID;
        public string StudentName;
    }
}
