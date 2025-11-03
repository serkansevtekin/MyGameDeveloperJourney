using System;

namespace MememntoNamespace
{
    class MementoClass
    {
        public static void MementoRunMain()
        {
            Orginator o = new Orginator();
            Caretaker c = new Caretaker();

            o.State = "Level 1";
            c.Save(o);

            o.State = "Level 2";
            c.Save(o);

            o.State = "Level 3";
            System.Console.WriteLine("Current: "+ o.State);

            c.Undo(o);
            System.Console.WriteLine("Undo: "+ o.State);


        }
    }

    class Memento
    {
        public string? State { get; }
        public Memento(string state) => State = state;
    }
    class Orginator
    {
        public string? State { get; set; }
        public Memento SaveState() => new Memento(State!);

        public void RestoreState(Memento memento) => State = memento.State;
    }
    class Caretaker
    {
        private Stack<Memento> history = new Stack<Memento>();

        public void Save(Orginator orginator)
        {
            history.Push(orginator.SaveState());
        }
        public void Undo(Orginator orginator)
        {
            if (history.Count >0)
            {
                orginator.RestoreState(history.Pop());
            }
        }
    }




    #region Mememnto Tanım
    /*
    Memento Design Pattern, bir nesnenin iç durumunu dışarı sızdırmadan kaydedip (save) daha sonra geri yüklemeyi (restore) sağlar. Amaç, “geri al” (undo) gibi işlemleri gerçekleştirebilmektir.
    

    **** UML ŞEMASI ****

+----------------+           +----------------+           +----------------+
|   Originator   |           |    Memento     |           |   Caretaker    |
+----------------+           +----------------+           +----------------+
| - state        |<--------->| - state        |           | - mementos     |
+----------------+           +----------------+           +----------------+
| + SetState()   |           | + GetState()   |           | + AddMemento() |
| + GetState()   |           |                |           | + GetMemento() |
| + SaveState()  |--------------------------------------->|                |
| + RestoreState()|<--------------------------------------|                |
+----------------+           +----------------+           +----------------+




Temel roller:

Originator: Durumu oluşturan nesne. CreateMemento() ve RestoreMemento() metodlarını içerir.

Memento: Kaydedilen durumu saklar.

Caretaker: Memento nesnelerini yönetir (saklar, geri yükler) ama içeriğini bilmez.

    */
    #endregion
}