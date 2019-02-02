using Milestone.Models;
using Milestone.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milestone.Services.Business
{

    public class SecurityService
    {

        public bool login(User user) {

            UserDAO dao = new UserDAO();

            return dao.findByUser(user);
        }

        public bool register(User user) {

            UserDAO dao = new UserDAO();

            return dao.register(user);
        }

    }
}