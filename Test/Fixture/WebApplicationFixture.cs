using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Test.Fixture;

    public class WebApplicationFixture<TStartup> : WebApplicationFactory<TStartup>
         where TStartup : class
    {

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {


            base.ConfigureWebHost(builder);
        }

    }
