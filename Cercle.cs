namespace _6TTI_DPMael_Cercle;

public class Cercle
{
    private double _rayon;

    public Cercle(double rayon)
    {
        _rayon = rayon;
    }

    public double Rayon
    {
        get { return _rayon; }
    }
    
    public double CalculerAire()
    {
        return Math.PI * _rayon * _rayon;
    }
    
    public double CalculerPerimetre()
    {
        return 2 * Math.PI * _rayon;
    }
    
    public string Informations()
    {
        return $"Cercle de rayon {_rayon}, aire {CalculerAire()}, périmètre {CalculerPerimetre()}";
    }
}