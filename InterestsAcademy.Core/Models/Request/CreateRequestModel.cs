using InterestsAcademy.Data.Models.Enums;
using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Request
{
    public class CreateRequestModel
    {
        public string TeacherId { get; set; } = null!;
        
        public string CourseId { get; set; } = null!;
       
        public string StudentId { get; set; } = null!;

        [EnumDataType(typeof(RequestStatusEnum))]
        public string Status { get; set; } = null!;
    }
}
