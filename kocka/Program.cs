
bod bodA = new bod();
bodA.sourX = 3;
bodA.sourY = -4;

bod bodB = new bod();
bodB.sourX = 4;
bodB.sourY = -3;

int Vzdalenost = bodA.Vzdalenost(bodB);
Console.WriteLine("vzdalenost bodů "  " + Vzdalenost);

class bod
{
    public int sourX;
    public int sourY;

    public int Vzdalenost(bod druhyBod)
    {
        double vzdX = Math.Pow(druhyBod.sourX - this.sourX, 2);
        double vzdY = Math.Pow(druhyBod.sourY - this.sourY, 2);
        double odm = Math.Sqrt(vzdX + vzdY);

        double vysledek = Math.Abs(odm);
        return (int)vysledek;
    }
    public bod()
    {
        Console.WriteLine("napis souradnici x");
        sourX = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("napis souradnici y");
        sourY = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("souřadnice x: " + sourX);
        Console.WriteLine("souřadnice y: " + sourY);
    }
}