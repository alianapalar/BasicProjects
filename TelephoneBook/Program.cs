using TelephoneBook.Operations;
using TelephoneBook.Works;

Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
Console.WriteLine("*******************************************");
Console.WriteLine("(1) Yeni Numara Kaydetmek");
Console.WriteLine("(2) Varolan Numarayı Silmek");
Console.WriteLine("(3) Varolan Numarayı Güncelleme");
Console.WriteLine("(4) Rehberi Listelemek");
Console.WriteLine("(5) Rehberde Arama Yapmak");

string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        SaveWork operation1 = new SaveWork();
        operation1.Save();
        break;

    case "2":
        DeleteWork operation2 = new DeleteWork();
        operation2.Delete();
        break;

    case "3":
        UpdateWork operation3 = new UpdateWork();
        operation3.Update();
        break;

    case "4":
        ListWork operation4 = new ListWork();
        operation4.List();
        break;

    case "5":
        SearchWork operation5 = new SearchWork();
        operation5.Search();
        break;
}
