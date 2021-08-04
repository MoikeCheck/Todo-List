using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Todo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty] 
        public IList<TodoItem> Items { get; set; }
        [BindProperty]
        public bool AddItem { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Items = TodoItems.Items;
            AddItem = false;
        }

        public void OnPost() 
        {
            if (AddItem)
            {
                Items.Add(new TodoItem()
                {
                    Id=Guid.NewGuid(), 
                    Text="New Task",
                    Completed=false
                });
            }
            if (Items.Where(i => i.Delete).Any())
            {
                Items.Remove(Items.Where(i => i.Delete).Single());
            }
            TodoItems.Items = Items;
            OnGet();
            Response.Redirect(Request.Path);
        }
    }
}
