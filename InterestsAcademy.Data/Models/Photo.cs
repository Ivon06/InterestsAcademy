using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
    public class Photo
    {
        public Photo()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }
        public string PhotoUrl { get; set; } = null!;

        [ForeignKey(nameof(Article))]
        public string ArticleId { get; set; }

        public Article Article{ get; set; }
    }
}
