using System;
using System.Collections;

namespace CompositeDesignPatternNamespaces
{
    class CompositeDesignPatternClass
    {
        public static void CompositeDesignPatternRunMethod()
        {
            Employee serkan = new Employee { Name = "Serkan Sevtekin" };

            Employee hakki = new Employee { Name = "Hakkı Polq" };

            serkan.AddSubordinate(hakki);


            Employee polat = new Employee { Name = "Polat Alem" };
            serkan.AddSubordinate(polat);

            Contractor ali = new Contractor { Name = "Ali" };
            polat.AddSubordinate(ali);

            Employee ahmet = new Employee { Name = "Ahmet ğok" };
            hakki.AddSubordinate(ahmet);


            System.Console.WriteLine(serkan.Name);
            foreach (Employee manager in serkan)
            {
                System.Console.WriteLine(manager.Name);
                foreach (IPerson item in manager)
                {
                    System.Console.WriteLine(" "+item.Name);
                }
                
            }

        }
    }

    interface IPerson
    {
        public string? Name { get; set; }
    }

    class Contractor : IPerson
    {
        public string? Name { get; set; }
    }

    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }
        public string? Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var item in _subordinates)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }




    #region Composit Design Pattern Tanım
    /*
    Amaç:
        - Nesneleri ağaç yapısı şeklide organize edip, bireysel nesneler ve nesne guruplarını aynı şekilde işleyebilmek
        -Genellikle "Leaf"(yaprak) ve "Composite"(bileşik) sınıfları ile uygulanır

    Katmanlar:
        1) Component (Arayüz veya Soyut sınıf)
            - Hem yaprak hemde bileşik nesneler için ortak operasyonları tanımlar

        2)  Leaf (Yaprak)
                - Tek bir nesneyi temsil eder.
                - Composite'e özgü add/remove operasyonları yoktur.
        
        3) Composite (Bileşik)
                - Leaf veya başka bir Composite nesnelerini içerebilir
                - Add, remove gibi operasyonları uygular
    

    UML Diyagramı:
    ┌─────────────┐
    │  IComponent │
    └─────┬───────┘
          │
  ┌───────┴────────┐
  │                │
┌───────┐       ┌─────────┐
│ Leaf  │       │ Composite│
└───────┘       └─────────┘
  │                │
  │                └───> children : List<IComponent>
  │
Display()          +Add(IComponent)
                +Remove(IComponent)
                +Display()

    Özet Mantık:
        - Leaf tek başına çalışır
        - Composite kendi içinde hem Leaf hem Composite barındırabilir
        -  Tüm nesneler ortak IComponent arayüzü kulanır.

    */
    #endregion
}