using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DotVVMSignalRSample.Hubs
{
    public class TestHub : Hub
    {
        public async Task FormPosted()
        {
            await Task.Delay(2000);
            await Clients.Caller.SendAsync("FormSended");
        }
    }
}
