using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectOrthodontics.Core.Entities
{
    public class Doctors
    {
        public string ID { get; set; }
        public string NameD { get; set; }
        public int Specializes { get; set; }//תחום התמחות
        [NotMapped]
        public List<string> days { get; set; }//באלו ימים עובד
        [NotMapped]
        public List<string> hours { get; set; }//באלו שעות עובד
                                              
    }
}
