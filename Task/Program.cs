
Console.WriteLine("Введите колличество элементов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
string[] GetArray(int size)
{
    string[] result = new string[size]; 
    for (int i = 0; i < result.Length; i++) 
    {
         result[i] = Console.ReadLine();
    }
    return result;
}

string [] Array = GetArray(n);


int count = 0;

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3) 
    {
         count++;
    }
}
string[] finish = new string[count];
int count1 = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3) 
    {
        
        finish[count1] = Array[i];
        count1++;
    }
}
Console.WriteLine($"Результат: [ {String.Join(" ; ", finish)} ]");