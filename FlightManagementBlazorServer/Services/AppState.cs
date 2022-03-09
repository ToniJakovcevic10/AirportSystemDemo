using System;

namespace FlightManagementBlazorServer.Services
{
    public class AppState
    {
        private string _role = "costumer";
        public event Action OnChange;
        
        public string Role
        {
            get { return _role; }
            set
            {
                if(_role != value)
                {
                    _role = value;
                    OnChangeNotifier();
                }
            }
        }
        private void OnChangeNotifier()=> OnChange?.Invoke();
    }
}
