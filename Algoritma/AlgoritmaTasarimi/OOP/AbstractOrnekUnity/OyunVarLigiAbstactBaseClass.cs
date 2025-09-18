using System;

namespace Programlama.AlgoritmaTasarimi
{
    public abstract class OyunVarLigi
    {
        public string? varlikIsmi { get; set; }
        public int can { get; set; } = 100;
        public int hasarDegeri { get; set; } = 10;


        public virtual void HasarAl(int miktar)
        {
            can -= miktar;
            System.Console.WriteLine($" {varlikIsmi} {miktar} hasar aldı! Kalan Can: {can}");
            if (can <= 0) OL();
    
        }


        public abstract void Saldir(OyunVarLigi hedef);
        public virtual void OL()
        {
           
            System.Console.WriteLine($"{varlikIsmi} {can} öldü!");
        }
   }
}