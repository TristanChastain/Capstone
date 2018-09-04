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
   public class ShoppingCartDataAccess
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["QotSA Store"].ConnectionString;
        public bool DeleteShoppingCart(shoppingcartDAO cartToDelete)
        {
            bool yes = false;
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_DeleteShoppingCart", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@ShoppingCart_ID", cartToDelete.ShoppingCart_ID);
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
        public List<shoppingcartDAO> GetUserShoppingCart(int User_ID)
        {
            List<shoppingcartDAO> _shoppingcartlist = new List<shoppingcartDAO>();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_GetCartByID", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@User_ID", User_ID);
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                shoppingcartDAO _cartToList = new shoppingcartDAO();
                                _cartToList.ShoppingCart_ID = _reader.GetInt32(0);
                                _cartToList.Albums_ID = _reader.GetInt32(1);
                                _cartToList.Clothing_ID = _reader.GetInt32(2);
                                _cartToList.Instruments_ID = _reader.GetInt32(3);
                                _cartToList.User_ID = _reader.GetInt32(4);
                                _shoppingcartlist.Add(_cartToList);
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
            return _shoppingcartlist;
        }
        public void CreateShoppingCart(shoppingcartDAO shoppingcartToCreate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_CreateShoppingCart", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Albums_ID", shoppingcartToCreate.Albums_ID);
                        _command.Parameters.AddWithValue("@Clothing_ID", shoppingcartToCreate.Clothing_ID);
                        _command.Parameters.AddWithValue("@Instruments_ID", shoppingcartToCreate.Instruments_ID);
                        _command.Parameters.AddWithValue("@User_ID", shoppingcartToCreate.User_ID);
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
        public void UpdateShoppingCart(shoppingcartDAO shoppingcartToUpdate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_UpdateShoppingCart", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@ShoppingCart_ID", shoppingcartToUpdate.ShoppingCart_ID);
                        _command.Parameters.AddWithValue("@Albums_ID", shoppingcartToUpdate.Albums_ID);
                        _command.Parameters.AddWithValue("@Clothing_ID", shoppingcartToUpdate.Clothing_ID);
                        _command.Parameters.AddWithValue("@Instruments_ID", shoppingcartToUpdate.Instruments_ID);
                        _command.Parameters.AddWithValue("@User_ID", shoppingcartToUpdate.User_ID);
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
        public List<shoppingcartDAO> GetPrices()
        {
            List<shoppingcartDAO> _ListPrices = new List<shoppingcartDAO>();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_PricePull", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                shoppingcartDAO _PriceToList = new shoppingcartDAO();
                                _PriceToList.AlbumPrice = _reader.GetDecimal(0);
                                _PriceToList.ClothingPrice = _reader.GetDecimal(1);
                                _PriceToList.InstrumentsPrice = _reader.GetDecimal(2);
                                _ListPrices.Add(_PriceToList);
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
            return _ListPrices;
        }
        public List<shoppingcartDAO> GetAllShoppingCarts()
        {
            List<shoppingcartDAO> _cartList = new List<shoppingcartDAO>();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_ViewAllShoppingCarts", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                shoppingcartDAO _cartToList = new shoppingcartDAO();
                                _cartToList.ShoppingCart_ID = _reader.GetInt32(0);
                                _cartToList.Albums_ID = _reader.GetInt32(1);
                                _cartToList.Clothing_ID = _reader.GetInt32(2);
                                _cartToList.Instruments_ID = _reader.GetInt32(3);
                                _cartToList.User_ID = _reader.GetInt32(4);
                                _cartList.Add(_cartToList);
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
            return _cartList;
        }
        public void CreateShoppingCartOnRegister2(shoppingcartDAO shoppingCartFromRegister2)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_CreateCartOnRegisterPart2", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@User_ID", shoppingCartFromRegister2.User_ID);
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
    }
}
