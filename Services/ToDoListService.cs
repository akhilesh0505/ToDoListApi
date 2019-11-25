using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListApi.Models;

namespace ToDoListApi.Services
{
	public class ToDoListService : IToDoListService
	{
		private IToDoListRepository _ToDoListObject;

		public ToDoListService(IToDoListRepository toDoListObject)
		{
			_ToDoListObject = toDoListObject;
		}

		#region ToDoListObject Methods
		public List<ToDoListObject> GetToDoList()
		{
			return _ToDoListObject.GetToDoList();
		}

		public List<ToDoListObject> GetToDoList(String UserId)
		{
			return _ToDoListObject.GetToDoList(UserId);
		}

		public ToDoListObject GetToDoList(int ID)
		{
			return _ToDoListObject.GetToDoList(ID);
		}

		public void AddToDoListObject(ToDoListObject obj)
		{
			_ToDoListObject.AddToDoListObject(obj);
		}

		public void UpdateToDoListObject(int ID, ToDoListObject targetObj)
		{
			_ToDoListObject.UpdateToDoListObject(ID, targetObj);
		}

		public void RemoveToDoListObject(int ID)
		{
			_ToDoListObject.RemoveToDoListObject(ID);
		}

		#endregion

		#region ToDoListItem Methods
		public List<ToDoListItem> GetToDoListItem(int ToDoListObjectID)
		{
			ToDoListObject obj = _ToDoListObject.GetToDoList(ToDoListObjectID);
			if (obj != null)
				return obj.ToDoListItems;
			else
			{
				throw new Exception("No Item Found.");
			}
		}

		public void AddToDoListItem(int ToDoListObjectID, ToDoListItem obj)
		{
			ToDoListObject objToDoListObject = _ToDoListObject.GetToDoList(ToDoListObjectID);
			if (objToDoListObject != null)
				_ToDoListObject.AddToDoListItem(ToDoListObjectID, obj);
		}

		public void RemoveToDoListItem(int ToDoListObjectID, int ToDoListItemID)
		{
			ToDoListObject objToDoListObject = _ToDoListObject.GetToDoList(ToDoListObjectID);
			if (objToDoListObject != null)
			{
				ToDoListItem objToDoListItem = objToDoListObject.ToDoListItems.Where(y => y.ID == ToDoListItemID).FirstOrDefault();
				if (objToDoListItem != null)
					_ToDoListObject.RemoveToDoListItem(ToDoListObjectID, ToDoListItemID);
			}
		}

		public void UpdateToDoListItem(int ToDoListObjectID, ToDoListItem objToDoListItemTarget)
		{
			ToDoListObject objToDoListObject = _ToDoListObject.GetToDoList(ToDoListObjectID);
			if (objToDoListObject != null)
			{
				ToDoListItem objToDoListItemSource = objToDoListObject.ToDoListItems.Where(y => y.ID == objToDoListItemTarget.ID).FirstOrDefault();
				if (objToDoListItemSource != null)
				{
					objToDoListItemSource.Description = objToDoListItemTarget.Description;
					objToDoListItemSource.Status = objToDoListItemTarget.Status;
				}
			}
		}
		#endregion

	}
}