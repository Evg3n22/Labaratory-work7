using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5.Data;
using Lab5.Data.Repo;

namespace Lab5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Option 1: Using service locator (if implemented)
            // IClientRepository clientRepository = new ClientRepository(ServiceLocator.GetContext());

            // Option 2: Direct instantiation
            ClientContext context = new ClientContext(); // Replace with your connection string configuration
            IClientRepository clientRepository = new ClientRepository(context);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(clientRepository));
        }
    }
}
