#pragma checksum "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\Demo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd4d64d272d0c22f180e0817935c96c5c2347b7d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/EmployeePayroll")]
    public partial class Demo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "en");
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, @"<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;600&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""../css/Employeepayroll.css"">
    <title>Employee payroll form</title>
</head>

");
            __builder.OpenElement(5, "body");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, @"<header class=""header-content header"">
        <div class=""logo-content"">
            <img src=""../assets/images/logo.png"" alt>
            <div>
                <span class=""emp-text"">EMPLOYEE</span><br>
                <span class=""emp-text emp-payroll"">PAYROLL</span><br>
            </div>
        </div>
    </header>
    <br>
    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-content");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "form");
            __builder.AddAttribute(12, "class", "form");
            __builder.AddAttribute(13, "action", "#");
            __builder.AddAttribute(14, "onreset", "resetForm()");
            __builder.AddAttribute(15, "onsubmit", "save()");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<div class=\"form-head\">\r\n                Employee Payroll Form\r\n            </div>\r\n            ");
            __builder.AddMarkupContent(18, @"<div class=""row-content"">
                <label class=""label text"" for=""name"">Name</label>
                <input class=""input"" type=""text"" id=""name"" name=""name"" placeholder=""Your name"" required>
                <error-output class=""text-error"" for=""text""></error-output>
            </div>
            ");
            __builder.AddMarkupContent(19, @"<div class=""row-content"">
                <label class=""label text"" for=""profile"">Profile Image</label>
                <div class=""profile-radio-content"">
                    <label>
                        <input type=""radio"" id=""profile1"" name=""profile"" value=""../assets/profile-images/Ellipse -2.png"">
                        <img class=""profile"" id=""image1"" src=""../assets/profile-images/Ellipse -3.png"">
                    </label>
                    <label>
                        <input type=""radio"" id=""profile2"" name=""profile"" value=""../assets/profile-images/Ellipse -3.png"">
                        <img class=""profile"" id=""image2"" src=""../assets/profile-images/Ellipse 1.png"">
                    </label>
                    <label>
                        <input type=""radio"" id=""profile3"" name=""profile"" value=""../assets/profile-images/Ellipse -7.png"">
                        <img class=""profile"" id=""image3"" src=""../assets/profile-images/Ellipse -8.png"">
                    </label>
                    <label>
                        <input type=""radio"" id=""profile4"" name=""profile"" value=""../assets/profile-images/Ellipse -9.png"">
                        <img class=""profile"" id=""image4"" src=""../assets/profile-images/Ellipse -7.png"">
                    </label>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(20, @"<div class=""row-content"">
                <label class=""label text"" for=""gender"">Gender</label>
                <div>
                    <input type=""radio"" id=""male"" name=""gender"" value=""male"">
                    <label class=""text"" for=""male"">Male</label>
                    <input type=""radio"" id=""female"" name=""gender"" value=""female"">
                    <label class=""text"" for=""female"">Female</label>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(21, @"<div class=""row-content"">
                <label class=""label text"" for=""department"">Department</label>
                <div>
                    <input class=""checkbox"" type=""checkbox"" id=""hr"" name=""department"" value=""HR"">
                    <label class=""text"" for=""hr"">HR</label>
                    <input class=""checkbox"" type=""checkbox"" id=""sales"" name=""department"" value=""Sales"">
                    <label class=""text"" for=""sales"">Sales</label>
                    <input class=""checkbox"" type=""checkbox"" id=""finance"" name=""department"" value=""Finance"">
                    <label class=""text"" for=""finance"">Finance</label>
                    <input class=""checkbox"" type=""checkbox"" id=""engineer"" name=""department"" value=""Engineer"">
                    <label class=""text"" for=""engineer"">Engineer</label>
                    <input class=""checkbox"" type=""checkbox"" id=""others"" name=""department"" value=""Others"">
                    <label class=""text"" for=""others"">Others</label>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(22, @"<div class=""row-content"">
                <label class=""label text"" for=""salary"">Choose Your Salary</label>
                <input class=""input"" type=""range"" name=""salary"" id=""salary"" min=""3000000"" max=""5000000"" step=""100"" value=""4000000"" required>
                <output class=""salary-output"" for=""salary"">4000000</output>
            </div>
            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row-content");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<label class=\"label text\" for=\"startDate\">Start Date</label>\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "id", "date");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "select");
            __builder.AddAttribute(31, "id", "day");
            __builder.AddAttribute(32, "name", "Day");
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "Day");
            __builder.AddContent(36, "Day");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "01");
            __builder.AddContent(40, "01");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "02");
            __builder.AddContent(44, "02");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "03");
            __builder.AddContent(48, "03");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "04");
            __builder.AddContent(52, "04");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "option");
            __builder.AddAttribute(55, "value", "05");
            __builder.AddContent(56, "05");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", "06");
            __builder.AddContent(60, "06");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", "07");
            __builder.AddContent(64, "07");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "08");
            __builder.AddContent(68, "08");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "09");
            __builder.AddContent(72, "09");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "10");
            __builder.AddContent(76, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", "11");
            __builder.AddContent(80, "11");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "option");
            __builder.AddAttribute(83, "value", "12");
            __builder.AddContent(84, "12");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "option");
            __builder.AddAttribute(87, "value", "13");
            __builder.AddContent(88, "13");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                        ");
            __builder.OpenElement(90, "option");
            __builder.AddAttribute(91, "value", "14");
            __builder.AddContent(92, "14");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "option");
            __builder.AddAttribute(95, "value", "15");
            __builder.AddContent(96, "15");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", "16");
            __builder.AddContent(100, "16");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.OpenElement(102, "option");
            __builder.AddAttribute(103, "value", "17");
            __builder.AddContent(104, "17");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "value", "18");
            __builder.AddContent(108, "18");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.OpenElement(110, "option");
            __builder.AddAttribute(111, "value", "19");
            __builder.AddContent(112, "19");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.OpenElement(114, "option");
            __builder.AddAttribute(115, "value", "20");
            __builder.AddContent(116, "20");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.OpenElement(118, "option");
            __builder.AddAttribute(119, "value", "21");
            __builder.AddContent(120, "21");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                        ");
            __builder.OpenElement(122, "option");
            __builder.AddAttribute(123, "value", "22");
            __builder.AddContent(124, "22");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                        ");
            __builder.OpenElement(126, "option");
            __builder.AddAttribute(127, "value", "23");
            __builder.AddContent(128, "23");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "option");
            __builder.AddAttribute(131, "value", "24");
            __builder.AddContent(132, "24");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                        ");
            __builder.OpenElement(134, "option");
            __builder.AddAttribute(135, "value", "25");
            __builder.AddContent(136, "25");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                        ");
            __builder.OpenElement(138, "option");
            __builder.AddAttribute(139, "value", "26");
            __builder.AddContent(140, "26");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                        ");
            __builder.OpenElement(142, "option");
            __builder.AddAttribute(143, "value", "27");
            __builder.AddContent(144, "27");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                        ");
            __builder.OpenElement(146, "option");
            __builder.AddAttribute(147, "value", "28");
            __builder.AddContent(148, "28");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                        ");
            __builder.OpenElement(150, "option");
            __builder.AddAttribute(151, "value", "29");
            __builder.AddContent(152, "29");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                        ");
            __builder.OpenElement(154, "option");
            __builder.AddAttribute(155, "value", "30");
            __builder.AddContent(156, "30");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                        ");
            __builder.OpenElement(158, "option");
            __builder.AddAttribute(159, "value", "31");
            __builder.AddContent(160, "31");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                    ");
            __builder.OpenElement(163, "select");
            __builder.AddAttribute(164, "id", "month");
            __builder.AddAttribute(165, "name", "Month");
            __builder.AddMarkupContent(166, "\r\n                        ");
            __builder.OpenElement(167, "option");
            __builder.AddAttribute(168, "value", "Month");
            __builder.AddContent(169, "Month");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                        ");
            __builder.OpenElement(171, "option");
            __builder.AddAttribute(172, "value", "01");
            __builder.AddContent(173, "January");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                        ");
            __builder.OpenElement(175, "option");
            __builder.AddAttribute(176, "value", "02");
            __builder.AddContent(177, "February");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                        ");
            __builder.OpenElement(179, "option");
            __builder.AddAttribute(180, "value", "03");
            __builder.AddContent(181, "March");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                        ");
            __builder.OpenElement(183, "option");
            __builder.AddAttribute(184, "value", "04");
            __builder.AddContent(185, "April");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                        ");
            __builder.OpenElement(187, "option");
            __builder.AddAttribute(188, "value", "05");
            __builder.AddContent(189, "May");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                        ");
            __builder.OpenElement(191, "option");
            __builder.AddAttribute(192, "value", "06");
            __builder.AddContent(193, "June");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n                        ");
            __builder.OpenElement(195, "option");
            __builder.AddAttribute(196, "value", "07");
            __builder.AddContent(197, "July");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n                        ");
            __builder.OpenElement(199, "option");
            __builder.AddAttribute(200, "value", "08");
            __builder.AddContent(201, "August");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n                        ");
            __builder.OpenElement(203, "option");
            __builder.AddAttribute(204, "value", "09");
            __builder.AddContent(205, "September");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n                        ");
            __builder.OpenElement(207, "option");
            __builder.AddAttribute(208, "value", "10");
            __builder.AddContent(209, "October");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n                        ");
            __builder.OpenElement(211, "option");
            __builder.AddAttribute(212, "value", "11");
            __builder.AddContent(213, "November");
            __builder.CloseElement();
            __builder.AddMarkupContent(214, "\r\n                        ");
            __builder.OpenElement(215, "option");
            __builder.AddAttribute(216, "value", "12");
            __builder.AddContent(217, "December");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n                    ");
            __builder.OpenElement(220, "select");
            __builder.AddAttribute(221, "id", "year");
            __builder.AddAttribute(222, "name", "Year");
            __builder.AddMarkupContent(223, "\r\n                        ");
            __builder.OpenElement(224, "option");
            __builder.AddAttribute(225, "value", "Year");
            __builder.AddContent(226, "Year");
            __builder.CloseElement();
            __builder.AddMarkupContent(227, "\r\n                        ");
            __builder.OpenElement(228, "option");
            __builder.AddAttribute(229, "value", "2021");
            __builder.AddContent(230, "2021");
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n                        ");
            __builder.OpenElement(232, "option");
            __builder.AddAttribute(233, "value", "2020");
            __builder.AddContent(234, "2020");
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\r\n                        ");
            __builder.OpenElement(236, "option");
            __builder.AddAttribute(237, "value", "2019");
            __builder.AddContent(238, "2019");
            __builder.CloseElement();
            __builder.AddMarkupContent(239, "\r\n                        ");
            __builder.OpenElement(240, "option");
            __builder.AddAttribute(241, "value", "2018");
            __builder.AddContent(242, "2018");
            __builder.CloseElement();
            __builder.AddMarkupContent(243, "\r\n                        ");
            __builder.OpenElement(244, "option");
            __builder.AddAttribute(245, "value", "2017");
            __builder.AddContent(246, "2017");
            __builder.CloseElement();
            __builder.AddMarkupContent(247, "\r\n                        ");
            __builder.OpenElement(248, "option");
            __builder.AddAttribute(249, "value", "2016");
            __builder.AddContent(250, "2016");
            __builder.CloseElement();
            __builder.AddMarkupContent(251, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(252, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\r\n                <error-output class=\"date-error\" for=\"text\"></error-output>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(254, "\r\n            ");
            __builder.AddMarkupContent(255, "<div class=\"row-content\">\r\n                <label class=\"label text\" for=\"notes\">Notes</label>\r\n                <textarea id=\"notes\" class=\"input\" name=\"Notes\" style=\"height:100px;\"></textarea>\r\n            </div>\r\n            ");
            __builder.AddMarkupContent(256, @"<div class=""buttonParent"">
                <a href=""./Home.html"" class=""resetButton button cancelButton"">Cancel</a>
                <div class=""submit-reset"">
                    <button type=""submit"" class=""button submitButton"" id=""submitButton"">Submit</button>
                    <button type=""reset"" class=""resetButton button"" id=""resetButton"">Reset</button>
                </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(257, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(258, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(259, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 174 "C:\Users\HP\Desktop\d\BlazorEmployee\BlazorEmployee\Pages\Demo.razor"
       
    //public bool Checksubmit = true;
    //Employee Emp = new Employee();

    //protected void CreateEMP()
    //{
    //    newEmp.Create(Emp);
    //    Navigation.NavigateTo("empwage");
    //}
    //void Cancel()
    //{
    //    Navigation.NavigateTo("empwage");
    //}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591