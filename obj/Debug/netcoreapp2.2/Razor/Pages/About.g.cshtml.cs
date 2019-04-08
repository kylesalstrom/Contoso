#pragma checksum "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed565b334de2f07f4b798de12ff260cbd7f8532d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoUniversity.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(ContosoUniversity.Pages.Pages_About), null)]
namespace ContosoUniversity.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed565b334de2f07f4b798de12ff260cbd7f8532d", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c0473ebe7d620ab1ae06d83bc5bc87bf314407", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
            BeginContext(111, 167, true);
            WriteLiteral("\r\n<h2>Enrollments</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            Enrollment Date\r\n        </th>\r\n        <th>\r\n            Students\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 20 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
     foreach (var item in Model.EnrollmentDates)
    {

#line default
#line hidden
            BeginContext(335, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(384, 49, false);
#line 24 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(433, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(489, 17, false);
#line 27 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(506, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
    }

#line default
#line hidden
            BeginContext(549, 175, true);
            WriteLiteral("</table>\r\n\r\n<h2>Course Grades</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            Course\r\n        </th>\r\n        <th>\r\n            Average Grade\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 45 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
     foreach (var item in Model.AvgGrades)
    {

#line default
#line hidden
            BeginContext(775, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(824, 46, false);
#line 49 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
           Write(Html.DisplayFor(modelItem => item.CourseTitle));

#line default
#line hidden
            EndContext();
            BeginContext(870, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(926, 43, false);
#line 52 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
           Write(Html.DisplayFor(modelItem => item.AvgGrade));

#line default
#line hidden
            EndContext();
            BeginContext(969, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "/Users/kyle/Documents/Dev/Projects/ContosoUniversity/Pages/About.cshtml"
    }

#line default
#line hidden
            BeginContext(1012, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContosoUniversity.Pages.AboutModel>)PageContext?.ViewData;
        public ContosoUniversity.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
