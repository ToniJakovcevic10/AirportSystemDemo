#pragma checksum "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12e8789fe9860754ad3f4e7f8440b5a2479d00ac"
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
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using ValidationModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PassengerList")]
    public partial class PassengerList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>PassengerList</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-success");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
                                                        OpenAddPassenger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "<span class=\"oi oi-plus\"></span>\r\n    Add Passenger\r\n");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
 if(Passengers==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Loading ...</p>");
#nullable restore
#line 14 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddMarkupContent(8, "<thead><tr><th>Name</th>\r\n                <th>Surname</th>\r\n                <th>Gender</th></tr></thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 26 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
             foreach(var passenger in Passengers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
#nullable restore
#line 29 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
__builder.AddContent(12, passenger.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 30 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
__builder.AddContent(15, passenger.Surname);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 31 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
__builder.AddContent(18, passenger.Gender);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/EditPassenger/" + (
#nullable restore
#line 33 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
                                                 passenger.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddMarkupContent(24, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n                         ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
                                                                                () => DeletePassenger(passenger.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<FlightManagementBlazorServer.Pages.ConfirmationDialog>(31);
            __builder.AddAttribute(32, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 49 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
                                                                          OnDeleteConfirmationSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(33, "Question", "Delete Passenger?");
            __builder.AddComponentReferenceCapture(34, (__value) => {
#nullable restore
#line 49 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
                          DeleteConfirmationDialog = (FlightManagementBlazorServer.Pages.ConfirmationDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\PassengerList.razor"
       
    private List<Passenger> Passengers{get;set;}
    public ConfirmationDialog DeleteConfirmationDialog{ get; set; }
    public int SelectedPassengerId{ get; set; }

    protected override async Task OnInitializedAsync()
    {
        Passengers = await _passengerService.GetPassengers();
    }

    private void OpenAddPassenger()
    {
        _navigationManager.NavigateTo("/AddPassenger");
    }

    private async Task DeletePassenger(int passengerId)
    {
        SelectedPassengerId = passengerId;
        DeleteConfirmationDialog.Show();
    }

    private async Task OnDeleteConfirmationSelected(bool isDeleteConfirmed)
    {
        if(isDeleteConfirmed)
        {
            await _passengerService.DeletePassenger(SelectedPassengerId);
            Passengers = await _passengerService.GetPassengers();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PassengerService _passengerService { get; set; }
    }
}
#pragma warning restore 1591