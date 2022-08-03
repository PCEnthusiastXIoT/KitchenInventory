using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KitchenInventory.Common
{
    public partial class Seasoning
    {
        [Key]
        public int Id { get; set; }
        [Column("amount")]
        public int? Amount { get; set; }
        [Column("name")]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Column("unit")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Unit { get; set; }
    }
}
