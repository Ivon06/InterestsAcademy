using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Common.ErrorMessages;
using static InterestsAcademy.Data.Constants.ArticleConstants;

namespace InterestsAcademy.Core.Models.Article
{
    public class ArticleQueryViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ArticleNameMaxLength, MinimumLength = ArticleNameMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ArticleDescriptionMaxLength, MinimumLength = ArticleDescriptionMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Description { get; set; } = null!;
        public string? UserId { get; set; }
        public List<string>? ArticlePictureURLs { get; set; }

        public DateTime PublishedOn { get; set; }

    }
}
