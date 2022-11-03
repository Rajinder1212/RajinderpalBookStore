using System;

namespace RajinderpalBookStore.Models.ViewModels.ErrorViewModels //added ViewModels annd updated ErrorViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
