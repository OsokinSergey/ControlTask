
string[] inputArray = new string[] {"Однажды","Вася","был","голодный","проглотил","утюг","холодный"};
string[] outputArray = new string[0];


void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++){
        Console.Write($"'{array[i]}' ");
    }
    Console.WriteLine("]");
}

//Проходим по всем элементам входного массива
for(int i=0; i<inputArray.Length; i++ ){
    string element=inputArray[i];
    if(element.Length<5){
        Array.Resize(ref outputArray,outputArray.Length+1);
        outputArray[outputArray.Length-1]=element;
    }
}

PrintArray(outputArray);
