

string[] mass1 = new string[8] {"BMW", "Volvo", "KIA", "Nissan", "Geele", "JMC", "Mersedes", "Subaru"};
string[] mass2 = new string[mass1.Length];
void FillMass2Method(string[] mass1, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
    if(mass1[i].Length <= 3)
        {
        mass2[count] = mass1[i];
        count++;
        }
    }
}
void PrintMass2(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
FillMass2Method(mass1, mass2);
PrintMass2(mass2);