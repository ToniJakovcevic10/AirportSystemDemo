#pragma checksum "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerFields.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "631be4362b60d4c6b8a0c0c0ec3ec456dbce9c28"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using ValidationModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Pages;

#line default
#line hidden
#nullable disable
    public partial class PassengerFields : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerFields.razor"
 if(Flights==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading...</p>");
#nullable restore
#line 6 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerFields.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "PassengerFields");
            __builder.AddMarkupContent(3, "<label for=\"PassengerName\">Passenger Number</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(4);
            __builder.AddAttribute(5, "id", "PassengerName");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerFields.razor"
                                                    Passenger.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Passenger.Name = __value, Passenger.Name))));
            __builder.AddAttribute(9, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Passenger.Name));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n    \r\n        ");
            __builder.AddMarkupContent(11, "<label for=\"PassengerSurname\">Passenger Surname</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
            __builder.AddAttribute(13, "id", "PassengerSurname");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerFields.razor"
                                                       Passenger.Surname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Passenger.Surname = __value, Passenger.Surname))));
            __builder.AddAttribute(17, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Passenger.Surname));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n        \r\n        ");
            __builder.AddMarkupContent(19, "<label for=\"PassengerGender\">Passenger Gender</label>\r\n        ");
            __Blazor.FlightManagementBlazorServer.Pages.PassengerFields.TypeInference.CreateInputSelect_0(__builder, 20, 21, "PassengerGender", 22, "form-control", 23, 
#nullable restore
#line 17 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerFields.razor"
                                                        Passenger.Gender

#line default
#line hidden
#nullable disable
            , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Passenger.Gender = __value, Passenger.Gender)), 25, () => Passenger.Gender, 26, (__builder2) => {
                __builder2.AddMarkupContent(27, "<option value>Select...</option>\r\n            ");
                __builder2.AddMarkupContent(28, "<option value=\"Male\">Male</option>\r\n            ");
                __builder2.AddMarkupContent(29, "<option value=\"Female\">Female</option>\r\n            ");
                __builder2.AddMarkupContent(30, "<option value=\"Unspecified\">Unspecified</option>");
            }
            );
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerFields.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerFields.razor"
       
    [Parameter]
    public Passenger Passenger{ get; set; }

    public List<Flight> Flights{ get; set; }

    protected override async Task OnInitializedAsync()
    {
        Flights = await _flightService.GetFlights(); 
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlightService _flightService { get; set; }
    }
}
namespace __Blazor.FlightManagementBlazorServer.Pages.PassengerFields
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
