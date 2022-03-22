using DomainModel.Models;
using FlightManagementBlazorServer.Services;
using FlightManagementBlazorServer.ValidationModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagementBlazorServer.Pages
{
    public class LoginPageBase : ComponentBase
    {
        public string username, password;
        protected List<User> Users { get; set; }
        [Inject]
        protected UserService _userService { get; set; }
        [Inject]
        protected NavigationManager _navigationManager { get; set; }
        [Inject]
        protected AppState _appState { get; set; }

        public ConfirmationDialog confirmationDialog { get; set; }
        public NotificationDialog WrongAuthorizationLogin { get; set; }
        public List<ValidationError> ValidationErrors { get; set; }
        public String ConcatenatedValidationErrors { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Users = await _userService.GetUsers();
        }

        protected async void AuthorizeLogin()
        {
            var user = await _userService.GetUserByUserName(username, password);
            if (user == null)
            {
                ValidationErrors = Message(false);
                ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
                WrongAuthorizationLogin.Show();
            }
            else
            {
                _appState.Role = user.RoleId;
                ValidationErrors = Message(true);
                ConcatenatedValidationErrors = GetConcatenatedValidationErrors(ValidationErrors);
                confirmationDialog.Show();
            }
        }

        protected void Close()
        {
            _navigationManager.NavigateTo("/");
        }
        protected List<ValidationError> Message(bool successful)
        {
            var validationErrors = new List<ValidationError>();

            if (successful == true)
                validationErrors.Add(new ValidationError { Description = "Successful login!" });
            else
                validationErrors.Add(new ValidationError { Description = "Wrong Authorization!" });

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
        protected void OnConfirmationSelected(bool isConfirmed)
        {
            if (isConfirmed == true)
                Close();
        }
    }
}
