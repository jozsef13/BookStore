#pragma checksum "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c81b858a2ef75609eaa69145082085d45b2224"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
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
#line 1 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c81b858a2ef75609eaa69145082085d45b2224", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("buy-now btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c81b858a2ef75609eaa69145082085d45b22246454", async() => {
                WriteLiteral(@"
  <div class=""site-wrap"">
    <div class=""site-blocks-cover"" style=""background-image: url(images/background.jpg);"" data-aos=""fade"">
      <div class=""container"">
        <div class=""row align-items-start align-items-md-center justify-content-end"">
          <div class=""col-md-5 text-center text-md-left pt-5 pt-md-0"">
              <h1 style=""color:white;"">William Styron</h1>
            <div class=""intro-text text-center text-md-left"">
                <p style=""color:white;"">“A great book should leave you with many experiences, and slightly exhausted at the end. You live several lives while reading.”</p>
              <p>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c81b858a2ef75609eaa69145082085d45b22247376", async() => {
                    WriteLiteral("Books");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class=""site-section"">
        <h1 style=""text-align:center; color: darkslateblue;"">Latest Books</h1>
        <br />
        <div class=""container"">
            <div class=""row mb-5"">
");
#nullable restore
#line 26 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                 foreach (var element in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-sm-6 col-lg-4 mb-4\" data-aos=\"fade-up\">\n                        <div class=\"block-4 text-center border\">\n                            <figure class=\"block-4-image\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c81b858a2ef75609eaa69145082085d45b22249931", async() => {
                    WriteLiteral("<img style=\"width:500px;height:250px;\"");
                    BeginWriteAttribute("src", " src=\"", 1503, "\"", 1545, 1);
#nullable restore
#line 31 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
WriteAttributeValue("", 1509, Url.Content(element.CoverPhotoPath), 1509, 36, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" alt=\"Image placeholder\" class=\"img-fluid\">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                                                                 WriteLiteral(element.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </figure>\n                            <div class=\"block-4-text p-4\">\n                                <h3>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c81b858a2ef75609eaa69145082085d45b222413126", async() => {
#nullable restore
#line 34 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                                                                                             Write(element.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                                                                     WriteLiteral(element.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</h3>\n                                <h3>");
#nullable restore
#line 35 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                               Write(element.Author.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 35 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                                         Write(element.Author.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n");
#nullable restore
#line 36 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                  
                                    double averageRating = 0;
                                    int sum = 0;
                                    if (element.Reviews.Any())
                                    {
                                        foreach (Review review in element.Reviews)
                                        {
                                            sum += review.Rating;
                                        }

                                        averageRating = sum / element.Reviews.Count();
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p class=\"mb-0 rated\">\n                                        <span>Rating:</span>\n");
#nullable restore
#line 50 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                         if (averageRating == 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
");
#nullable restore
#line 57 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                        }
                                        else if (averageRating >= 1 && averageRating < 2)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
");
#nullable restore
#line 65 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                        }
                                        else if (averageRating >= 2 && averageRating < 3)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
");
#nullable restore
#line 73 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                        }
                                        else if (averageRating >= 3 && averageRating < 4)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star""></span>
                                            <span class=""fa fa-star""></span>
");
#nullable restore
#line 81 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                        }
                                        else if (averageRating >= 4 && averageRating < 5)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star""></span>
");
#nullable restore
#line 89 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                        }
                                        else if (averageRating == 5)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
                                            <span class=""fa fa-star checked""></span>
");
#nullable restore
#line 97 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </p>\n");
                WriteLiteral("                                <p><strong class=\"text-primary h4\">$");
#nullable restore
#line 100 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                                               Write(element.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></p>\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c81b858a2ef75609eaa69145082085d45b222423153", async() => {
                    WriteLiteral(@"
                                    <div class=""input-group mb-3"" style=""max-width: 120px;"">
                                        <input hidden type=""number"" id=""quantity"" name=""quantity"" class=""form-control text-center"" min=""1"" value=""1"" aria-describedby=""button-addon1"" />
                                    </div>
");
#nullable restore
#line 105 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                     if (User.IsInRole("User"))
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <button type=\"submit\" class=\"buy-now btn btn-sm btn-primary\">Add to cart</button>\n");
#nullable restore
#line 108 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                                                                          WriteLiteral(element.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["bookId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["bookId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 110 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                 if (User.IsInRole("Administrator"))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <br />\n                                    <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c81b858a2ef75609eaa69145082085d45b222427505", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                                                                     WriteLiteral(element.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\n");
#nullable restore
#line 114 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 118 "D:\Documents\AUTOMATICA\Anul IV\Semestrul I\Project\Actual Project\BookStore\BookStore\Views\Home\index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </div>

        <div class=""site-section site-section-sm site-blocks-1"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 col-lg-4 d-lg-flex mb-4 mb-lg-0 pl-4"" data-aos=""fade-up"" data-aos-delay="""">
                        <div class=""icon mr-4 align-self-start"">
                            <span class=""icon-truck""></span>
                        </div>
                        <div class=""text"">
                            <h2 class=""text-uppercase"">Free Shipping</h2>
                            <p>You can benefit for free shipping for a short period of time. Grab a book and lay back. We'll deliver it to you for free.</p>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-4 d-lg-flex mb-4 mb-lg-0 pl-4"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""icon mr-4 align-self-start"">
                            <span class=""icon-refresh2""></span>");
                WriteLiteral(@"
                        </div>
                        <div class=""text"">
                            <h2 class=""text-uppercase"">Free Returns</h2>
                            <p>
                                If you don't feel like you want that book anymore, you can return it for free. Keep in mind that the product must be sealed
                                and not damaged.
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-6 col-lg-4 d-lg-flex mb-4 mb-lg-0 pl-4"" data-aos=""fade-up"" data-aos-delay=""200"">
                        <div class=""icon mr-4 align-self-start"">
                            <span class=""icon-help""></span>
                        </div>
                        <div class=""text"">
                            <h2 class=""text-uppercase"">Customer Support</h2>
                            <p>We are here for you! Do you have any question about buying from us? Don't hesitate to contact us at our contact page.</p>");
                WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
