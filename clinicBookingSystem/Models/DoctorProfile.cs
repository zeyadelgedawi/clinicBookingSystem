using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicBookingSystem.Models
{
    public class DoctorProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SpecialtyId { get; set; }
        public string Bio { get; set; }
        public decimal ConsultationFee { get; set; }
    }
}
