// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] CopyArray(int[,] array) 
{
    int[,] copy = new int[array.GetLength(0),array.GetLength(1)]; 

    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            copy[i,j] = array[i,j];  
        } 
    }
  return copy;
}  


int[,] array = new int [3,4]; 
Random random = new Random(); 

for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        array[i,j] = random.Next(0,10); 
        Console.Write($"{array[i,j]}\t"); 
    } 
    
} 

Console.WriteLine(); 
 
 
int[,] save = CopyArray(array); 

for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if ((i % 2 == 0) && ( j % 2 == 0)) 
        { 
            save[i,j] = array[i,j]*array[i,j];  
            Console.Write($"({i}, {j}) Before: {array[i,j]}. After: {save[i,j]}\n"); 
        } 

    }
}
Console.WriteLine();

for (int i = 0; i < save.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{save[i,j]}\t");
    }
    Console.Write("\n");
}

Console.WriteLine();