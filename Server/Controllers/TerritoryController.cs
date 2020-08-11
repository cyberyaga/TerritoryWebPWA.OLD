using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TerritoryWebPWA.Server.Data;
using TerritoryWebPWA.Shared;
using System.Linq;

namespace TerritoryWebPWA.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TerritoryController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public TerritoryController(ApplicationDbContext context)
        {
            db = context;
        }


        [HttpGet]
        public IEnumerable<TerritoryIndexView> Get()
        {
            var ter = 
                from t in db.Territories
                select new TerritoryIndexView() {
                    TerritoryId = t.Id,
                    TerritoryName = t.TerritoryName,
                    City = t.City,
                    TerritoryType = t.TerritoryType.Description                    
                };

            return ter;
        }
    }
}