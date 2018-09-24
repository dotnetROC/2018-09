using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

using BlazorTodo.Services;

namespace BlazorTodo
{
	public class Startup
	{
		public void ConfigureServices( IServiceCollection services )
		{
			services.AddSingleton<ITodoService, TodoService>();
		}

		public void Configure( IBlazorApplicationBuilder app )
		{
			app.AddComponent<App>( "app" );
		}
	}
}
