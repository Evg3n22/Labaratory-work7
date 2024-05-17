using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Data.Repo
{
    public interface IClientRepository
    {
        //Client methods
        void AddClient(Client client);
        List<Client> GetClients();
        Client GetClientById(int id);
        Client GetClientByName(string name);
        void UpdateClient(Client client);
        void DeleteClient(int id);

        //Haicut methods
        List<Haircut> GetHaircuts();
        void AddHaircut(Haircut haircut);
        Haircut GetHaircutById(int id);
        void UpdateHaircut(Haircut haircut);
        void DeleteHaircut(int id);

        // Appointment methods
        void AddAppointment(Appointment appointment);
        List<Appointment> GetAppointments();
        Appointment GetAppointmentById(int id);
        void UpdateAppointment(Appointment appointment);
        void DeleteAppointment(int id);
    }
}
