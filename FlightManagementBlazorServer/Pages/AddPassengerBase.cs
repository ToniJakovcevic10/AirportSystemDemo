using DomainModel.Models;
using FlightManagementBlazorServer.Services;
using FlightManagementBlazorServer.ValidationModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class AddPassengerBase : ComponentBase
    {
        public Passenger Passenger { get; set; }
        [Inject]
        protected PassengerService _passengerService { get; set; }
        [Inject]
        protected NavigationManager _navigationManager { get; set; }
        public NotificationDialog NotificationDialog { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
        public String ConcatenatedValidationErrors { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Passenger = new Passenger();
        }
        protected async Task AddPassengerAsync()
        {
            ValidationErrors = ValidatePassenger();
            if (ValidationErrors.Any())
            {
                ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
                NotificationDialog.Show();
            }
            else
            {
                await _passengerService.AddPassenger(Passenger);
                Close();
            }

        }

        protected void Close()
        {
            _navigationManager.NavigateTo("/PassengerList");
        }

        protected List<ValidationError> ValidatePassenger()
        {
            var validationErrors = new List<ValidationError>();

            if (String.IsNullOrWhiteSpace(Passenger.Name))
                validationErrors.Add(new ValidationError { Description = "Please insert Passenger Name!" });

            if (String.IsNullOrWhiteSpace(Passenger.Surname))
                validationErrors.Add(new ValidationError { Description = "Please insert Passenger Surname!" });

            if (Passenger.Gender == null)
                validationErrors.Add(new ValidationError { Description = "Please select Gender!" });


            return validationErrors;
        }

        protected string GetConcatenatedValidationErrors(List<ValidationError> ValidationErrors)
        {
            StringBuilder message = new StringBuilder();
            foreach (var error in ValidationErrors)
            {
                if (message.Length == 0)
                    message.Append(error.Description);
                else
                    message.Append($"{Environment.NewLine} {error.Description}");

            }
            return message.ToString();
        }
    }
}
