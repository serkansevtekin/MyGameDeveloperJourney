using System;

namespace MediatorDesignPatternNamespace
{
    class Mediator
    {
        public static void MediatorDesignPatternRunMain()
        {

            ConcreteMediator mediator = new ConcreteMediator();
            var a = new ConcreteColleagueA(mediator);
            var b = new ConcreteCollageagueB(mediator);

            mediator.AddColleague(a);
            mediator.AddColleague(b);

            a.Send("Merhaba B");
            b.Send("Selam A");

        }
    }

    interface IMediator
    {
        void SendMessage(string message, AColleague sender);
    }

    abstract class AColleague
    {
        protected IMediator? _mediator;
        public AColleague(IMediator mediator)
        {
            _mediator = mediator;
        }
    }


    class ConcreteColleagueA : AColleague
    {
        public ConcreteColleagueA(IMediator mediator) : base(mediator) { }

        public void Send(string message) => _mediator!.SendMessage(message, this);
        public void Receive(string message) => System.Console.WriteLine("A aldı: " + message);

    }

    class ConcreteCollageagueB : AColleague
    {
     
        public ConcreteCollageagueB(IMediator mediator) : base(mediator) { }
        public void Send(string message) => _mediator!.SendMessage(message, this!);
        public void Receive(string message) => System.Console.WriteLine("B aldı " + message);
    }


    class ConcreteMediator : IMediator
    {

        private List<AColleague> _aColleagues = new List<AColleague>();

        public void AddColleague(AColleague c) => _aColleagues.Add(c);
        

        public void SendMessage(string message, AColleague sender)
        {
            foreach (var c in _aColleagues)
            {
                if (c != sender)
                {
                    (c as dynamic).Receive(message);
                }
            }
        }
    }



    #region Mediator Design Pattern | Tanım
    /*
    Mediator Design Pattern, nesneleri doğrudan birbiriyle iletişim kurmak yerine bir "aracı (mediator)" üzerinden haberleşmesini sağlar. Böylece bağımlılık azalır, sınıflar "loosely coupled" hale gelir
    
    Amaç:
        - Nesneler arası karmaşık etileşimleri tek bir merkezde toplamak
        - Her nesnenin diğerlerinden haberdar olmasını engellemek
        - Sistem genişlediğinde iletişimi kontrol altında tutmak

   *** UML Şeması ***
    
          +----------------+
          |   IMediator    |
          +----------------+
          | +SendMessage() |
          +----------------+
                  ▲
                  |
          +----------------+
          |ConcreteMediator|
          +----------------+
          | +colleagues    |
          | +AddColleague()|
          | +SendMessage() |
          +----------------+
             ▲          ▲
             |          |
 +----------------+   +----------------+
 | ConcreteCol...A|   | ConcreteCol...B|
 +----------------+   +----------------+
 | +Send()        |   | +Send()        |
 | +Receive()     |   | +Receive()     |
 +----------------+   +----------------+



    ***           ***

Unity’de Uygulama Alanı:

    - Çoklu NPC veya AI ajanlarının bir GameManager (tower) üzerinden haberleşmesi.
        
    - Örneğin: düşman gemiler birbirine değil, bir EnemyController üzerinden hareket bilgisi alır.
        
    - Böylece her ajan diğerlerini tanımak zorunda kalmaz.

Unity'de Kullanımı:
            - UI event yönetimi, chat sistemi, menü kontrolü, AI ajan iletişimi gibi durumlarda kullanılabilir
            - Ancak Observer, Event System, ScriptableObject event pattern ve UnityEvent genelde daha pratik çözümler sunduğu için "Mediator " doğrudan sık kullanılmaz
            - Büyük oyunlar (özellikle UI'lar arası mesajlaşma veya network event routing) aracı yönetici script mantığında dolaylı olarak kullanılır

    */

    #endregion
}