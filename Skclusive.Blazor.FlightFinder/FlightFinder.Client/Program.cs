﻿using Microsoft.AspNetCore.Blazor.Hosting;

namespace Skclusive.Blazor.FlightFinder
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
			BlazorWebAssemblyHost
				.CreateDefaultBuilder()
				.UseBlazorStartup<Startup>();
	}
}
