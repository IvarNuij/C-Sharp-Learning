using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        Users();
    }

    static void Users()
    {
        //Instantiate Users
        user Admin = new user("1", "Admin", "admin");
        user Ivaanstaan = new user("2", "Ivaanstaan", "123");

    chooseUser:
        //Print Users
        Console.WriteLine("Users:");
        Admin.printInfo();
        Ivaanstaan.printInfo();

        string userInput = Console.ReadLine();

        //Switch
        switch (userInput)
        {
            case "1": 
                Console.WriteLine("haha leuk geprobeerd");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                goto chooseUser;

            case "2":
                passwordWrong:
                Console.Clear();
                Console.WriteLine("Hello" + Ivaanstaan.name + "!\nEnter Password:");
                string userPasswordInput = Console.ReadLine();

                if (userPasswordInput == Ivaanstaan.password)
                {
                    Console.Clear();
                    Console.WriteLine("Password Correct");
                    GameCore();
                }
                else
                {
                    Console.WriteLine("Password Wrong");
                    goto passwordWrong;
                }

                break;

            default: 
                Console.WriteLine("Wrong input");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                goto chooseUser;
        }

    }

    static void GameCore()
    {
        //Random Int
        Random random = new Random();
        //Multidimentional Array
        int height = 30;
        int width = 40;

        int[,] gameGrid = new int[height, width];

    gameLoop:

        //Random
        for (int i = 0; i <= 100; i++)
        {
            gameGrid[random.Next(0, 30), random.Next(0, 40)] = random.Next(0, 1000);
        }

        //Draw
        for (int x = 0; x < height; x++)
        {
            for (int y = 0; y < width; y++)
            {
                Console.Write(gameGrid[x, y]);
            }
            Console.WriteLine();
        }

        //New Frame
        System.Threading.Thread.Sleep(1);
        Console.Clear();
        goto gameLoop;
    }

    static void CountTo100()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);
        }
    }

    class user
    {
        public string number;
        public string name;
        public string password;
        
        public user(string _number, string _name, string _password)
        {
            number = _number;
            name = _name;
            password = _password;
        }
        
        public void printInfo()
        {
            Console.WriteLine(number + " - " + name);
        }
    }
}