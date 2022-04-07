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

        public ToDoListModel ToDoListItem = new ToDoListModel();

        public string Name { get; set; }
        public string Description { get; set; }

        private readonly ToDoService _service;
        

        public CategoryModel(ToDoService service)
        {
            _service = service;

        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id != null)
            {
                List<ToDoListModel> items = _service.GetUncompleteToDos();
                ToDoListItem = items.FirstOrDefault(m => m.Id == id);

                Name = ToDoListItem.Name;
                Description = ToDoListItem.Description;

            }


            return Page();

        }

        public IActionResult OnPostSubmit(ToDoListModel model)
        {
            if(model.Name == null)
            {
                return null;
            }

            if (model.Id == null)
            {
                model.Id = _service.GetUncompleteToDos().Count + 1;
                model.IsDone = false;
                _service.AddToDo(model);
            }

            else
            {
                List<ToDoListModel> items = _service.GetUncompleteToDos();
                int index = items.FindIndex(m => m.Id == model.Id);
                _service.AddToDAt(model, index);
            }

            return RedirectToPage("Index");

        }



        //public ActionResult OnGet(string category)
        //{
        //    category = "ToDoList";
        //    Items = _service.GetItemsForCategory(category);
        //    return Page();
        //}

        //public List<ToDoListModel> Items { get; set; }
            
        //public void OnGet()
        //{
        //}


    }

}

