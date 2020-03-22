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

        //public List<Symptom> Symptoms { get; set; }

        private List<Symptom> symptoms;

        public List<Symptom> Symptoms
        {
            get { return symptoms; }
            set 
            { 
                symptoms = value; 
            }
        }

        public List<ContactPerson> Contacts { get; set; }

    }
}
