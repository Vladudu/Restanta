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
    public partial class MainScreenview : Form, MainScreen
    {
        public MainScreenview()
        {
            InitializeComponent();
            btnHotels.Click += delegate { ShowHotelView?.Invoke(this, EventArgs.Empty); };

        }

        public event EventHandler ShowHotelView;
    }
}
