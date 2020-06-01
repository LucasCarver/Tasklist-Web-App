#pragma checksum "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "736bf634703faef3c71801b47f406bce0787425d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_ShowComplete), @"mvc.1.0.view", @"/Views/Task/ShowComplete.cshtml")]
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
#line 1 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\_ViewImports.cshtml"
using TaskListWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\_ViewImports.cshtml"
using TaskListWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"736bf634703faef3c71801b47f406bce0787425d", @"/Views/Task/ShowComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae973e4182538944e897f3d1b478252dc0d9117", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_ShowComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tasks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
  
    ViewData["Title"] = "TaskIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Completed tasks</h1>\r\n<p class=\"text-danger\">");
#nullable restore
#line 8 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
                  Write(ViewBag.TaskNotAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
  

    int i = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
     foreach (Tasks t in Model)
    {
        if (t.Complete)
        {
            i++;
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
 if (i == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-danger\">Your tasklist is empty.</p>\r\n    <p><a href=\"/Task/AddTask\">Click here to add your first task!</a></p>\r\n");
#nullable restore
#line 24 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <p><a href=""/Task/TaskIndex"">Show all tasks</a></p>
    <table width=""50%"">
        <tr>
            <th>
                Description
            </th>
            <th>
                Due Date
            </th>
            <th>
                Status
            </th>
            <th>
                Toggle Completion
            </th>
            <th>
                Delete
            </th>
        </tr>
");
#nullable restore
#line 46 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
         foreach (Tasks t in Model)
        {
            if (t.Complete)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
                   Write(t.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
                   Write(t.DueDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>Complete</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "736bf634703faef3c71801b47f406bce0787425d6961", async() => {
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Change Status\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1295, "/Task/ToggleStatus?id=", 1295, 22, true);
#nullable restore
#line 59 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
AddHtmlAttributeValue("", 1317, t.Id, 1317, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "736bf634703faef3c71801b47f406bce0787425d9149", async() => {
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Delete\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1539, "/Task/DeleteTask?id=", 1539, 20, true);
#nullable restore
#line 64 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
AddHtmlAttributeValue("", 1559, t.Id, 1559, 5, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <p><a href=\"/Task/AddTask\">Add another task.</a></p>\r\n");
#nullable restore
#line 73 "C:\Users\imWUMPUS\source\repos\CSharp_April2020\TaskListWebApp\TaskListWebApp\Views\Task\ShowComplete.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tasks>> Html { get; private set; }
    }
}
#pragma warning restore 1591