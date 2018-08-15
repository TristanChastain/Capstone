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

namespace DAL
{
    public class AlbumDataAccess
    {
        static string connectionstring = ConfigurationManager.ConnectionStrings["QotSA Store"].ConnectionString;
        public bool DeleteAlbum(albumDAO albumToDelete)
        {
            bool yes = false;
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_DeleteAlbum", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Albums_ID", albumToDelete.Albums_ID);
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

        public List<albumDAO> GetAllAlbums()
        {
            List<albumDAO> _albumlist = new List<albumDAO>();
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_ViewAlbums", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _connection.Open();
                        using (SqlDataReader _reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                albumDAO _albumToList = new albumDAO();
                                _albumToList.Albums_ID = _reader.GetInt32(0);
                                _albumToList.AlbumName = _reader.GetString(1);
                                _albumToList.AlbumDescription = _reader.GetString(2);
                                _albumToList.AlbumPrice = _reader.GetDecimal(3);
                                _albumToList.YearReleased = _reader.GetDateTime(4);
                                _albumToList.NumberOfSongs = _reader.GetInt32(5);
                                _albumlist.Add(_albumToList);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return _albumlist;
        }
        public void CreateAlbum(albumDAO albumToCreate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_CreateAlbum", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Name", albumToCreate.AlbumName);
                        _command.Parameters.AddWithValue("@Description", albumToCreate.AlbumDescription);
                        _command.Parameters.AddWithValue("@Price", albumToCreate.AlbumPrice);
                        _command.Parameters.AddWithValue("@YearReleased", albumToCreate.YearReleased);
                        _command.Parameters.AddWithValue("@NumberOfSongs", albumToCreate.NumberOfSongs);
                        _connection.Open();
                        _command.ExecuteNonQuery();
                        _connection.Close();
                        _connection.Dispose();
                    }
                }
            }
            catch(Exception)
            {

            }
        }
        public void UpdateAlbum(albumDAO albumToUpdate)
        {
            try
            {
                using (SqlConnection _connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand _command = new SqlCommand("Sp_UpdateAlbums", _connection))
                    {
                        _command.CommandType = CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Albums_ID", albumToUpdate.Albums_ID);
                        _command.Parameters.AddWithValue("@Name", albumToUpdate.AlbumName);
                        _command.Parameters.AddWithValue("@Description", albumToUpdate.AlbumDescription);
                        _command.Parameters.AddWithValue("@Price", albumToUpdate.AlbumPrice);
                        _command.Parameters.AddWithValue("@YearReleased", albumToUpdate.YearReleased);
                        _command.Parameters.AddWithValue("@NumberOfSongs", albumToUpdate.NumberOfSongs);
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
