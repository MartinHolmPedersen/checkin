using System.Collections.Generic;
using scrum_checkin.Model;
using System.Linq;
using System;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace scrum_checkin.Controllers
{
    public class CheckInSessionController : ODataController
    {
        private readonly CheckinSessionsDbContext _db;
        public CheckInSessionController(CheckinSessionsDbContext applicationDbContext)
        {
            _db = applicationDbContext;
            if (!_db.Sessions.Any())
            {
                _db.Sessions.Add(new CheckInSession
                {
                    SessionTime = new DateTime(2020, 1, 1),
                    TeamName = "Magneto",
                    Participants = new List<Participant> { new Participant {TeamMemberName = "Henrik", Score = 5},
                                                           new Participant {TeamMemberName = "Ole", Score = 2}}
                });
                _db.SaveChanges();
            }
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Sessions);
        }
        
    }
}
