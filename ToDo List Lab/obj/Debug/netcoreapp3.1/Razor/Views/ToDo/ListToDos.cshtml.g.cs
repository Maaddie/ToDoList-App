#pragma checksum "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\ToDo\ListToDos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f74afe27ed60ee2e624673f4b5e9fa533f820c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_ListToDos), @"mvc.1.0.view", @"/Views/ToDo/ListToDos.cshtml")]
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
#line 1 "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\_ViewImports.cshtml"
using ToDo_List_Lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\_ViewImports.cshtml"
using ToDo_List_Lab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f74afe27ed60ee2e624673f4b5e9fa533f820c1", @"/Views/ToDo/ListToDos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4a512d675b7a672956ea93becb4dcad3b4a40b", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_ListToDos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\ToDo\ListToDos.cshtml"
  
    ViewData["Title"] = "ListToDos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of Tasks</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\ToDo\ListToDos.cshtml"
 foreach (ToDo td in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"border: solid 2px blue\">\r\n\r\n    <p>Name: ");
#nullable restore
#line 14 "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\ToDo\ListToDos.cshtml"
        Write(td.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Hours Needed: ");
#nullable restore
#line 15 "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\ToDo\ListToDos.cshtml"
                Write(td.HoursNeeded);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Is Completed: ");
#nullable restore
#line 16 "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\ToDo\ListToDos.cshtml"
                Write(td.IsCompleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    \r\n</div>\r\n");
#nullable restore
#line 19 "C:\Users\mvarasteanu\source\ToDo List Lab\ToDo List Lab\Views\ToDo\ListToDos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
