#pragma checksum "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Shared\_team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68011d4b3be61f427793afcf6f33fc1f095f6082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__team), @"mvc.1.0.view", @"/Views/Shared/_team.cshtml")]
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
#line 1 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\_ViewImports.cshtml"
using KlinikaProjekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\_ViewImports.cshtml"
using KlinikaProjekt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Shared\_team.cshtml"
using KlinikaProjekt.Data.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68011d4b3be61f427793afcf6f33fc1f095f6082", @"/Views/Shared/_team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5edc81fe146ce39ab93be470b0a1045af55c2156", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Shared\_team.cshtml"
 foreach(Doctor doctor in Model.Doctors){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t <div class=\"col-md-3\">\r\n\t\t\t\t     <div class=\"team-box\">\r\n\t\t\t\t\t     <div class=\"team-media\">\r\n\t\t\t\t\t\t      <img width=\"350px\" height=\"250px\"");
            BeginWriteAttribute("src", " src=\"", 248, "\"", 279, 1);
#nullable restore
#line 9 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Shared\_team.cshtml"
WriteAttributeValue("", 254, doctor.ProfilePictureURL, 254, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 280, "\"", 302, 1);
#nullable restore
#line 9 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Shared\_team.cshtml"
WriteAttributeValue("", 286, doctor.FullName, 286, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n\t\t\t\t\t\t </div>\r\n\t\t\t\t\t\t <div class=\"team-info\">\r\n\t\t\t\t\t\t     <h3> ");
#nullable restore
#line 12 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Shared\_team.cshtml"
                             Write(Html.DisplayFor(modelItem => doctor.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
							 <p>Cardiologist</p>
							 <ul class=""team-social"">
							    <li> <a href=""#""> <i class=""fa fa-facebook"" aria-hidden=""true""></i> </a>  </li>
							    <li> <a href=""#""> <i class=""fa fa-twitter"" aria-hidden=""true""></i> </a>  </li>
							    <li> <a href=""#""> <i class=""fa fa-linkedin"" aria-hidden=""true""></i></a>  </li>
							    <li> <a href=""#""> <i class=""fa fa-instagram"" aria-hidden=""true""></i></a>  </li>
							 </ul>
						 </div>
					 </div>
				 </div>
");
#nullable restore
#line 23 "C:\Users\manik\Downloads\Lab-Course1\KlinikaProjekt\KlinikaProjekt\Views\Shared\_team.cshtml"
				 
				 }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
