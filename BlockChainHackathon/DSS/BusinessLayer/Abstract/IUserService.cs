﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        List<User> GetList();
        void UserAdd(User user);
        User GetByID(int id);
        void UserDelete(User user);
        void UserUpdate(User user);
    }
}
