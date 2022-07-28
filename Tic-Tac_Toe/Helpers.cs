namespace Tic_Tac_Toe
{
    public static class Helpers
    {
        public static bool GetCoordinate(string coordinateXY, out int x, out int y)
        {
            x = 0;
            y = 0;

            if (coordinateXY.Length != 2)
            {
                return false;
            }

            var xOk = coordinateXY[0] == '1' || coordinateXY[0] == '2' || coordinateXY[0] == '3';
            var yOk = coordinateXY[1] == '1' || coordinateXY[1] == '2' || coordinateXY[1] == '3';

            if (!xOk || !yOk)
            {
                return false;
            }

            x = coordinateXY[0] - 49;
            y = coordinateXY[1] - 49;
            return true;
        }

        public static bool TryFindWinner(char[,] gamearray, char player)
        {
            for (int i = 0; i < 3; i++)
            {
                var rowOk = true;
                var colOk = true;
                for (int j = 0; j < 3; j++)
                {
                    if (gamearray[i, j] != player)
                        rowOk = false;
                    if (gamearray[j, i] != player)
                        colOk = false;
                }
                if (rowOk || colOk)
                    return true;
            }

            var diag1Ok = true;
            var diag2Ok = true;
            for (int i = 0; i < 3; i++)
            {
                if (gamearray[i, i] != player)
                    diag1Ok = false;
                if (gamearray[2 - i, i] != player)
                    diag2Ok = false;
            }

            if (diag1Ok || diag2Ok)
                return true;

            return false;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (gamearray[i, j] != ' ')
            //        {
            //            try
            //            {
            //                if (gamearray[i, j] == gamearray[i + 1, j])
            //                {
            //                    if (gamearray[i, j] == gamearray[i + 2, j])
            //                    {
            //                        return true;
            //                    }
            //                }
            //            }
            //            catch (System.IndexOutOfRangeException)
            //            { }
            //            try
            //            {
            //                if (gamearray[i, j] == gamearray[i + 1, j + 1])
            //                {
            //                    if (gamearray[i, j] == gamearray[i + 2, j + 2])
            //                    {
            //                        return true;
            //                    }
            //                }
            //            }
            //            catch (System.IndexOutOfRangeException)
            //            { }
            //            try
            //            {
            //                if (gamearray[i, j] == gamearray[i, j + 1])
            //                {
            //                    if (gamearray[i, j] == gamearray[i, j + 2])
            //                    {
            //                        return true;
            //                    }
            //                }
            //            }
            //            catch (System.IndexOutOfRangeException)
            //            { }
            //        }
            //    }
            //}

            //return false;
        }
        public static string GetGraphic(char[,] gamearray)
        {
            return (gamearray[0, 0] + "|" + gamearray[0, 1] + "|" + gamearray[0, 2] + "|") +
            Environment.NewLine+(gamearray[1, 0] + "|" + gamearray[1, 1] + "|" + gamearray[1, 2] + "|") +
            Environment.NewLine+(gamearray[2, 0] + "|" + gamearray[2, 1] + "|" + gamearray[2, 2] + "|");
        }
    }
}


