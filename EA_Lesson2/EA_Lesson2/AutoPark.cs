using System;
using System.Collections;
using System.Collections.Generic;

namespace EA_Lesson2
{
    abstract class BaseAutoPark
    {
        protected AbstractCar[] carCollection = null;

        public abstract int Insert();
        public abstract AbstractCar Remove();
        public abstract Add(AbstractCar car);

        public abstract oooo GetEnumerator();
    }

    class AutoPark : BaseAutoPark, IEnumerator, IEnumerable
    {
        
        private int index = 0;

        public AutoPark()
        {
            carCollection = new AbstractCar[1];
        }

        public object Current
        {
            get
            {
                return carCollection[index];
            }
        }

        public int Add(AbstractCar car)
        {
            if (index >= carCollection.Length)
            {
                AbstractCar[] temp = new AbstractCar[carCollection.Length * 2]; 
                Array.Copy(carCollection, temp, carCollection.Length);
                carCollection = temp;
            }

            carCollection[index] = car;
            index++;

            return (index - 1);
        }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            
        }
    }
}
