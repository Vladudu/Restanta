using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Restanta.Models;

namespace Restanta._Repositories
{
    public class HotelRepository : BaseRepository, IHotelRepository
    {

        public HotelRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(RestModel restModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(RestModel restModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RestModel> GetAll()
        {
            var hotelList = new List<RestModel>();
            using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Hotel order by Hotel_Id desc";

                using(var reader=command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var restModel = new RestModel();
                        restModel.Id = (int)reader[0];
                        restModel.HotelName = reader[1].ToString();
                        restModel.Rooms = (int)reader[2];
                        restModel.Price = reader[3].ToString();
                        hotelList.Add(restModel);
                    }
                }
            }

            return hotelList;
        }

        public IEnumerable<RestModel> GetByValue(string value)
        {
            var hotelList = new List<RestModel>();
            int hotelID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string hotelName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * from Hotel
                                      where Hotel_Id=@id or Hotel_Name like @name+'%'      
                                      order by Hotel_Id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = hotelID;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = hotelName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var restModel = new RestModel();
                        restModel.Id = (int)reader[0];
                        restModel.HotelName = reader[1].ToString();
                        restModel.Rooms = (int)reader[2];
                        restModel.Price = reader[3].ToString();
                        hotelList.Add(restModel);
                    }
                }
            }

            return hotelList;
        }
    }
}
