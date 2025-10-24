using System;
namespace CSharpProgramlama.IleriCSharpEgitimi.AbstractClass
{
    public class AbstractClass
    {
        public static void AbstractClassRunMet()
        {
            Database sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Update();
            sqlServer.Delete();

            Database oracle = new Oracle();
            oracle.Add();
            oracle.Update();
            oracle.Delete();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            System.Console.WriteLine("Added by default");
        }

        public virtual void Update()
        {
            System.Console.WriteLine("Updater by default");
        }
        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
           System.Console.WriteLine("Deleted by Sql");
        }
    }
    class Oracle : Database
    {
        public override void Update()
        {
            System.Console.WriteLine("Update by Oracle");
           // base.Update();
        }
        public override void Delete()
        {
            System.Console.WriteLine("Deleted by oracle");
        }
    }
}