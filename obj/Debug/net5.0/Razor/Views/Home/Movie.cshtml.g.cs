#pragma checksum "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b880a20184c180d026149dcc9a40f2c7d47277d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Movie), @"mvc.1.0.view", @"/Views/Home/Movie.cshtml")]
namespace AspNetCore
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
#line 1 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\_ViewImports.cshtml"
using MovieBase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\_ViewImports.cshtml"
using MovieBase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b880a20184c180d026149dcc9a40f2c7d47277d", @"/Views/Home/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02d253789c94f1d6994ff8bfcde1d34bca6a3ae8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Movie DataBase";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        ");
#nullable restore
#line 10 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
   Write(Model.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
         foreach(var c in Model.Countries)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
           Write(c.FullName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
                           
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
         foreach(var g in Model.Genres)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
           Write(g.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
                       
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
         if (Model.ServicesRating?.Imdb != null)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Projects\Visual Studio\NET\MovieBase\MovieBase\Views\Home\Movie.cshtml"
       Write(Model.ServicesRating.Imdb);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
