using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.PrivateChat
{
    public class PrivateChatViewModel
    {
        public PrivateChatViewModel()
        {
            this.ChatMessages = new HashSet<ChatMessage>();
        }

        public InterestsAcademy.Data.Models.User FromUser { get; set; } = null!;
        public InterestsAcademy.Data.Models.User ToUser { get; set; } = null!;

        public string Group { get; set; } = null!;

        public ICollection<ChatMessage> ChatMessages { get; set; }

    }
}
