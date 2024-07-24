using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Week_4_test.service;

namespace Week_4_test
{
    public partial class CreatesFormula : Form
    {
        XmlService xmlService;
        public CreatesFormula()
        {
            InitializeComponent();
            xmlService = new XmlService();
            Start();
        }
        private void Start()
        {
            comboBoxDaysInWeek.Text = "לחץ כדי לבחור";
            comboBoxDayInMonth.Text = "לחץ כדי לבחור";
            comboBoxMonth.Text = "לחץ כדי לבחור";
            comboBoxYears.Text = "לחץ כדי לבחור";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string DaysInWeek = comboBoxDaysInWeek.Text;
            string DayInMonth = comboBoxDayInMonth.Text;
            string Month = comboBoxMonth.Text;
            string Year = comboBoxYears.Text;
            if (DaysInWeek == "לחץ כדי לבחור" || DayInMonth == "לחץ כדי לבחור" || Month == "לחץ כדי לבחור" || Year == "לחץ כדי לבחור")
            {
                MessageBox.Show("מלא את כל הפרטים! ");
            }
            else
            {
                string Result = HandlesText.TheWordingDate(DaysInWeek, DayInMonth, Month, Year);
                MessageBox.Show($"הנוסח שהתקבל הוא  {Result}");
                XElement Query = xmlService.CreateXML(DaysInWeek, DayInMonth, Month, Year, Result);
                xmlService.SaveQueryToFile(Query);
                MessageBox.Show("נשמר במערכת בהצלחה");

            }

        }
    }
}
