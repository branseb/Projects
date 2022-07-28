using Tic_Tac_Toe;

string name1player;
string name2player;
while (true)
{
    Console.WriteLine("Write Name 1. Player:");
    name1player = Console.ReadLine();

    if (name1player != string.Empty)
    {
        break;
    }
}
while (true)
{
    Console.WriteLine("Write Name 2. Player:");
    name2player = Console.ReadLine();

    if (name2player != null)
    {
        break;
    }
}
/*int sizeint;
while (true)
{
 
    Console.WriteLine("Choose field size:");
    string sizestring = Console.ReadLine();
    bool sizebool = int.TryParse(sizestring, out sizeint);

    if (sizebool)
    { break; }

    else
    {
        Console.WriteLine("Write numer!");
    }

}
*/
Console.WriteLine("{0} & {1} !", name1player, name2player);
Console.WriteLine("The Battle Begins!!");
Console.WriteLine("{0} - X", name1player);
Console.WriteLine("{0} - O", name2player);
    char[,] gamearray = new char[3, 3];
    char player1char = 'x';
    char player2char = 'O';
    string nameplayer = name1player;
    char playerchar = player1char;

while (true)
{
    bool end = true;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
            gamearray[i, j] = ' ';
    }

    while (end)
    {
        while (end)
        {


            Console.WriteLine(nameplayer + " enter Coorddiinate XY");
            string coordinateXY = Console.ReadLine();
            bool coordinatecheck = Helpers.GetCoordinate(coordinateXY, out int x, out int y);
            if (!coordinatecheck)
            {
                Console.WriteLine("Wrong Choice!");
                break;
            }
            if (gamearray[x, y] != ' ')
            {
                Console.WriteLine("Coordinates are occupied!");
                break;
            }

            gamearray[x, y] = playerchar;
            Console.WriteLine(Helpers.GetGraphic(gamearray));
            bool winner = Helpers.TryFindWinner(gamearray, playerchar);
            if (winner)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Winner its " + nameplayer);
                Console.BackgroundColor = ConsoleColor.Black;
                end = false;
                break;
            }

            int drawint = 0;
            foreach (char c in gamearray)
            {
                if (c == ' ')
                {
                    drawint++;
                }

            }
            if (drawint == 0)
            {
                Console.WriteLine("No Winner - Draw");
                end = false;
            }
            if (playerchar == player1char)
            {
                playerchar = player2char;
                nameplayer = name2player;
            }
            else if (playerchar == player2char)
            {
                nameplayer = name1player;
                playerchar = player1char;
            }
        }
    }
}
