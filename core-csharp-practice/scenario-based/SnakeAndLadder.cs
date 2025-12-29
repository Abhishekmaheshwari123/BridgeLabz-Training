using System;
class SnakeAndLadder
{
    static Random dice = new Random();
                            

    public static void Main(String[] args)
    {
       Solve();
    }

    static void Solve()
    {
        Console.WriteLine("Enter the number of Players");
        int n = int.Parse(Console.ReadLine());

        int[] values = new int[n];
        string[]names = new string[n];
        int[,] snakes = {
                                { 17, 7 },
                                { 54, 34 },
                                { 62, 19 },
                                { 64, 60 },
                                { 87, 24 },
                                { 93, 73 },
                                { 95, 75 },
                                { 98, 79 }
                                };
    
        int[,] ladders = {
                                { 4, 14 },
                                { 9, 31 },
                                { 20, 38 },
                                { 28, 84 },
                                { 40, 59 },
                                { 51, 67 },
                                { 63, 81 },
                                { 71, 91 }
                            };                        
        for(int i = 0; i < n; i++)
        {   
            Console.WriteLine("Enter the name of "+(i+1)+" player");
            names[i] = Console.ReadLine();
        }

        bool []flg = new bool[n];
        int chance = 0;

        
        while(true)
        {
            Console.WriteLine("Press Enter to roll the dice for : "+names[chance]);
            Console.ReadLine();
            int nextValue = RollDice(dice);
            Console.WriteLine("Dice value for "+names[chance]+" : "+nextValue+"  ");
            if(flg[chance] == false)
            {
                if(nextValue == 1)
                {
                    Console.WriteLine(names[chance]+" can start onboard and move from "+values[chance]+" to "+(values[chance] + 1));
                    flg[chance] = true;
                    values[chance] = 1;
                }
            }
            else
            {
                Console.WriteLine(names[chance]);
                int temp = values[chance] + nextValue;
                if(temp > 100){
                    Console.WriteLine("This value is out of bound");
                    continue;
                }                
                else if(temp == 100)
                {
                    Console.WriteLine("Congratulations! Winner is : "+names[chance]);
                    values[chance] = temp;
                    break;
                }
                else if (CheckIfSnake(temp,snakes) != -1)
                {
                    int nextPos = CheckIfSnake(temp,snakes);
                    Console.WriteLine("Oops you land on a snake! "+names[chance] +" moved from "+values[chance] +" to "+nextPos);
                    values[chance] = nextPos;
                }
                else if(CheckIfLadder(temp,ladders) != -1)
                {
                    int nextPos = CheckIfLadder(temp,ladders);
                    Console.WriteLine("Wow you land on a ladder! "+names[chance] +" moved from "+values[chance] +" to "+nextPos);
                    values[chance] = nextPos;
                }
                else {
                    int nextPos = temp;
                    Console.WriteLine(names[chance]+ " moved from "+values[chance] +" to "+temp);
                    values[chance] = temp;
                }
            }
            chance++;
            chance = chance % n;
        }
        


    }

    static int RollDice(Random dice)
    {
        return dice.Next(1,7);
    }

    static int CheckIfLadder(int temp, int[,]ladders)
    {
        for(int i = 0; i < ladders.GetLength(0); i++)
        {
            if(ladders[i,0] == temp) return ladders[i,1];
        }
        return -1;
    }
    static int CheckIfSnake(int temp,int[,]snakes)
    {
        for(int i = 0; i < snakes.GetLength(0); i++)
        {
            if(snakes[i,0] == temp) return snakes[i,1];
        }
        return -1;
    }
}