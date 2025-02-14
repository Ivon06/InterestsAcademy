using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Article
{
    public class AdminArticleViewModel
    {
        public string Id { get; set; }
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }
        public string UserName { get; set; }
        public DateTime ArticlePublishedOn { get; set; }
        public List<string>? ArticlePictureURLs { get; set; }

    }
}
