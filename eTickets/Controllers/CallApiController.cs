﻿using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace eTickets.Controllers
{
    public class CallApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            var hhtc = new HttpClient();
            var response = await hhtc.GetAsync("https://mustafa.millenniumtraveltr.com/api/UsersApi");
            string resString = await response.Content.ReadAsStringAsync();
            users = JsonConvert.DeserializeObject<List<ApplicationUser>>(resString);
            return View(users);

        //https://localhost:7044/api/UsersApi
        //https://mustafa.millenniumtraveltr.com/api/UsersApi
        }
    }
}
