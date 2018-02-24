using System;
namespace ClassWork
{

    public enum TypeOfInfo
    {
        AllINFO,
        ALLSCHEDULE
    }

    public class Appointment
    {
        bool added;
        string room;
        DateTime time;

        public Appointment(bool added, string room, DateTime time)
        {
            this.added = added;
            this.room = room;
            this.time = time;
        }

        public bool Added { get; }
        public string Room { get; }
        public DateTime Time { get; }
    }

    public interface IRegistry
    {
        string GetInfo(TypeOfInfo type);
        bool AddPatient(string id);
        Appointment AddAppointment(string id, string speciality, DateTime time);
        bool RemoveAppointment(string id, string speciality); 

    }
}
