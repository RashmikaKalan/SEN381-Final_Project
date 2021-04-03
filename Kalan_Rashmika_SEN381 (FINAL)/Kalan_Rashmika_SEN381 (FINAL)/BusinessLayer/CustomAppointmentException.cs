using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomAppointmentException : Exception
    {
        public CustomAppointmentException(string message)
            :base(message)
        {

        }

        public static void CheckTime(DateTime current, DateTime start, DateTime chosen)
        {
            if (current.Year == chosen.Year && current.Month == chosen.Month && current.Day == chosen.Day)
            {
                if (chosen > current && chosen <= start)
                {
                    throw new CustomAppointmentException("Employee Booked For That Time Slot Already.");
                }
            }
        }
    }
}
