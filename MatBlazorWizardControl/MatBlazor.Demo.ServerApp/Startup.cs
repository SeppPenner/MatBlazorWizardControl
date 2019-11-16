using System.Net.Http;
using EmbeddedBlazorContent;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MatBlazor.Demo.ServerApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<HttpClient>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            //                .AddSignalR().AddHubOptions<ComponentHub>(o =>
            //            {
            //                o.MaximumReceiveMessageSize = 1024 * 1024 * 100;
            //            });
            //services.AddServerSideBlazor();

            services.AddMatToaster(config =>
            {
                //example MatToaster customizations
                config.PreventDuplicates = false;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();

            app.UseStaticFiles();


            app.UseEmbeddedBlazorContent(typeof(BaseMatDomComponent).Assembly);

            app.UseEmbeddedBlazorContent(typeof(Index).Assembly);

            app.UseRouting();


//            app.UseSignalR(route => route.MapHub<ComponentHub>(ComponentHub.DefaultPath, o =>
//            {
//                o.ApplicationMaxBufferSize = 1024 * 1024 * 100; // larger size
//                o.TransportMaxBufferSize = 1024 * 1024 * 100; // larger size
//            }));


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}