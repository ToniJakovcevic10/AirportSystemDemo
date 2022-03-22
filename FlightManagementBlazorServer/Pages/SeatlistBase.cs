using DomainModel.Models;
using FlightManagementBlazorServer.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class SeatlistBase : ComponentBase
    {
        [Parameter]
        public string FlightId { get; set; }
        [Inject]
        protected SeatService _seatService { get; set; }
        [Inject]
        protected NavigationManager _navigationManager { get; set; }
        [Inject]
        protected AppState _appState { get; set; }

        protected Seat seatToCheckIn = new Seat();
        public NotificationDialog notificationDialog { get; set; }

        protected List<Seat> Seats { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Seats = await _seatService.GetSeats(int.Parse(FlightId));
        }
        protected override void OnInitialized()
        {
            _appState.OnChange += StateHasChanged;
        }
        public void Dispose()
        {
            _appState.OnChange -= StateHasChanged;
        }
        protected void OpenAddPassengersToList()
        {
            _navigationManager.NavigateTo($"/AddPassengersToSeat/{FlightId}");
        }

        protected async Task CheckInPassenger(int seatId)
        {
            seatToCheckIn = await _seatService.GetSeatAsync(int.Parse(FlightId), seatId);
            if (seatToCheckIn.SeatNumber == null)
            {
                _navigationManager.NavigateTo($"/EditSeat/{FlightId}/{seatId}");
            }
            else
            {
                notificationDialog.Show();
            }
        }
        protected async Task DeleteSeat(int seatId)
        {
            await _seatService.DeleteSeat(seatId);
            Seats = await _seatService.GetSeats(int.Parse(FlightId));
        }
        protected void Close()
        {
            _navigationManager.NavigateTo("/");
        }
    }
}
