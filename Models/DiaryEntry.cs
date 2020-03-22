using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoodAid.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        private DateTime time;
        private string activity;
        private decimal temperature;

        public DateTime Time
        {
            get { return time; }
            set 
            {
                try
                {
                    time = value;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"The following error happened: {ex.Message}");
                }
            }
        }


        public string Activity
        {
            get { return activity; }
            set 
            { 
                try
                {
                    activity = value;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"The following error happened: {ex.Message}");
                }
            }
        }



        public decimal Temperature
        {
            get { return temperature; }
            set 
            { 
                try
                {
                    temperature = value;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"The following error happened: {ex.Message}");
                }
            }
        }

        public bool Husten { get; set; }
        public bool Kurzatmigkeit { get; set; }
        public bool Atemnot { get; set; }
        public bool Gliederschmerzen { get; set; }
        public bool Durchfall { get; set; }
        public bool GeruchssinnVerlust { get; set; }
        public bool Muedigkeit { get; set; }

        public List<ContactPerson> Contacts { get; set; }

    }
}
