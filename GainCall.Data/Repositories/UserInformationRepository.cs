using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GainCall.Data.Interfaces;

namespace GainCall.Data.Repositories
{
    public class UserInformationRepository:IUserInformationRepository
    {
        public UserInformation GetUserInformation(int userId)
        {
            using (GainCallDBEntities gainCallDbEntities = new GainCallDBEntities())
            {
                return gainCallDbEntities.UserInformations.FirstOrDefault(user => user.UserId == userId);
            }
        }
    }
}
