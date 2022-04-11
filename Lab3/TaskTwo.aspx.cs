using System;
using System.Collections.Generic;
using System.Linq;
using static Lab3.Structure;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class TaskTwo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
                Response.Redirect("AutorisationForm.aspx");
            if (!(IsPostBack || IsCrossPagePostBack))   
            {
                int sum = 0;
                HashSet<String> dep = new HashSet<string>();
                Dictionary<String, String> count = new Dictionary<string, string>();
                HashSet<String> diagnoz = new HashSet<string>();
                foreach (var elem in Patients)
                {
                    if (!diagnoz.Contains(elem.Value.diagnosis))
                    {
                        diagnoz.Add(elem.Value.diagnosis);
                    }
                }

                foreach (var elem in diagnoz)
                {
                    foreach (var pat in Patients)
                    {
                        if (elem.Equals(pat.Value.diagnosis))
                        {
                            foreach (var doc in Doctors)
                            {
                                if (pat.Value.doctor_name.Equals(doc.Value.last_name))
                                {
                                    if (!dep.Contains(doc.Value.department))
                                    {
                                        dep.Add(doc.Value.department);
                                        sum++;
                                    }
                                }
                            }
                        }
                    }

                    count.Add(elem, sum.ToString());
                    dep.Clear();
                    sum = 0;
                }


                task2_result.DataSource = count.Select(elem => new
                {
                    Діагноз = elem.Key,
                    Кількість = elem.Value
                }); ;
                task2_result.DataBind();
            }
           // task2_result.Sort("Діагноз", SortDirection.Ascending);
        }
    }
}