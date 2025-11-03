using System;

namespace ObserverPatternNamespace
{
    class EnTemelObjectseverClass
    {
        public static void EnTemelObjectseverRun()
        {
            Subject subject = new Subject();

            IObserver obsA = new ConcreteObserverA();
            IObserver obsB = new ConcreteObserverB();

            subject.Attach(obsA); // A eklendi
            subject.Attach(obsB); // B eklendi

            subject.ChangeSomething(); // A ve B bildirim göderildi

            subject.Detach(obsA); // A çıkarıldı

            subject.ChangeSomething(); // sadece B bildirim alır

        }
    }


    // Subject
    class Subject
    {
        List<IObserver> _observer = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observer.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observer.Remove(observer);
        }

        private void Notify()
        {
            foreach (var obs in _observer)
            {
                obs.Update();
            }
        }

        public void ChangeSomething()
        {
            System.Console.WriteLine("Subject: Something changed!");
            Notify();
        }
    }



    //Observer
    interface IObserver
    {
        void Update();
    }

    // CONCRETE OBSERVER 1 
    class ConcreteObserverA : IObserver
    {
        public void Update()
        {
            System.Console.WriteLine("Observer A: Notified");
        }
    }

    // CONCRETE OBSERVER 2

    class ConcreteObserverB : IObserver
    {
        public void Update()
        {
            System.Console.WriteLine("Observer B: Notified");

        }
    }

    /*
    En yalın ve öğretici halidir.
    Çalışma Mantığı:
        1) Subject değişiklik yapar (ChangeSomething())
        2) Notify() tüm kayıtlı gözlemcilere haber verir
        3) Her gözlemci kendi update metodunu çalıştırır
    */
}