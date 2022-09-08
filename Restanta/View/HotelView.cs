using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restanta.View
{
    public partial class HotelView : Form , IHotelView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        

        public HotelView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPage2);
        }
       
        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

        }

        public string HotelId { get => txtHotelId.Text; set => txtHotelId.Text = value; }
        public string HotelName { get => txtHotelName.Text; set => txtHotelName.Text = value; }
        public string HotelRooms { get => txtHotelRooms.Text; set => txtHotelRooms.Text = value; }
        public string HotelPrice { get => txtHotelPrice.Text; set => txtHotelPrice.Text = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => IsEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetHotelListBindingSource(BindingSource hotelList)
        {
            dataGridView.DataSource = hotelList;
        }


        private static HotelView instance;
        public static HotelView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new HotelView();
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                    instance.BringToFront();
            }
            return instance;
        }

    }
}
