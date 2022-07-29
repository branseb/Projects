using System.Text;
namespace Pexeso
{
    public static class Helpers
    {
        public static Stack<char> GetCards(int countcards)
        {
            List<char> cards = new List<char>();
            for (int i = 65; i < countcards / 2 + 65; i++)
            {
                cards.Add((char)i);
                cards.Add((char)i);
            }
            var random = new Random();
            cards = cards.OrderBy(x => random.Next()).ToList();
            return new Stack<char>(cards);
        }
        public static char[,] GetArray(int x, int y)
        {
            var count = x * y;
            var deck = Helpers.GetCards(count);
            var array = new char[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = deck.Pop();
                }

            }
            return array;
        }
        public static bool TryParseSize(string xstring, string ystring, out int x, out int y)
        {


            bool xbool = int.TryParse(xstring, out x);
            bool ybool = int.TryParse(ystring, out y);

            return ((x * y) % 2 == 0 && xbool && ybool);

        }
        public static bool GetCoordinate(string coordinateXY, char [,] cards,out int x, out int y)
        {
          
            bool xbool = int.TryParse(coordinateXY[0].ToString(), out x);
            bool ybool = int.TryParse(coordinateXY[1].ToString(), out y);
            if (coordinateXY.Length != 2 || !xbool || !ybool)
            {
                return false;
            }

            var xOk = 0 < x && x <= cards.GetLength(0);
            var yOk = y > 0 && y <= cards.GetLength(1);

            
            if (!xOk || !yOk || cards [x,y] == ' ')
            {
                return false;
            }
            return true;
        }

        public static string GetGraphic(char[,] cards, int card1x, int card1y, int card2x, int card2y)
        {
            StringBuilder graphic = new StringBuilder();
            for (int i = 0; i < cards.GetLength(0); i++)
            {
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    if ((i == card1x-1 && j == card1y-1)||(i == card2x-1 && j == card2y-1))
                    {
                        graphic.Append(cards[i,j]+"|");
                    }
                    else if (cards[i,j] == ' ')
                    {
                        graphic.Append(" |");
                    }
                    else
                    {
                        graphic.Append("░|");
                    }

                }
                graphic.AppendLine();
            }
            return graphic.ToString();
        }
    }
}
