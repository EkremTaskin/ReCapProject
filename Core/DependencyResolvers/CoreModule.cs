using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
	public class CoreModule : ICoreModule
	{
		public void Load(IServiceCollection serviceCollection)
		{
			serviceCollection.AddMemoryCache(); // otomatik MemoryCacheManager veriyor Redis geçileceği zaman bu satır silinir
			serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
		}
	}
}
