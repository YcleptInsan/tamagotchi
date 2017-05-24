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
        return View["Views.cshtml"];
      };
      Get["/tomo-name"] =_=>
      {
        userTomogatchi myTamagotchi = new userTomogatchi(Request.Form["new-name"]);
        return View["yourTomo.cshtml", myTamagotchi];
      };
    }
  }
}
