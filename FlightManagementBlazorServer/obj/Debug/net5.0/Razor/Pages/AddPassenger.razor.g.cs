#pragma checksum "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72acde43080da51579048f4fc20873e07985f17f"
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
#nullable restore
#line 2 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPassenger")]
    public partial class AddPassenger : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddPassenger</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor"
                 Passenger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor"
                                            AddPassengerAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<FlightManagementBlazorServer.Pages.PassengerFields>(5);
                __builder2.AddAttribute(6, "Passenger", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DomainModel.Models.Passenger>(
#nullable restore
#line 8 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor"
                                 Passenger

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    <br>\n    ");
                __builder2.AddMarkupContent(8, "<button type=\"submit\" class=\"btn btn-success\"><span class=\"oi oi-pencil\"></span>\n        Add Passenger\n    </button>\n\n    ");
                __builder2.OpenElement(9, "button");
                __builder2.AddAttribute(10, "type", "button");
                __builder2.AddAttribute(11, "class", "btn btn-secondary");
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor"
                                                              Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(13, "<span class=\"oi oi-media-skip-backward\"></span>\n        Close\n    ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenComponent<FlightManagementBlazorServer.Pages.NotificationDialog>(15);
            __builder.AddAttribute(16, "Description", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor"
                                                            ConcatenatedValidationErrors

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(17, (__value) => {
#nullable restore
#line 22 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor"
                          NotificationDialog = (FlightManagementBlazorServer.Pages.NotificationDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Toni\Desktop\FESB\EDIT_junDev\ZavrsniProjekt\AirportSystem-main\FlightManagementBlazorServer\Pages\AddPassenger.razor"
       
    public Passenger Passenger { get; set; }
    public NotificationDialog NotificationDialog{ get; set; }
    public List<ValidationError> ValidationErrors{ get; set; }
    public String ConcatenatedValidationErrors{ get; set; }
    protected override async Task OnInitializedAsync()
    {
        Passenger = new Passenger();
    }     
    private async Task AddPassengerAsync()
    {
        ValidationErrors = ValidatePassenger();
        if(ValidationErrors.Any())
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

    private void Close()
    {
        _navigationManager.NavigateTo("/PassengerList");
    }  

    private List<ValidationError> ValidatePassenger()
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

    private string GetConcatenatedValidationErrors(List<ValidationError> ValidationErrors)
    {
        StringBuilder message = new StringBuilder();
        foreach(var error in ValidationErrors)
        {
            if (message.Length == 0)
                message.Append(error.Description);
            else
                message.Append($"{Environment.NewLine} {error.Description}");

        }
        return message.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PassengerService _passengerService { get; set; }
    }
}
#pragma warning restore 1591