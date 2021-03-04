using Business.Utilities.Results;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        User GetByMail(string email);
    }
}
