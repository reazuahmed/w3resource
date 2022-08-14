using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Data
{
    public class LocalStorageService
    {
        public IJSRuntime JSRuntime { get; set; }
        public LocalStorageService(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }
        //Setter
        public async Task SetItemAsync(string key, string value)
        {
            await JSRuntime.InvokeVoidAsync("localStorage.setitem", key, value);
        }

        //Getter
        public async Task<string> GetItemAsync(string key)
        {
            var result = await JSRuntime.InvokeAsync<string>("localStorage.getitem", key);
            return result;

        }
    }
}
