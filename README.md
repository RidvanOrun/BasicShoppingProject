# CMS 
Bu proje; Asp.NetCore teknolojisi ile yapılmıştır. 

Projede Asp.NetCore teknolojisiyle birlikte aşağıda belirttiğim hususlar anlatılmıştır.


[**IdentityUser**](https://github.com/RidvanOrun/CMSSolution/blob/master/CMSSolution.Entity/Entities/Concrete/AppUser.cs) => Bu kısımda IdentityUser kullanılmış ve  anlatılmıştır.

[**IEntityTypeConfiguration**](https://github.com/RidvanOrun/CMSSolution/blob/master/CMSSolution.Map/Mapping/Abstract/BaseMap.cs) => CMSSolution.Mapping katmanında mapping işlemi yapılmış ve bu kısımda IEntityTypeConfiguration anlatılmıştır.

[**IdentityDbContext**](https://github.com/RidvanOrun/CMSSolution/blob/master/CMSSolution.Data/Context/ApplicationDbContext.cs) => Projenin DB ile bağlantısının oluşturmak için kullanılan AplicationDbContext.cs'nin Asp.netCore'da nasıl oluşturulduğu anlatılmıştır.

[**DataAccess**](https://github.com/RidvanOrun/CMSSolution/tree/master/CMSSolution.Data/Repositories) => Bu kısımda DIP'e uyulması gereği UI katmanında kullanıclak olan Interfacelerin özelliklerinin nasıl kazandırıldığı, inject yöneti ve Generic repository mantığı uygulanmıştır.

[**SeedData**](https://github.com/RidvanOrun/CMSSolution/blob/master/CMSSolution.Data/SeedData/SeedPages.cs) => Tohumlama işlemi uygulanmış ve anlatılmıştır.

[**Startup.cs**](https://github.com/RidvanOrun/CMSSolution/blob/master/CMSSolution.Web/Startup.cs) => Gittbook sayfamda ayrıntılı anlattığım Startup.cs içerisinde bulunan Configure ve ConfigureService methodları kullanılmış/anlatılmıştır.

# Asp.NetCore nedir?;

![Image of CORE](https://gblobscdn.gitbook.com/assets%2F-MR9wwvmI8SJVJgLR_0N%2F-MRBEwGOYBF7cH7-C3qI%2F-MRBMEg99F6yDnstQVuW%2FStandartvsCore.png?alt=media&token=8a59b987-3601-452a-9311-4c0c04c13b7f)

  Asp.Net Core Microsoft tarafından açık kaynak kodlu (open-source) olarak geliştirilen. Cross platform(windows, macos, linux işletim sistemlerinde çalışabilen) olarak çalışan, esnek ve modern geliştirme platformudur. .Net Core ile beraber yazılımcılar dilerse macos, linux veya android platformlarına uygulamalarını yazabileceklerdir.
  
  Asp.Net Core hem Dependency Injection destekler hem de bunun için herhangi bir ek uygulamaya ihtiyaç duymaz. Buda kullanıcıları için oldukça büyük bir verimlilik oluşturur.
   
   Yukarıda başlangıç olarak sunduğum Asp.NetCore, IOC Conteyner, Startup.cs ile ilgili ayrıntıyı bilgiye GitBook sayfadam [*GitBook/RidvanOrun*](https://ridvanorun.gitbook.io/asp-net-core/)  ulaşabilirisniz 
