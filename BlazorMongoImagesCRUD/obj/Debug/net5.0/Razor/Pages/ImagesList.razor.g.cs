#pragma checksum "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f79859f2602c4da753fe2ebc1a999e6cce96ba"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>ImagesList</h3>");
#nullable restore
#line 10 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor"
 if (images == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em> Loading... </em></p>");
#nullable restore
#line 13 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor"
}
else
{
    foreach (var image in images)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddAttribute(4, "style", "width:30rem;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "rounded m-1");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 20 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor"
                                               image.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "alt");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-success");
            __builder.AddAttribute(15, "value", "Delete");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor"
                                                                                        () => Delete(image.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\g\Documents\github\BlazorMongoImagesCRUD\BlazorMongoImagesCRUD\Pages\ImagesList.razor"
    }
}

#line default
#line hidden
#nullable disable
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