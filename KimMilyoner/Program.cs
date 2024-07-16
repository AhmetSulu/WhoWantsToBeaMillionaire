int correctAnswerCount = 0;

Console.WriteLine("Kızınca tukuren hayvan hangisidir?");
Console.WriteLine("A) Lama");
Console.WriteLine("B) Deve");
Console.WriteLine("Cevabın");

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

Console.WriteLine("Dünyaya en yakın gezegen hangisidir?");
Console.WriteLine("A) Venüs");
Console.WriteLine("B) Mars");
Console.WriteLine("Cevabın");

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

if (correctAnswerCount == 2 )
{
    Console.WriteLine("Tebrikler! 3 sorudan 2 soruya doğru cevabı verdin 1 Milyon TL ödülü kazandın!");
}
else
{
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
