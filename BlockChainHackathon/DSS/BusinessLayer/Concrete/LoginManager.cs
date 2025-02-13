﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LoginManager
    {
        IUserDal _userDal;

        public LoginManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetUser(string username, string password)
        {
            return _userDal.Get(x => x.UserMail == username && x.UserPassword == password);
        }
    }
}
