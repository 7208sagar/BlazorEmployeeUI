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
