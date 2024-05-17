using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Data
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        [Required]
        public string ClientName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [StringLength(255)]
        public string Notes { get; set; } = "";

        public Appointment(int appointmentId, int clientId, string clientName, DateTime date, string notes = "")
        {
            AppointmentId = appointmentId;
            ClientId = clientId;
            ClientName = clientName;
            Date = date;
            Notes = notes;
        }
    }
}
