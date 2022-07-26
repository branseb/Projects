using System;
var generator = new Random(0);
var generatory = new Random(1);

List<(double, double,bool)> points = new List<(double, double, bool)>();

int inCircleCount=0;
int allPoints = 0;
double priemer = 0;
int count = -1;
while (true)
{
    count++;
    while (count < 101)
    {
        double x = generator.NextDouble();
        double y = generatory.NextDouble();
        double diffX = 0.5 - x;
        double diffY = 0.5 - y;
        double fromMiddle = Math.Sqrt(Math.Pow(diffX, 2.0) + Math.Pow(diffY, 2));
        bool inCircle = fromMiddle <= 0.5;

        if (inCircle)
        {
            inCircleCount++;
        }

        allPoints++;

        priemer = priemer + ((double)inCircleCount / allPoints * 4);

        count++;
    }
    double priemertotal = priemer / count;
    Console.WriteLine(priemertotal);
}