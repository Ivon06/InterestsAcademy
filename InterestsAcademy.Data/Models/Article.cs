using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Common.ErrorMessages;
using static InterestsAcademy.Data.Constants.ArticleConstants;

namespace InterestsAcademy.Data.Models
{
    public class Article
    {
        public Article()
        {
            Id = Guid.NewGuid().ToString();
            IsActive = false;
        }
        [Key]
        public string Id { get; set; } = null!;


        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(ArticleNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(ArticleDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;

        public User User { get; set; } = null!;
        public List<string>? ArticlePictureURLs { get; set; }

        public DateTime PublishedOn { get; set; }
        public bool IsActive { get; set; }

    }
}
