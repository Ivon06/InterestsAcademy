using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using static InterestsAcademy.Data.Constants.ChatImageConstants;

namespace InterestsAcademy.Data.Models
{
    public class ChatImage
    {
        public ChatImage()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [MaxLength(ChatImageNameMaxLength)]
        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        [ForeignKey(nameof(Group))]
        public string GroupId { get; set; } = null!;

        public Group Group { get; set; } = null!;

        [ForeignKey(nameof(ChatMessage))]
        public string ChatMessageId { get; set; } = null!;

        public ChatMessage ChatMessage { get; set; } = null!;

    }
}
