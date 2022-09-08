using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restanta.Models;
using Restanta.View;

namespace Restanta.Presenters
{
    class HotelPresenter
    {
        private IHotelView view;
        private IHotelRepository repository;
        private BindingSource hotelsBindingSource;
        private IEnumerable<RestModel> hotelList;

        public HotelPresenter(IHotelView view, IHotelRepository repository)
        {
            this.hotelsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchHotel;
            this.view.AddNewEvent += AddNewHotel;
            this.view.EditEvent += EditorHotel;
            this.view.DeleteEvent += DeleteHotel;
            this.view.SaveEvent += SaveCurrentHotel;
            this.view.CancelEvent += CancelAction;

            this.view.SetHotelListBindingSource(hotelsBindingSource);
            LoadAllHotelsList();
            this.view.Show();
        }

        private void LoadAllHotelsList()
        {
            hotelList= repository.GetAll();
            hotelsBindingSource.DataSource = hotelList;
        }

        private void SearchHotel(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                hotelList = repository.GetByValue(this.view.SearchValue);
            else hotelList = repository.GetAll();
            hotelsBindingSource.DataSource = hotelList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCurrentHotel(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteHotel(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditorHotel(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewHotel(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
