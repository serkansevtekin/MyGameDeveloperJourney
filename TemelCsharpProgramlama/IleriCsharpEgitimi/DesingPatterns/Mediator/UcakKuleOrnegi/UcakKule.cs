using System;

namespace MediatorDesignPatternUcakKuleOrnekNamespace
{
    class MediatorDesignPatternUcakKuleOrnekClass
    {
        public static void MediatorDesignPatternUcakKuleOrnekRunMain()
        {
            var tower = new AirTrafficControlTower();


            var plane1 = new Airplane("THY123");
            var plane2 = new Airplane("PEG456");
            var plane3 = new Airplane("LEFT789");


            tower.Register(plane1);
            tower.Register(plane2);
            tower.Register(plane3);

            plane1.Send("İniş izni istiyorum");
            plane2.Send("Kalkışa Hazırlanıyorum");

        }
    }

    // Arayüz: Kule ile uçakların iletişim kuracağı temel sözleşme
    interface IAirTrafficControl
    {
        void Register(Airplane airplane);   // Yeni uçağı kuleye kaydeder
        void SendMessage(string message, Airplane sender); // Bir uçaktan gelen mesajı diğerlerine iletir
    }

    // Somut Madiator (Kule)
    class AirTrafficControlTower : IAirTrafficControl
    {
        // Kuleye bağlı uçakların listesi
        private List<Airplane> _airplane = new List<Airplane>();

        // Uçağı kuleye kaydeder ve uçağın kule referansını ayarlar
        public void Register(Airplane airplane)
        {
            _airplane.Add(airplane);
            airplane.SetTower(this);
        }

        // Mesaj gönderen uçak dışındaki tüm uçaklara masajı iletir
        public void SendMessage(string message, Airplane sender)
        {
            foreach (var plane in _airplane)
            {
                if (plane != sender)
                {
                    plane.Receive(message);
                }
            }
        }
    }

    // Collague (Uçak)
    class Airplane
    {
        private string? name;   // Uçağın kimliği
        private IAirTrafficControl? tower; // Uçağın bağlı olduğu kule (Mediator)

        public Airplane(string? name)
        {
            this.name = name;
        }

        // Uçak bir mesaj gönderir -> kuleye iletilir
        public void Send(string message)
        {
            System.Console.WriteLine($"{name} mesaj gönderildi: {message}");
            tower?.SendMessage(message, this); // this = gönderen uçak
        }

        // Uçak mesaj alır
        public void Receive(string message)
        {
            System.Console.WriteLine($"{name} mesaj aldı: {message}");
        }
        // Uçağa kule referansını verir
        public void SetTower(IAirTrafficControl tower)
        {
            this.tower = tower;
        }

    }



    /*

    UML ŞEMASI

              +------------------------+
              |   IAirTrafficControl   |
              +------------------------+
              | +Register()            |
              | +SendMessage()         |
              +------------------------+
                        ▲
                        |
              +------------------------+
              | AirTrafficControlTower |
              +------------------------+
              | -airplanes             |
              | +Register()            |
              | +SendMessage()         |
              +------------------------+
                        ▲
                        |
                 +---------------+
                 |   Airplane    |
                 +---------------+
                 | -name         |
                 | -tower        |
                 | +Send()       |
                 | +Receive()    |
                 | +SetTower()   |
                 +---------------+


IAirTrafficControl → Mediator arayüzü

AirTrafficControlTower → Somut Mediator

Airplane → Colleague (katılımcı nesne)

Send metodu → Mesajı kuleye gönderir

Receive metodu → Kule tarafından diğer uçaklara iletilen mesajı alır
    */

}