bool playAgain = true;
bool end = false;
Console.Clear();
while(playAgain == true){
int[] intArray = { 0, 1, 2, 3, 4, 5};
Console.WriteLine(intArray.Length);
Console.WriteLine(intArray[0]);


for(int i = 0 ; i < intArray.Length; ++i){
    Console.WriteLine(i);
}

int[] Array = { 0, 1, 2, 3, 4, 5};
Console.WriteLine(intArray.Length);
Console.WriteLine(intArray[0]);


for (int i = intArray.Length - 1; i >= 0; i--){
    Console.WriteLine(i);
}
    Console.WriteLine("To restart type playAgain to end type in end");
    string ending = Console.ReadLine();
        if(ending == "end")
        {
            playAgain = false;

        }else
        {
            end = true;
        }
}
