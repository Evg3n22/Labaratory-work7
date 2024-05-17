using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Xml.Linq;
using static Lab5.Form2;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Lab5.Data;
using Lab5.Data.Repo;


namespace Lab5
{
    public partial class Form2 : Form

    {

        public List<Client> client_list = new List<Client>();
        private readonly ClientContext _context;
        private IClientRepository clientRepository;

        private int lastAppointmentId;
        private decimal totalMoney = 0;
        public decimal cost;

        Image loading;
        private int currFrame = 0;



        private Task ClientSelectQuery(int selectedHair, int selectedClientId)
        {
            return Task.Run(() =>
            {
                var query = _context.Clients
                    .Where(x => x.Hair_id == selectedHair)
                    .Where(c => c.ClientId == selectedClientId)
                    .Join(_context.Haircuts, c => c.Hair_id, h => h.HaircutId, (c, h) => new
                    {
                        ClientName = c.Name,
                        HaircutCost = h.BaseCost
                    })
                    .ToList();
                var selectedClient = query.Select(result => $"{result.ClientName}: {result.HaircutCost} грн \n").FirstOrDefault();
                foreach (var client in query)
                {
                    TextBox2.Text += selectedClient;
                }
            });
        }

        public Form2(IClientRepository clientRepository)
        {
            InitializeComponent();



            this._context = new ClientContext();
            this.clientRepository = clientRepository;

            if (clientRepository.GetClients() != null)
            {
                listBox1.Items.Clear();

                foreach (var client in clientRepository.GetClients())
                {
                    listBox1.Items.Add(client);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            client_list = clientRepository.GetClients();

            if (listBox1.SelectedIndex > -1)
            {
                clientRepository.UpdateClient(client_list[listBox1.SelectedIndex]);

                var selectedHair = client_list[listBox1.SelectedIndex].Hair_id;
                var selectedClientId = client_list[listBox1.SelectedIndex].ClientId;

                var query = _context.Clients
                    .Where(x => x.Hair_id == selectedHair)
                    .Where(c => c.ClientId == selectedClientId)
                    .Join(_context.Haircuts, c => c.Hair_id, h => h.HaircutId, (c, h) => new
                    {
                        HaircutCost = h.BaseCost
                    })
                    .ToList();
                var selectedClient = query.Select(result => $"{result.HaircutCost}").FirstOrDefault();
                cost = decimal.Parse(selectedClient);
            }

            if (listBox1.SelectedIndex > -1)
            {
                if (!clientRepository.GetAppointments().Any())
                {
                    int lastAppointmentId = 1;
                }
                else
                {
                    int lastAppointmentId = clientRepository.GetAppointments().Max(a => a.AppointmentId) + 1;
                }
                Appointment appointment = new Appointment(lastAppointmentId,
                                                            client_list[listBox1.SelectedIndex].ClientId,
                                                            client_list[listBox1.SelectedIndex].Name,
                                                            client_list[listBox1.SelectedIndex].Date);
                clientRepository.AddAppointment(appointment);
                clientRepository.UpdateAppointment(appointment);

                totalMoney += cost;
                textBox1.Clear();

                textBox1.Text = totalMoney.ToString();

                clientRepository.DeleteClient(client_list[listBox1.SelectedIndex].ClientId);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            client_list = clientRepository.GetClients();

            if (listBox1.SelectedIndex > -1)
            {
                clientRepository.DeleteClient(client_list[listBox1.SelectedIndex].ClientId);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private async void Button4_Click_1(object sender, EventArgs e)
        {
            client_list = clientRepository.GetClients();

            if (listBox1.SelectedIndex > -1)
            {
                clientRepository.UpdateClient(client_list[listBox1.SelectedIndex]);

                var selectedHair = client_list[listBox1.SelectedIndex].Hair_id;
                var selectedClientId = client_list[listBox1.SelectedIndex].ClientId;


                loading = new Bitmap("D:\\ООПР\\Lab5\\loading(cat_run).png");

                timer1.Interval = 100;
                timer1.Tick += new EventHandler(update_anim);
                timer1.Start();

                pictureBox1.Visible = true;
                materialLabel1.Visible = false;

                await ClientSelectQuery(selectedHair, selectedClientId);

                timer1.Stop();
                pictureBox1.Visible = false;
                TextBox2.Visible = true;

            }

        }

        private void update_anim(object sender, EventArgs e)
        {
            playAnimation();
            if (currFrame == 11)
            {
                currFrame = 0;
            }
            currFrame++;
        }

        private void playAnimation()
        {
            Image part = new Bitmap(95, 40);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(loading, new Rectangle(0, 0, 360, 583), 0, 45*currFrame, 360, 583, GraphicsUnit.Pixel);
            pictureBox1.Size = new Size(95, 40);
            pictureBox1.Image = part;
        }

    }
}
