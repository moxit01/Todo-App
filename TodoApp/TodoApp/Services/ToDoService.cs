using System;
using System.Collections.Generic;
using TodoApp.Model;

namespace TodoApp.Services
{
    public class ToDoService
    {
        List<ToDoListModel> ToDoList = new List<ToDoListModel>();
#pragma warning disable IDE0090 // Use 'new(...)'
        List<ToDoListModel> UncompletedToDoList = new List<ToDoListModel>();
#pragma warning restore IDE0090 // Use 'new(...)'



        //public List<ToDoListModel> GetItemsForCategory(string category)
        //{

        //    if (category != null)
        //    {
        //        ToDoList.Add(new ToDoListModel { Id = 1, Name = "Homework", Descrip = "xyz", IsDone = true });
        //        ToDoList.Add(new ToDoListModel { Id = 2, Name = "Homework2", Descrip = "xyz2", IsDone = true });
        //        ToDoList.Add(new ToDoListModel { Id = 3, Name = "Homework3", Descrip = "xyz3", IsDone = true });
        //    }
        //    return ToDoList;


        //}



        public List<ToDoListModel> GetUncompleteToDos()
            {
                return UncompletedToDoList;
            }

        public List<ToDoListModel>AddToDo(ToDoListModel model)
            {
                ToDoList.Add(model);
                return ToDoList;

            }

        public void AddToDAt(ToDoListModel model, int index)
        {
            ToDoList.RemoveAt(index);
            ToDoList.Insert(index, model);
        }

        public List<ToDoListModel> RemoveToDo(int id)
        {
            int index = 0;

            for(int i=0; i< ToDoList.Count; i++)
            {
                if (ToDoList[i].Id == id)
                {
                    index = i;
                }
            }

            ToDoList.RemoveAt(index: index);
            return ToDoList;

        }


        public List<ToDoListModel> MarkCompleted(ToDoListModel model)
        {
            model.IsDone = true;
            model.CompletionDate = DateTime.Now;

            int index = UncompletedToDoList.FindIndex(m => m.Id == model.Id);
            UncompletedToDoList.RemoveAt(index);

            return UncompletedToDoList;

        }



        public ToDoService()
        {
            ToDoList.Add(new ToDoListModel { Id = 1, Name = "Homework1", Description = "xyz2", IsDone = false });
            ToDoList.Add(new ToDoListModel { Id = 2, Name = "Homework2", Description = "xyz2", IsDone = false });
            ToDoList.Add(new ToDoListModel { Id = 3, Name = "Homework3", Description = "xyz3", IsDone = false });

            UncompletedToDoList = ToDoList;

        }
    }
}
