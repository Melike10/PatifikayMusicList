
using PatifikayMusicList;

// print method for just name



// create a list
List<Musician> musicians = new List<Musician> ();
// add  musician into list
musicians.Add (new Musician { Name ="Ajda Pekkan",MusicType ="Pop",Year = 1968,SalesAlbum=20000000});
musicians.Add(new Musician { Name = "Sezen Aksu", MusicType = "Türk Hal Müziği/Pop", Year = 1971, SalesAlbum = 10000000 });
musicians.Add(new Musician { Name = "Funda Arar", MusicType = "Pop", Year = 1999, SalesAlbum = 3000000 });
musicians.Add(new Musician { Name = "Sertap Erener", MusicType = "Pop", Year = 1994, SalesAlbum = 5000000 });
musicians.Add(new Musician { Name = "Sıla", MusicType = "Pop", Year = 2009, SalesAlbum = 3000000 });
musicians.Add(new Musician { Name = "Serdar Ortaç", MusicType = "Pop", Year = 1994, SalesAlbum = 10000000 });
musicians.Add(new Musician { Name = "Tarkan", MusicType = "Pop", Year = 1992, SalesAlbum = 40000000 });
musicians.Add(new Musician { Name = "Hande Yener", MusicType = "Pop", Year = 1999, SalesAlbum = 7000000 });
musicians.Add(new Musician { Name = "Hadise", MusicType = "Pop", Year = 2005, SalesAlbum = 5000000 });
musicians.Add(new Musician { Name = "Gülben Ergen", MusicType = "Pop/Türk Halk Müziği", Year = 1968, SalesAlbum = 10000000});
musicians.Add(new Musician { Name = "Neşet Ertaş", MusicType = "Türk Halk Müziği/ Türk Sanat", Year = 1960, SalesAlbum = 2000000});



Console.WriteLine("--- İsmi 'S' Harfi İle Başalayan Şarkıcılar ---- ");
var nameStartsWithS = musicians.Where(m => m.Name.StartsWith("S")).ToList();
Musician.Print(nameStartsWithS);

Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("--- Albüm satışları 10 milyon'un üzerinde olan şarkıcılar ---- ");
var salesAlbumHigherThan10Milion = musicians.Where(m => m.SalesAlbum > 10000000).ToList();
Musician.Print(salesAlbumHigherThan10Milion);

Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("--2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar---");
var list2000Before = musicians.Where(m => m.Year<2000).OrderBy(m => m.Year).GroupBy(m => m.Year).ToList();

foreach (var item in list2000Before)
{
    Console.WriteLine(item.Key+" Yılı Çıkış Yapanlar");
    var group = item.OrderBy(i => i.Name).ToList();
    foreach(var musician in group)
    {
        Console.WriteLine(musician.Name);
    }
}
Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("--- En Çok Satış Yapan Şarkıcı---");
var topMusician = musicians.OrderByDescending(m => m.SalesAlbum).FirstOrDefault();
Console.WriteLine("İsim: "+topMusician.Name);



Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("--- En Yeni Çıkış Yapan Şarkıcı---");
var newMusician = musicians.OrderByDescending(m => m.Year).FirstOrDefault();
Console.WriteLine("İsim: "+newMusician.Name+" / Çıkış Yılı: "+ newMusician.Year);


Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("--- En Eski Çıkış Yapan Şarkıcı---");
var oldMusician = musicians.OrderBy(m => m.Year).FirstOrDefault();
Console.WriteLine("İsim: " + oldMusician.Name + " / Çıkış Yılı: " + oldMusician.Year);