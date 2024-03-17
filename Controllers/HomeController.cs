using Microsoft.AspNetCore.Mvc;
using Restaurant_management_system;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // Create a collection to hold items
        var items = new List<Item>();

        // Create and add example items to the collection
        var item1 = new Item
        {
            Name = "Item 1",
            Description = "Description for Item 1"
        };
        items.Add(item1);

        var item2 = new Item
        {
            Name = "Item 2",
            Description = "Description for Item 2"
        };
        items.Add(item2);

        var item3 = new Item
        {
            Name = "Item 3",
            Description = "Description for Item 3"
        };
        items.Add(item3);

        var item4 = new Item
        {
            Name = "Item 4",
            Description = "Description for Item 4"
        };
        items.Add(item4);

        // Return the collection of items as JSON
        return Ok(items);
    }
}
