using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoApp.Model;
using TodoApp.Services;

namespace TodoApp.Pages
{
    public class CategoryModel : PageModel
    {

        private readonly ToDoService _service;
        

        public CategoryModel(ToDoService service)
        {
            _service = service;

        }

        public ActionResult OnGet(string category)
        {
            category = "ToDOList";
            Items = _service.GetItemsForCategory(category);
            return Page();
        }

        public List<ToDoListModel> Items { get; set; }
            
        //public void OnGet()
        //{
        //}


    }

}

