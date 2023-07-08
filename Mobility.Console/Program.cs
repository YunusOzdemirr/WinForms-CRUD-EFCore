// See https://aka.ms/new-console-template for more information

int[] numbers = { 2, 2, 3, 5, 5, 6, 7 };

for (int i = 0; i < numbers.Length ; i++)
{
    //Select current number
    var lastNumber = numbers[i];
    //Counter for the how much numbers repeating on the array
    var counter = 0;
    for (int j = 0; j < numbers.Length; j++)
    {
        var numberX = numbers[j];
        //If numbersX equals to zero skip
        if (numberX == 0)
            continue;
        //If lastnumber equals to numberX set the numberX and increase counter
        if (lastNumber == numberX)
        {
            numberX = 0;
            counter++;
        }
    }
    //when for finished set counter to numberX and set counter to zero
    numbers[i] = counter;
    counter = 0;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}