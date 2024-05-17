using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Data
{
    public class Haircut
    {
        [Key]
        public int HaircutId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal BaseCost { get; set; }
        public Haircut(int haircutId, string name, decimal baseCost)
        {
            HaircutId = haircutId;
            Name = name;
            BaseCost = baseCost;
        }
        public Haircut() { }
        public override string ToString()
        {
            return $"{Name},{BaseCost}";
        }
    }
}
