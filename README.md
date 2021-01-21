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


![Image of CORE](https://gblobscdn.gitbook.com/assets%2F-MR9wwvmI8SJVJgLR_0N%2F-MRFyJKdvV_OJpkXG0Vu%2F-MRFzpFQ92XJl30dWSYJ%2FCoreee.jpeg?alt=media&token=f656e305-2294-4c58-981d-09541db59beb)

  Asp.Net Core Microsoft tarafından açık kaynak kodlu (open-source) olarak geliştirilen. Cross platform(windows, macos, linux işletim sistemlerinde çalışabilen) olarak çalışan, esnek ve modern geliştirme platformudur. .Net Core ile beraber yazılımcılar dilerse macos, linux veya android platformlarına uygulamalarını yazabileceklerdir.
  
  Asp.Net Core hem Dependency Injection destekler hem de bunun için herhangi bir ek uygulamaya ihtiyaç duymaz. Buda kullanıcıları için oldukça büyük bir verimlilik oluşturur.
  
  ## .Net Core DIP'e uyumak için baştan dizayn edilmiştir. Peki nedir bu DIP prensibi ve bu prensibe nasıl uyulur?
  ![Image of IOC](https://gblobscdn.gitbook.com/assets%2F-MR9wwvmI8SJVJgLR_0N%2F-MRAAVHkkC8QloLf9Njv%2F-MRAB0wdppWkKP1b40nt%2FIOC.jpeg?alt=media&token=0d40fa9c-a79c-4ef9-a844-9c29f9bce782)
  
   Inversion of Control ve Dependencey Inversion Princible Solip prensibidir. Temelde bu 2 prensibin amacı bağımlılıkları en aza indirmek üzerinde kuruludur (SOLID prensipleri kısmından ayrıntılarına ulaşabilirisiniz). Dependencey Injection DI bu prensiplerin uygulanmasına aracı olan bir patterndır. Ki bu pattern Constructor Injection, Property Injection ve Method Injection olmak üzere 3 yöntemle uygulanır.  IOC container ise bu uygulamaların projede hayata geçiren bir frameworktur.  
   
   ## Built-in IOC conteyner nasıl çalışır?
   ![Image of IOC1](https://gblobscdn.gitbook.com/assets%2F-MR9wwvmI8SJVJgLR_0N%2F-MRAM0YgJ23jslj1E14S%2F-MRANuUTD4bawOfqYfug%2Fbuiltin-ioc.png?alt=media&token=a9bddc81-322d-45b1-b7af-cfbc137f6f2e)
   
   .NetCore birbirine bağımlı olan sınıfları servis olarak değerlendiriyor ve IOC conteynıra register etmek için Start up classı içerisinde bulunan Configure servise methoduna eklememizi istiyor. ve artık bağımlı olan sınıfları newlemek yerine consturactor methodla inject ederek Dependencey Injection pattern'nına uyulmuş oluyor.
   
   Yukarıda başlangıç olarak sunduğum Asp.NetCore, IOC Conteyner, Startup.cs ile ilgili ayrıntıyı bilgiye GitBook sayfadam [*GitBook/RidvanOrun*](https://ridvanorun.gitbook.io/asp-net-core/)  ulaşabilirisniz 
