using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KitchenInventory.Common
{
    public partial class Condiment
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        public float? Amount { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Units { get; set; }
        public bool Opened { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Expiration { get; set; }
    }
}
