using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Request
{
    public class RequestViewModel
    {
       

        
        public string Id { get; set; }
        public string CourseId { get;set; }
        public string TeacherId {  get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string Status { get;set; }
        
    }
}
