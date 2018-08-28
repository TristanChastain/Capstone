using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Objects;
using System.Web;
using Queens_of_the_Stone_Age_Store.Models;
using BLL;
using BLL.Objects;

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
                _userToView.Password = _userToMap.Password;
                _userToView.Role_ID = _userToMap.Role_ID;
                _userListToReturn.Add(_userToView);
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
        public List<BandMembers> MemeberMap(List<bandmembersDAO> _memberListToMap)
        {
            List<BandMembers> _memberListToReturn = new List<BandMembers>();
            foreach (bandmembersDAO _memberToMap in _memberListToMap)
            {
                BandMembers _memberToView = new BandMembers();
                _memberToView.BandMembers_ID = _memberToMap.BandMembers_ID;
                _memberToView.MemberName = _memberToMap.MemberName;
                _memberToView.MemberBio = _memberToMap.MemberBio;
                _memberToView.DateOfBirth = _memberToMap.DateOfBirth;
                _memberToView.BirthLocation = _memberToMap.BirthLocation;
                _memberListToReturn.Add(_memberToView);
            }
            return _memberListToReturn;
        }
        public bandmembersDAO SingleMember(BandMembers _SingleMemberToMap)
        {
            bandmembersDAO MemberToReturn = new bandmembersDAO();
            {
                bandmembersDAO _memberToView = new bandmembersDAO();
                _memberToView.BandMembers_ID = _SingleMemberToMap.BandMembers_ID;
                _memberToView.MemberName = _SingleMemberToMap.MemberName;
                _memberToView.MemberBio = _SingleMemberToMap.MemberBio;
                _memberToView.DateOfBirth = _SingleMemberToMap.DateOfBirth;
                _memberToView.BirthLocation = _SingleMemberToMap.BirthLocation;
                MemberToReturn = _memberToView;
            }
            return MemberToReturn;
        }
        public BandMembers SelectMember(bandmembersDAO _SelectMemberToMap)
        {
            BandMembers MemberToReturn = new BandMembers();
            {
                BandMembers _memberToView = new BandMembers();
                _memberToView.BandMembers_ID = _SelectMemberToMap.BandMembers_ID;
                _memberToView.MemberName = _SelectMemberToMap.MemberName;
                _memberToView.MemberBio = _SelectMemberToMap.MemberBio;
                _memberToView.DateOfBirth = _SelectMemberToMap.DateOfBirth;
                _memberToView.BirthLocation = _SelectMemberToMap.BirthLocation;
                MemberToReturn = _memberToView;
            }
            return MemberToReturn;
        }
        public List<ShoppingCart> ShoppingCartMap(List<shoppingcartDAO> _shoppingcartToList)
        {
            List<ShoppingCart> _shoppingcartListToReturn = new List<ShoppingCart>();
            foreach (shoppingcartDAO _shoppingcartToMap in _shoppingcartToList)
            {
                ShoppingCart _shoppingcartToView = new ShoppingCart();
                _shoppingcartToView.ShoppingCart_ID = _shoppingcartToMap.ShoppingCart_ID;
                _shoppingcartToView.Albums_ID = _shoppingcartToMap.Albums_ID;
                _shoppingcartToView.Clothing_ID = _shoppingcartToMap.Clothing_ID;
                _shoppingcartToView.Instruments_ID = _shoppingcartToMap.Instruments_ID;
                _shoppingcartToView.User_ID = _shoppingcartToMap.User_ID;
                _shoppingcartListToReturn.Add(_shoppingcartToView);
            }
            return _shoppingcartListToReturn;
        }
        public shoppingcartDAO SingleShoppingCart(ShoppingCart _SingleCartToMap)
        {
            shoppingcartDAO cartToReturn = new shoppingcartDAO();
            {
                shoppingcartDAO _cartToView = new shoppingcartDAO();
                _cartToView.ShoppingCart_ID = _SingleCartToMap.ShoppingCart_ID;
                _cartToView.Albums_ID = _SingleCartToMap.Albums_ID;
                _cartToView.Clothing_ID = _SingleCartToMap.Clothing_ID;
                _cartToView.Instruments_ID = _SingleCartToMap.Instruments_ID;
                _cartToView.User_ID = _SingleCartToMap.User_ID;
                cartToReturn = _cartToView;
            }
            return cartToReturn;
        }
        public  ShoppingCart SelectCart(shoppingcartDAO _SelectCartToMap)
        {
            ShoppingCart CartToReturn = new ShoppingCart();
            {
                ShoppingCart _cartToView = new ShoppingCart();
                _cartToView.ShoppingCart_ID = _SelectCartToMap.ShoppingCart_ID;
                _cartToView.Albums_ID = _SelectCartToMap.Albums_ID;
                _cartToView.Clothing_ID = _SelectCartToMap.Clothing_ID;
                _cartToView.Instruments_ID = _SelectCartToMap.Instruments_ID;
                _cartToView.User_ID = _SelectCartToMap.User_ID;
                CartToReturn = _cartToView;
            }
            return CartToReturn;
        }
        public albumBLO SingleAlbumLogicMap(Album _SingleAlbumLogic)
        {
            albumBLO LogicToReturn = new albumBLO();
            {
                albumBLO _albumLogicView = new albumBLO();
                _albumLogicView.Albums_ID = _SingleAlbumLogic.Albums_ID;
                _albumLogicView.AlbumName = _SingleAlbumLogic.AlbumName;
                _albumLogicView.AlbumDescription = _SingleAlbumLogic.AlbumDescription;
                _albumLogicView.AlbumPrice = _SingleAlbumLogic.AlbumPrice;
                _albumLogicView.YearReleased = _SingleAlbumLogic.YearReleased;
                _albumLogicView.NumberOfSongs = _SingleAlbumLogic.NumberOfSongs;
            }
            return LogicToReturn;
        }
        public Album SelectAlbumLogicMap(albumBLO _SelectAlbumLogic)
        {
            Album LogicToReturn = new Album();
            {
                Album _albumLogicView = new Album();
                _albumLogicView.Albums_ID = _SelectAlbumLogic.Albums_ID;
                _albumLogicView.AlbumName = _SelectAlbumLogic.AlbumName;
                _albumLogicView.AlbumDescription = _SelectAlbumLogic.AlbumDescription;
                _albumLogicView.AlbumPrice = _SelectAlbumLogic.AlbumPrice;
                _albumLogicView.YearReleased = _SelectAlbumLogic.YearReleased;
                _albumLogicView.NumberOfSongs = _SelectAlbumLogic.NumberOfSongs;
            }
            return LogicToReturn;
        }
        public clothingBLO SingleClothingLogicMap(Clothing _SingleClothingLogic)
        {
            clothingBLO LogicToReturn = new clothingBLO();
            {
                clothingBLO _clolthingLogicView = new clothingBLO();
                _clolthingLogicView.Clothing_ID = _SingleClothingLogic.Clothing_ID;
                _clolthingLogicView.TypeOFClothing = _SingleClothingLogic.TypeOFClothing;
                _clolthingLogicView.ClothingDescription = _SingleClothingLogic.ClothingDescription;
                _clolthingLogicView.Sizes = _SingleClothingLogic.Sizes;
                _clolthingLogicView.ClothingPrice = _SingleClothingLogic.ClothingPrice;
                _clolthingLogicView.ClothingName = _SingleClothingLogic.ClothingName;
            }
            return LogicToReturn;
        }
        public Clothing SelectClothingLogicMap(clothingBLO _SelectClothingLogic)
        {
            Clothing LogicToReturn = new Clothing();
            {
                Clothing _clothingLogicView = new Clothing();
                _clothingLogicView.Clothing_ID = _SelectClothingLogic.Clothing_ID;
                _clothingLogicView.TypeOFClothing = _SelectClothingLogic.TypeOFClothing;
                _clothingLogicView.ClothingDescription = _SelectClothingLogic.ClothingDescription;
                _clothingLogicView.Sizes = _SelectClothingLogic.Sizes;
                _clothingLogicView.ClothingPrice = _SelectClothingLogic.ClothingPrice;
                _clothingLogicView.ClothingName = _SelectClothingLogic.ClothingName;
            }
            return LogicToReturn;
        }
        public instrumentsBLO SingleInstrumentsLogicMap(Instruments _SingleInstrumentLogic)
        {
            instrumentsBLO LogicToReturn = new instrumentsBLO();
            {
                instrumentsBLO _instrumentsLogicView = new instrumentsBLO();
                _instrumentsLogicView.Instruments_ID = _SingleInstrumentLogic.Instruments_ID;
                _instrumentsLogicView.InstrumentName = _SingleInstrumentLogic.InstrumentName;
                _instrumentsLogicView.InstrumentDescription = _SingleInstrumentLogic.InstrumentDescription;
                _instrumentsLogicView.InstrumentPrice = _SingleInstrumentLogic.InstrumentPrice;
            }
            return LogicToReturn;
        }
        public Instruments SelectInstrumentsLogicMap(instrumentsBLO _SelectInstrumentLogic)
        {
            Instruments LogicToReturn = new Instruments();
            {
                Instruments _instrumentLogicView = new Instruments();
                _instrumentLogicView.Instruments_ID = _SelectInstrumentLogic.Instruments_ID;
                _instrumentLogicView.InstrumentName = _SelectInstrumentLogic.InstrumentName;
                _instrumentLogicView.InstrumentDescription = _SelectInstrumentLogic.InstrumentDescription;
                _instrumentLogicView.InstrumentPrice = _SelectInstrumentLogic.InstrumentPrice;
            }
            return LogicToReturn;
        }
        public List<ShoppingCart> ShoppingCartLogicMap(List<shoppingcartBLO> _shoppingcartToList)
        {
            List<ShoppingCart> _shoppingcartListToReturn = new List<ShoppingCart>();
            foreach (shoppingcartBLO _shoppingcartToMap in _shoppingcartToList)
            {
                ShoppingCart _shoppingcartLogicView = new ShoppingCart();
                _shoppingcartLogicView.ShoppingCart_ID = _shoppingcartToMap.ShoppingCart_ID;
                _shoppingcartLogicView.Albums_ID = _shoppingcartToMap.Albums_ID;
                _shoppingcartLogicView.Clothing_ID = _shoppingcartToMap.Clothing_ID;
                _shoppingcartLogicView.Instruments_ID = _shoppingcartToMap.Instruments_ID;
                _shoppingcartLogicView.User_ID = _shoppingcartToMap.User_ID;

                _shoppingcartListToReturn.Add(_shoppingcartLogicView);
            }
            return _shoppingcartListToReturn;
        }
        public List<Album> AlbumLogicMap(List<albumBLO> _albumListToMap)
        {
            List<Album> _albumListToReturn = new List<Album>();
            foreach (albumBLO _albumToMap in _albumListToMap)
            {
                Album _albumLogicView = new Album();
                _albumLogicView.Albums_ID = _albumToMap.Albums_ID;
                _albumLogicView.AlbumName = _albumToMap.AlbumName;
                _albumLogicView.AlbumDescription = _albumToMap.AlbumDescription;
                _albumLogicView.AlbumPrice = _albumToMap.AlbumPrice;
                _albumLogicView.YearReleased = _albumToMap.YearReleased;
                _albumLogicView.NumberOfSongs = _albumToMap.NumberOfSongs;
                _albumListToReturn.Add(_albumLogicView);
            }
            return _albumListToReturn;
        }
        public List<Clothing> ClothingLogicMap(List<clothingBLO> _clothingListToMap)
        {
            List<Clothing> _clothingListToReturn = new List<Clothing>();
            foreach (clothingBLO _clothingToMap in _clothingListToMap)
            {
                Clothing _clothingLogicView = new Clothing();
                _clothingLogicView.Clothing_ID = _clothingToMap.Clothing_ID;
                _clothingLogicView.TypeOFClothing = _clothingToMap.TypeOFClothing;
                _clothingLogicView.ClothingDescription = _clothingToMap.ClothingDescription;
                _clothingLogicView.Sizes = _clothingToMap.Sizes;
                _clothingLogicView.ClothingPrice = _clothingToMap.ClothingPrice;
                _clothingLogicView.ClothingName = _clothingToMap.ClothingName;
                _clothingListToReturn.Add(_clothingLogicView);
            }
            return _clothingListToReturn;
        }
        public List<Instruments> InstrumentsLogicMap(List<instrumentsBLO> _instrumentsListToMap)
        {
            List<Instruments> _instrumentsListToReturn = new List<Instruments>();
            foreach (instrumentsBLO _instrumentsToMap in _instrumentsListToMap)
            {
                Instruments _instrumentsLogicView = new Instruments();
                _instrumentsLogicView.Instruments_ID = _instrumentsToMap.Instruments_ID;
                _instrumentsLogicView.InstrumentName = _instrumentsToMap.InstrumentName;
                _instrumentsLogicView.InstrumentDescription = _instrumentsToMap.InstrumentDescription;
                _instrumentsLogicView.InstrumentPrice = _instrumentsToMap.InstrumentPrice;
                _instrumentsListToReturn.Add(_instrumentsLogicView);
            }
            return _instrumentsListToReturn;
        }
    }
}