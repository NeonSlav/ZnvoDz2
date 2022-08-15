Console.WriteLine("Введите трехзначное число. введите выход для закрытия программы");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("выход"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }