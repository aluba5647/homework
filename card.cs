using System;

public class Phone
{
    public string HomePhone { get; set; }
    public string BusinessPhone { get; set; }
    public string CellPhone { get; set; }

    public Phone(string home, string business, string cell)
    {
        HomePhone = home;
        BusinessPhone = business;
        CellPhone = cell;
    }

    public override string ToString()
    {
        return $"Home: {HomePhone}, Business: {BusinessPhone}, Cell: {CellPhone}";
    }
}

public class Cards
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public Phone PhoneList { get; set; }

    public Cards(string name, string occupation, int age, string email, Phone phoneList)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Email = email;
        PhoneList = phoneList;
    }

    public void GetCard()
    {
        Console.WriteLine("== 名片資料 ==");
        Console.WriteLine($"姓名: {Name}");
        Console.WriteLine($"職業: {Occupation}");
        Console.WriteLine($"年齡: {Age}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"電話: {PhoneList}");
    }
}

public class Program
{
    public static void Main()
    {
        Phone phone = new Phone("0800092000", "9487946", "51125112");
        Cards card = new Cards("林基德", "工程師", 25, "xuan@gmail.com", phone);

        card.GetCard();
        Console.Read();
    }
}
