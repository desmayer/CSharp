using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NodaTime;
using NodaTime.Text;
using NodaTime.TimeZones;

namespace NodaTimeExamples
{
    public partial class Form1 : Form
    {
        public DateTimeZone datetimeZone;
        public CultureInfo culture;
        public CultureInfo defaultCulture = new CultureInfo("en-GB");
        public Form1()
        {
            ReadOnlyCollection<TimeZoneInfo> timezones;
            timezones = TimeZoneInfo.GetSystemTimeZones();
            InitializeComponent();
            Instant i2 = Instant.FromDateTimeOffset(DateTime.Now);
            Instant now = SystemClock.Instance.GetCurrentInstant();
            DateTimeZone tz = DateTimeZoneProviders.Tzdb["Europe/London"];
            ZonedDateTime zdt = now.InZone(tz);
            //This will be the best way to display a datetime?
            ZonedDateTime test = (Instant.FromDateTimeOffset(DateTime.Now)).InZone(tz);
            txtDate.Text = now.InUtc().ToString();
            txtDateTimeNow.Text = test.ToString();
            //comboBox1.DataSource = TzdbDateTimeZoneSource.Default
            //    .ZoneLocations.OrderBy(t => t.ZoneId)
            //    .ToList();
            //comboBox1.DisplayMember = "ZoneId";
            var zonesss = TzdbDateTimeZoneSource.Default.Aliases.ToList();
            comboBox1.DataSource = TzdbDateTimeZoneSource.Default.ZoneLocations.OrderBy(o=>o.ZoneId).ToList();
            comboBox1.DisplayMember = "ZoneId";
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.SpecificCultures);
            comboBox1.DataSource = cultures.ToList();
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.SelectedItem = defaultCulture;

            

            txtInstant.Text = "Instant: " + now.ToString() + Environment.NewLine;
            txtInstant.Text += "ZonedDateTime: " + now.InUtc().ToString() + Environment.NewLine;
            txtInstant.Text += "Time Zone: " + tz.Id.ToString() + Environment.NewLine;
            txtInstant.Text += "Local Time: " + now.InZone(tz).ToString() + Environment.NewLine;
            txtInstant.Text += "Offset: " + tz.MaxOffset.ToString() + Environment.NewLine;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimeZone tz = DateTimeZoneProviders.Tzdb["Europe/London"];
            var appointment = LocalDateTime.FromDateTime(DateTime.Now);
            
            MessageBox.Show(appointment.ToString());
            MessageBox.Show(appointment.InZoneStrictly(tz).ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DateTimeZone tz = DateTimeZoneProviders.Tzdb[time_zone.StandardName];
            if (comboBox1.SelectedItem is CultureInfo culture)
            {
                //store the LCID in the database
                culture = new CultureInfo(culture.Name);
                textBox1.Text = culture.DisplayName;
                textBox1.Text += Environment.NewLine + culture.Name;
                textBox1.Text += Environment.NewLine + DateTime.Now.ToString(culture);
                textBox1.Text += Environment.NewLine + String.Format(culture, "{0:C}", 10.545);
                ///-----
                // This gets an instant from stored time
                LocalDateTime localDateTime = LocalDateTime.FromDateTime(dateTimePicker1.Value);
                var timeZone = DateTimeZoneProviders.Tzdb["Europe/London"];
                var zonedDateTime = localDateTime.InZoneLeniently(timeZone);
                //quicker way of doing it ---VVV--
                timeZone.AtLeniently(localDateTime).ToInstant();
                var instant = zonedDateTime.ToInstant();
                textBox1.Text += Environment.NewLine + "---------------------------------------";
                textBox1.Text += Environment.NewLine + "Local Date Time: " + localDateTime.ToString();
                textBox1.Text += Environment.NewLine + "Zoned Date Time: " + zonedDateTime.ToString();
                textBox1.Text += Environment.NewLine + "Instant: " + instant.ToString();
            }
        }
    }
}
