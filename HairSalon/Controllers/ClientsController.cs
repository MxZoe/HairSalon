using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    
    [HttpGet("/stylists/{id}/clients/")]
    public ActionResult Index()
    {
      List<Client> allClients = Client.GetAll();
      return View(allClients);
    }
    

    [HttpGet("/stylists/{id}/clients/new")]
    public ActionResult New(int stylistID)
    {
      Stylist stylist = Stylist.Find(stylistID +1);
      return View(stylist);
    }    
  }
}