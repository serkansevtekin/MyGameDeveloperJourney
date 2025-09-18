using System;

namespace Programlama.AlgoritmaTasarimi
{
    public class Player : OyunVarLigi
    {
      
        public override void Saldir(OyunVarLigi hedef)
        {
            System.Console.WriteLine($"{varlikIsmi} {hedef.varlikIsmi}'e {hasarDegeri} hasar veriyor");
            hedef.HasarAl(hasarDegeri);
        }
    }
}