using System;
using System.Collections.Generic;
using TodoApp.Model;

namespace TodoApp.Services
{
    public class ToDoService
    {
        List<ToDoListModel> ToDoList = new List<ToDoListModel>();

        public List<ToDoListModel> GetItemsForCategory(string category)
        {

            if(category!=null)
            {
                ToDoList.Add(new ToDoListModel { Id = 1, Name = "Homework", Descrip = "xyz", IsDone = true });
                ToDoList.Add(new ToDoListModel { Id = 2, Name = "Homework2", Descrip = "xyz2", IsDone = true });
                ToDoList.Add(new ToDoListModel { Id = 3, Name = "Homework3", Descrip = "xyz3", IsDone = true });
            }
            return ToDoList;

        }





        //List<ToDoListModel> ToDoList = new();

        //List&ToDOModel> UnCompleteToDoList=new();


        //public ListeToDoModel>GetUncompleteToDos()
        //return UnCompleteToDoList;
        //public List&ToDoModel> AddToDo(ToDoModel model)
        //{
        //    ToDOList.Add(model);
        //    return ToDoList:
        //public void AddToDAt(ToDoModel model, int index)
        //ToDOList.RemoveAt(index) ;
        //ToDoList.Insert(index, model);
        //public List&ToDoModel> RemoveToDo(intid)
        //int ItemIndex = 0;
        //for (int 1 = 0; 1 < TooList.Count; 144)
        //if (ToDoList(1).Id == 1d)
        //ItemIndex = 1;
        //ToDoList.RemoveAt(index: ItemIndex);
        //return ToDoList;




        public ToDoService()
        {
        }
    }
}
