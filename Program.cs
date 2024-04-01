// See https://aka.ms/new-console-template for more information

int dateTime = DateTime.Now.Hour;
Console.WriteLine(dateTime.ToString());

// eğer 21-5 arası ise iyi geceler desin
// eğer 6-11 arası ise iyi sabahlar
// eğer 11-16 arası ise iyi öğlenler
// eğer 16-21 arası ise iyi akşamlar

if(dateTime >= 21 || dateTime <= 5)
{
    Console.WriteLine("İyi geceler");
}else if(dateTime >5 && dateTime <= 11)
{
    Console.WriteLine("İyi sabahlar, Günaydın!");
}else if (dateTime > 11 && dateTime <= 16)
{
    Console.WriteLine("İyi öğlenler");
}else if(dateTime > 16 && dateTime < 21){
    Console.WriteLine("İyi akşamlar");
}
else
{
    Console.WriteLine("Bir şeyler ters gitti.");
}