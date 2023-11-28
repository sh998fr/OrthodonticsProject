namespace ProjectOrthodontics.Core.Entities
{
    public class Doctors
    {
        public string IdD { get; set; }
        public string NameD { get; set; }
        public int Specializes { get; set; }//תחום התמחות

        public List<string> days { get; set; }//באלו ימים עובד
        public List<string> hours { get; set; }//באלו שעות עובד
                                              
    }
}
