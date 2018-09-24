using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace BlazorTodo.Services
{
	public class TodoService : ITodoService
	{
		private readonly HttpClient _httpClient;

		private List<TodoItem> items = new List<TodoItem>();

		/// <summary>
		/// Initializes a new instance of the service with sample data.
		/// </summary>
		/// <param name="httpClient">Injected singleton instance of the HttpClient class.</param>
		public TodoService( HttpClient httpClient )
		{
			_httpClient = httpClient;

			InitializeTodoItems();
		}

		/*****************************************************************
		 * NOTE: A 'real' service would make calls to some backend API to
		 *       store & retrieve the data.
		 ****************************************************************/
		#region ITodoService implementation

		public IList<TodoItem> GetItems()
		{
			return items;
		}

		public void AddItem( TodoItem item )
		{
			items.Add( item );
		}

		public void CompleteItem( Guid itemId )
		{
			var item = items.Single( i => i.ItemId == itemId );
			item.Completed = true;
		}

		public void UpdateItem( TodoItem updatedItem )
		{
			var oldItem = items.Single( i => i.ItemId == updatedItem.ItemId );
			oldItem.Update( updatedItem );
		}

		public void RemoveItem( Guid itemId )
		{
			var item = items.Single( i => i.ItemId == itemId );
			items.Remove( item );
		}

		#endregion

		/// <summary>
		/// Builds a small sample list of todo items.
		/// </summary>
		/// <remarks>
		/// The real application would retrieve these from a servive and persist
		/// using local storage.
		/// </remarks>
		private void InitializeTodoItems()
		{
			// sample item
			items.Add( new TodoItem
			{
				Title = "Plan VDUNY October meeting",
				Description = "Find a speaker and a sponsor",
				DueDate = new DateTime( 2018, 10, 4 )
			} );

			// sample completed item
			items.Add( new TodoItem
			{
				Title = "Finish VDUNY Demos",
				Description = "Build sample todo application",
				DueDate = new DateTime( 2018, 9, 27 ),
				Completed = true
			} );

			// sample overdue item
			items.Add( new TodoItem
			{
				Title = "Plan VDUNY September meeting",
				Description = "Find a speaker and sponsor",
				DueDate = new DateTime( 2018, 09, 01 )
			} );
		}
	}
}
