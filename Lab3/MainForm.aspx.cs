using System;
using System.Collections.Generic;
using System.Linq;
using static Lab3.Structure;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("AutorisationForm.aspx");
            if (!(IsPostBack || IsCrossPagePostBack))
            {
                var DataDir = Server.MapPath(@"~/Hospital/");
                loadData(DataDir);
                data_doctors.DataSource = Doctors.Values
                    .Select(doctor => new { Прізвище = doctor.last_name, Відділення = doctor.department });
                data_doctors.DataBind();
                data_patients.DataSource = Patients.Values
                    .Select(patient => new { Прізвище = patient.last_name, Діагноз = patient.diagnosis, Лікар = patient.doctor_name, Дата = patient.date.ToShortDateString() });
                data_patients.DataBind();
            }

            //Список відділень
            foreach (var elem in Doctors)
            {
                ListItem item = depart.Items.FindByText(elem.Value.department);
                if (item == null)
                {
                    depart.Items.Add(elem.Value.department);
                }
            }

            //Список років
            foreach (var elem in Patients)
            {
                ListItem item = year.Items.FindByText(elem.Value.date.Year.ToString());
                if (item == null)
                {
                    year.Items.Add(elem.Value.date.Year.ToString());
                }
            }
        }

        protected void Task1_Click(object sender, EventArgs e)
        {
            Session["dep"] = depart.SelectedValue.ToString();
            Session["year"] = year.SelectedValue.ToString();
            task1.Text = depart.SelectedValue;
            Response.Redirect("TaskOne.aspx");
        }

        protected void Task2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TaskTwo.aspx");
        }
    }
}