using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Data
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [NotMapped]
        public Haircut Haircut { get; set; }
        [ForeignKey("HaircutId")]
        public int Hair_id { get; set; }
        public Client(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
        public override string ToString()
        {
            return $"{Name} - {Date}";
        }
        public Client() { }
    }
}
