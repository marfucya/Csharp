using System;

namespace Train
{
    /* Создайте структуру с именем train, содержащую поля: название пункта назначения,
     * номер поезда, время отправления. Ввести данные в массив из пяти элементов типа train,
     * упорядочить элементы по номерам поездов. Добавить возможность вывода информации о поезде,
     * номер которого введен пользователем. Добавить возможность сортировки массив по пункту назначения,
     * причем поезда с одинаковыми пунктами назначения должны быть упорядочены по времени отправления.
*/

    class Program
    {
        static void Main(string[] args)
        {
            Train[] list = new Train[5]
            {
                new Train("Lviv", 13, "13:40"),
                new Train("Kovel", 98, "20:15"),
                new Train("Odessa", 76, "06:15"),
                new Train("Dnipro", 43, "09:55"),
                new Train("Dnipro", 32, "18:19"),
            };

            Train.SortByDestination(list, SortBy.NUMBERTRAIN);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].numberTrain);
            }
            Console.WriteLine("----------");

            Train.SortByDestination(list, SortBy.DESTINATION);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].destination + " " + list[i].departureTime);
            }

            Console.ReadKey();
        }
    }
}
