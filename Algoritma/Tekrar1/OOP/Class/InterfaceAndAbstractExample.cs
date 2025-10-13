using System;

namespace Programlama.Tekrars1
{
    public class InterfaceAndAbstractClass
    {
        public static void InterfaceAndAbstractRunMethod()
        {
            Tesla myTesla = new Tesla("Tesla", "Model 3",60);

            //Abstract class ve normal metotlar
            myTesla.Honk();
            myTesla.ShowInfo();
            myTesla.Start();

            //Explicit implementation

            IMovable movable = myTesla;
            movable.Drive(); // IMovable.Drive

            IElectric electric = myTesla;
            electric.Drive(); // IElectric.Drive

            myTesla.Stop();
            electric.Charge(20);
        }
    }





    // Günlük hayat örneğinde explicit implementation ile birlikte interface + abstract class kullanım
    #region Interface Tanımları

    public interface IMovable
    {
        void Start();
        void Stop();
        void Drive(); // Aynı isim farklı interfece'te çakışacak
    }

    public interface IElectric
    {
        void Charge(int amout);
        void Drive(); // Çakışma -> explicit implementation lağzım
    }

    #endregion

    #region Abstract Class

    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
            Speed = 0;
        }

        public abstract void Honk(); // abstract metot -> override zorunlu
        public virtual void ShowInfo() // virtual metot -> override opsiyonel
        {
            System.Console.WriteLine($"Vehicle: {Brand} {Model}, Speed: {Speed}");
        }

        public void StopVehicle()
        {
            Speed = 0;
            System.Console.WriteLine($"{Brand} {Model} stopped.");
        }

    }
    #endregion

    #region Concrate class
    //Concrate class -> Tüm metodları impelemnte edilmiş, nesne oluşturulabilen somut sınıf

    public class Tesla : Vehicle, IMovable, IElectric
    {

        public int Battery { get; private set; }
        public Tesla(string brand, string model,int battery = 100) : base(brand, model)
        {
            Battery = battery;
        }


        public void Charge(int amout)
        {
            Battery += amout;
            System.Console.WriteLine($"{Brand} {Model} charge {amout}%. Total: {Battery}%");
        }

         void IElectric.Drive()
        {
            System.Console.WriteLine($"{Brand} {Model} drives normally (IElectric)");
        }
         void IMovable.Drive()
        {
            System.Console.WriteLine($"{Brand} {Model} drives normally (IMovable)");
        }

        public override void Honk()
        {
           System.Console.WriteLine($"{Brand} {Model} honks silently!");
        }

        public void Start()
        {
            System.Console.WriteLine($"{Brand} {Model} started.");
            Speed = 5;
            Battery -= 1;
        }

        public void Stop()
        {
            StopVehicle();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine($"Battery: {Battery}");
        }
    }
    #endregion

}