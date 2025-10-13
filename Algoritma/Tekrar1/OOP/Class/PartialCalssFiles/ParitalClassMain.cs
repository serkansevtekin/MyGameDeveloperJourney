using System;

namespace Programlama.Tekrars1
{
    public class PartialMainClass
    {
        public static void PartialMainRun()
        {
            Pc1 p = new Pc1();
            p.Name = "serkan"; //parial class 1
            p.Attack(); // partial class 2
        }
    }
    #region Tanım
        /*
        Tanım:
            - "partial" anahtar kelimesi, bir sınıfın tanımını birden fazla dosyaya bölmeye yarar
            - Derleme sırasında parçalar birlştirilir

        Amaç:
            - Büyük sınıfları daha düzenli bölmek (örneğin farklı modüller)
            - Otomatik üretilen kodla (ör: Unity, WinForms) manuel kodu ayırmak
            - Aynı sınıfı takım halinde geliştirmek

        Kurallar:
            - Her parçada partial anahtar kelimesi olmalı
            - Aynı namespace, class name ve access modifier kullanılmalı
            - Derleyici hepsini tek sınıf gibi birleştirir
        */
    #endregion

}