using System;
using Entity.Concrete;


namespace DataAccess.Abstract
{
    public interface ICustomerDal
    {
        /// <summary>
        /// Müşteri ekleme operasyonu
        /// </summary>
        /// <param name="customer">Eklenecek müşteri nesnesi</param>
        void Add(Customer customer);

        /// <summary>
        /// Verilen Müşter sistemde mevcutmu konrol eder
        /// </summary>
        /// <param name="customer">Kontrol edilecek müşteri nesnesi</param>
        /// <returns>Müşteri varsa true, yoksa false döner</returns>
        bool CustomerExists(Customer customer);
    }
}