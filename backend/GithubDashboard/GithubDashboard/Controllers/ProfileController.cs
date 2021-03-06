﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using GithubDashboard.Models;
using System.Net;
using System.IO;

namespace GithubDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet("{id}")]
        public Profile Get([FromRoute] string id)
        {
            string url = "https://api.github.com/users/"+id;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Nisant Yadav";
            request.Credentials = CredentialCache.DefaultCredentials;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string json = reader.ReadToEnd();
            Console.WriteLine(json);
            Profile profile = JsonConvert.DeserializeObject<Profile>(json);

            return profile;
        }
    }
}