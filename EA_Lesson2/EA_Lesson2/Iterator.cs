using System;
namespace EA_Lesson2
{
    public class Iterator
    {
        abstract class AbstractIterator
        {
            public abstract bool MoveNext();
            public abstract object Current { get; }
            public abstract void Reset();
        }
        class ConcreteAutoParkIterator : AbstractIterator
        {
            public override object Current => throw new NotImplementedException();

            public override bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public override void Reset()
            {
                throw new NotImplementedException();
            }
        }


    }
}
