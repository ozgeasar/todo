using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo.Data;

namespace todo.ViewComponents
{
    public class CViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;

        public CViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool ShowEmpty=true)
        {
            var items = await dbContext.Categories.Where(c=> ShowEmpty || c.TodoItems.Any() ).ToListAsync();
            return View(items);
        }
    }
}
