#pragma checksum "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posting_Job), @"mvc.1.0.view", @"/Views/Posting/Job.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\_ViewImports.cshtml"
using OnlineJob;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\_ViewImports.cshtml"
using OnlineJob.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a", @"/Views/Posting/Job.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c78331258e8225f6ba583058518eae0c4e6f69", @"/Views/_ViewImports.cshtml")]
    public class Views_Posting_Job : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineJob.Models.Posting>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
  
    ViewData["Title"] = "Job";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""slider-area "">
    <div class=""single-slider section-overly slider-height2 d-flex align-items-center"" data-background=""../assets/img/about.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""hero-cap text-center"">
                        <h2>Get your job</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>  
<!-- Hero Area End -->
<!-- Job List Area Start -->
<div class=""job-listing-area pt-120 pb-120"">
    <div class=""container"">
        <div class=""row"">
            <!-- Left content -->
            <div class=""col-xl-3 col-lg-3 col-md-4"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""small-section-tittle2 mb-45"">
                            <div class=""ion"">
                                <svg xmlns=""http://www.w3.org/2000/svg""
                                    ");
            WriteLiteral(@" xmlns:xlink=""http://www.w3.org/1999/xlink""
                                     width=""20px"" height=""12px"">
                                    <path fill-rule=""evenodd"" fill=""rgb(27, 207, 107)""
                                          d=""M7.778,12.000 L12.222,12.000 L12.222,10.000 L7.778,10.000 L7.778,12.000 ZM-0.000,-0.000 L-0.000,2.000 L20.000,2.000 L20.000,-0.000 L-0.000,-0.000 ZM3.333,7.000 L16.667,7.000 L16.667,5.000 L3.333,5.000 L3.333,7.000 Z"" />
                                </svg>
                            </div>
                            <h4>Filter Jobs</h4>
                        </div>
                    </div>
                </div>
                <!-- Job Category Listing start -->
                <div class=""job-category-listing mb-50"">
                    <!-- single one -->
                    <div class=""single-listing"">
                        <div class=""small-section-tittle2"">
                            <h4>Job Category</h4>
                        </div>
   ");
            WriteLiteral("                     <!-- Select job items start -->\r\n                        <div class=\"select-job-items2\">\r\n                            <select name=\"select\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a6024", async() => {
                WriteLiteral("All Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                                foreach (var item in Model)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a7507", async() => {
#nullable restore
#line 56 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                                            Write(item.CategoriesName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </select>
                        </div>
                        <!--  Select job items End-->
                        <!-- select-Categories start -->
                        <div class=""select-Categories pt-80 pb-50"">
                            <div class=""small-section-tittle2"">
                                <h4>Job Type</h4>
                            </div>
                            <label class=""container"">
                                Full Time
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                                Part Time
                                <input type=""checkbox"" checked=""checked active"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                       ");
            WriteLiteral(@"         Remote
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                                Freelance
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                        </div>
                        <!-- select-Categories End -->
                    </div>
                    <!-- single two -->
                    <div class=""single-listing"">
                        <div class=""small-section-tittle2"">
                            <h4>Job Location</h4>
                        </div>
                        <!-- Select job items start -->
                        <div class=""select-job-items2"">
                            <select name=""select"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a11162", async() => {
                WriteLiteral("Anywhere");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a12356", async() => {
                WriteLiteral("Category 1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a13552", async() => {
                WriteLiteral("Category 2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a14748", async() => {
                WriteLiteral("Category 3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a15944", async() => {
                WriteLiteral("Category 4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>
                        <!--  Select job items End-->
                        <!-- select-Categories start -->
                        <div class=""select-Categories pt-80 pb-50"">
                            <div class=""small-section-tittle2"">
                                <h4>Experience</h4>
                            </div>
                            <label class=""container"">
                                1-2 Years
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                                2-3 Years
                                <input type=""checkbox"" checked=""checked active"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                   ");
            WriteLiteral(@"             3-6 Years
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                                6-more..
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                        </div>
                        <!-- select-Categories End -->
                    </div>
                    <!-- single three -->
                    <div class=""single-listing"">
                        <!-- select-Categories start -->
                        <div class=""select-Categories pb-50"">
                            <div class=""small-section-tittle2"">
                                <h4>Posted Within</h4>
                            </div>
                            <label class=""container"">
                                Any
    ");
            WriteLiteral(@"                            <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                                Today
                                <input type=""checkbox"" checked=""checked active"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                                Last 2 days
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                                Last 3 days
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
              ");
            WriteLiteral(@"                  Last 5 days
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                            <label class=""container"">
                                Last 10 days
                                <input type=""checkbox"">
                                <span class=""checkmark""></span>
                            </label>
                        </div>
                        <!-- select-Categories End -->
                    </div>
                    <div class=""single-listing"">
                        <!-- Range Slider Start -->
                        <aside class=""left_widgets p_filter_widgets price_rangs_aside sidebar_box_shadow"">
                            <div class=""small-section-tittle2"">
                                <h4>Filter Jobs</h4>
                            </div>
                            <div class=""widgets_inner"">
                                <");
            WriteLiteral("div class=\"range_item\">\r\n                                    <!-- <div id=\"slider-range\"></div> -->\r\n                                    <input type=\"text\" class=\"js-range-slider\"");
            BeginWriteAttribute("value", " value=\"", 9223, "\"", 9231, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                    <div class=""d-flex align-items-center"">
                                        <div class=""price_text"">
                                            <p>Price :</p>
                                        </div>
                                        <div class=""price_value d-flex justify-content-center"">
                                            <input type=""text"" class=""js-input-from"" id=""amount"" readonly />
                                            <span>to</span>
                                            <input type=""text"" class=""js-input-to"" id=""amount"" readonly />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </aside>
                        <!-- Range Slider End -->
                    </div>
                </div>
                <!-- Job Category Listing End -->
            </div>
            <!--");
            WriteLiteral(@" Right content -->
            <div class=""col-xl-9 col-lg-9 col-md-8"">
                <!-- Featured_job_start -->
                <section class=""featured-job-area"">
                    <div class=""container"">
                        <!-- Count of Job list Start -->
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""count-job mb-35"">
                                    <span>39, 782 Jobs found</span>
                                    <!-- Select job items start -->
                                    <div class=""select-job-items"">
                                        <span>Sort by</span>
                                        <select name=""select"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a23644", async() => {
                WriteLiteral("None");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a24846", async() => {
                WriteLiteral("job list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a26052", async() => {
                WriteLiteral("job list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9c9c43bc1ec341f24b7f625ca8051c0f5aa60a27258", async() => {
                WriteLiteral("job list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </select>
                                    </div>
                                    <!--  Select job items End-->
                                </div>
                            </div>
                        </div>
                        <!-- Count of Job list End -->
                        <!-- single-job-content -->
");
#nullable restore
#line 227 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""single-job-items mb-30"">
                                <div class=""job-items"" style="" overflow: hidden; text-overflow: ellipsis;"">
                                    <div class=""company-img"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 12078, "\"", 12141, 1);
#nullable restore
#line 232 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
WriteAttributeValue("", 12085, Url.Action("Details", "Posting",new{id=item.PostingID}), 12085, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img");
            BeginWriteAttribute("src", " src=\"", 12148, "\"", 12164, 1);
#nullable restore
#line 232 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
WriteAttributeValue("", 12154, item.Logo, 12154, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 12165, "\"", 12171, 0);
            EndWriteAttribute();
            WriteLiteral(@"}""></a>
                                    </div>
                                    <div class=""job-tittle job-tittle2"" style=""text-overflow:ellipsis"">
                                        <a href=""#"">
                                            <h4>");
#nullable restore
#line 236 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                                           Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        </a>\r\n                                        <ul>\r\n                                            <li>");
#nullable restore
#line 239 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                                           Write(item.CategoriesName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li><i class=\"fas fa-map-marker-alt\"></i>");
#nullable restore
#line 240 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                                                                                Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li>");
#nullable restore
#line 241 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                                           Write(item.Wage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li style=\" white-space: nowrap; overflow: hidden; text-overflow: ellipsis; max-width: 200px;\">");
#nullable restore
#line 242 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"
                                                                                                                                      Write(item.ExperienceRequired);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                    </div>\r\n                                </div>\r\n                              \r\n                            </div>\r\n");
#nullable restore
#line 248 "C:\Users\Admin\Desktop\ass2\OnlineJobSearch\OnlineJob\Views\Posting\Job.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>
                </section>
                <!-- Featured_job_end -->
            </div>
        </div>
    </div>
</div>
<!-- Job List Area End -->
<!--Pagination Start  -->
<div class=""pagination-area pb-115 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-12"">
                <div class=""single-wrap d-flex justify-content-center"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination justify-content-start"">
                            <li class=""page-item active""><a class=""page-link"" href=""#"">01</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">02</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">03</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#""><span class=""ti-angle-right""></span></a></li>
                        </ul>
               ");
            WriteLiteral("     </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineJob.Models.Posting>> Html { get; private set; }
    }
}
#pragma warning restore 1591
