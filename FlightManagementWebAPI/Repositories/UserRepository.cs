using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class UserRepository
    {
        private readonly AirportSystemContext _airportSystemContext;

        public UserRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }
        public List<User> GetUsers()
        {
            return _airportSystemContext.Users.ToList();
        }

        public void InsertUser(User user)
        {
            _airportSystemContext.Users.Add(user);
            _airportSystemContext.SaveChanges();
        }
        public User GetUser(int userId)
        {
           return _airportSystemContext.Users.FirstOrDefault(user=>user.Id == userId);
        }
        
        public User GetUserByUsername(string userName)
        {
            var user= _airportSystemContext.Users.FirstOrDefault(user => user.UserName == userName);
            if(user!=null)
                return user;
            return null;
        }

        public void UpdateUser(User user)
        {
            var userForUpdate = GetUser(user.Id);
            if (userForUpdate != null)
            {
                userForUpdate.Id = user.Id;
                userForUpdate.UserName=user.UserName;
                userForUpdate.Password=user.Password;
                userForUpdate.RoleId=user.RoleId;
            }
        }

        public void DeleteUser(int userId)
        {
            var userForDelete=GetUser(userId);
            if(userForDelete != null)
            {
                _airportSystemContext.Users.Remove(userForDelete);
                _airportSystemContext.SaveChanges();
            }
        }
    }
}
