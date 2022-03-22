using DomainModel.Models;
using System;
using FlightManagementBlazorServer.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class FlightListBase : ComponentBase
    {
        public List<Flight> Flights = new List<Flight>();

        protected readonly Action StateHasChanged;
        
        [Inject]
        protected FlightService _flightService { get; set; }
        [Inject]
        protected NavigationManager _navigationManager { get; set; }
        [Inject]
        protected AppState _appState { get; set; }
        protected ConfirmationDialog DeleteConfirmationDialog { get; set; }
        protected ConfirmationDialog ArchiveConfirmationDialog { get; set; }
        public int SelectedFlightId { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Flights = await GetFlightsAsync();
        }
        
        protected override void OnInitialized()
        {
            _appState.OnChange += StateHasChanged;
        }
        public void Dispose()
        {
            _appState.OnChange -= StateHasChanged;
        }
        protected void OpenAddFlightPage()
        {
            _navigationManager.NavigateTo("/AddFlight");
        }

        protected async Task DeleteFlight(int flightId)
        {
            SelectedFlightId = flightId;
            DeleteConfirmationDialog.Show();
        }

        protected async Task OnDeleteConfirmationSelected(bool isDeleteConfirmed)
        {
            if (isDeleteConfirmed)
            {
                await _flightService.DeleteFlight(SelectedFlightId);
                Flights = await _flightService.GetFlights();
            }
        }

        protected async Task OnArchiveConfirmationSelected(bool isArchiveConfirmed)
        {
            if (isArchiveConfirmed)
            {
                await _flightService.ArchiveFlight(SelectedFlightId);
                Flights = await _flightService.GetFlights();
            }
        }
        protected async Task ArchiveFlight(int flightId)
        {
            SelectedFlightId = flightId;
            ArchiveConfirmationDialog.Show();
        }
        protected async Task<List<Flight>> GetFlightsAsync()
        {
            return await _flightService.GetFlights();
        }
    }
}
