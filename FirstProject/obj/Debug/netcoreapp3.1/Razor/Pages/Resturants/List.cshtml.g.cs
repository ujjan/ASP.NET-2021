#pragma checksum "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc4836c10c46e8458428560c1ce9d3bea4bc3f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FirstProject.Pages.Resturants.Pages_Resturants_List), @"mvc.1.0.razor-page", @"/Pages/Resturants/List.cshtml")]
namespace FirstProject.Pages.Resturants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/_ViewImports.cshtml"
using FirstProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4836c10c46e8458428560c1ce9d3bea4bc3f70", @"/Pages/Resturants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d37f5fe89410d87f89e00f76c541ed80282c3e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Resturants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml"
   ViewData["Title"] = "List"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Restaurants</h1>\r\n\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 9 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml"
     foreach (var restaurant in Model.Restaurants)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 12 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml"
           Write(restaurant.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 15 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml"
           Write(restaurant.Cuisine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 17 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n<div>");
#nullable restore
#line 21 "/Users/Ayaz/Desktop/programing/asp-dotnet/FirstProject/FirstProject/Pages/Resturants/List.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstProject.Pages.Resturants.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstProject.Pages.Resturants.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstProject.Pages.Resturants.ListModel>)PageContext?.ViewData;
        public FirstProject.Pages.Resturants.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591