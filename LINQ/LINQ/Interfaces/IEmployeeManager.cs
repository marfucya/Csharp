using System;
namespace ClassWork
{


    public interface IEmployeeManager
    {
        string GetInfo(TypeOfInfo type);
        bool AddEmployee(string id, string speciality);
        bool AddRoomToEmployee(string id);
        bool RemoveEmployee(string id);

    }
}
