int correctAnswerCount = 0;


// İlk soruyu soruyoruz

Console.WriteLine("Kızınca tukuren hayvan hangisidir?");
Console.WriteLine("A) Lama");
Console.WriteLine("B) Deve");
Console.WriteLine("Cevabın");

// Cevabı alıyoruz

string answer1 = Console.ReadLine().ToLower();

if (answer1 == "a")
{
    correctAnswerCount++;

    Console.WriteLine("Dogru!");
}
else
{
    Console.WriteLine("Yanlış!");
}
// İkinci soruyu soruyoruz
Console.WriteLine("Dünyaya en yakın gezegen hangisidir?");
Console.WriteLine("A) Venüs");
Console.WriteLine("B) Mars");
Console.WriteLine("Cevabın");

//Cevabı alıyoruz

string answer2 = Console.ReadLine().ToLower();

if (answer2 == "a")
{
    correctAnswerCount++;

    Console.WriteLine("Doğru!");
}
else
{
    Console.WriteLine("Yanlış!");
}
// Burda ilk 2 soruya doğru cevabı verirse 3.soruya gecmeden ödül kazandınız ekranı geliyor
if (correctAnswerCount == 2 )
{
    Console.WriteLine("Tebrikler! 3 sorudan 2 soruya doğru cevabı verdin 1 Milyon TL ödülü kazandın!");
}
else
{
    // Egerki ilk 2 soruyu yanlış yaptıysan 3.soruyu soruyor ve toplamda 2 doğru cevap alındıysa ödül kazandınız ekranı geliyor.
    // Veya tek soruya doğru cevabı verdiyse ödülü kazanamadınız ekrani geliyor.


    Console.WriteLine("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
    Console.WriteLine("A) 7");
    Console.WriteLine("B) 12");
    Console.WriteLine("Cevabın");

    string answer3 = Console.ReadLine().ToLower();
    
    if (answer3 == "b")
    {
        correctAnswerCount++;

        Console.WriteLine("Doğru!");
    }
    else
    {
        Console.WriteLine("Yanlış!");
    }
}
if (correctAnswerCount >= 2 )
{
    Console.WriteLine("Tebrikler! 3 Sorudan 2 soruya doğru cevabı verdin 1 Milyon TL ödülü kazandın!");
}
else
{
    Console.WriteLine("Üzgünüm büyük ödülü kazanamadın :( ");
}
