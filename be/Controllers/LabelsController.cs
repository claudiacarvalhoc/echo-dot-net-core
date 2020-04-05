using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TodoApi.ApiModel;
using TodoApi.Context;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class LabelsController
    {
        private readonly TodoContext _context;

        public LabelsController(TodoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<LabelItem> GetAll()
        {
            List<LabelItem> items = new List<LabelItem>();

            items.Add(new LabelItem() {
                Name = "New",
                Count = _context.TodoItems.Count(n => n.Status == TodoStatus.NEW)
            });

            items.Add(new LabelItem()
            {
                Name = "On Going",
                Count = _context.TodoItems.Count(n => n.Status == TodoStatus.UPDATED)
            });

            items.Add(new LabelItem()
            {
                Name = "Marked as Done",
                Count = _context.TodoItems.Count(n => n.Status == TodoStatus.DONE)
            });

            return items;
        }
    }
}
