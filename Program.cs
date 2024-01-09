// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длинна которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] array = {"Hello", "Russia", "457", "Ura", "2P", ":-)", "Prime"};
int count =  0;
for (int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <= 3) count = count + 1;
   
  } 
     
string[] array1 = new string[count];

for (int i = 0; i < array.Length; i++)
{
  if(array[i].Length <= 3) 
   {
   
      int k = 0;
      array1[k] = array[i];

      Console.Write(array1[k] + ", ");
       k++;
     }

}