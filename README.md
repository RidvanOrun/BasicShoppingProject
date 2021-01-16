
Bu proje; ASP.NetCore teknolojisi ile yapılmıştır. 
Projede özet olarak; 
[**Lab1**]() => DataBase First yönetimin ve Linq To temel sorguları anlatılmıştır.

[**Lab1**]() => DataBase First yönetimin ve Linq To temel sorguları anlatılmıştır.

[**Lab1**]() => DataBase First yönetimin ve Linq To temel sorguları anlatılmıştır.

[**Lab1**]() => DataBase First yönetimin ve Linq To temel sorguları anlatılmıştır.

[**Lab1**]() => DataBase First yönetimin ve Linq To temel sorguları anlatılmıştır.


# Asp.NetCore nedir?;

![Image of CORE](https://gblobscdn.gitbook.com/assets%2F-MR9wwvmI8SJVJgLR_0N%2F-MRA7sHfUI-iHNmRinJ4%2F-MRA97LrHwGUKuU-xYzn%2F.netCore.png?alt=media&token=f65394ac-7c8f-4731-8d32-d3aa996b2c58)

  Asp.Net Core Microsoft tarafından açık kaynak kodlu (open-source) olarak geliştirilen. Cross platform(windows, macos, linux işletim sistemlerinde çalışabilen) olarak çalışan, esnek ve modern geliştirme platformudur. .Net Core ile beraber yazılımcılar dilerse macos, linux veya android platformlarına uygulamalarını yazabileceklerdir.
  
  Asp.Net Core hem Dependency Injection destekler hem de bunun için herhangi bir ek uygulamaya ihtiyaç duymaz. Buda kullanıcıları için oldukça büyük bir verimlilik oluşturur.
  
  ## .Net Core DIP'e uyumak için baştan dizayn edilmiştir. Peki nedir bu DIP prensibi ve bu prensibe nasıl uyulur?
  ![Image of IOC](https://gblobscdn.gitbook.com/assets%2F-MR9wwvmI8SJVJgLR_0N%2F-MRAAVHkkC8QloLf9Njv%2F-MRAB0wdppWkKP1b40nt%2FIOC.jpeg?alt=media&token=0d40fa9c-a79c-4ef9-a844-9c29f9bce782)
  
   Inversion of Control ve Dependencey Inversion Princible Solip prensibidir. Temelde bu 2 prensibin amacı bağımlılıkları en aza indirmek üzerinde kuruludur (SOLID prensipleri kısmından ayrıntılarına ulaşabilirisiniz). Dependencey Injection DI bu prensiplerin uygulanmasına aracı olan bir patterndır. Ki bu pattern Constructor Injection, Property Injection ve Method Injection olmak üzere 3 yöntemle uygulanır.  IOC container ise bu uygulamaların projede hayata geçiren bir frameworktur.  
   
   ## Built-in IOC conteyner nasıl çalışır?
   ![Image of IOC1](https://gblobscdn.gitbook.com/assets%2F-MR9wwvmI8SJVJgLR_0N%2F-MRAM0YgJ23jslj1E14S%2F-MRANuUTD4bawOfqYfug%2Fbuiltin-ioc.png?alt=media&token=a9bddc81-322d-45b1-b7af-cfbc137f6f2e)
   
   .NetCore birbirine bağımlı olan sınıfları servis olarak değerlendiriyor ve IOC conteynıra register etmek için Start up classı içerisinde bulunan Configure servise methoduna eklememizi istiyor. ve artık bağımlı olan sınıfları newlemek yerine consturactor methodla inject ederek Dependencey Injection pattern'nına uyulmuş oluyor.
   
   Yukarıda başlangıç olarak sunduğum Asp.NetCore, IOC Conteyner, Startup.cs ile ilgili ayrıntıyı bilgiye GitBook sayfadam [*GitBook/RidvanOrun*](https://ridvanorun.gitbook.io/asp-net-core/)  ulaşabilirisniz 
