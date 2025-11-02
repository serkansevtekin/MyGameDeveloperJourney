using System;

namespace BridgeNamespace
{
    class BridgeDesignPatternClass
    {
        public static void BridgeDesignPatternRunMain()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.MessageSenderBase = new SmsSender();
            customerManager.UpdateCustomer();
        }
    }
    abstract class MessageSenderBase
    {
        public void Save()
        {
            System.Console.WriteLine("Message saved!");
        }

        public abstract void Send(Body body);

    }
    class Body
    {
        public string? Title { get; set; }
        public string? Text { get; set; }
    }

    class SmsSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
          System.Console.WriteLine( $"{body.Title} was sent via SmsSender");
        }
    }

    class EmailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            System.Console.WriteLine($"{body.Title} was sent via EmailSender");
        }
    }
    


    class CustomerManager
    {
        public MessageSenderBase? MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase!.Send(new Body{Title ="Abaout the course!"});
            System.Console.WriteLine("Customer updated");
        }
    }


    #region Bridge Design Pattern  | Tanım
    /*

* Amaç:
        - Soyutlamayı (abstraction) ve uygulamayı (implementation) birbirinden ayırmak

* Lehim Noktası:
        - İkisi bağımsız olarak değiştirilebilir

* Kullanım:
        - Farklı implementasyonların (platform, veri kaynağı, render) birden çok soyutlama tarafından paylaşılması gerektiğinde.

* Avantaj:
        - Değişime açık, sınıf patlamasını engeller, tek sorumluluk ilkesi korunu

* Dezavantaj:
        - Tasarım biraz daha karmaşık olur, başlangıçta eksra arayüzşer gerekir




  **  UML ŞEMASI **


+----------------+           +----------------------+
| Abstraction    |<>-------->| Implementor (IImpl)  |
| - implementor  |           | + OperationImpl()    |
| + Operation()  |           +----------------------+
+----------------+                     /      \
     ^                              /        \
     |                             /          \
+--------------------+   +----------------+    +----------------+
| RefinedAbstraction |   | ConcreteImplA  |    | ConcreteImplB  |
| + Operation()      |   | + OperationImpl()|  | + OperationImpl()|
+--------------------+   +------------------+  +------------------+

UML ŞEMA AÇIKLAMASI:

* Abstraction:
    -> Soyut katman. Kullanıcı bununla etkileşir
    -> İçinde "Implementor" arayüzüne referans (composition) vardor (<>---->).
    -> "Operation() metodu, "Implementor"'un metodunu çağırır.

* Implementor (IImpl):
    -> Alt sistemin soyutlanması. "Abstration" bununla iletişim kurar
    -> "OperationImpl()" adında soyut metot tanımlar

* ConcreteImplA / ConcreteImplB:
    -> "Implementor" arayüzünü gerçekleyen sınıflar
    -> Farklı platform veya işlem mantıkları burada uygulanır

* RefinedAbstraction:
    -> "Abstraction"'dan türeyen sınıf
    -> "Operation()" metodunu genişletir yada özelleştirir
    -> Hala "Implementor" nesnesi üzerinden işlem yapar

**** -> Soyutlama(Abstraction) ve uygulama(Implementor) birbirine gevşek bağlıdır
**** -> Abstraction, Implementor referansını içerir ama onun somut tipini bilmez
**** -> Bu sayede soyutlama ve uygulama birbirinden bağımsız değişebilir


  **             **
    */
    #endregion
}