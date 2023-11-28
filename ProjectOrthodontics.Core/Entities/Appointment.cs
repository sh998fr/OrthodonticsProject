namespace ProjectOrthodontics.Core.Entities
{
    public class Appointment
    {
        public int CodeA { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentStartTime { get; set; }
        public DateTime AppointmentDuration { get; set; }

        public string AppointmentName { get; set; }
        public int Documenting { get; set; }
        public int SerialNumber { get; set; }
    }
}
