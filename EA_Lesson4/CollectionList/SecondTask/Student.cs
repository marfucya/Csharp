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

    public struct Student
    {
        public string lastName;
        public string firstName;
        public int numberGroup;
        public int[] marks;

        public Student(string lastName, string firstName, int numberGroup, int[] marks)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.numberGroup = numberGroup;
            this.marks = marks;
        }

        public string GetGoodStudentOnly()
        {

            bool pass = true;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 4) pass = false;
            }
            return pass ?
                lastName + " " + firstName + " " + numberGroup :
                "";
        }

        public double GetMiddleMark()
        {
            double sum = 0;
            for (int i = 0; i < marks.Length; i++)
                sum += marks[i];
            return sum / marks.Length;
        }

    }
}
