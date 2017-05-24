using Nancy;
using System.Collections.Generic;
using Tomogatchi.Objects;

namespace Tomogatchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=>
      {
        List<userTomogatchi> allTomogatchi = userTomogatchi.GetAll();
        return View["views.cshtml"];
      };
      Post["/tomo-name"] =_=>
      {
        userTomogatchi myTomogatchi = new userTomogatchi(Request.Form["new-name"]);
        List<userTomogatchi> allTomogatchi = userTomogatchi.GetAll();
        return View["yourTomo.cshtml", allTomogatchi];
      };
    }
  }
}
