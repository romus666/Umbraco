using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using vs.models;
using vs.models.MemberLogin;

namespace vs.controllers
{
    public class MemberLoginController : SurfaceController
    {
        public ActionResult Index()
        {
            var loginModel = new MemberLogin();
            return View("Index", loginModel);
        }

        public ActionResult Login(MemberLogin model)
        {
            var member =
                Services.MemberService.GetAllMembers()
                    .FirstOrDefault(x => x.Username.ToLower().Equals(model.UserName.ToLower()));
            
            if (member != null)
            {
                //TODO CHECK PASSWORD
                return Redirect("/Home");
            }
            else
            {
                //TODO NOT FOUND
                return Redirect("/Login");
            }
            // var users = umbraco.BusinessLogic.User.getAll();
            
        }
    }
}