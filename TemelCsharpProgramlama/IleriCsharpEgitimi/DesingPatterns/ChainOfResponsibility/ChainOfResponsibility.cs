using System;

namespace ChainOfResponsibilityNamespace
{
    class ChainOfResponsibilityClass
    {
        public static void ChainOfResponsibilityRunMethod()
        {
            Manager manager = new Manager();
            VicePresident vicePresident = new VicePresident();
            President president = new President();

            manager.SetSuccesor(vicePresident);
            vicePresident.SetSuccesor(president);

            Expense expense = new Expense { Detail = "Eğitim", Amount = 1098 };


            manager.HandleExpense(expense);
        }
    }


    class Expense
    {
        public string? Detail { get; set; }
        public decimal Amount { get; set; }
    }


    abstract class ExpenseHandlerBase
    {

        // Zincirdeki bir sonraki handler'ın referansı
        // İstek burada işlenemezse Succesor'a iletilir
        protected ExpenseHandlerBase? Successor;

        // İsteği (burada Expense nesnesini) işleyecek somut metot
        // Her alt sınıf bu metodu kendi iş kuralına göre uygular
        public abstract void HandleExpense(Expense expense);
        

        // Zincirdeki bir  sonraki handler'ı bağlamak için kullanılır
        public void SetSuccesor(ExpenseHandlerBase expenseHandlerBase)
        {
            Successor = expenseHandlerBase;
        }
    }


    class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                System.Console.WriteLine("Manager imzaladı");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }

    class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                System.Console.WriteLine("Vice President imzaladı");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }

    class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                System.Console.WriteLine("President imzaladı");
            }

        }
    }



    #region Chain Of fResponsibility (Sorumluluk zinciri) | Tanım
    /*
    *Amaç:
         Bir isteği gönderen ile işleyen arasında gevşek bağ kurmak. İstek bir zincir üzerinde sırayla işleyicilere (handler) iletilir. Her handler isteği işleyebilir veya bir sonraki handler'a iletir. Her handler isteği işleyebilir veya bir sonraki handler'a iletir.

    Kullanım:
        Hata/istek işleme, logging, event filitreleme, komut dağıtımı

    Yapı (Katılımcılar):

        * Handler (absract/interface): 
            İsteği işler veya successor'a iletir. Handle(request) metodu ve SetSuccesor() / Susccesor alanı içerir

        * ConcreteHandler:
            Gerçek iş mantığını içerir. İşleyemezse successor'a yönlendirir.

        * Client:
            Zinciri kurar ve isteği başlatır.


    Avantaj:
        Gevşek bağlılık. Yeni handler eklemek kolay.

    Dezavantaj:
        Zinciri takip etmek zor. Hiç bir handler isteği işlemezse davranışı belirsiz.


   ***  UML ŞEMASI ***

+----------------+      1       +--------------------+
|    Client      |------------->|    Handler (A)     |
+----------------+              +--------------------+
                               ^    |
                               |    | successor
                               |    v
                         +--------------+
                         |ConcreteHandler|
                         +--------------+


    */
    #endregion
}