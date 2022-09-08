using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restanta.View;
using Restanta.Models;
using Restanta._Repositories;

namespace Restanta.Presenters
{
    public class MainPresenter
    {
        private MainScreen mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(MainScreen mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowHotelView += ShowHotelView;
        }

        private void ShowHotelView(object sender, EventArgs e)
        {
            IHotelView view = HotelView.GetInstance();
            IHotelRepository repository = new HotelRepository(sqlConnectionString);
            new HotelPresenter(view, repository);
        }
    }
}
