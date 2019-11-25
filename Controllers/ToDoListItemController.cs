using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoListApi.Models;
using ToDoListApi.Services;

namespace ToDoListApi.Controllers
{

	/// <summary>
	/// Controller Class for ToDoListItem.
	/// </summary>
	public class ToDoListItemController : ApiController
    {
		private IToDoListService _toDoListService;

		/// <summary>
		/// Parameterized Constructor with Injection of ToDoListService Class
		/// </summary>
		/// <param name="toDoListService"></param>
		public ToDoListItemController(IToDoListService toDoListService)
		{
			_toDoListService = toDoListService;
		}

		/// <summary>
		/// Api fuction to retreive list of ToDoListItem for given ToDoListObject.
		/// </summary>
		/// <param name="ToDoListObjectId"></param>
		/// <returns></returns>
		public List<ToDoListItem> Get(int ToDoListObjectId)
        {
			List<ToDoListItem> ToDoListItems = _toDoListService.GetToDoListItem(ToDoListObjectId);
			return ToDoListItems;
		}

		/// <summary>
		/// Api Function to add new ToDoListItem for given ToDoListObject with given ToDoListObjectId. 
		/// </summary>
		/// <param name="ToDoListObjectId"></param>
		/// <param name="objs"></param>
		[HttpPost]
		public void AddToDoListItem(int ToDoListObjectId, ToDoListItem objs)
		{
			_toDoListService.AddToDoListItem(ToDoListObjectId, objs);
		}

		/// <summary>
		/// Api function to update ToDoListItem for given ToDoListObject with ToDoListObjectId from values as provided in the target Object.
		/// </summary>
		/// <param name="ToDoListObjectId"></param>
		/// <param name="targetObj"></param>
		[HttpPut]
		public void UpdateToDoListItem(int ToDoListObjectId, ToDoListItem targetObj)
		{
			_toDoListService.UpdateToDoListItem(ToDoListObjectId, targetObj);
		}

		/// <summary>
		/// Api function to Delete a ToDoListItem  with given ToDoListItemID for a given ToDoListObject with ToDoListObjectID.
		/// </summary>
		/// <param name="ToDoListObjectID"></param>
		/// <param name="ToDoListItemID"></param>
		[HttpDelete]
		public void DeleteToDoListItem(int ToDoListObjectID, int ToDoListItemID)
		{
			_toDoListService.RemoveToDoListItem(ToDoListObjectID, ToDoListItemID);
		}
	}
}
