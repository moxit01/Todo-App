using System;
namespace TodoApp.Model
{
    public class ToDoListModel
    {
        public int? Id { get; set; }
        public String Name { get; set; }
        public String Descrip { get; set; }
        public bool IsDone { get; set; }
        //public DateTime CompletionDate { get; set; }

        public ToDoListModel()
        {
           
        }

    }

}
