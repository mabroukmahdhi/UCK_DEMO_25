//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Components;
//using UCK.Web.Models.Foundations.Attendees;
//using UCK.Web.Services.Foundations.Attendees;

//namespace UCK.Web.Views.Components.Attendees
//{
//    public partial class AttendeesComponent : ComponentBase
//    {
//        [Inject]
//        public IAttendeeService AttendeeService { get; set; }

//        private List<Attendee> attendees;

//        protected override async Task OnInitializedAsync()
//        {
//            attendees =
//                await AttendeeService.RetrieveAllAttendeesAsync();
//        }
//    }
//}