#pragma checksum "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f571ed82795518466f017383a58933c8529ebddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomePage), @"mvc.1.0.view", @"/Views/Home/HomePage.cshtml")]
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
#line 1 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\_ViewImports.cshtml"
using online_mart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\_ViewImports.cshtml"
using online_mart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f571ed82795518466f017383a58933c8529ebddc", @"/Views/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03fae5d6bc02e0dd1b522b740bfafac1cd85c637", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<online_mart.Models.ItemClass>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .home {\r\n        margin-top: 100px;\r\n    }\r\n</style>\r\n\r\n<div class=\"home\"></div>\r\n<div class=\"row mt-20\">\r\n");
#nullable restore
#line 11 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 mb-2\">\r\n            <div class=\"card text-center\">\r\n                <div class=\"card-body\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 359, "", 373, 1);
#nullable restore
#line 16 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml"
WriteAttributeValue("", 364, item.Url, 364, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"300\" width=\"200\" class=\"card-img-top\">\r\n                    <h4>");
#nullable restore
#line 17 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                    <div class=\"chck\">\r\n                        <span class=\"info\">");
#nullable restore
#line 20 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml"
                                      Write(item.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div style=\"color:blue;\">Price: ");
#nullable restore
#line 22 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n                </div>\r\n                <div class=\"card-footer text-muted\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml"
               Write(Html.ActionLink("Order", "MakeOrder", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml"
               Write(Html.ActionLink("Add to Cart", "AddtoCart", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\india\Desktop\mywork\wddn project\Project_CE022\Project_CE022\online_mart\Views\Home\HomePage.cshtml"
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<online_mart.Models.ItemClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
