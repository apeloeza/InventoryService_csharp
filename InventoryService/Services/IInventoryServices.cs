using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InventoryService.Models;

namespace InventoryService.Services
{
    interface IInventoryServices
    {
        object AddInventoryItems(InventoryItems items);
    }
}
