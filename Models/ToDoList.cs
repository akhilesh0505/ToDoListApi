using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListApi.Models
{
	public class ToDoListObject
	{
		public int ID { get; set; }
		public string Description { get; set; }
		public List<ToDoListItem> ToDoListItems { get; set; } = new List<ToDoListItem>();
		public string UserId { get; set; }
	}
}