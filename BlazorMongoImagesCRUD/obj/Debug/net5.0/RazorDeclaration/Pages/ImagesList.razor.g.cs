// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMongoImagesCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using BlazorMongoImagesCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\_Imports.razor"
using BlazorMongoImagesCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class ImagesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor"
       

    private IEnumerable<StorableImage> images;
    private string ErrorMessage;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            images = await ImageService.GetAllImages();
        }
        catch (Exception e)
        {
            ErrorMessage = e.Message;
        }
    }

    protected async void Delete(ObjectId id)
    {
        await ImageService.DeleteImage(id);
        NavigationManager.NavigateTo("/", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IImageService ImageService { get; set; }
    }
}
#pragma warning restore 1591
