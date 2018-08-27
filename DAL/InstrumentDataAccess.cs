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
   public class InstrumentDataAccess
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["QotSA Store"].ConnectionString;
        public bool DeleteInstruments(instrumentsDAO instrumentToDelete)
        {
            bool yes = false;
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_DeleteInstrument", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Instruments_ID", instrumentToDelete.Instruments_ID);
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

        public List<instrumentsDAO> GetAllInstruments()
        {
            List<instrumentsDAO> _instrumentslist = new List<instrumentsDAO>();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_ViewInstruments", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                instrumentsDAO _instrumentsToList = new instrumentsDAO();
                                _instrumentsToList.Instruments_ID = _reader.GetInt32(0);
                                _instrumentsToList.InstrumentName = _reader.GetString(1);
                                _instrumentsToList.InstrumentDescription = _reader.GetString(2);
                                _instrumentsToList.InstrumentPrice = _reader.GetDecimal(3);
                                _instrumentslist.Add(_instrumentsToList);
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
            return _instrumentslist;
        }
        public void CreateInstruments(instrumentsDAO instrumentsToCreate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_CreateInstrument", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Name", instrumentsToCreate.InstrumentName);
                        _command.Parameters.AddWithValue("@Description", instrumentsToCreate.InstrumentDescription);
                        _command.Parameters.AddWithValue("@Price", instrumentsToCreate.InstrumentPrice);
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
        public void UpdateInstrument(instrumentsDAO instrumentsToUpdate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_UpdateInstruments", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Instruments_ID", instrumentsToUpdate.Instruments_ID);
                        _command.Parameters.AddWithValue("@Name", instrumentsToUpdate.InstrumentName);
                        _command.Parameters.AddWithValue("@Description", instrumentsToUpdate.InstrumentDescription);
                        _command.Parameters.AddWithValue("@Price", instrumentsToUpdate.InstrumentPrice);
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
        public int GetInstrumentsID(shoppingcartDAO instrumentsidToGet)
        {
            int GetInstrumentsID = new int();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_GetInstrumentsID", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Instruments_ID", instrumentsidToGet.Instruments_ID);
                        _command.Parameters.AddWithValue("@User_ID", instrumentsidToGet.User_ID);
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                instrumentsDAO _GetIDInstruments = new instrumentsDAO();
                                _GetIDInstruments.Instruments_ID = _reader.GetInt32(0);
                                _GetIDInstruments.InstrumentName = _reader.GetString(1);
                                _GetIDInstruments.InstrumentDescription = _reader.GetString(2);
                                _GetIDInstruments.InstrumentPrice = _reader.GetInt32(3);
                                GetInstrumentsID = _GetIDInstruments.Instruments_ID;
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
            return GetInstrumentsID;
        }
    }
}