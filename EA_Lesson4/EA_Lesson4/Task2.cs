using System;
using System.Collections.Generic;

namespace EA_Lesson4
{

    /*
     * 
     * Задание 2
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его экземпляр
а аналогично экземпляру класса List<T>. Минимально требуемый интерфейс взаимодействия с экземпляро
м, должен включать метод добавления элемента, индексатор для получения значения элемента по указанному 
индексу и свойство только для чтения для получения общего количества элементов.


    */

    public class MyList<T>
    {
        private List<T> store = new List<T>();

        public MyList()
        {
            
        }

        public void Add(T item)
        {
            this.store.Add(item);
        }

        public void Show()
        {
            this.store.ForEach((T item)=>{
                Console.WriteLine( item );
            });
        }



    }
}
