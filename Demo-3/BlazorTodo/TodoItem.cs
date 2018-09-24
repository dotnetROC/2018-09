using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodo
{
	public class TodoItem
	{
		/// <summary>Unique identifier for the item.</summary>
		public Guid ItemId { get; private set; } = Guid.NewGuid();

		/// <summary>Brief title of the todo item.</summary>
		public string Title { get; set; }

		/// <summary>Extra information (notes) about item.</summary>
		public string Description { get; set; }

		/// <summary>Date the todo item should be completed by.</summary>
		public DateTime DueDate { get; set; } = DateTime.Now.Date.AddDays( 1 );

		/// <summary>Whether the item has been completed or not.</summary>
		public bool Completed { get; set; } = false;

		/// <summary>
		/// Updates the current item with new values.
		/// </summary>
		/// <param name="updated"></param>
		public void Update( TodoItem updated )
		{
			Title = updated.Title;
			Description = updated.Description;
			DueDate = updated.DueDate;
			Completed = updated.Completed;
		}
	}
}
