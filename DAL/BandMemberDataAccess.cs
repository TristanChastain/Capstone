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
    public class BandMemberDataAccess
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["QotSA Store"].ConnectionString;
        public bool DeleteMember(bandmembersDAO memberToDelete)
        {
            bool yes = false;
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_DeleteBandMember", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@BandMembers_ID", memberToDelete.BandMembers_ID);
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
        public List<bandmembersDAO> GetAllMembers()
        {
            List<bandmembersDAO> _MemberList = new List<bandmembersDAO>();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_ViewBandMembers", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                bandmembersDAO _memberToList = new bandmembersDAO();
                                _memberToList.BandMembers_ID = _reader.GetInt32(0);
                                _memberToList.MemberName = _reader.GetString(1);
                                _memberToList.MemberBio = _reader.GetString(2);
                                _memberToList.DateOfBirth = _reader.GetDateTime(3);
                                _memberToList.BirthLocation = _reader.GetString(4);
                                _MemberList.Add(_memberToList);
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
            return _MemberList;
        }
        public void CreateMember(bandmembersDAO memberToCreate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_CreateBandMembers", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Name", memberToCreate.MemberName);
                        _command.Parameters.AddWithValue("@Bio", memberToCreate.MemberBio);
                        _command.Parameters.AddWithValue("@DateOfBirth", memberToCreate.DateOfBirth);
                        _command.Parameters.AddWithValue("@BirthLocation", memberToCreate.BirthLocation);
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
        public void UpdateMember(bandmembersDAO memberToUpdate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_UpdateBandMembers", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@BandMembers_ID", memberToUpdate.BandMembers_ID);
                        _command.Parameters.AddWithValue("@Name", memberToUpdate.MemberName);
                        _command.Parameters.AddWithValue("@Bio", memberToUpdate.MemberBio);
                        _command.Parameters.AddWithValue("@DateOfBirth", memberToUpdate.DateOfBirth);
                        _command.Parameters.AddWithValue("@BirthLocation", memberToUpdate.BirthLocation);
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
        public void GetClothingID(int albumidToGet)
        {
            int GetClothingID = new int();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_GetClothingID", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Clothing_ID", albumidToGet);
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
