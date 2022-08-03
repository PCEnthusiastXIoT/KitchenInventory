using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace KitchenInventory.Common;

[ApiController]
[Route("[controller]")]
public class CondimentController : ControllerBase
{
    
    private readonly ILogger<CondimentController> _logger;

    public CondimentController(ILogger<CondimentController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCondiments")]
    public IEnumerable<Condiment> Get()
    {
        using (KitchenInventoryContext db = new KitchenInventoryContext())
        {
            DbSet<Condiment> allCondiments = db.Condiments;

            return allCondiments;
        }
    }

    [HttpGet(Name = "GetCondimentsByDate")]
    public IEnumerable<Condiment> GetByDate()
    {
        using (KitchenInventoryContext db = new())
        {
            DbSet<Condiment> condiments = db.Condiments;
            IEnumerable<Condiment> condimentsByDate =
                condiments.OrderByDescending(c => c.Expiration);

            return condimentsByDate;
        }
    }
}