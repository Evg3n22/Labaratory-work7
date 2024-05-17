using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Lab5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Lab5.Data;
using Lab5.Data.Repo;


namespace Lab5
{
    
    public partial class Form1 : MaterialForm
    {
        private readonly IClientRepository clientRepository;
        private readonly ClientContext _context;

        public int FormCoin = 0;
        private void CloseForm2Instances()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form2))
                {
                    form.Close();
                    CloseForm2Instances(); 
                }
            }
        }


        public Form1(IClientRepository clientRepository)
        {
            InitializeComponent();
            this.clientRepository = clientRepository;
            this._context = new ClientContext();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            List<Haircut> haircuts = new()
            {
                new (0, "Сrop", 200),
                new (1, "Fade", 150),
                new (2, "Shorty", 300),
                new (3, "Nalyso", 5)
            };

            string name = textBox1.Text;
            DateTime date = dateTimePicker1.Value;
            int selectedIndex = ComboBox2.SelectedIndex;

            if (ComboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Choose your haircut");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter the name");
                return;
            }

            Client client = new(name, date);
            clientRepository.AddClient(client);

            client.Hair_id = haircuts[selectedIndex].HaircutId;

            int chekIndex = comboBox1.SelectedIndex;
            if (chekIndex == 0)
            {
                clientRepository.GetClients().Sort((c1, c2) => c1.Date.CompareTo(c2.Date));
            }
            else if (chekIndex == 1)
            {
                clientRepository.GetClients().Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
            }
            else if (chekIndex == 2)
            {
                clientRepository.GetClients().Sort((c1, c2) => c2.Haircut.BaseCost.CompareTo(c1.Haircut.BaseCost));
            }

            textBox1.Clear();

            if (FormCoin == 0)
            {
                Form2 formReceiver = new Form2(clientRepository);
                formReceiver.Show();
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Form2))
                    {
                        form.Hide();
                    }
                }
                Form2 formReceiver = new Form2(clientRepository);
                formReceiver.Show();
            }
            FormCoin++;
        }
    }
}


