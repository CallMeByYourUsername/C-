void getCoordinates (double xa, double ya, double za, double xb, double yb, double zb)
{
    double x = xa - xb;
    double y = ya - yb;
    double z = za - zb;
    double c = Math.Sqrt(x*x + y*y + z*z);
    Console.WriteLine(Math.Round(c,2));
}
getCoordinates(3, 6, 8, 2, 1, -7);

