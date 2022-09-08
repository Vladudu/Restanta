using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Restanta.Models
{
    public class RestModel
    {
        private int id;
        private string hotelName;
        private int rooms;
        private string price;
        [DisplayName("Hotel ID")]
        public int Id { get => id; set => id = value; }
        [DisplayName("Hotel Name")]
        [Required(ErrorMessage = "Hotel name is required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Hotel name must be between 2 and 30 characters")]
        public string HotelName { get => hotelName; set => hotelName = value; }
        [DisplayName("Rooms")]
        [Required(ErrorMessage = "Type how many rooms the hotel have!")]
        public int Rooms { get => rooms; set => rooms = value; }
        [DisplayName("Price per room")]
        [Required(ErrorMessage = "Price is required")]
        public string Price { get => price; set => price = value; }
    }
}
