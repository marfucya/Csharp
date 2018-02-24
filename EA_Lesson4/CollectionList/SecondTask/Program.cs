using System;

namespace SecondTask
{
 /*
     * 
     * Создайте структуру с именем student, содержащую поля: фамилия и инициалы, 
     * номер группы, успеваемость (массив из пяти элементов). Создать массив из 
     * десяти элементов такого типа, упорядочить записи по возрастанию среднего балла. 
     * Добавить возможность вывода фамилий и номеров групп студентов, имеющих оценки, равные только 4 или 5.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Student[] list = new Student[5]{
                new Student("Пупкин", "Вася", 1, new int[5]{ 4, 3, 3, 3, 3}),
                new Student("Черешня", "Люда", 3, new int[5]{ 5, 5, 4, 4, 5}),
                new Student("Тур", "Леся", 2, new int[5]{ 4, 2, 3, 5, 3}),
                new Student("Рука", "Вова", 3, new int[5]{ 4, 3, 4, 3, 1}),
                new Student("Окно", "Костя", 2, new int[5]{ 4, 5, 3, 4, 5})
            };


            Array.Sort(list, (x, y) => x.GetMiddleMark().CompareTo(y.GetMiddleMark()));

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine( list[i].GetMiddleMark());
                Console.WriteLine( list[i].GetGoodStudentOnly());
            }

            Console.ReadKey();
        }
    }
}
