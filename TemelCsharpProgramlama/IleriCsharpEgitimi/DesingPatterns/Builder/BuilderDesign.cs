using System;

namespace BuilderDesignNameSpace
{
    class BuilderDesignClass
    {
        public static void BuilderDesignRunMain()
        {
            ProductDirector director = new();
            var builder = new OldCustomerProductBuilder();
            director.GenerateProduct(builder);
            var model = builder.GetModel();
            System.Console.WriteLine(model.Id);
            System.Console.WriteLine(model.CategoryName);
            System.Console.WriteLine(model.ProductName);
            System.Console.WriteLine(model.UnityPrice);
            System.Console.WriteLine(model.DiscountedPrice);
            System.Console.WriteLine(model.DiscountApplied);



        }
    }

    class ProductViewModel
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? ProductName { get; set; }
        public decimal UnityPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
    }


    abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();
    }

    class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new();

        public override void GetProductData()
        {
            //Farzdiyoruz veri tabanından gelen bilgiler
            model.Id = 1;
            model.CategoryName = "Baverages";
            model.ProductName = "Chai";
            model.UnityPrice = 20;
        }
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnityPrice * (decimal)0.90;
            model.DiscountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }
    }

    class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new();

        public override void GetProductData()
        {
            //Farzdiyoruz veri tabanından gelen bilgiler
            model.Id = 1;
            model.CategoryName = "Baverages";
            model.ProductName = "Chai";
            model.UnityPrice = 20;
        }
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnityPrice;
            model.DiscountApplied = false;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }
    }

    class ProductDirector
    {
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
        }
    }





    #region Builder Design Pattern | Tanım
    /*
    Nedir?
        - Karmaşık nesnelerin adım adım oluşturulmaısnı sağlar
        - Nesnenin oluşturulma sürecini ve iç yapısını birbirinden ayırır
        - Özellikle nesnenin farklı varyasyonları oluşturulacaksa kullanışlıdır
    
    Kullanım Alanları:
        - Kompleks objeler (çok parametreli constructor'lar)
        - Farklı konfigürasyonlarla nesne üretmek
        - Nesne yaratma sürecini kontrol etmek

    Roller:

        1) Builder (Soyut Buşlder)
            - Nesnenin parçalarını oluşturacak metotları tanımlar

        2) Concrater Builder(Somut Builder)
            - Builder arayüzünü uygular ve parçaları oluşturur

        3) Director (Yönetici)
            - Builder'ı kullanarak nesnenin oluşturulma sırasını belirler

        4) Product (Ürün)
            - Buşkder tarafından oluşturulan nesne

    Avantajları:
        - Karmaşık nesneler daha okunaklı ve yönetilebilir olur
        - Nesne oluşturma süreci director ile standardize edilebilir
        - Farklı nesne varyasyonları kolayca üretile bilir
    
    Dezavantajları:
        - Küçük ve basit nesneler için gereksiz karmaşıklık yaratır
        

        Bilder Pattern UML
         ┌─────────────────────┐
         │     Director        │
         ├─────────────────────┤
         │ - builder: Builder  │
         ├─────────────────────┤
         │ + Construct()       │
         └────────┬────────────┘
                  │ uses
                  ▼
        ┌─────────────────────┐
        │     Builder         │<<interface>>
        ├─────────────────────┤
        │ + BuildPartA()      │
        │ + BuildPartB()      │
        │ + GetResult():Product│
        └────────┬────────────┘
                 │implements
   ┌─────────────┴─────────────┐
   │                           │
┌─────────────────────┐   ┌─────────────────────┐
│  ConcreteBuilder1   │   │  ConcreteBuilder2   │
├─────────────────────┤   ├─────────────────────┤
│ - product: Product  │   │ - product: Product  │
│ + BuildPartA()      │   │ + BuildPartA()      │
│ + BuildPartB()      │   │ + BuildPartB()      │
│ + GetResult()       │   │ + GetResult()       │
└────────┬────────────┘   └────────┬────────────┘
         │ creates                 │ creates
         ▼                         ▼
      ┌─────────────────────┐
      │      Product        │
      ├─────────────────────┤
      │ + AddPart()         │
      │ + ShowParts()       │
      └─────────────────────┘

    */
    #endregion
}
