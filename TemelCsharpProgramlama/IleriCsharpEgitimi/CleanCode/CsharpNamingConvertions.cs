using System;


//namespac PascalCase
namespace CleanCode
{
    //c# naming convertion

    //class PascalCase
    class ProductManager
    {
        //Constrouctor PascalCase
        public ProductManager() { }

        //Method Name PascalCase
        public void GetAll() { }

        //Properties PascalCase
        public string? ProductName { get; set; }

        //local veriables ve private fields(_) camelCase
       // int stockAmaunt = 0;
       // private int producrId;

        //Method arguments camelCase
        void UpdateProduct(int productId)
        {

        }

        // const UPPER_CASE
        const int MAX_STOCK = 100;


        // Async methodlar -> "Async" ile biter
        // Task LoadDataAsync();

        //Event ve Delegate:
        // - Event'ler fiil kipinde, "EventHandler" patternine uygun olamalı
       /*  public event EventHandler? StockAdded;
        public delegate void StockHandler(); */

    }

    //interface -> "I" ile başlar
    interface ICustomer{}

    // enum PascalCase
    enum GameState { Running, Paused, Ended }

}
