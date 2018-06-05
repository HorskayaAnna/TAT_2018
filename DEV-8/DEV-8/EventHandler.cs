using System;
using System.Collections.Generic;
using System.Linq;

namespace DEVTask8
{
    /// <summary>
    /// Class which extends EventArgs in the way we need
    /// </summary>
    public class AccountEventArgs : EventArgs
    {
        public List<Human> Humans { get; }
        public string LastName { get; }

        /// <summary>
        /// Constructor, which leaves only persons bearing the same surname
        /// </summary>
        /// <param name="paramHumans">
        /// list of humans
        /// </param>
        /// <param name="paramName">
        /// input lastname
        /// </param>
        public AccountEventArgs(List<Human> paramHumans, string paramName)
        {
            Humans = paramHumans.Where(h => h.LastName==paramName).ToList();
            LastName = paramName;
        }

        public override string ToString()
        {
            string response = string.Empty;
            foreach (Human human in Humans)
            {
                response += $"Firstname : {human.FirstName},LastName: {human.LastName}, Age: {human.Age}, sex: {human.Sex}"; 
            }
            return response;
        }
    }
}