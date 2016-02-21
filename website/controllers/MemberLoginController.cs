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
            if (ModelState.IsValid)
            {
                var member =
                    Services.MemberService.GetAllMembers()
                        .FirstOrDefault(x => x.Username.ToLower().Equals(model.UserName.ToLower()));
                if (member != null)
                {
                    var memberShipHelper = new Umbraco.Web.Security.MembershipHelper(UmbracoContext);
                    if (memberShipHelper.Login(model.UserName, model.Password)){
                        return Redirect("/Home");
                    }
                }
            }
            return Redirect("/Login");
        }
        public ActionResult Logout()
        {
            var memberShipHelper = new Umbraco.Web.Security.MembershipHelper(UmbracoContext);
            memberShipHelper.Logout();
            return Redirect("/Login");
        }
    }
}