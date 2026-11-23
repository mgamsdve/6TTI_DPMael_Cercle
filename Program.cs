namespace _6TTI_DPMael_Cercle;

class Program
{
    static void Main(string[] args)
    {
        string recommencer;
        
        Console.WriteLine("Bienvenue dans ce programme sur le cercle !");

        do
        {
            LireDouble("Tapez un rayon pour créer un cercle :", out double rayonCercle);
            Cercle cercle = new Cercle(rayonCercle);
            Console.WriteLine(cercle.Informations());
            
            Console.WriteLine("Avec un cercle de rayon diminué de moitié : ");
            Cercle cercleDiminue = new Cercle(rayonCercle / 2);
            Console.WriteLine(cercleDiminue.Informations());
            
            Console.WriteLine("Un autre cercle ? Tapez sur espace");
            recommencer = Console.ReadLine();
        } while (recommencer == " ");
    }

    public static void LireDouble(string question, out double resultat)
    {
        do
        {
            Console.WriteLine(question);
        } while (!double.TryParse(Console.ReadLine(), out resultat));
    }
}