using System;
namespace ClassWork
{
    public interface IPatientManager
    {
        string GetInfo(string id);
        bool UpdateInfo(string id, string newInfo);
        bool AddPatient(string id);
        bool RemovePatient(string id);

    }
}
