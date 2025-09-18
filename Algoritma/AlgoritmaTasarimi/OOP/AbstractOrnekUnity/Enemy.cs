using System;

namespace Programlama.AlgoritmaTasarimi
{
    class Enemy : OyunVarLigi
    {
        public override void OL()
        {
              System.Console.WriteLine("Varlığa özel ölüm animasyonu ");
            System.Console.WriteLine($"{varlikIsmi} Varlık öldü ");
        }

        public override void Saldir(OyunVarLigi hedef)
        {
            hedef.HasarAl(hasarDegeri);
        }
    }
}