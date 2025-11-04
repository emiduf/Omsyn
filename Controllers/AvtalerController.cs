using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omsyn.Models;

namespace Omsyn.Controllers; 

public class AvtalerController : Controller
{
    public IActionResult Table()
    {

        var avtaler = new List<Avtaler>();
        var avtaler1 = new Avtaler();
        avtaler1.KlientId = "K123";
        avtaler1.PersonalId = "P466";
        avtaler1.Tid = DateTime.Now.AddHours(2);
        avtaler1.Oppgave = "Følge til legetime";
        avtaler1.Notat = "Taxi er bestilt";

        var avtaler2 = new Avtaler();
        {
            avtaler2.KlientId = "K124";
            avtaler2.PersonalId = "P345";
            avtaler2.Tid = DateTime.Now.AddDays(1).AddHours(3);
            avtaler2.Oppgave = "Handle matvarer";
            avtaler2.Notat = null; 
        };

        avtaler.Add(avtaler1);
        avtaler.Add(avtaler2);

        ViewBag.CurrentViewName = "Avtaler Tabell";
        return View(avtaler);
    }
}