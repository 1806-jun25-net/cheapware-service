﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.RepoClasses;
using Cheapware.Library.Models;
using Microsoft.AspNetCore.Authorization;

namespace CheapWare.API.Controllers
{
    [Route("api/GraphicsCards")]
    [ApiController]
    [Authorize]
    public class GraphicsCardsController : ControllerBase
    {
        // GET: api/GraphicsCards
        private ComputerRepo repo { get; }

        public GraphicsCardsController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<GraphicsCard>>> GetGraphicsCards()
        {
            return await repo.GetGraphicsCards();
        }

        // GET: api/GraphicsCards/5
        

        [HttpGet("{name}", Name = "GetGraphicsCardByName")]
        public async Task<ActionResult<GraphicsCard>> GetGraphicsCardsByName(string name)
        {
            return await repo.GetGraphicsCardByName(name);
        }


    }
}
