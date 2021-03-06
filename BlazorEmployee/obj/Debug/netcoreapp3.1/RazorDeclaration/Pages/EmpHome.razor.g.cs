// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\EmpHome.razor"
using BlazorEmployee.model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\EmpHome.razor"
using DataLayer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\EmpHome.razor"
using BlazorEmployee.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\EmpHome.razor"
using ServiceLayer;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Home")]
    public partial class EmpHome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\EmpHome.razor"
       
    List<EmployeeM> empList = new List<EmployeeM>();

    EmployeeM emp = new EmployeeM();

    [Parameter]
    public string CurrentId { get; set; }
    protected override async Task OnInitializedAsync()
    {
        empList = await Task.Run(() => newEmp.GetEmployees());
    }
    void update(string CurrentId)
    {
        navigate.NavigateTo("/updateEmp" + CurrentId);
    }
    void delete(string CurrentId)
    {
        navigate.NavigateTo("/deleteEmp" + CurrentId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeServices newEmp { get; set; }
    }
}
#pragma warning restore 1591
