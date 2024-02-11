using Business.Concrete;
using Entities.Concrete;
//Citizen citizen_one = new Citizen
//{

//};

SelamVer(isim: "Berkay");
SelamVer(isim: "Ayşe");
SelamVer(isim: "Fatma");
SelamVer(isim: "Hayriye");
SelamVer();

int sonuc = Topla();

string[] students = new string[3];

    students[0] = "Berkay";
    students[1] = "Engin";
    students[2] = "Kerem";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(i + " " + students[i]);
}

// old type of arrays
string[] cities1 = new[] {"Ankara", "İstanbul", "İzmir"};
string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır"};

//new type of arrays
List<string> provinces1 = new List<string> { "aAnkara", "aİstanbul", "aİzmir" };
List<string> provinces2 = new List<string> { "aBursa", "aAntalya", "aDiyarbakır" };
provinces1.Add("Badana");

foreach (string province in provinces1)
{
    Console.WriteLine(province);
}

int citi = 0;

cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);

Person person1 = new Person();
person1.FirstName = "Berkay";
person1.LastName = "Arabacı";
person1.NationalIdentity = 13612744750;
person1.DateOfBirthYear = 1997;

Person person2 = new Person
{
    FirstName = "Berçin",
    LastName = "Arabacı",
    NationalIdentity = 4737285947,
    DateOfBirthYear = 1999
};

foreach (string city in cities1)
{
    Console.WriteLine("foreach " + citi + " " + city);
    citi++;
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


Console.ReadLine();

static void SelamVer(string isim = "anon")
{
    Console.WriteLine("Selam " + isim);
}

static int Topla (int sayi1 = 1, int sayi2 = 2, int sayi3 = 3)
{
    int sonuc = sayi1 + sayi2 + sayi3;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}

public class Citizen
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int DateOfBirth { get; set; }
    public long NationalId { get; set; }
}