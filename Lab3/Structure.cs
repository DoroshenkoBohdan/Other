using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab3
{
    public class Structure
    {

        public class Doctor
        {
            public String last_name { get; set; }
            public String department { get; set; }
        }

        public class Patient
        {
            public String last_name { get; set; }
            public String diagnosis { get; set; }
            public String doctor_name { get; set; }
            public DateTime date { get; set; }

        }

        public static Dictionary<int, Patient> Patients { get; private set; }
        public static Dictionary<int, Doctor> Doctors { get;private set; }

        public static void loadData(string fileDirection)
        {
            Doctors = new Dictionary<int, Doctor>();
            Patients = new Dictionary<int, Patient>();
            int index = 1;
            foreach (var line in File.ReadAllLines(fileDirection + "doctors.txt", Encoding.UTF8))
            {
                var words = Regex.Split(line.Trim(), @"\s+");
                if (words.Length != 2)
                    continue;
                Doctors.Add(index, new Doctor { last_name = words[0], department = words[1] });
                index++;
            }
            index = 1;
            foreach (var line in File.ReadAllLines(fileDirection + "patients.txt"))
            {
                var words = Regex.Split(line.Trim(), @"\s+");
                if (words.Length != 4)
                    continue;
                Patients.Add(index, new Patient { last_name = words[0], diagnosis = words[1], doctor_name = words[2], date = DateTime.Parse(words[3]) });
                index++;
            }
        }

    }

}