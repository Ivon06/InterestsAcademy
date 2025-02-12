using InterestsAcademy.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.InMemory;

namespace InterestAcademy.Tests.Mock
{
    public class DbMock
    {
        public static InterestsAcademyDbContext Instance
        {
            get
            {
                var options = new DbContextOptionsBuilder<InterestsAcademyDbContext>()
                    .UseInMemoryDatabase("InterestAcademyInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

                return new InterestsAcademyDbContext(options, false);
            }
        }
    }
}
