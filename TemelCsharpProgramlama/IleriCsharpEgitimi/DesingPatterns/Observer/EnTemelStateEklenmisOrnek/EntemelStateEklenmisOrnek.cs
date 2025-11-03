using System;

namespace ObserverDesignPatternNamespace
{
    class EnTemelStateEklenmisOrnekClass
    {
        public static void EnTemelStateEklenmisOrnekRun()
        {
            WeatherStation weatherStation = new WeatherStation();

            IObserver phone = new PhoneDisplay("Ali is Phone");
            IObserver window = new WindowDisplay();

            weatherStation.Attach(phone);
            weatherStation.Attach(window);

            weatherStation.SetTemperature(20);

            System.Console.WriteLine();

            weatherStation.Detach(window);
            weatherStation.SetTemperature(3);



        }
    }
    // Observer state eklenmiş örnek

    //Subject
    public class WeatherStation
    {
        private List<IObserver> _observer = new List<IObserver>();
        private float _temperature;

        public void Attach(IObserver observer) => _observer.Add(observer);
        public void Detach(IObserver observer) => _observer.Remove(observer);

        private void Notify()
        {
            foreach (var obs in _observer)
            {
                obs.Update(_temperature);
            }
        }

        public void SetTemperature(float temp)
        {
            _temperature = temp;
            System.Console.WriteLine($"[WeatherStation] Temperature changed to {_temperature}°C");
            Notify();
        }

    }

    //IObserver
    public interface IObserver
    {
        void Update(float temperature);
    }

    // ConcreteObserver 1
    public class PhoneDisplay : IObserver
    {
        private string? _name;

        public PhoneDisplay(string name)
        {
            _name = name;
        }
        public void Update(float temperature)
        {
            System.Console.WriteLine($"{_name} show new temperature {temperature}°C");
        }
    }

    // ConcreteObserver 2

    public class WindowDisplay : IObserver
    {

        public void Update(float temperature)
        {
            System.Console.WriteLine($"[WindowDisplay] Temperature changed to {temperature}°C");

        }
    }


    /*

    State ile temel uml yapısı:

    +----------------+
    |   Subject      |
    +----------------+
    | -observers     |
    | -state          |
    +----------------+
    | +Attach()      |
    | +Detach()      |
    | +Notify()      |
    +----------------+
            |
            v
    +----------------+
    |  IObserver     |
    +----------------+
    | +Update(state) |
    +----------------+
            ^
            |
    +---------------------+
    | ConcreteObserver    |
    +---------------------+
    | +Update(state)      |
    +---------------------+


    */
}