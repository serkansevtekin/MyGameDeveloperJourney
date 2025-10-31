using System;

namespace AdapterDesignPatternNamespace
{
    class AdapterDesignPatternBurgerOrnekClass
    {
        public static void AdapterDesignPatternBurgerOrnekRun()
        {
            //Eski burger sınıfı (dokunmamıyoruz)
            OldBurger oldBurger = new OldBurger();

            // Adapter ile uyumlu hale getiriyoruz
            IBurger burger = new BurgerAdapter(oldBurger);

            // İstemci sadece IBurger arayüzüyle çalışıyor
            burger.MakeBurger();
        }
    }
    // 1. Target: istemcinin beklediği arayüz
    public interface IBurger
    {
        void MakeBurger();
    }

    // 2. Adaptee: Mevcut sınıf (Dokunamıyoruz)
    public class OldBurger
    {
        public void AssembleRun() => System.Console.WriteLine("Bun hazırlandı");
        public void CookPatty() => System.Console.WriteLine("Patty pişti");
        public void AddCheeseSlice() => System.Console.WriteLine("Peynir eklendi");

    }



    // 3. Adapter: Adaptee'i Target arayüzüne uyarlıyoruz
    public class BurgerAdapter : IBurger
    {
        private OldBurger _oldBurger;

        public BurgerAdapter(OldBurger oldBurger)
        {
            _oldBurger = oldBurger;
        }

        public void MakeBurger()
        {
            //Adapter burada adaptasyonu yapıyor
            _oldBurger.AssembleRun();
            _oldBurger.CookPatty();
            _oldBurger.AddCheeseSlice();
            System.Console.WriteLine("Burger Hazır\n");
        }
    }











}