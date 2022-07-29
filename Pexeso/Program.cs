using Pexeso;

Console.WriteLine("Hi!");
bool sizebool = false;
int sizex = 0;
int sizey = 0;
while (!sizebool)
{
    Console.WriteLine("Choose first size:");
    string sizexstring = Console.ReadLine();

    Console.WriteLine("Choose second size:");
    string sizeystring = Console.ReadLine();
    sizebool = Helpers.TryParseSize(sizexstring, sizeystring, out sizex, out sizey);
    if (!sizebool)
    {
        Console.WriteLine("Wrong choice!!");
    }

}
char[,] cards = Helpers.GetArray(sizex, sizey);
bool end = true;
(int id, int score) player1 = (1, 0);
(int id, int score) player2 = (2, 0);
(int id, int score) player = (player1.id, player1.score);
while (end)
{
    int x1 = 0;
    int y1 = 0;
    int x2 = 0;
    int y2 = 0;
    Console.WriteLine("Get Player Nr.{0}", player.id);
    bool firstcard = false;
    while (!firstcard)
    {
        Console.WriteLine("Enter coordinate xy first cards:");
        var coordinatexy = Console.ReadLine();
        firstcard = Helpers.GetCoordinate(coordinatexy, cards, out x1, out y1);
        if (!firstcard)
        {
            Console.WriteLine("Bad choice! Try Again");
        }
    }
    bool seconcard = false;
    while (!seconcard)
    {
        Console.WriteLine("Enter coordinate xy second cards:");
        var coordinatexy = Console.ReadLine();
        seconcard = Helpers.GetCoordinate(coordinatexy, cards, out x2, out y2);
        if (!seconcard)
        {
            Console.WriteLine("Bad choice! Try Again");
        }
    }
    Console.WriteLine(Helpers.GetGraphic(cards,x1,y1,x2,y2));
    if (cards[x1, y1] == cards[x2, y2])
    {
        Console.WriteLine("Match!");
        cards[x1, y1] = ' ';
        cards[x2, y2] = ' ';
        if (player.id == 1)
        {
            player1.score++;
        }
        else
        {
            player2.score++;

        }
    }
    else
    {
        Console.WriteLine("Bad Luck!");
    }
    if (player.id == player1.id)
    {
        player = player2;
    }
    else if (player.id == player2.id)
    {
        player = player1;
    }
    int endint = 0;
    foreach (var card in cards)
    {

        if (card == ' ')
        {
            endint++;
        }

    }
    if (endint == cards.Length)
    { 
        end = false;
        if (player1.score>player2.score)
        {
            Console.WriteLine("Winner its Player Nr." + player1.id);
        }
        else if (player2.score>player1.score)
        {
            Console.WriteLine("Winner its Player Nr." + player2.id);
        }
        else
        {
            Console.WriteLine("No winner !");
        }
    }
    
}