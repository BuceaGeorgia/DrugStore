using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public enum Status
    {
        MedicalStaff, Pharmacist, Admin
    }
    [Serializable]
    public class User : INotifyPropertyChanged
    {

        public User() { }
        [Key]
        public int UserID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public Status Status { get; set; }
        public int SectieID { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }

}
