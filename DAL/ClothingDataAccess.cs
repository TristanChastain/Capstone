using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.Objects;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using DAL;
using ErrorLogger;

namespace DAL
{
    public class ClothingDataAccess
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["QotSA Store"].ConnectionString;
        public bool DeleteClothing(clothingDAO clothingToDelete)
        {
            bool yes = false;
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_DeleteClothing", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Clothing_ID", clothingToDelete.Clothing_ID);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        yes = true;
                        _connection.Close();
                    }
                }
            }
            catch (Exception _Error)
            {
                Error_Logger Log = new Error_Logger();
                Log.Errorlogger(_Error);
            }
            if (yes == true)
            {

            }
            return yes;
        }

        public List<clothingDAO> GetAllClothing()
        {
            List<clothingDAO> _clothinglist = new List<clothingDAO>();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_ViewClothing", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                clothingDAO _clothingToList = new clothingDAO();
                                _clothingToList.Clothing_ID = _reader.GetInt32(0);
                                _clothingToList.TypeOFClothing = _reader.GetString(1);
                                _clothingToList.ClothingDescription = _reader.GetString(2);
                                _clothingToList.Sizes = _reader.GetString(3);
                                _clothingToList.ClothingPrice = _reader.GetDecimal(4);
                                _clothingToList.ClothingName = _reader.GetString(5);
                                _clothingToList.ClothingQuantity = _reader.GetInt32(6);
                                _clothinglist.Add(_clothingToList);
                            }
                        }
                    }
                }
            }
            catch (Exception _Error)
            {
                Error_Logger Log = new Error_Logger();
                Log.Errorlogger(_Error);
            }
            return _clothinglist;
        }
        public void CreateClothing(clothingDAO clothingToCreate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_CreateClothing", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@TypeOFClothing", clothingToCreate.TypeOFClothing);
                        _command.Parameters.AddWithValue("@Description", clothingToCreate.ClothingDescription);
                        _command.Parameters.AddWithValue("@Sizes", clothingToCreate.Sizes);
                        _command.Parameters.AddWithValue("@Price", clothingToCreate.ClothingPrice);
                        _command.Parameters.AddWithValue("@Name", clothingToCreate.ClothingName);
                        _command.Parameters.AddWithValue("@ClothingQuantity", clothingToCreate.ClothingQuantity);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        _connection.Dispose();
                    }
                }
            }
            catch (Exception _Error)
            {
                Error_Logger Log = new Error_Logger();
                Log.Errorlogger(_Error);
            }
        }
        public void UpdateClothing(clothingDAO clothingToUpdate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_UpdateClothing", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Clothing_ID", clothingToUpdate.Clothing_ID);
                        _command.Parameters.AddWithValue("@TypeOFClothing", clothingToUpdate.TypeOFClothing);
                        _command.Parameters.AddWithValue("@Description", clothingToUpdate.ClothingDescription);
                        _command.Parameters.AddWithValue("@Sizes", clothingToUpdate.Sizes);
                        _command.Parameters.AddWithValue("@Price", clothingToUpdate.ClothingPrice);
                        _command.Parameters.AddWithValue("@Name", clothingToUpdate.ClothingName);
                        _command.Parameters.AddWithValue("@ClothingQuantity", clothingToUpdate.ClothingQuantity);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        _connection.Close();
                    }
                }
            }
            catch (Exception _Error)
            {
                Error_Logger Log = new Error_Logger();
                Log.Errorlogger(_Error);
            }
        }
        public void GetClothingID(shoppingcartDAO clothingidToGet)
        {
            int GetClothingID = new int();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_GetClothingID", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Clothing_ID", clothingidToGet.Clothing_ID);
                        _command.Parameters.AddWithValue("@User_ID", clothingidToGet.User_ID);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        _connection.Close();
                    }
                }
            }
            catch (Exception _Error)
            {
                Error_Logger Log = new Error_Logger();
                Log.Errorlogger(_Error);
            }
        }
        public void SendClothingID(shoppingcartDAO clothingidToSend)
        {
            int SendClothingID = new int();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_SendClothingID", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Clothing_ID", clothingidToSend.Clothing_ID);
                        _command.Parameters.AddWithValue("@User_ID", clothingidToSend.User_ID);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        _connection.Close();
                    }
                }
            }
            catch (Exception _Error)
            {
                Error_Logger Log = new Error_Logger();
                Log.Errorlogger(_Error);
            }
        }
    }
}
