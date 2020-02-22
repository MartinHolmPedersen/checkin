using System.Collections.Generic;
using scrum_checkin.Model;
using System.Linq;
using System;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace scrum_checkin.Controllers
{
    public class ParticipantsController : ODataController
    {
        private readonly CheckinSessionsDbContext _db;
        public ParticipantsController(CheckinSessionsDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Participants);
        }
        
    }
}
