using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Db4objects.Db4o;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (IObjectContainer db = Db4oEmbedded.OpenFile("Osoba.data"))
            {

                Osoba o1 = new Osoba("Jan", "Kowalski", 22);
                Osoba o2 = new Osoba("Jan", "Kowalski2", 33);

                db.Store(o1);
                db.Store(o2);
                db.Commit();
                
                //przykład query by example
                IObjectSet result = db.QueryByExample(new Osoba(null, null, 0, null));

                while (result.HasNext())
                {
                    Osoba next = (Osoba) result.Next();
                    Console.WriteLine(next.ToString());
                }

                Console.Read();

                db.Close();
            }
        }
    }
}
                       