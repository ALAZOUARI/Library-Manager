#pragma checksum "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f177bf277c08cfb33a64c541b97d2f01ab3f54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\_ViewImports.cshtml"
using Librarymanagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\_ViewImports.cshtml"
using Librarymanagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f177bf277c08cfb33a64c541b97d2f01ab3f54", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a3794e563ac1812bf6f971b55f012b819d5b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Librarymanagement.Models.BookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Books</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 13 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
           Write(Html.ActionLink(item.Title, "Details", new { id = item.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 43 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
                 if (item.IsAvailable)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
               Write(Html.ActionLink("Borrow", "Create", "BorrowHistories", new { id = item.BookId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
                                                                                                                                         
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
               Write(Html.ActionLink("Return", "Edit", "BorrowHistories", new { id = item.BookId }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"
                                                                                                                                       
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Ala\source\repos\Librarymanagement\Librarymanagement\Views\Books\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Librarymanagement.Models.BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591