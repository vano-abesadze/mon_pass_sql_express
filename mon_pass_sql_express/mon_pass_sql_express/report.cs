using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mon_pass_sql_express
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ReportParameter1", variables.textBox1_Text));
            reportParameters.Add(new ReportParameter("ReportParameter2", variables.textBox2_Text));
            reportParameters.Add(new ReportParameter("ReportParameter3", variables.textBox3_Text));
            reportParameters.Add(new ReportParameter("ReportParameter4", variables.textBox4_Text));
            reportParameters.Add(new ReportParameter("ReportParameter5", variables.textBox5_Text));
            reportParameters.Add(new ReportParameter("ReportParameter7", variables.textBox6_Text));
            reportParameters.Add(new ReportParameter("ReportParameter8", variables.textBox7_Text));
            reportParameters.Add(new ReportParameter("ReportParameter6", variables.numericUpDown1_.ToString()));
            reportParameters.Add(new ReportParameter("ReportParameter9", variables.dateTimePicker_.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
