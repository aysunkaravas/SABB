using SABB.BLL.Abstract;
using SABB.DataAccess.Abstract;
using SABB.DataAccess.Concrete;
using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SABB.BLL.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
    }
}
