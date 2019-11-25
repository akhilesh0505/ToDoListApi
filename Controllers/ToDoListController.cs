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
	/// Controller Class for ToDoListObject.
	/// </summary>
    public class ToDoListController : ApiController
    {
		private IToDoListService _toDoListService;

		/// <summary>
		/// Default Constructor
		/// </summary>
		public ToDoListController()
		{
		}

		/// <summary>
		/// Parameterized Constructor with Injection of ToDoListService Class
		/// </summary>
		/// <param name="toDoListService"></param>
		public ToDoListController(IToDoListService toDoListService)
		{
			_toDoListService = toDoListService;
		}

		/// <summary>
		/// Api Function to retreive List of All ToDoListObjects defined in the system for all Users.
		/// </summary>
		/// <returns>List of ToDoListObjects</returns>
		public List<ToDoListObject> Get()
		{
			List<ToDoListObject> lstToDoListObject = new List<ToDoListObject>();
			lstToDoListObject = _toDoListService.GetToDoList();
			return lstToDoListObject;
		}

		/// <summary>
		/// Api Function to retreive List of All ToDoListObjects defined in the system for given User.
		/// </summary>
		/// <param name="UserId"></param>
		/// <returns>List of ToDoListObjects</returns>
		[HttpGet]
		public List<ToDoListObject> GetToDoListByUser(string UserId)
		{
			List<ToDoListObject> lstToDoListObject = new List<ToDoListObject>();
			lstToDoListObject = _toDoListService.GetToDoList(UserId.ToLower());
			return lstToDoListObject;
		}

		/// <summary>
		/// Api Function to retreive details of ToDoListObjects defined in the system for given Object ID.
		/// </summary>
		/// <param name="UserId"></param>
		/// <returns>ToDoListObject</returns>
		[HttpGet]
		public ToDoListObject GetToDoListById( int id)
		{
			ToDoListObject toDoListObject = _toDoListService.GetToDoList(id);
			return toDoListObject;
		}

		/// <summary>
		/// Api function to add ToDoListObject to the repository
		/// </summary>
		/// <param name="objs"></param>
		[HttpPost]
		public void AddToDoListObject(ToDoListObject objs)
		{
			_toDoListService.AddToDoListObject(objs);
		}

		/// <summary>
		/// Api function to update ToDoListObject for given object ID with values as provided in the target Object.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="targetObj"></param>
		[HttpPut]
		public void UpdateToDoListObject(int id, ToDoListObject targetObj)
		{
			_toDoListService.UpdateToDoListObject(id, targetObj);
		}

		/// <summary>
		/// Api function to Delete a ToDoListObject for the given Object ID.
		/// </summary>
		/// <param name="id"></param>
		[HttpDelete]
		public void DeleteToDoListObject(int id)
        {
			_toDoListService.RemoveToDoListObject(id);
		}
	}
}
