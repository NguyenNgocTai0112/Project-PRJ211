#pragma checksum "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d54ad0eed22dfd1404467116276f22977b6b48f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListUser), @"mvc.1.0.view", @"/Views/Admin/ListUser.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\_ViewImports.cshtml"
using OnlineJob;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\_ViewImports.cshtml"
using OnlineJob.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d54ad0eed22dfd1404467116276f22977b6b48f", @"/Views/Admin/ListUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c78331258e8225f6ba583058518eae0c4e6f69", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineJob.Models.AccountUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>List user</h3>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.PassWord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.isAdminstrator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Gmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayNameFor(model => model.YearOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n\r\n\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.AccountID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.PassWord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.isAdminstrator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 89 "C:\Users\Admin\Desktop\CodeInHome\OnlineJobSearch\OnlineJob\Views\Admin\ListUser.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineJob.Models.AccountUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591