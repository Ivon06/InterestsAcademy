using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.User
{
    public class UsersQueryModel
    {
        public UsersQueryModel()
        {
            this.Users = new HashSet<UserViewModel>();
        }
        public string? SearchString { get; set; }

        public ICollection<UserViewModel> Users { get; set; }

        public int UsersCount { get; set; }

        public int StudentsCount { get; set; }
        public int ActivitiesCount { get; set; }

        public int CoursesCount { get; set; }


    }
}
