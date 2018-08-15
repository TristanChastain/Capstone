using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Objects;
using System.Web;
using Queens_of_the_Stone_Age_Store.Models;

namespace Queens_of_the_Stone_Age_Store.Models
{
    public class Mapper
    {
        public List<Album> AlbumMap(List<albumDAO> _albumListToMap)
        {
            List<Album> _albumListToReturn = new List<Album>();
            foreach (albumDAO _albumToMap in _albumListToMap) 
            {
                Album _albumToView = new Album();
                _albumToView.Albums_ID = _albumToMap.Albums_ID;
                _albumToView.AlbumName = _albumToMap.AlbumName;
                _albumToView.AlbumDescription = _albumToMap.AlbumDescription;
                _albumToView.AlbumPrice = _albumToMap.AlbumPrice;
                _albumToView.YearReleased = _albumToMap.YearReleased;
                _albumToView.NumberOfSongs = _albumToMap.NumberOfSongs;
                _albumListToReturn.Add(_albumToView);
            }
            return _albumListToReturn;
        }
        public List<Clothing> ClothingMap(List<clothingDAO> _clothingListToMap)
        {
            List<Clothing> _clothingListToReturn = new List<Clothing>();
            foreach (clothingDAO _clothingToMap in _clothingListToMap)
            {
                Clothing _clothingToView = new Clothing();
                _clothingToView.Clothing_ID = _clothingToMap.Clothing_ID;
                _clothingToView.TypeOFClothing = _clothingToMap.TypeOFClothing;
                _clothingToView.ClothingDescription = _clothingToMap.ClothingDescription;
                _clothingToView.Sizes = _clothingToMap.Sizes;
                _clothingToView.ClothingPrice = _clothingToMap.ClothingPrice;
                _clothingToView.ClothingName = _clothingToMap.ClothingName;
                _clothingListToReturn.Add(_clothingToView);
            }
            return _clothingListToReturn;
        }
        public List<Instruments> InstrumentsMap(List<instrumentsDAO> _instrumentsListToMap)
        {
            List<Instruments> _instrumentsListToReturn = new List<Instruments>();
            foreach (instrumentsDAO _instrumentsToMap in _instrumentsListToMap)
            {
                Instruments _instrumentsToView = new Instruments();
                _instrumentsToView.Instruments_ID = _instrumentsToMap.Instruments_ID;
                _instrumentsToView.InstrumentName = _instrumentsToMap.InstrumentName;
                _instrumentsToView.InstrumentDescription = _instrumentsToMap.InstrumentDescription;
                _instrumentsToView.InstrumentPrice = _instrumentsToMap.InstrumentPrice;
                _instrumentsToView.BandMembers_ID = _instrumentsToMap.BandMemberName;
                _instrumentsListToReturn.Add(_instrumentsToView);
            }
            return _instrumentsListToReturn;
        }
        public List<User> _UserMap(List<userDAO> _userListToMap)
        {
            List<User> _userListToReturn = new List<User>();
            foreach (userDAO _userToMap in _userListToMap)
            {
                User _userToView = new User();
                _userToView.User_ID = _userToMap.User_ID;
                _userToView.Username = _userToMap.Username;
                _userToView.Password = _userToView.Password;
                _userToView.Role_ID = _userToMap.Role_ID;
            }
            return _userListToReturn;
        }
        public albumDAO SingleAlbum(Album _SingleAlbumToMap)
        {
            albumDAO AlbumToReturn = new albumDAO();
            {
                albumDAO _albumToView = new albumDAO();
                _albumToView.Albums_ID = _SingleAlbumToMap.Albums_ID;
                _albumToView.AlbumName = _SingleAlbumToMap.AlbumName;
                _albumToView.AlbumDescription = _SingleAlbumToMap.AlbumDescription;
                _albumToView.AlbumPrice = _SingleAlbumToMap.AlbumPrice;
                _albumToView.YearReleased = _SingleAlbumToMap.YearReleased;
                _albumToView.NumberOfSongs = _SingleAlbumToMap.NumberOfSongs;
                AlbumToReturn = _albumToView;
            }
            return AlbumToReturn;
        }
        public clothingDAO SingleClothing(Clothing _SingleClothingToMap)
        {
            clothingDAO ClothingToReturn = new clothingDAO();
            {
                clothingDAO _clothingToView = new clothingDAO();
                _clothingToView.Clothing_ID = _SingleClothingToMap.Clothing_ID;
                _clothingToView.TypeOFClothing = _SingleClothingToMap.TypeOFClothing;
                _clothingToView.ClothingDescription = _SingleClothingToMap.ClothingDescription;
                _clothingToView.Sizes = _SingleClothingToMap.Sizes;
                _clothingToView.ClothingPrice = _SingleClothingToMap.ClothingPrice;
                _clothingToView.ClothingName = _SingleClothingToMap.ClothingName;
                ClothingToReturn = _clothingToView;
            }
            return ClothingToReturn;
        }
        public instrumentsDAO SingleInstrument(Instruments _SingleInstrumentToMap)
        {
            instrumentsDAO InstrumentsToReturn = new instrumentsDAO();
            {
                instrumentsDAO _instrumentsToView = new instrumentsDAO();
                _instrumentsToView.Instruments_ID = _SingleInstrumentToMap.Instruments_ID;
                _instrumentsToView.InstrumentName = _SingleInstrumentToMap.InstrumentName;
                _instrumentsToView.InstrumentDescription = _SingleInstrumentToMap.InstrumentDescription;
                _instrumentsToView.InstrumentPrice = _SingleInstrumentToMap.InstrumentPrice;
                _instrumentsToView.BandMemberName = _SingleInstrumentToMap.BandMembers_ID;
                InstrumentsToReturn = _instrumentsToView;
            }
            return InstrumentsToReturn;
        }
        public userDAO SingleUser(User _SingleUserToMap)
        {
            userDAO UserToReturn = new userDAO();
            {
                userDAO _userToView = new userDAO();
                _userToView.User_ID = _SingleUserToMap.User_ID;
                _userToView.Username = _SingleUserToMap.Username;
                _userToView.Password = _SingleUserToMap.Password;
                _userToView.Role_ID = _SingleUserToMap.Role_ID;
                UserToReturn = _userToView;
            }
            return UserToReturn;
        }
        public Album SelectAlbum(albumDAO _SelectAlbumToMap)
        {
            Album AlbumToReturn = new Album();
            {
                Album _albumToView = new Album();
                _albumToView.Albums_ID = _SelectAlbumToMap.Albums_ID;
                _albumToView.AlbumName = _SelectAlbumToMap.AlbumName;
                _albumToView.AlbumDescription = _SelectAlbumToMap.AlbumDescription;
                _albumToView.AlbumPrice = _SelectAlbumToMap.AlbumPrice;
                _albumToView.YearReleased = _SelectAlbumToMap.YearReleased;
                _albumToView.NumberOfSongs = _SelectAlbumToMap.NumberOfSongs;
                AlbumToReturn = _albumToView;
            }
            return AlbumToReturn;
        }
        public Clothing SelectClothing(clothingDAO _SelectClothingToMap)
        {
            Clothing ClothingToReturn = new Clothing();
            {
                Clothing _clothingToView = new Clothing();
                _clothingToView.Clothing_ID = _SelectClothingToMap.Clothing_ID;
                _clothingToView.TypeOFClothing = _SelectClothingToMap.TypeOFClothing;
                _clothingToView.ClothingDescription = _SelectClothingToMap.ClothingDescription;
                _clothingToView.Sizes = _SelectClothingToMap.Sizes;
                _clothingToView.ClothingPrice = _SelectClothingToMap.ClothingPrice;
                _clothingToView.ClothingName = _SelectClothingToMap.ClothingName;
                ClothingToReturn = _clothingToView;
            }
            return ClothingToReturn;
        }
        public Instruments SelectInstruments(instrumentsDAO _SelectInstrumentsToMap)
        {
            Instruments InstrumentsToReturn = new Instruments();
            {
                Instruments _instrumentsToView = new Instruments();
                _instrumentsToView.Instruments_ID = _SelectInstrumentsToMap.Instruments_ID;
                _instrumentsToView.InstrumentName = _SelectInstrumentsToMap.InstrumentName;
                _instrumentsToView.InstrumentDescription = _SelectInstrumentsToMap.InstrumentDescription;
                _instrumentsToView.InstrumentPrice = _SelectInstrumentsToMap.InstrumentPrice;
                _instrumentsToView.BandMembers_ID = _SelectInstrumentsToMap.BandMemberName;
                InstrumentsToReturn = _instrumentsToView;
            }
            return InstrumentsToReturn;
        }
        public User SelectUser(userDAO _SelectUserToMap)
        {
            User UserToReturn = new User();
            {
                User _userToView = new User();
                _userToView.User_ID = _SelectUserToMap.User_ID;
                _userToView.Username = _SelectUserToMap.Username;
                _userToView.Password = _SelectUserToMap.Password;
                _userToView.Role_ID = _SelectUserToMap.Role_ID;
                UserToReturn = _userToView;
            }
            return UserToReturn;
        }
    }
}