#pragma checksum "F:\New\FinalPrject\FinalPrject\Views\Shared\_TraineeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1f3c59923a08cb6a0af3746722b7d2c68fe84e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TraineeList), @"mvc.1.0.view", @"/Views/Shared/_TraineeList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TraineeList.cshtml", typeof(AspNetCore.Views_Shared__TraineeList))]
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
#line 1 "F:\New\FinalPrject\FinalPrject\Views\_ViewImports.cshtml"
using FinalPrject;

#line default
#line hidden
#line 2 "F:\New\FinalPrject\FinalPrject\Views\_ViewImports.cshtml"
using FinalPrject.Models;

#line default
#line hidden
#line 1 "F:\New\FinalPrject\FinalPrject\Views\Shared\_TraineeList.cshtml"
using TrainingManagement.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b1f3c59923a08cb6a0af3746722b7d2c68fe84e", @"/Views/Shared/_TraineeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"583a1a7b7d224d475b637f0dea734b927a0e9bd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TraineeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Trainee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 214, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Reg No</th>\r\n                <th>Department</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 15 "F:\New\FinalPrject\FinalPrject\Views\Shared\_TraineeList.cshtml"
             foreach (var trainee in Model)
            {

#line default
#line hidden
            BeginContext(337, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(384, 12, false);
#line 18 "F:\New\FinalPrject\FinalPrject\Views\Shared\_TraineeList.cshtml"
                   Write(trainee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(396, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(428, 13, false);
#line 19 "F:\New\FinalPrject\FinalPrject\Views\Shared\_TraineeList.cshtml"
                   Write(trainee.RegNo);

#line default
#line hidden
            EndContext();
            BeginContext(441, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(473, 27, false);
#line 20 "F:\New\FinalPrject\FinalPrject\Views\Shared\_TraineeList.cshtml"
                   Write(trainee.Department.DeptName);

#line default
#line hidden
            EndContext();
            BeginContext(500, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 22 "F:\New\FinalPrject\FinalPrject\Views\Shared\_TraineeList.cshtml"

            }

#line default
#line hidden
            BeginContext(547, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Trainee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
