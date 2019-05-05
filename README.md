C# .Net Core MVC de Entityframework CRUD islemleri icin ornek bir web application projesidir. (Daha da guzellestirmek isterseniz, BusinessLayer ile presentation layer 
arasina WebApi Layer i eklemenizi tavsiye ederim.)

Eğer northwind db create edilmemişse, asagidaki gibi cmd prompta local db instance i create edilerek connect olunur;

"sqllocaldb" komutunu yaz
"sqllocaldb i" komutu ile yeni local db instance ini create et.
Visual studio connect mssql db wizard servername: (LocalDB)\MSSQLLocalDB (VS server explorer dan local db ye connect ol.)
Daha sonra "instnwnd.sql" dosyasını Visual studio SQL window da run ederek, northwind db yi create et.
Artık solution u localinizde çalıştırabilirsiniz.

Entity framework reverse engineering islemi yaparak var olan db nin entitylerini projenize asagidaki sekilde create edebilirsiniz;
1)Gerekli kütüphaneleri install ediyoruz,
install-package Microsoft.EntityFrameworkCore
install-package Microsoft.EntityFrameworkCore.Design
install-package Microsoft.EntityFrameworkCore.Tools
install-package Microsoft.EntityFrameworkCore.SqlServer
install-package Microsoft.EntityFrameworkCore.SqlServer.Design
Yukaridaki paketleri ister Package Manager Console dan isterseniz NugetPackages Manager dan install ediniz. 

2)Sonra asagidaki komutu, Entity lerin olacagi proje icerisindeyken Package Manager Console dan calistiriniz.(OutputDir parametresi entity objelerinin atilacagi folder i belirtir.)

scaffold-dbcontext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;” -OutputDir Models
