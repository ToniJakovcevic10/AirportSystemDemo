#pragma checksum "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76c742c3a5acacd89721b7665c4cffae8257cad"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Seat/{FlightId}")]
    public partial class Seatlist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
 if(Seats==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading...</p>");
#nullable restore
#line 9 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Seat List in Flight ");
#nullable restore
#line 12 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
__builder.AddContent(3, FlightId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "type", "button");
            __builder.AddAttribute(6, "class", "btn btn-success");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                                                             OpenAddPassengersToList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "<span class=\"oi oi-plus\"></span>\r\n            Add Passengers\r\n     ");
            __builder.CloseElement();
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-responsive");
            __builder.AddMarkupContent(11, "<thead><tr><th>SeatId</th>\r\n                <th>Name</th>\r\n                <th>Surname</th>\r\n                <th>Gender</th></tr></thead>\r\n       ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 29 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
             foreach(var seat in Seats)
            {
                if(seat.FlightId==int.Parse(FlightId))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
#nullable restore
#line 34 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
__builder.AddContent(15, seat.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 35 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
__builder.AddContent(18, seat.Passenger.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 36 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
__builder.AddContent(21, seat.Passenger.Surname);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 37 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
__builder.AddContent(24, seat.Passenger.Gender);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 39 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                             if(_appState.Role=="Admin")
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                                                                                       () => DeleteSeat(seat.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                             if(_appState.Role=="Admin" || _appState.Role=="CheckIn")
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-secondary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                                                                                          () => CheckInPassenger(seat.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                                    Check In Passenger\r\n                                ");
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<FlightManagementBlazorServer.Pages.NotificationDialog>(37);
            __builder.AddAttribute(38, "Description", "Passenger is already checked in!");
            __builder.AddComponentReferenceCapture(39, (__value) => {
#nullable restore
#line 58 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
                          notificationDialog = (FlightManagementBlazorServer.Pages.NotificationDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\Seatlist.razor"
       
    [Parameter]
    public string FlightId{ get; set; }
    private Seat seatToCheckIn = new Seat();
    public NotificationDialog notificationDialog{ get; set; }

    private List<Seat> Seats{get;set;}

    protected override async Task OnInitializedAsync()
    {
        Seats = await _seatService.GetSeats(int.Parse(FlightId));
    }
    private void OpenAddPassengersToList()
    {
        _navigationManager.NavigateTo($"/AddPassengersToSeat/{FlightId}");
    }

    private async Task CheckInPassenger(int seatId)
    {
        seatToCheckIn = await _seatService.GetSeatAsync(int.Parse(FlightId), seatId);
        if(seatToCheckIn.SeatNumber==null)
        {
            _navigationManager.NavigateTo($"/EditSeat/{FlightId}/{seatId}");
        }
        else
        {
            notificationDialog.Show(); 
        }
    }
    private async Task DeleteSeat(int seatId)
    {
        await _seatService.DeleteSeat(seatId);
        Seats = await _seatService.GetSeats(int.Parse(FlightId));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState _appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SeatService _seatService { get; set; }
    }
}
#pragma warning restore 1591