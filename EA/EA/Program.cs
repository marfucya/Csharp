using System;
using System.Collections;

public class Staff
{
    public string firstName;
    public string lastName;

    public Staff(string fName, string lName)

    {
        this.firstName = fName;
        this.lastName = lName;
    }
}

public class AllStaff : IEnumerable
{
    private Staff[] _allStaff;

    public AllStaff(Staff[] sArray)
    {
        _allStaff = new Staff[sArray.Length];

        for (int i = 0; i < sArray.Length; i++)
        {
            _allStaff[i] = sArray[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }

    public AllStaffEnum GetEnumerator()
    {
        return new AllStaffEnum(_allStaff);
    }
}

public class AllStaffEnum : IEnumerator
{
    public Staff[] _allStaff;

    int position = -1;

    public AllStaffEnum(Staff[] list)
    {
        _allStaff = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < _allStaff.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Staff Current
    {
        get
        {
            try
            {
                return _allStaff[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

class App
{
    static void Main()
    {
        Staff[] AllStaffArray = new Staff[3]
        {
            new Staff("Іван", "Калита"),
            new Staff("Люба", "Головач"),
            new Staff("Лена", "Калуга"),
        };

        AllStaff staffList = new AllStaff(AllStaffArray);
        foreach (Staff s in staffList)
            Console.WriteLine(s.firstName + " " + s.lastName);

    }
}
