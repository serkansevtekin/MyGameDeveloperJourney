using System;
namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces.KendiOrnegim
{
    interface IPersonDal
    {
        int personId { get; set; }
        void Add();
        void Update();
        void Delete();
    }
}