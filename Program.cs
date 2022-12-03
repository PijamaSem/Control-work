// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры.

int HowManyElement (string [] arr)
{
int count =0;
for (int i=0; i<arr.Length;i++){
    if (arr[i].Length <4 ) count++;
}
return count;
}
//
// void ShowArray(string [] arr)
// {
//     for (int i=0; i<arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//         Console.WriteLine();
// }
//
Console.WriteLine("This program new show array which eleement have 3 characters or less");
string [] Array = {"123","c124","1c24","d3d5"};
Console.WriteLine(HowManyElement(Array));
string [] NewArray = new string [HowManyElement(Array)];
Console.WriteLine(NewArray.Length);
// NewArray[0]="dfvb";
// ShowArray(NewArray);
