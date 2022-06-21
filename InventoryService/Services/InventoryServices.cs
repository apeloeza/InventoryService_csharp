using System;
using System.Collections.Generic;
using InventoryService.Models;
using InventoryService.Services;



namespace InventoryService.Services
{
    public class InventoryServices : IInventoryServices
    {
        private readonly Dictionary<string, InventoryItems> _inventoryItems;

        public InventoryServices()
        {
            _inventoryItems = new Dictionary<string, InventoryItems>();
        }

        public InventoryItems AddInventoryItem(InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);

            return items;
        }

        public object AddInventoryItems(InventoryItems items)
        {
            throw new NotImplementedException();
        }
    }
}