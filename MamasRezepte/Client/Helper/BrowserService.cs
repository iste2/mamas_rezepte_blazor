using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamasRezepte.Client.Helper
{
    public class BrowserService
    {

        private readonly IJSRuntime Js;

        public BrowserService(IJSRuntime _Js)
        {
            Js = _Js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            return await Js.InvokeAsync<BrowserDimension>("getDimensions");
        }


    }

    public class BrowserDimension {
        public int Width { get; set; }
        public int Height { get; set; }
    }

}
