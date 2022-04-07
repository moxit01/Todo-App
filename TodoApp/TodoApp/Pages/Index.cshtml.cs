using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TodoApp.Model;
using TodoApp.Services;

namespace TodoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ToDoService _service;

        

        public IndexModel(ToDoService service)
        {
            _service = service;
        }


        public List<ToDoListModel> Items { get; set; }



        public ActionResult OnGet()
        {
            Items = _service.GetUncompleteToDos();
            return Page();
        }

        public IActionResult OnPostSubmit(int id)
        {
            List<ToDoListModel> items = _service.GetUncompleteToDos();
            ToDoListModel model = items.Find(m => m.Id == id);

            Items = _service.MarkCompleted(model);
            return Page();
        }




    }
}
