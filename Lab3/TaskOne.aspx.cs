using System;
using System.Collections.Generic;
using System.Linq;
using static Lab3.Structure;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class TaskOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HashSet<String> pat = new HashSet<string>();
            if (Session["user"] == null)
                Response.Redirect("AutorisationForm.aspx");
            if (!(IsPostBack || IsCrossPagePostBack))
            {
                String depart = Session["dep"].ToString();
                String year = Session["year"].ToString();

                foreach (var patient in Patients)
                {
                    if (year == patient.Value.date.Year.ToString())
                    {
                        foreach (var doctor in Doctors)
                        {
                            if (patient.Value.doctor_name.Equals(doctor.Value.last_name) && depart.Equals(doctor.Value.department))
                            {
                                pat.Add(patient.Value.last_name);
                            }
                        }
                    }
                }

                if (pat.Count > 0)
                {
                    data_patient.DataSource = pat.Select(elem => new
                    {
                        Пацієнти = elem
                    });
                    data_patient.DataBind();
                }
                else
                {
                    ResultLabel.Text = "Пацієнтів цього відділення у цьому році не було";
                }
            }
        }
    }
}