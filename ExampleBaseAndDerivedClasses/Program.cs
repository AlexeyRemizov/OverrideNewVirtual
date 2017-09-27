using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Пример работы с ключевыми словами override, new, virtual
 * 
 *b1.Method1();  - примеры вызова методов из базового класса 
  b1.Method2();    с ключевым словом virtual и без него
  d1.Method1();  - вызов метода с ключевым словом override из производного класса
  d1.Method2();  - вызов метода с ключевым словом new из производного класса
  bd1.Method1(); - вызов метода из производного класса с ключевым словом override
  bd1.Method2(); - вызов метода из родительског класса, т.к. 
                   "new" скрыла метод №2 в производном классе
  d2.Method1();  - вызов метода №1 из наследуемого класса с ключевым словом new(в родительском virtual)
  d2.Method2();  - вызов метода №2 из родит. класса, т.к. реализация в насл. классе отсутствует этот метод                 
  bd2.Method1(); - вызов методов №1 и №2 происходит из родительского класса
  bd2.Method2(); - вызов методов №1 и №2 происходит из родительского класса   
     
     
     */

namespace ExampleBaseAndDerivedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Base1 b1 = new Base1();
            Derived1 d1 = new Derived1();
            Base1 bd1 = new Derived1();
            Derived2 d2 = new Derived2();
            Base1 bd2 = new Derived2();

            b1.Method1();
            b1.Method2();
            d1.Method1();
            d1.Method2();
            bd1.Method1();
            bd1.Method2();
            d2.Method1();
            d2.Method2();
            bd2.Method1();
            bd2.Method2();

            Console.ReadKey();
        }
    }

    public class Base1
    {

        public virtual void Method1()
        {
            Console.WriteLine("Base - Method #1");
        }

        public void Method2()
        {
            Console.WriteLine("Base - Method #2");
        }
    }

    public class Derived1 : Base1
    {
        public new void  Method2()
        {
            Console.WriteLine("Derived #1 - Method #2");
        }

        public override void Method1()
        {
            Console.WriteLine("Derived #1 - Method #1");
        }
            
    }

    public class Derived2 : Base1
    {
        public new void Method1()
        {
            Console.WriteLine("Derived #2 - Method #1");
        }
    }
}
