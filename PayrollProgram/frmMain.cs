using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProgram
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHourlyRate.Text = String.Empty;
            txtHoursWorked.Text = String.Empty;
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {

            decimal WorkedHours = Convert.ToDecimal(txtHoursWorked.Text);
            decimal HrRate = Convert.ToDecimal(txtHourlyRate.Text);
            decimal gross = WorkedHours * HrRate;

            decimal State = gross * .035m;
            decimal Federal = gross * .15m;
            decimal Social = gross * .062m;
            decimal Medi = gross * .029m;

            decimal Net = gross - (State + Federal + Social + Medi);
            //lblDisplay.Text = gross.ToString("Gross Pay: " + gross + System.Environment.NewLine +
                                             //"State Deduction: " + State + System.Environment.NewLine + 
                                            // "Federal Deduction: " + Federal + System.Environment.NewLine +
                                            // "Social Deduction: " + Social + System.Environment.NewLine +
                                            // "Medicare Deduction: " + Medi + System.Environment.NewLine +
                                            // "Net Pay: " + Net);

            lblDisplay.Text = "Gross Pay: " + gross.ToString("c") + System.Environment.NewLine 
                            + "State Deductions: " + State.ToString("c") + System.Environment.NewLine
                            + "Federal Deductions: " + Federal.ToString("c") + System.Environment.NewLine
                            + "Social Security Deductions: " + Social.ToString("c") + System.Environment.NewLine
                            + "Medicare Deductions: " + Medi.ToString("c") + System.Environment.NewLine
                            + "Net Income: " + Net.ToString("c");
        }


    }
}
