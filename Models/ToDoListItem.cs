using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoListApi.Models
{
	public class ToDoListItem
	{
		public int ID { get; set; }
		public string Description { get; set; }
		public bool Status { get; set; }
		public int ToDoListObjectId { get; set; }
	}
}