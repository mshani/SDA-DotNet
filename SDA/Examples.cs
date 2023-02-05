using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA
{
    internal class Examples
    {   public void Example01()
        {
            //Withdaw amount from the bank
            decimal amount = 200;
            decimal overdraft = 100;
            decimal withdrawal = 400;

            if (amount >= withdrawal)
            {
                amount = amount - withdrawal;
                Console.WriteLine($"{amount}: amount");
                Console.WriteLine($"{overdraft}: overdraft");
            }
            else if (amount + overdraft >= withdrawal)
            {
                withdrawal = withdrawal - amount;
                amount = 0;
                overdraft = overdraft - withdrawal;
                Console.WriteLine($"{amount}: amount");
                Console.WriteLine($"{overdraft}: overdraft");
            }
            else
            {
                Console.WriteLine("No funds available");
            }
        }
        public void Example02()
        {
            //Max of 3 numbers
            int a = 3;
            int b = 4;
            int c = 5;

            if (a > b && a > c)
            {
                Console.WriteLine('a');
            }
            else if (b > c)
            {
                Console.WriteLine('b');
            }
            else
            {
                Console.WriteLine('c');
            }
        }
        public void Example03()
        {
            //Find if a year is a leap year and print it's numbers
            int year = 1000;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("leap year");
            }

            int a = year % 10;
            int b = (year - a) / 10 % 10;
            int c = (year - b * 10 - a) / 100 % 10;
            int d = (year - c * 100 - b * 10 - c) / 1000 % 10;

            Console.WriteLine($"{d},{c},{b},{a}");

        }
        public void Example04()
        {
            //sum, average, min, max
            int[] numbers = { 3, 5, 6, 3, 7, 8 };
            float sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            float average = sum / numbers.Length;
            Console.WriteLine(sum);
            Console.WriteLine(average);
        }
        public void e05()
        {
            int[] numbers = { 6, 5, 9, 2, -1, 8 };
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                else if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
        }    
        public void E06()
        {//print odd numbers
            int[] numbers = { 6, 5, 9, 2, -1, 8 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!(numbers[i] % 2 == 0))
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
        public void E07()
        {
            //copy array
            int[] numbers = { 6, 5, 9, 2, -1, 8 };
            int[] numbersCopy = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
                Console.WriteLine(numbersCopy[i]);
            }

        }
        public void E08()
        {//Copy in reverse
            int[] numbers = { 6, 5, 9, 2, -1, 8 };
            int[] numbersCopy = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[numbers.Length - 1 - i];
                Console.WriteLine(numbersCopy[i]);
            }
        }
        public void E09()
        {
            //Find element in array
            int[] numbers = { 6, 5, 9, 2, -1, 8 };
            int value = 3;
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (value == numbers[i])
                {
                    isFound = true;
                    Console.WriteLine($"U gjet elementi: {numbers[i]}, ne pozicionin {i + 1}");
                    break;
                }

            }
            if (!isFound)
            {
                Console.WriteLine($"Nuk u gjet elementi: {value}");
            }

        }
        public void E091()
        {
            int[] numbers = { 6, 5, 9, 2, -1, 8 };
            int[] numbers2 = { 3, -1, 4, 9 };
            List<int> commonElements = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers[i] == numbers2[j])
                    {
                        commonElements.Add(numbers[i]);
                        Console.WriteLine(numbers[i]);
                        break;
                    }
                }
            }
            foreach (int nr in numbers)
            {
                foreach (int nr2 in numbers2)
                {
                    if (nr == nr2)
                    {
                        commonElements.Add(nr);
                        Console.WriteLine(nr);
                        break;
                    }
                }
            };

        }
        public void E092()
        {
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                //for loop to add start
                for (int k = i; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void E093()
        {
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                //for loop to add start
                for (int k = 0; k <= n - i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void E10()
        {
            //    *
            //   ***
            //  *****
            // *******
            //*********
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                //for loop to add space
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }
                //for loop to add start
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void E11()
        {
            //*******
            //*     *
            //*     *
            //*     *
            //*     *
            //*     *
            //*******
            int number = 7;

            for (int i = 0; i < number; i++)
            {
                //print all stars if it is the first and last row
                if (i == 0 || i == number - 1)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                //The rest of the rows
                if (i >= 1 && i <= number - 2)
                {
                    for (int j = 0; j < number; j++)
                    {
                        //if it is the first and the last column print *
                        if (j == 0 || j == number - 1)
                        {
                            Console.Write("*");
                        }
                        //the columns in between
                        else if (j >= 1 && j <= number - 2)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        public void E12()
        {
            //square of x
            Console.WriteLine("Please enter the number: ");
            string value = Console.ReadLine();
            bool isSuccess = Int32.TryParse(value, out int nr);

            if (isSuccess)
            {
                int sqNr = SquareNr(nr);
                Console.WriteLine($"{nr} * {nr} = {sqNr}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            int SquareNr(int x)
            {
                return x * x;
            }
        }
        public void E13()
        {
            Console.WriteLine("Ju lutem jepni oren: ");
            string value = Console.ReadLine();
            bool isSuccess = Int32.TryParse(value, out int nr);
            //Check te inputit nese eshte numer i vlefshem`

            if (isSuccess)
            {
                //Check nese ora eshte e vlefshme Nga 00 deri ne 23
                if (nr >= 0 && nr <= 23)
                {
                    SayHello(nr);
                }
                else
                {
                    Console.WriteLine("Ora e pavlevshme");
                }
            }
            else
            {
                Console.WriteLine("Input i pavlevshem");
            }


            void SayHello(int time)
            {
                if (time <= 11)
                {
                    Console.WriteLine("Good morning!");
                }
                else if (time > 11 && time < 18)
                {
                    Console.WriteLine("Good day!");
                }
                else
                {
                    Console.WriteLine("Good evening!");
                }
            }

        }
        public void Example001()
        {
            Console.WriteLine("Please enter the principal amount: ");
            string? value1 = Console.ReadLine();
            bool v1 = Single.TryParse(value1, out float initialAmount);
            if (!v1 || initialAmount < 0)
            {
                Console.WriteLine("invalid principal value");
                return;
            }

            Console.WriteLine("Please enter the target amount: ");
            string? value2 = Console.ReadLine();
            bool v2 = Single.TryParse(value2, out float targetAmount);
            if (!v2 || targetAmount < 0)
            {
                Console.WriteLine("invalid target value");
                return;
            }

            if (initialAmount > targetAmount)
            {
                Console.WriteLine("Initial amount cannot be larger than target amount");
                return;
            }

            float percentage = 0.05f;
            int yearsCount = 0;
            while (initialAmount < targetAmount)
            {
                yearsCount++;
                initialAmount = (percentage * initialAmount) + initialAmount;
                Console.WriteLine(yearsCount + ": " + initialAmount);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(yearsCount + " years needed to reach target value");
        }
        public void Example002()
        {
            Console.WriteLine("Please enter the first number: ");
            string? value1 = Console.ReadLine();
            bool v1 = Single.TryParse(value1, out float nr1);
            if (!v1)
            {
                Console.WriteLine("invalid first value");
                return;
            }

            Console.WriteLine("Please enter the second number: ");
            string? value2 = Console.ReadLine();
            bool v2 = Single.TryParse(value2, out float nr2);
            if (!v2)
            {
                Console.WriteLine("invalid second value");
                return;
            }

            float shuma = Sum(nr1, nr2);
            Console.WriteLine("Result: " + shuma);

            //---------------------------------------------
            #region Methods
            float Sum(float x, float y)
            {
                float result = x + y;
                return result;
            }
            #endregion
        }
        public void Example003()
        {
            Console.WriteLine("Please enter a number: ");
            string? value1 = Console.ReadLine();
            bool v1 = Int32.TryParse(value1, out int nr1);
            if (!v1 || nr1 <= 0)
            {
                Console.WriteLine("invalid first value");
                return;
            }

            int shuma = Sum(nr1);
            Console.WriteLine("shuma: " + shuma);

            //---------------------------------------------
            #region Methods
            int Sum(int nr)
            {
                int result = 0;
                //while(nr > 0)
                //{
                //    result += nr;
                //    nr--;
                //}       
                for (int i = nr; i <= 0; i--)
                {
                    result += nr;
                }
                return result;
            }
            #endregion
        }
        public void Example004()
        {
            SayHello();

            Console.WriteLine("Please enter a number: ");
            string? value1 = Console.ReadLine();
            CheckUserInput(value1);
            int nr1;
            int shuma = Sum(nr1);
            Console.WriteLine("shuma: " + shuma);

            //---------------------------------------------
            #region Methods
            int Sum(int nr)
            {
                int result = 0;
                while (nr > 0)
                {
                    result += nr;
                    nr--;
                }
                return result;
            }

            void SayHello()
            {
                Console.WriteLine("Hello!");
            }

            void CheckUserInput(string? valueFromUser)
            {
                bool v1 = Int32.TryParse(valueFromUser, out nr1);
                if (!v1 || nr1 <= 0)
                {
                    Console.WriteLine("invalid value");
                    return;
                }
            }
            #endregion
        }
        public void Example005()
        {

                int[] numrat = { 15, 1, 2 };
                int shuma = Sum(numrat);
                ResetArray(numrat);


                int[] numrat2 = { 15, 1, 2, 5, 4 };
                int shuma2 = Sum(numrat2);
                ResetArray(numrat2);

                for (int i = 0; i < numrat.Length; i++)
                {
                    Console.WriteLine(numrat[i]);
                }

                int Sum(int[] a)
                {
                    int result = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        result += a[i];
                    }
                    return result;
                }

                void ResetArray(int[] b)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        b[i] = 0;
                    }
                }

            }
        public void Example006()
        {
            Console.WriteLine("Please enter number: ");
            string? value1 = Console.ReadLine();

            double number;
            bool v1 = Double.TryParse(value1, out number);
            if (!v1)
            {
                Console.WriteLine("invalid number");
                return;
            }

            double rrenjaKatrore;
            if (SquareRoot(number, out rrenjaKatrore))
            {
                Console.WriteLine(rrenjaKatrore);
            }
            else
            {
                Console.WriteLine("Ia ke fut kot");
            }

            bool SquareRoot(double n, out double sqrt)
            {
                sqrt = Math.Sqrt(n);
                //bool result = Double.IsNaN(sqrt) ? false : true;
                bool result = true;
                if (Double.IsNaN(sqrt))
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
                return result;
            }
        }
        public void Example007()
        {
            List<string> qytetet = new List<string>();

            qytetet.Add("Tirana");
            qytetet.Add("Durres");

            List<string> qytetetEurope = new List<string>();
            qytetetEurope.Add("Roma");
            qytetetEurope.Add("Berlin");

            qytetet.AddRange(qytetetEurope);

            foreach (string s in qytetet)
            {
                Console.WriteLine(s);
            }
        }
        public void Example008()
        {
            User newUser = new User("Nikolin", "jfiyfiyfu");


            User user2 = new User();
            user2.Username = "Geri";
            user2.Password = "12345";

            Console.WriteLine(newUser.Username + '\n' + user2.Username);

        }
        public void Example009()
        {
            Console.WriteLine("Please enter the first number: ");
            string? value1 = Console.ReadLine();
            bool v1 = Single.TryParse(value1, out float nr1);
            if (!v1 || nr1 < 0)
            {
                Console.WriteLine("invalid first value");
                return;
            }

            Console.WriteLine("Please enter the second number: ");
            string? value2 = Console.ReadLine();
            bool v2 = Single.TryParse(value2, out float nr2);
            if (!v2 || nr2 < 0)
            {
                Console.WriteLine("invalid second value");
                return;
            }

            //Drejkendesh drejkendesh = new Drejkendesh(nr1, nr2);
            //Console.WriteLine("Siperfaqja: " + drejkendesh.LlogaritSiperfaqen());
            //Console.WriteLine("Perimetri:" + drejkendesh.LlogaritPerimetrin());
        }
        public void Example010()
        {
            //Create acoount with amount 0
            BankAccountType1 llogari =
                new BankAccountType1(
                    "IBAN001",
                    "Filan Fisteku",
                    "ffisteku@test.com",
                    "ALL");
            //Make deposit 250
            llogari.Deposit(250);

            //Make withdrawal 100
            llogari.Withdraw(100);//150

            //Make withdrawal 300
            llogari.Withdraw(300);

            llogari.GetBalace();//150

            //deactivate account
            llogari.SetStatus(false);

            //get status
            llogari.GetStatus();

            //Make deposit 150
            llogari.Deposit(150);

            //Make withdrawal 150
            llogari.Withdraw(150);

            //deactivate account
            llogari.SetStatus(true);

            //get status
            llogari.GetStatus();

            //Make deposit 150
            llogari.Deposit(150);

            llogari.GetBalace();

            llogari.GetAccountHolders();

            llogari.AddAccountHolder("Marsela");

            llogari.AddAccountHolder("John Doe");

            llogari.GetAccountHolders();

            llogari.RemoveAccountHolder("John Doe");

            llogari.GetAccountHolders();

            bool hasAccHolder = llogari.SearchAccountHolder("Marsela");
            if (hasAccHolder) Console.WriteLine("account holder found: Marsela");
            else Console.WriteLine("account holder NOT found: Marsela");

            bool hasAccHolder2 = llogari.SearchAccountHolder("John Doe");
            if (hasAccHolder2) Console.WriteLine("account holder found: John Doe");
            else Console.WriteLine("account holder NOT found: John Doe");

            llogari.GetIban();
        }
        public void Example011()
        {
            string line = PrintToScreen();
            while (line != "stop")
            {
                string[] splitted = line.Split(',');

                int[] numbers = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = Convert.ToInt32(splitted[i]);
                }


                Array.Sort(numbers);


                foreach (var n in numbers)
                {
                    Console.WriteLine(n);
                }
                line = PrintToScreen();

            };


            string PrintToScreen()
            {
                Console.WriteLine("Please enter 5 numbers or enter \"stop\" to exit the app");
                return Console.ReadLine();
            }
        }
        public void Example012()
        {
            Console.WriteLine("Please enter 5 numbers or enter \"x\" to exit the app");
            string line = Console.ReadLine();


            while (line != "x")
            {
                string[] splitted = line.Split(',');

                int[] numbers = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = Convert.ToInt32(splitted[i]);
                }

                ConsoleKeyInfo option = PrintToScreen();

                switch (option.Key)
                {
                    case ConsoleKey.A:
                        Array.Sort(numbers);
                        PrintArray(numbers);
                        break;
                    case ConsoleKey.B:
                        Array.Reverse(numbers);
                        PrintArray(numbers);
                        break;
                    case ConsoleKey.C:
                        PrintArray(numbers);
                        break;
                    case ConsoleKey.X:
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            };


            ConsoleKeyInfo PrintToScreen()
            {
                Console.WriteLine("--------------");
                Console.WriteLine("Enter a to sort");
                Console.WriteLine("Enter b to reverse");
                Console.WriteLine("Enter c to print");
                Console.WriteLine("Enter x to exit");
                return Console.ReadKey();

            }

            void PrintArray(int[] numbers)
            {
                Console.WriteLine();
                foreach (var n in numbers)
                {
                    Console.Write($"{n}, ");
                }
                Console.WriteLine();
            }
        }
        public void Example013()
        {
            Console.WriteLine("Vendosni numrat e array-t ose \"x\" per te dale");
            string input = Console.ReadLine();

            while (!string.Equals(input, "x", StringComparison.OrdinalIgnoreCase))
            {
                string[] strings = input.Split(",");
                int[] numbers = new int[strings.Length];

                GjeneroArray(strings, numbers);
                AfishoOpsionet();

                string option = Console.ReadLine();
                KryejVeprimet(option, numbers);

                PrintoArray(numbers);
                Console.WriteLine();
                Console.WriteLine("Vendosni numrat e array-t ose \"x\" per te dale");
                input = Console.ReadLine();
            }
            void AfishoOpsionet()
            {
                Console.WriteLine("Vendosni opsionin \"a\" per te renditur");//Array.Sort(numbers);
                Console.WriteLine("Vendosni opsionin \"b\" per ta pasqyruar");//Array.Reverse(numbers);
            }
            void PrintoArray(int[] ints)
            {
                foreach (int i in ints)
                {
                    Console.Write(i + ",");
                }
            }
            void GjeneroArray(string[] strings, int[] ints)
            {

                for (int i = 0; i < ints.Length; i++)
                {
                    ints[i] = int.Parse(strings[i]);
                }
            }
            void KryejVeprimet(string option, int[] numbers)
            {
                switch (option)
                {
                    case "a":
                        Array.Sort(numbers);
                        break;
                    case "b":
                        Array.Reverse(numbers);
                        break;
                    default:
                        Console.WriteLine("Opsion i pavlefshem");
                        break;
                }
            }
        }
        public void Task6()
        {
            Console.WriteLine("Jepni nje numer te plote");
            int nr = Convert.ToInt32(Console.ReadLine());
            int b = BiggestDigit(nr);
            Console.WriteLine(b);

            void PrintDigit(int number)
            {
                List<int> digits = new List<int>();
                while (number > 0)
                {
                    int r = number % 10;
                    digits.Insert(0, r);
                    number /= 10;
                }

                foreach (int digit in digits)
                {
                    Console.WriteLine(digit);
                }
            }
            int BiggestDigit(int number)
            {
                int biggestDigit = 0;
                while (number > 0)
                {
                    int r = number % 10;
                    if (biggestDigit < r)
                    {
                        biggestDigit = r;
                    }
                    number /= 10;
                }
                return biggestDigit;
            }
        }
        public void Task7()
        {
            Console.WriteLine("Jepni nje string");
            string value = Console.ReadLine();

            double f = Occurence(value);
            Console.WriteLine(f + "%");

            double Occurence(string phrase)
            {
                char first = phrase[0];
                double occurence = 0;
                foreach (char c in phrase)
                {
                    if (char.ToUpper(c) == char.ToUpper(first))
                    {
                        occurence++;
                    }
                }
                double frequency = (occurence / (double)phrase.Length) * 100;
                return frequency;
            }
        }
        public void Task8()
        {
            int counter = 1;
            int number = 1;
            int sum = 0;
            while (counter <= 10)
            {
                bool isPrime = IsPrime(number);
                bool hasThree = Convert.ToString(number).Contains('3');
                if (isPrime && !hasThree)
                {
                    Console.Write($"{number},");
                    sum += number;
                    counter++;
                }
                number++;
            }

            Console.WriteLine("\nSum: " + sum);
            bool IsPrime(int n)
            {
                double j = Math.Floor(Math.Sqrt(n));
                for (int i = 2; i <= j; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public void Task9() {
            Console.WriteLine("Please provide the next lesson date");
            string value = Console.ReadLine();
            DateTime.TryParse(value, out DateTime result);

            int totalDays = CalcDays(result);
            Console.WriteLine($"Next lesson in {totalDays} days");

            int CalcDays(DateTime date)
            {
                int days = (date - DateTime.Now.Date).Days;
                return days;
            }

        }
        public void Task10()
        {
            bool exit = false;
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            Console.WriteLine("Please enter number:");
            while (!exit)
            {
                string value = Console.ReadLine();
                int nr = Convert.ToInt32(value);
                if (nr == randomNumber)
                {
                    Console.WriteLine("Congratulations!");
                    exit = true;
                }
                else if (nr < randomNumber)
                {
                    Console.WriteLine("Not enough");
                }
                else if (nr > randomNumber)
                {
                    Console.WriteLine("too much");
                }
            }
        }
        public void Task11()
        {
            char[] array1 = { '1', '4', '7', '9', '0' };
            char[] array2 = { '2', '5' };
            char[] array3 = { '3', '6', '8' };
            List<char> finalSequence = new List<char>();
            List<char[]> list = new List<char[]>();
            list.Add(array1);
            list.Add(array2);
            list.Add(array3);

            int longestArrayLength = new int[] { array1.Length, array2.Length, array3.Length }.Max();

            for (int i = 0; i < longestArrayLength; i++)
            {
                foreach (char[] charArray in list)
                {
                    if (charArray.Length > i)
                    {
                        finalSequence.Add(charArray[i]);
                    }
                }
            }
            Console.WriteLine(finalSequence.ToArray());
        }
        public void Task13()
        {
            Console.WriteLine("Enter a number");
            string value = Console.ReadLine();
            int number = Convert.ToInt32(value);

            int smallerPrime = number - 1;
            int biggerPrime = number + 1;

            while (!IsPrime(smallerPrime))
            {
                smallerPrime--;
            }
            while (!IsPrime(biggerPrime))
            {
                biggerPrime++;
            }

            Console.WriteLine($"Smaller prime:{smallerPrime}");
            Console.WriteLine($"Bigger prime:{biggerPrime}");
            bool IsPrime(int n)
            {
                double j = Math.Floor(Math.Sqrt(n));
                for (int i = 2; i <= j; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public void Task17()
        {
            string value = Console.ReadLine();
            string[] words = value.Split(' ');

            foreach (string w in words)
            {
                Console.Write($"{w} {w} ");
            }
        }
        public void Task17_1()
        {
            string value = Console.ReadLine();
            string[] words = value.Split(' ');

            for (int i = 0; i < words.Length; i = i + 2)
            {
                Console.Write($"{words[i]} ");
            }
        }
        public void Task17_2()
        {
            string value = Console.ReadLine();
            string[] words = value.Split(' ');
            List<string> cleaned = new List<string>();
            cleaned.Add(words[0]);
            foreach (string w in words)
            {
                if (w != cleaned.Last())
                {
                    cleaned.Add(w);
                }
            }
            Console.WriteLine(String.Join(" ", cleaned));
            //This is is is a test test and it is very very simple
            //This is a test and it is very simple
        }
        public void Task20() {

            int[] array = new int[] { 7, 256, 9, 0, 1, -1, 13, -273 };

            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }
        public void Task16()
        {
            Console.WriteLine("Type in number");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int[] array = { 0, 1, 4, 5, 9, 12, 14, 20, 23, 25 };
            int min = 0;
            int max = array.Length - 1;
            int index = -1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (number == array[mid])
                {
                    index = mid;
                    break;
                }
                else if (number < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            Console.WriteLine($"Index: {index}");
        }
    }     
}
