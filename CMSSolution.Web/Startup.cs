using CMSSolution.Data.Context;
using CMSSolution.Data.Repositories.Concrete.EntityTypeRepository;
using CMSSolution.Data.Repositories.Interface.EntityRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSSolution.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        // Burası IOC container. Projemde inject ettiğim sınıflarımı burada belirtiyorum ki böylece kullanıma hazır hale geliyor.
        // Proje içerisinde; bağlantılı olan sınıflarımı birbirlerine inject ediyorum.  Müteakiben IOC conteynırıa register etmek için Start up classının içeirisnde bulunan ConfigureServices methodunun içerisine ekliyorum. IOC kanteynır da bana Bağımlılıkları tersine çevirmeyi temin ediyor. Bu yöntem ile sınıflarımın (new lemekteki) sıkı sıkıya bağımlılığı ortadan kaldırma amacıyla yapılmıştır.Böylecede DIP'e tamamen uymuş olduk.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPageRepository, PageRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
          

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>           
            {
                // NOT : => DEFAULT ÜZERİNDE YAPILACAK İŞLEMLER İÇİN TEK TEK ENDPOİNT KULLANILMASI GEREKİYOR. FAKAT AREA İÇİN TEK BİR  HAMLE YETERLİDİR.
                endpoints.MapControllerRoute(
                     name: "page", //Name => Yolun Adı
                     pattern: "{slug?}", // "slug?" nedir slug yanında id de taşır... => pattern Bunun yazılmasının sebebi methodların yapılacağı işleme göre URL belirlenmesidir.
                defaults: new { controller = "Page", action = "Page" });  // => 

                endpoints.MapControllerRoute(
                    name: "product",
                    pattern: "product/{categorySlug}",
                    defaults: new { controller = "Product", action = "ProductByCategory" }); // => endpointleri methodlara yönlendirmek için default kullanılır.

                endpoints.MapControllerRoute( // => default sayfalar için bu end pointi kullandık
                    name: "default", //=> yolun adı
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute( //=> Area içerisinde bütün controller üzerinde ki methodların olduğu View sayfasının görüntülenmesi için sadece bu endpointi kullanmak yeterlidir.
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"); // => pattern adres gösterir, eğer direk adres belirtiyorsa defaults a gerek yok. 
                // exist => kullanıldığında name içerisinde yazılı olan bütün index ve methodlar çalışır.
                // sağ tarafına yazılması gereken adreslerin "{controller=Home}/{action=Index}/{id?}" standartı belirtilmesi yeterlidir. 
            });        
        }
    }
}
