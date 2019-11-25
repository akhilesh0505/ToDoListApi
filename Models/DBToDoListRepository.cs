using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListApi.Models
{
	public class DBToDoListRepository : IToDoListRepository
	{
		public void AddToDoListItem(int ToDoListObjectID, ToDoListItem obj)
		{
			throw new NotImplementedException();
		}

		public void AddToDoListObject(ToDoListObject obj)
		{
			throw new NotImplementedException();
		}

		public List<ToDoListObject> GetToDoList()
		{
			throw new NotImplementedException();
		}

		public List<ToDoListObject> GetToDoList(string UserId)
		{
			throw new NotImplementedException();
		}

		public ToDoListObject GetToDoList(int ID)
		{
			throw new NotImplementedException();
		}

		public List<ToDoListItem> GetToDoListItem(int ToDoListObjectID)
		{
			throw new NotImplementedException();
		}

		public void RemoveToDoListItem(int ToDoListObjectID, int ToDoListItemID)
		{
			throw new NotImplementedException();
		}

		public void RemoveToDoListObject(int ID)
		{
			throw new NotImplementedException();
		}

		public void UpdateToDoListItem(int ToDoListObjectID, ToDoListItem objToDoListItemTarget)
		{
			throw new NotImplementedException();
		}

		public void UpdateToDoListObject(int ID, ToDoListObject targetObj)
		{
			throw new NotImplementedException();
		}
	}
}