#pragma checksum "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb7e9063668b4c75a80691f67f3c2749c5df000"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorEmployee.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using BlazorEmployee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\_Imports.razor"
using BlazorEmployee.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
using BlazorEmployee.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
using DataLayer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
using BlazorEmployee.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
using ServiceLayer;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Delete/{EmpID}")]
    public partial class DeleteEmp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
                          emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
                                          Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "mainbox");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.AddMarkupContent(10, "<div class=\"emplogo\">\r\n                    <img class=\"logoimg\" src=\"./Assets/images/logo.png\">\r\n                    <p class=\"header\"><b>Employee Payroll</b></p>\r\n                </div>\r\n                ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "box");
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "content");
                __builder2.AddMarkupContent(16, "\r\n                        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "body11");
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.AddMarkupContent(20, "<h4>\r\n                                Do you want to delete this employee??\r\n                            </h4>\r\n                            ");
                __builder2.OpenElement(21, "table");
                __builder2.AddAttribute(22, "class", "table");
                __builder2.AddMarkupContent(23, "\r\n                                ");
                __builder2.OpenElement(24, "tr");
                __builder2.AddMarkupContent(25, "\r\n                                    ");
                __builder2.AddMarkupContent(26, "<td>EmployeeID</td>\r\n                                    ");
                __builder2.OpenElement(27, "td");
                __builder2.AddContent(28, 
#nullable restore
#line 35 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
                                         emp._id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                                ");
                __builder2.OpenElement(31, "tr");
                __builder2.AddMarkupContent(32, "\r\n                                    ");
                __builder2.AddMarkupContent(33, "<td>Name</td>\r\n                                    ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 39 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
                                         emp.EmpName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                ");
                __builder2.OpenElement(38, "tr");
                __builder2.AddMarkupContent(39, "\r\n                                    ");
                __builder2.AddMarkupContent(40, "<td>Profile Image</td>\r\n                                    ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 43 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
                                         emp.ProfileImage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                                ");
                __builder2.OpenElement(45, "tr");
                __builder2.AddMarkupContent(46, "\r\n                                    ");
                __builder2.AddMarkupContent(47, "<td>Department</td>\r\n                                    ");
                __builder2.OpenElement(48, "td");
                __builder2.AddContent(49, 
#nullable restore
#line 47 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
                                         emp.Department

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                                ");
                __builder2.OpenElement(52, "tr");
                __builder2.AddMarkupContent(53, "\r\n                                    ");
                __builder2.AddMarkupContent(54, "<td>Notes</td>\r\n                                    ");
                __builder2.OpenElement(55, "td");
                __builder2.AddContent(56, 
#nullable restore
#line 51 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
                                         emp.Notes

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                        <br>\r\n                        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "btns1");
                __builder2.AddMarkupContent(63, "\r\n                            ");
                __builder2.AddMarkupContent(64, "<button class=\"btn btn-outline-danger\"> Yes </button>\r\n                            ");
                __builder2.OpenElement(65, "button");
                __builder2.AddAttribute(66, "class", "btn btn-outline-warning");
                __builder2.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
                                                                                ()=>Cancle()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(68, " No ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\DeleteEmp.razor"
       
    [Parameter]
    public string EmpId { get; set; }

    EmployeeM emp = new EmployeeM();

    protected void Delete()
    {
        newEmp.Delete(EmpId);
        navigation.NavigateTo("/getempdata");
    }
    protected void Cancle()
    {
        navigation.NavigateTo("/getempdata");
    }
    protected override async Task OnInitializedAsync()
    {
        emp = await Task.Run(() => newEmp.GetEmployee(EmpId));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeServices newEmp { get; set; }
    }
}
#pragma warning restore 1591