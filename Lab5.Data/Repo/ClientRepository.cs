using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Lab5.Data.Repo
{

    public class ClientRepository : IClientRepository
    {
        private readonly ClientContext _context;

        public ClientRepository(ClientContext context)
        {
            _context = context;
        }

        //Client methods
        public void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public List<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientById(int id)
        {
            return _context.Clients.FirstOrDefault(c => c.ClientId == id);
        }

        public Client GetClientByName(string name)
        {
            return _context.Clients.FirstOrDefault(c => c.Name == name);
        }

        public void UpdateClient(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteClient(int id)
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Entry(client).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        //Haicrut methods
        public List<Haircut> GetHaircuts()
        {
            return _context.Haircuts.ToList();
        }

        public void AddHaircut(Haircut haircut)
        {
            _context.Haircuts.Add(haircut);
            _context.SaveChanges();
        }

        public Haircut GetHaircutById(int id)
        {
            return _context.Haircuts.Find(id);
        }

        public void UpdateHaircut(Haircut haircut)
        {
            _context.Haircuts.Update(haircut);
            _context.SaveChanges();
        }

        public void DeleteHaircut(int id)
        {
            var haircut = _context.Haircuts.Find(id);
            if (haircut != null)
            {
                _context.Haircuts.Remove(haircut);
                _context.SaveChanges();
            }
        }

        //Appointment methods
        public void AddAppointment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public List<Appointment> GetAppointments()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetAppointmentById(int id)
        {
            return _context.Appointments.Find(id);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            _context.SaveChanges();
        }

        public void DeleteAppointment(int id)
        {
            var appointment = _context.Appointments.Find(id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                _context.SaveChanges();
            }
        }
    }
}
