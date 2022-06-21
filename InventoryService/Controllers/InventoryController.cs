using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InventoryService.Models;
using InventoryService.Services;
using Microsoft.AspNetCore.Http;

namespace InventoryService.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryServices _services;

        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            var inventoryItems = services.AddInventoryItems(items);

            if (inventoryItems == null)
            {
                return NotFound();
            }    
            return Ok(inventoryItems);
        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string, InventoryItems>> GetInventoryItems()
        {
            var inventoryItems = _services.GetInventoryItems();

            if (inventoryItems.Count == 0)
            {
                return NotFound();
            }

            return inventoryItems;
        }
    }
}
