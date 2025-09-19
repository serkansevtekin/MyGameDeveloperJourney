using System;

namespace Programlama.AlgoritmaTasarimi
{
    //Interface Inheritance

    //ITransfer ve IBankaHesap ikiside Interface olduğundan IBankaHesap içindekileri implemente etmeye gerek yok
    public interface ITrasfer : IBankaHesap
    {
        bool TrasferYap(IBankaHesap aliciHesap, decimal miktar);
    }
    
    /*
    “Interface Inheritance” dediğimiz olay, bir interface’in başka bir interface’ten türetilmesi.

    Yani class’larda olduğu gibi, bir interface başka bir interface’i miras alabilir. Böylece daha küçük parçaları birleştirerek büyük kurallar zinciri kurabiliyorsun.
     */
}