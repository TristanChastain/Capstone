using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DAL.Objects;

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
            catch (Exception)
            {

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
                                _instrumentsToList.BandMemberName = _reader.GetString(4);
                                _instrumentslist.Add(_instrumentsToList);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

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
                        _command.Parameters.AddWithValue("@BandMembers_ID", instrumentsToCreate.BandMemberName);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        _connection.Dispose();
                    }
                }
            }
            catch (Exception)
            {

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
                        _command.Parameters.AddWithValue("@BandMembers_ID", instrumentsToUpdate.BandMemberName);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        _connection.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}