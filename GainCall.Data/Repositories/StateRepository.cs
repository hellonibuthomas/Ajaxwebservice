using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GainCall.Data.Interfaces;
using GainCall.Entity;

namespace GainCall.Data.Repositories
{
    public class StateRepository : IStateRepository
    {
        public List<State> GetStates()
        {
            using (GainCallDBEntities dbEntities = new GainCallDBEntities())
            {
                return dbEntities.States.ToList();
            }
        }

        public State GetState(int stateId)
        {
            using (GainCallDBEntities dbEntities = new GainCallDBEntities())
            {
                return dbEntities.States.FirstOrDefault(state => state.StateId == stateId);
            }
        }
    }
}
