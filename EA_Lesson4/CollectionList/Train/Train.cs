using System;
namespace Train
{
    /* Создайте структуру с именем train, содержащую поля: название пункта назначения,
  * номер поезда, время отправления. Ввести данные в массив из пяти элементов типа train,
  * упорядочить элементы по номерам поездов. Добавить возможность вывода информации о поезде,
  * номер которого введен пользователем. Добавить возможность сортировки массив по пункту назначения,
  * причем поезда с одинаковыми пунктами назначения должны быть упорядочены по времени отправления.
*/

    public enum SortBy 
    {
        DESTINATION,
        NUMBERTRAIN,
        DEPARTURETIME
    }

    public struct Train
    {
        public string destination;
        public int numberTrain;
        public string departureTime;

        public Train (string destination, int numberTrain, string departureTime )
        {
            this.destination = destination;
            this.numberTrain = numberTrain;
            this.departureTime = departureTime;
        }

        public static void SortByDestination (Train[] arr, SortBy sortBy )
        {
            Array.Sort(arr, (x, y) => {

                int sort;
                switch (sortBy)
                {
                    case SortBy.DEPARTURETIME :
                        sort  = string.Compare(x.departureTime, y.departureTime);
                        break;  
                    case SortBy.NUMBERTRAIN :
                        sort  = x.numberTrain > y.numberTrain ? 1 : -1;
                        break; 
                    default :
                        sort = string.Compare(x.destination, y.destination);
                        if (sort == 0)
                        {
                            var t1 = TimeSpan.Parse(x.departureTime);
                            var t2 = TimeSpan.Parse(y.departureTime);
                            sort = t1 > t2 ? 1 : -1;
                        }
                        break;
                }
                return sort;
            });
        }
    }
}
