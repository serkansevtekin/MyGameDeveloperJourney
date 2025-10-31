using System;

namespace CompositeDesignPatternNamespaces
{
    class CompositeDesignPatternClass
    {
        public static void CompositeDesignPatternRunMethod()
        {

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