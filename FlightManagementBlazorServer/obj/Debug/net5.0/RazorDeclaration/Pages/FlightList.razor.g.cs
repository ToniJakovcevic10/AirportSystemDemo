// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class FlightList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\FlightList.razor"
       
    private List<Flight> Flights;
    public ConfirmationDialog DeleteConfirmationDialog{ get; set; }
    public ConfirmationDialog ArchiveConfirmationDialog{ get; set; }
    public int SelectedFlightId{ get; set; }
    protected override async Task OnInitializedAsync()
    {
        Flights = await _flightService.GetFlights();
    }
    private void OpenAddFlightPage()
    {
        _navigationManager.NavigateTo("/AddFlight");
    }

    private async Task DeleteFlight(int flightId)
    {
        SelectedFlightId = flightId;
        DeleteConfirmationDialog.Show();
    }

    private async Task OnDeleteConfirmationSelected(bool isDeleteConfirmed)
    {
        if(isDeleteConfirmed)
        {
            await _flightService.DeleteFlight(SelectedFlightId);
            Flights = await _flightService.GetFlights();
        }
    }

    private async Task OnArchiveConfirmationSelected(bool isArchiveConfirmed)
    {
        if(isArchiveConfirmed)
        {
            await _flightService.ArchiveFlight(SelectedFlightId);
            Flights = await _flightService.GetFlights();
        }
    }
    private async Task ArchiveFlight(int flightId)
    {
        SelectedFlightId = flightId;
        ArchiveConfirmationDialog.Show();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlightService _flightService { get; set; }
    }
}
#pragma warning restore 1591
