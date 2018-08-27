using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DAL.Objects;
using ErrorLogger;

namespace DAL.Objects
{
    public class UserDataAccess
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["QotSA Store"].ConnectionString;
        public bool DeleteUser(userDAO userToDelete)
        {
            bool yes = false;
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_DeleteUser", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@User_ID", userToDelete.User_ID);
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

        public List<userDAO> GetAllUsers()
        {
            List<userDAO> _userlist = new List<userDAO>();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_ViewUsers", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                userDAO _userToList = new userDAO();
                                _userToList.User_ID = _reader.GetInt32(0);
                                _userToList.Username = _reader.GetString(1);
                                _userToList.Password = _reader.GetString(2);
                                _userToList.Role_ID = _reader.GetInt32(3);
                                _userlist.Add(_userToList);
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
            return _userlist;
        }
        public void Createuser(userDAO userToCreate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_CreateUser", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Username", userToCreate.Username);
                        _command.Parameters.AddWithValue("@Password", userToCreate.Password);
                        _command.Parameters.AddWithValue("@Role_ID", userToCreate.Role_ID);
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
        public void UpdateUser(userDAO userToUpdate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_UpdateUser", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@User_ID", userToUpdate.User_ID);
                        _command.Parameters.AddWithValue("@Username", userToUpdate.Username);
                        _command.Parameters.AddWithValue("@Password", userToUpdate.Password);
                        _command.Parameters.AddWithValue("@Role_ID", userToUpdate.Role_ID);
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
        public userDAO Login(userDAO _userLogin)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_UserLogin", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Username", _userLogin.Username);
                        _command.Parameters.AddWithValue("@Password", _userLogin.Password);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                userDAO _userToView = new userDAO();
                                _userToView.User_ID = _reader.GetInt32(0);
                                _userToView.Username = _reader.GetString(1);
                                _userToView.Password = _reader.GetString(2);
                                _userToView.Role_ID = _reader.GetInt32(3);
                                _userLogin = _userToView;
                            }
                        }
                        _connection.Close();
                        _connection.Dispose();
                    }
                }
            }
            catch (Exception errorCaught)
            {
                Error_Logger LogError = new Error_Logger();
                LogError.Errorlogger(errorCaught);
            }
            return (_userLogin);
        }
    }
}