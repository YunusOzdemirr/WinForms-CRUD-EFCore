// See https://aka.ms/new-console-template for more information

int[] numbers = { 2, 2, 3, 5, 5, 6, 7,1};

for (int i = 0; i < numbers.Length; i++)
{
    //Şu anki sayıyı al
    var lastNumber = numbers[i];
    //Önceki index'in sıras
    var beforeNumberIndex = i;
    //Atlanması gereken index sayısı
    var skipIndex = i;
    //Counter for the how much numbers repeating on the array
    var counter = 0;
    for (int j = skipIndex; j < numbers.Length; j++)
    {
        var numberX = numbers[j];
        //If numbersX equals to zero skip
        if (numberX == 0)
            continue;
        //If lastnumber equals to numberX set the numberX and increase counter
        if (lastNumber == numberX)
        {
            //Bir önceki sayıyı 0'a set etme
            numbers[beforeNumberIndex] = 0;
            //counter eğer 0'dan büyükse numbers[j] değerini 0'a atmalıyız diğer türlü 2,1 gibi istemediğimiz sonuçlar ortaya çıkıyor
            if (counter > 0)
                numbers[j] = 0;
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