using Apstraktna_tvornica_DZ3;
using System;

class Program
{
    public static void Main()
    {
        ICharachterFactory factory = new FireCharachterFactory();
        factory.CreateGoblin().DoDamage();

        factory = new WaterCharachterFactory();
        factory.CreateWizard().DoMagic();
        
    }
}
