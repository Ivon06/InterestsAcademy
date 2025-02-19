using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Hubs
{
    public class DonationHub : Hub
    {
        public async Task UpdateDonations(string id, int amount)
        {
            await Clients.All.SendAsync("NewQuantity", id, amount);
        }
    }
}
