Osoba osoba1 = new Osoba("Jan", "Kowalski", 25);
Osoba osoba2 = new Osoba("Anna", "Nowak", 30);
Osoba osoba3 = new Osoba("Piotr", "Zalewski", 22);
 
Console.WriteLine("Test enumeratora wbudowanego w List<T>:");
ListaNaSterydach<Osoba> listaOsob = new ListaNaSterydach<Osoba> { osoba1, osoba2, osoba3 };
Console.WriteLine(listaOsob);
Console.WriteLine("=====================================");
 
Console.WriteLine("Test enumeratora osoby:");
Osoby osoby = new Osoby(listaOsob);
foreach (var item in osoby)
{
    Console.WriteLine(item);
}
Console.WriteLine("=====================================");
 
string s1 = "Mariusz Lewandowski";
string s2 = "Robert Lewandowski 15";
 
Osoba o1 = s1;
Console.WriteLine(o1);
 
Osoba o2 = s2;
Console.WriteLine(o2);
 
string s3 = (string)osoba1;
Console.WriteLine(s3);
 
Console.WriteLine("\tExcel:");
string[,] tabelkaExcela = new string[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        tabelkaExcela[i, j] = listaOsob[i][j];
    }
}
 
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(tabelkaExcela[i,j] + " ");
    }
    Console.WriteLine();
}
 
Osoba o3 = "Sławomir Peszko 0.7";
Console.WriteLine(o3);
