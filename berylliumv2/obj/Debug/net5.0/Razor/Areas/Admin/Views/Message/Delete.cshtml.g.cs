#pragma checksum "C:\Users\Asus\source\repos\berylliumv2\berylliumv2\Areas\Admin\Views\Message\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f93c2861dec29117701f7b5a230f6f3f2d2226cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/Delete.cshtml")]
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
#line 1 "C:\Users\Asus\source\repos\berylliumv2\berylliumv2\Areas\Admin\Views\_ViewImports.cshtml"
using berylliumv2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\berylliumv2\berylliumv2\Areas\Admin\Views\_ViewImports.cshtml"
using berylliumv2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f93c2861dec29117701f7b5a230f6f3f2d2226cd", @"/Areas/Admin/Views/Message/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a535fc88bbc2b1ddb3348e18f4ddc3d4269c8cf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Message_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Do you want really to delete this Message???</h1>\r\n<p>Name : ");
#nullable restore
#line 3 "C:\Users\Asus\source\repos\berylliumv2\berylliumv2\Areas\Admin\Views\Message\Delete.cshtml"
     Write(Model.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Email:  ");
#nullable restore
#line 4 "C:\Users\Asus\source\repos\berylliumv2\berylliumv2\Areas\Admin\Views\Message\Delete.cshtml"
      Write(Model.SenderEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Message Text:  ");
#nullable restore
#line 5 "C:\Users\Asus\source\repos\berylliumv2\berylliumv2\Areas\Admin\Views\Message\Delete.cshtml"
             Write(Model.MessageText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Date: ");
#nullable restore
#line 6 "C:\Users\Asus\source\repos\berylliumv2\berylliumv2\Areas\Admin\Views\Message\Delete.cshtml"
    Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 234, "\"", 281, 2);
            WriteAttributeValue("", 241, "/admin/message/deleteconfirmed/", 241, 31, true);
#nullable restore
#line 8 "C:\Users\Asus\source\repos\berylliumv2\berylliumv2\Areas\Admin\Views\Message\Delete.cshtml"
WriteAttributeValue("", 272, Model.Id, 272, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">DELETE</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
