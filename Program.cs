// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры.

// Methods
int HowManyElement (string [] arr)
    {
    int count =0;
    for (int i=0; i<arr.Length;i++){
        if (arr[i].Length <4 ) count++;
    }
    return count;
    }
void ShowArray(string [] arr)
    {
        Console.Write("[");
        for (int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
            Console.Write("]");
    }

string [] FillNewArray(string []arr, int size)
    {
    string [] NewArr = new string [size];
    int count =0;
    for(int i=0; i<arr.Length;i++)
    {
        if (arr[i].Length <4 )
        {
            NewArr[count]=arr[i];
            count++;   
        }
        }
    return NewArr;
    }
// Body of program
Console.WriteLine("This program new show array which eleement have 3 characters or less");
string [] Array = {"123","c24","1c24","d3d5"};
string [] NewArray = FillNewArray(Array,HowManyElement(Array));
ShowArray(NewArray);