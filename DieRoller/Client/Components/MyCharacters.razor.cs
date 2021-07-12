using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using DieRoller.Client;
using DieRoller.Client.Shared;
using DieRoller.Client.Components;
using DieRoller.Shared;
using System.Collections.Generic;

namespace DieRoller.Client.Components
{
    public partial class MyCharacters : ComponentBase
    {
        List<Character> characters = new List<Character>();

        protected override async Task OnInitializedAsync()
        {
            characters.Add(new Character() { Name = "Bob" });
            characters.Add(new Character() { Name = "Sam" });
            characters.Add(new Character() { Name = "Jim" });
            characters.Add(new Character() { Name = "Henry" });
            characters.Add(new Character() { Name = "Gondor the Magnificient" });
        }
    }
}