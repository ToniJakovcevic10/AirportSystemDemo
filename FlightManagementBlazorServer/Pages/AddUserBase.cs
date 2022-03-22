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
    public class AddUserBase : ComponentBase
    {
        public User User { get; set; }

        [Inject]
        protected UserService _userService { get; set; }

        [Inject]
        protected NavigationManager _navigationManager { get; set; }
        protected NotificationDialog NotificationDialog { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
        public String ConcatenatedValidationErrors { get; set; }

        protected override async Task OnInitializedAsync()
        {
            User = new User();
        }

        protected async Task AddUserAsync()
        {
            ValidationErrors = ValidateUser();
            if (ValidationErrors.Any())
            {
                ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
                NotificationDialog.Show();
            }
            else
            {
                await _userService.AddUserAsync(User);
                Close();
            }
        }

        protected void Close()
        {
            _navigationManager.NavigateTo("/UserList");
        }

        protected List<ValidationError> ValidateUser()
        {
            var validationErrors = new List<ValidationError>();
            if (String.IsNullOrWhiteSpace(User.UserName))
                validationErrors.Add(new ValidationError { Description = "Please insert username!" });

            if (String.IsNullOrWhiteSpace(User.Password))
                validationErrors.Add(new ValidationError { Description = "Please insert Password!" });

            if (String.IsNullOrWhiteSpace(User.RoleId))
                validationErrors.Add(new ValidationError { Description = "Please insert Role!" });

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
