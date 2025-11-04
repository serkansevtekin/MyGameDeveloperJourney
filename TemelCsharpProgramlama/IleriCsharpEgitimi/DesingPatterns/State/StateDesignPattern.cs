using System;

namespace StateDesignPatternNamespace
{
    class StateDesignPatternClass
    {
        public static void StateDesignPatternRunMethod()
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();



        }
    }

    interface IState
    {
        void Handle(Context context);
    }

    class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            System.Console.WriteLine("State: ConcreteStateA");
            context.SetState(new ConcreteStateB());
        }
    }
    class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            System.Console.WriteLine("State: ConcreteStateB");
            context.SetState(new ConcreteStateC());


        }
    }

    class ConcreteStateC : IState
    {
        public void Handle(Context context)
        {
            System.Console.WriteLine("State: ConcreteStateC");
            context.SetState(new ConcreteStateA());
        }
    }

    class Context
    {
        private IState? _state;

        public Context(IState state)
        {
            _state = state;
            System.Console.WriteLine($"Eski durum: {_state.GetType().Name}");
        }

        public void SetState(IState state)
        {
            _state = state;
            System.Console.WriteLine($"Yeni ve şuanki durum: {_state.GetType().Name}");
        }

        public void Request()
        {
            _state!.Handle(this);
            
        }
    }






    #region State Design Pattern Tanım
    /*
    State Design Pattern, bir nesnenin iç durumna göre davranışını değiştirmesini sağlar. Nesnenin durumu değiştiğinde, sanki sınıf değişmiş gibi farklı davranır. "if/else" zincirlerini ortadan kaldırır, her durumu ayro bir sınıf haline getirir.

   ** Yapı (UML Şeması) **

+-------------------+         +-------------------+
|     Context       |<>------>|     State         |
+-------------------+         +-------------------+
| - state: State    |         | + Handle(): void  |
+-------------------+         +-------------------+
| + SetState(State) |                 
| + Request()       |-----> çağırır -> Handle()  
+-------------------+         
      |
      | (Concrete States)
      v
+-----------------------+     +-----------------------+
|  ConcreteStateA       |     |  ConcreteStateB       |
+-----------------------+     +-----------------------+
| + Handle(): void      |     | + Handle(): void      |
+-----------------------+     +-----------------------+


Mantık: 
    * Context: Durum bilgisini taşır ve dış dünyaya tek arayüzdür
    * State: Ortak arayüz, her durumun davranışı bu arayüze uygular
    * ConcreteStateA/B: Davranışı belirleyen sınıf
    * Context.Request(): Aktif duruma göre davranış değiştirir.

**             **

****** İsteğe göre Unity'de AI, karakter animasyon geçişleri veya oyun seviyeleri arasında durum yönetimi için kullanılır


    */
    #endregion
}