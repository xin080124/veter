using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialTime();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //            DateTime t = DateTime.Now;
            //           textBox1.Text = t.AddDays(-2).ToString();
            int dateInOneYear = 365;
            DateTime aDate = dateTimePicker1.Value;
            DateTime bDate = aDate.AddDays(dateInOneYear - 1);
            if (DateTime.IsLeapYear(aDate.Year))
            {
                if ((aDate.Month == 2) && (aDate.Day == 29))
                {
                    bDate = bDate.AddDays(1);
                }
                else if(aDate.Month<=2) //add 2.29
                    bDate = bDate.AddDays(1);
            }
            else if (DateTime.IsLeapYear(bDate.Year))
            {
                if ((bDate.Month == 2) && (bDate.Day == 28))//so adate is 3.1
                {
                    bDate = bDate.AddDays(1);//in leap year, the day before 3.1 is 2.29
                }
                else if (bDate.Month > 2) //add 2.29
                    bDate = bDate.AddDays(1);
            }
                dateTimePicker2.Value = bDate;

          
            //txtDay.Text = bDate.Day.ToString();
            //label3.Text = bDate.ToString();
        }

        private DateTime FindNextSunday(DateTime aDate)
        {
            DateTime d;
            if (aDate.DayOfWeek == System.DayOfWeek.Sunday)
                d = aDate.AddDays(7);
            else
                d = aDate.AddDays((7-Convert.ToDouble(aDate.DayOfWeek)));

            int day = d.Day;
            int month = d.Month;
            int year = d.Year;

            d= new DateTime(year, month, day);
            return d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selector1_time = dateTimePicker1.Value;
            DateTime nextSunday = FindNextSunday(selector1_time);
            textBox1.Text = nextSunday.ToString("dd MMM yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            DateTime s;
            string sundaystr = "";
            while (d < dateTimePicker2.Value.AddDays(-7))
            {
                s = FindNextSunday(d);
                sundaystr += "\r\n"+s.ToString("dd MMM yyyy");
                d = s; 
            }
            textBox1.Text = sundaystr;
        }
        
        private void initialTime()
        {
            //DateTime aDate = DateTime.Now;
            DateTime bDate = (dateTimePicker1.Value).AddDays(364);
            dateTimePicker2.Value = bDate;
        }
        

    }
}
