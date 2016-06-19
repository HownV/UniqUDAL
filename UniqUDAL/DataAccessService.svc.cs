using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UniqUDAL.DataTransferObjects;
using UniqUDomainModel.Entities;
using UniqUDbManager;
using UniqUDomainModel;

namespace UniqUDAL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DataAccessService : IDataAccessService
    {
        readonly UniqUDbContext _dbContext = new UniqUDbContext();

        public string GetEcho(string value)
        {
            return value;
        }

        public List<User> GetUser(string email)
        {
            var query = from user in _dbContext.Users
                        where user.Email == email
                        select user;
            return query.ToList();
        }

        public void AddUser(string email, string passwordHash)
        {
            _dbContext.Users.Add(new User(email, passwordHash));
            _dbContext.SaveChanges();
        }
    }
}
