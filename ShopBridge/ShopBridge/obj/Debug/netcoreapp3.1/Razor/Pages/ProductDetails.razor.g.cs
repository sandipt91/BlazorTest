#pragma checksum "D:\Work\CodingPractice\ShopBridge\ShopBridge\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ad75a1134fbb9c738bd8f6f98c2d385e42f957"
// <auto-generated/>
#pragma warning disable 1591
namespace ShopBridge.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using ShopBridge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using ShopBridge.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\CodingPractice\ShopBridge\ShopBridge\_Imports.razor"
using ShopBridge.DataModels.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdetails/{id}")]
    public partial class ProductDetails : ProductDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "mb-5");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<div class=\"col-md-6 mb-4 mb-md-0\">\r\n\r\n\r\n\r\n        </div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-6");
            __builder.AddMarkupContent(9, "\r\n\r\n            ");
            __builder.OpenElement(10, "h5");
            __builder.AddContent(11, 
#nullable restore
#line 16 "D:\Work\CodingPractice\ShopBridge\ShopBridge\Pages\ProductDetails.razor"
                 product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<p class=\"mb-2 text-muted text-uppercase small\">Shirts</p>\r\n\r\n            ");
            __builder.OpenElement(14, "p");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "mr-1");
            __builder.OpenElement(17, "strong");
            __builder.AddContent(18, "$ ");
            __builder.AddContent(19, 
#nullable restore
#line 19 "D:\Work\CodingPractice\ShopBridge\ShopBridge\Pages\ProductDetails.razor"
                                             product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "pt-1");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddContent(24, 
#nullable restore
#line 21 "D:\Work\CodingPractice\ShopBridge\ShopBridge\Pages\ProductDetails.razor"
                 product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, @"<div class=""table-responsive"">
                <table class=""table table-sm table-borderless mb-0"">
                    <tbody>
                        <tr>
                            <th class=""pl-0 w-25"" scope=""row""><strong>Model</strong></th>
                            <td>Shirt 5407X</td>
                        </tr>
                        <tr>
                            <th class=""pl-0 w-25"" scope=""row""><strong>Color</strong></th>
                            <td>Black</td>
                        </tr>
                        <tr>
                            <th class=""pl-0 w-25"" scope=""row""><strong>Delivery</strong></th>
                            <td>USA, Europe</td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <hr>

        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n    ");
            __builder.AddMarkupContent(30, "<a class=\"btn btn-primary\" href=\"/\">Back</a>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
