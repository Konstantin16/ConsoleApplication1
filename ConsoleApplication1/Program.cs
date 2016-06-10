using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

/*
        СТРУКТУРЫ И ПЕРЕЧИСЛЕНИЯ
 В структуре не может быть конструктора по умолчанию
 Нельзя определить деструктор
 Нельзя определять модификатор доступа
  Нельзя инициализировать поля структуры в инициализаторе
  Структуры могут быть частичными (В разных файлах)
  Структуру нельзя помечать static и abstract
  В структуре может быть статический кончтруктор
  Поля структур могут быть ссылочного типа
  Перечисления наследники - System.Enum
  Нельзя явно преобразовывать 
  Для перечисления по умолчанию -int
  но можно задать перечисление любого другого целого типа


    КОЛЛЕКЦИИ
    В .NET есть 3 вида колеекции
    1) Обычные- которые находятся в пространстве System.Colection, эти коллекции являются не шаблонными.
    2) начиная с 2 framework полявились шаблонные коллекции System.Collections.Generic , они более безопасные и работаюют быстрее чем обычные коллекции
    3) Специальные коллекции System.Collections.Specialized 

    Класс Array.list - массивы списки

     
     */

namespace ConsoleApplication1
{
    public class Person : IComparable
    {
        public byte age;
        public string name;
        public double sallary;
        public Person(byte a, string name, double s)
        {
            age = a;
            this.name = name;
            sallary = s;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            if (p is Person)
            {
                if (this.age > p.age)
                    return 1;
                else if (this.age == p.age)
                    return 0;
                else
                    return -1;
            }
            throw new Exception("the object is not of Person type");
        }

        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {


            ////создание стека
            //Stack pers = new Stack();
            ////помещение объектов в стек
            //pers.Push(new Person(29, "Oleg", 2900));
            //pers.Push(new Person(31, "Dima", 3100));
            //pers.Push(new Person(44, "Boris", 4400));

            //Queue per = new Queue();


            //сколько в ней объектов
         //   Console.WriteLine(per.Count);


            //добавление объекта в очередь
            //per.Enqueue(new Person(29, "Oleg", 2500));
            //per.Enqueue(new Person(31, "Dima", 4600));
            //per.Enqueue(new Person(28, "Anna", 37500));
            //Console.WriteLine("{0} {1} {2}", ((Person)per.Peek()).age,
            //    ((Person)per.Peek()).name,
            //    ((Person)per.Peek()).sallary);
            //Console.WriteLine();
            //per.Dequeue();
            //Console.WriteLine("{0} {1} {2}", ((Person)per.Peek()).age,
            //   ((Person)per.Peek()).name,
            //   ((Person)per.Peek()).sallary);
            //Console.WriteLine();

            /*
                Работы со словарями 
                Это наборы предназначеные для хранения пар ключ-значение или имя значение, поддерживающие поиск по ключу (по имени)

             В качестве ключа может быть использован любой тип данных

             */

        }
    }
}
