using System;


namespace CSharpProgramlama.IleriCSharpEgitimi
{
    public class HataYonetimi
    {//Exceptions
        public static void HataYonetimiRun()
        {
            //ExceptionIntro();

            //KendiHata Sınıfımızı Yazma
            try
            {
                Kendi();
            }
            catch (RecaordNotFoundException exception)
            {
                System.Console.WriteLine(exception.Message);

            }

            //Method
            //Lambda ve Action
            //Kendi() metodunu delege olarak HandleException metoduna gönderiyoruz.
            // Eğer Kendi() içerinde bir hata oluşursa, HandleException yakalar ve yönetir
            HandleException(() => { Kendi(); }); // Delege Parametre olarak metod gönderme
        }


        /*
        HandleException metodu, kendisine parametre olarak verilen Action tipindeki metodu çalıştırır
        ve eğer bu metod içerisinde bir hata (Exception oluşursa try-catch ile yakalar.
        Bu sayede hatalar merkezi olarak yönetilmiş olur ve uygulama çökmez
        */
        private static void HandleException(Action action)
        {
           try
            {
            // parametre olarak gelen metodu çalıştırır
                action.Invoke();
           }
           catch (Exception exception)
            {
            //Hata olursa konsola mesaj yazdır
            System.Console.WriteLine(exception.Message);
       
           }
        }

        private static void Kendi()
        {
            List<string> students = new List<string> { "Serkan", "Mahmut", "Hakan" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecaordNotFoundException ("Record Not Found!");
            }
            else
            {
                System.Console.WriteLine("Recor found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3]//0,1,2 elemanlı
                {
                "Engin","Derin","Salih"
                };
                students[3] = "Ahmet"; // Hata verir array 3 elemanlı değil


            }
            catch (IndexOutOfRangeException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }

    //KendiHata Sınıfımızı Yazma
    public class RecaordNotFoundException : Exception
    {
        public RecaordNotFoundException(string message):base(message)
        {
            
        }
    }
}