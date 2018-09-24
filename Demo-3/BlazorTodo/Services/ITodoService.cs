using System;
using System.Collections.Generic;

namespace BlazorTodo.Services
{
	/// <summary>
	/// Defines the service interface for working with todo items.
	/// </summary>
	interface ITodoService
	{
		/// <summary>
		/// Gets the list of todo items.
		/// </summary>
		/// <returns>A list of todo items.</returns>
		IList<TodoItem> GetItems();

		/// <summary>
		/// Adds a new item to the list.
		/// </summary>
		/// <param name="item">The new item to add.</param>
		void AddItem( TodoItem item );

		/// <summary>
		/// Marks the specified item as complete.
		/// </summary>
		/// <param name="itemId">Unique id of the item to complete.</param>
		void CompleteItem( Guid itemId );

		/// <summary>
		/// Updates an existing item.
		/// </summary>
		/// <param name="updatedItem">Updated item.</param>
		void UpdateItem( TodoItem updatedItem );

		/// <summary>
		/// Removes an item from the list.
		/// </summary>
		/// <param name="itemId">Unique id of the item to remove.</param>
		void RemoveItem( Guid itemId );
	}
}
