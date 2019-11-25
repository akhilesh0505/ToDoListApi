using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApi.Models;

namespace ToDoListApi.Services
{
	public interface IToDoListService
	{
		List<ToDoListObject> GetToDoList();

		List<ToDoListObject> GetToDoList(string UserId);

		ToDoListObject GetToDoList(int ID);

		void AddToDoListObject(ToDoListObject obj);

		void UpdateToDoListObject(int ID, ToDoListObject targetObj);

		void RemoveToDoListObject(int ID);

		List<ToDoListItem> GetToDoListItem(int ToDoListObjectID);

		void AddToDoListItem(int ToDoListObjectID, ToDoListItem obj);

		void RemoveToDoListItem(int ToDoListObjectID, int ToDoListItemID);

		void UpdateToDoListItem(int ToDoListObjectID, ToDoListItem objToDoListItemTarget);
	}
}
