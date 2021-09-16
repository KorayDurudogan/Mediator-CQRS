using CQRSandMediatR.Models;
using System.Collections.Generic;

namespace CQRSandMediatR
{
    public static class Database
    {
        private static List<User> users;

        public static List<User> Users
        {
            get
            {
                if (users == null)
                {
                    users = new List<User>
                    {
                        new User{ Id = 1, Name = "Koray", Surname = "Durudoğan", Age = 28},
                        new User{ Id = 2, Name = "Yalçın", Surname = "Durudoğan", Age = 29},
                        new User { Id = 3, Name = "Gülgün", Surname = "Durudoğan", Age = 30 },
                        new User { Id = 4, Name = "Merve", Surname = "Durudoğan", Age = 31 }
                    };
                }

                return users;
            }
        }
    }
}
