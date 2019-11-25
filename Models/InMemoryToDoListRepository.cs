using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListApi.Models
{
	public class InMemoryToDoListRepository : IToDoListRepository
	{
		private static List<ToDoListObject> _toDoListObjectList =  new List<ToDoListObject>();

		public InMemoryToDoListRepository()
		{
		}

		public void AddToDoListObject(ToDoListObject obj)
		{
			obj.ID = _toDoListObjectList.Count == 0 ? 1 : _toDoListObjectList.Max(x => x.ID) + 1;
			int counter = 0;
			foreach (var item in obj.ToDoListItems)
			{
				counter++;
				item.ID = counter;
				item.ToDoListObjectId = obj.ID;
			}
			_toDoListObjectList.Add(obj);
		}

		public List<ToDoListObject> GetToDoList()
		{
			return _toDoListObjectList;
		}

		public List<ToDoListObject> GetToDoList(String UserId)
		{
			return _toDoListObjectList.FindAll(x=> x.UserId.ToLower().Equals(UserId));
		}

		public ToDoListObject GetToDoList(int ID)
		{
			return _toDoListObjectList.FirstOrDefault(x=> x.ID == ID);
		}

		public void RemoveToDoListObject(int ID)
		{
			var _toDoListObject = _toDoListObjectList.FirstOrDefault(x => x.ID == ID);
			if (_toDoListObject != null)
				_toDoListObjectList.Remove(_toDoListObject);
		}

		public void UpdateToDoListObject(int ID, ToDoListObject targetObj)
		{
			var _toDoListObject = _toDoListObjectList.FirstOrDefault(x => x.ID == ID);
			if (_toDoListObject != null)
			{
				_toDoListObject.Description = targetObj.Description;
				foreach (var item in _toDoListObject.ToDoListItems)
				{
					var targetItem = targetObj.ToDoListItems.FirstOrDefault(x => x.ID == item.ID);
					item.Description = targetItem.Description;
					item.Status = targetItem.Status;
				}
			}
		}


		public List<ToDoListItem> GetToDoListItem(int ToDoListObjectID)
		{
			var _toDoListObject = _toDoListObjectList.FirstOrDefault(x => x.ID == ToDoListObjectID);
			if (_toDoListObject != null)
			{
				return _toDoListObject.ToDoListItems;
			}
			else
				throw new Exception("No Data Found.");
		}
		public void AddToDoListItem(int ToDoListObjectID, ToDoListItem obj)
		{
			var _toDoListObject = _toDoListObjectList.FirstOrDefault(x => x.ID == ToDoListObjectID);
			if (_toDoListObject != null)
			{
				obj.ID = _toDoListObject.ToDoListItems.Count == 0 ? 1 : _toDoListObject.ToDoListItems.Max(x => x.ID) + 1;
				obj.ToDoListObjectId = ToDoListObjectID;
				_toDoListObject.ToDoListItems.Add(obj);
			}
		}
		public void RemoveToDoListItem(int ToDoListObjectID, int ToDoListItemID)
		{
			var _toDoListObject = _toDoListObjectList.FirstOrDefault(x => x.ID == ToDoListObjectID);
			if (_toDoListObject != null)
			{
				var _toDoListItem = _toDoListObject.ToDoListItems.FirstOrDefault(x => x.ID == ToDoListItemID);

				if (_toDoListItem != null)
				{
					_toDoListObject.ToDoListItems.Remove(_toDoListItem);
				}
			}
		}
		public void UpdateToDoListItem(int ToDoListObjectID, ToDoListItem objToDoListItemTarget)
		{
			var _toDoListObject = _toDoListObjectList.FirstOrDefault(x => x.ID == ToDoListObjectID);
			if (_toDoListObject != null)
			{
				var _toDoListItem = _toDoListObject.ToDoListItems.FirstOrDefault(x => x.ID == objToDoListItemTarget.ID);

				if (_toDoListItem != null)
				{
					_toDoListItem.Description = objToDoListItemTarget.Description;
					_toDoListItem.Status = objToDoListItemTarget.Status;
				}
			}
		}

	}
}