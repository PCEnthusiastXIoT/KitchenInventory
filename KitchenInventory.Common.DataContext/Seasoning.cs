using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenInventory.Common.DataContext
{
    public class Seasoning
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public float? Amount { get; set; }

        public string? Units { get; set; }
    }
}
