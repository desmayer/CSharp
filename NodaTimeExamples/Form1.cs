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
        public CultureInfo culture = new CultureInfo("en-GB");
        public DateTimeZone timeZone = DateTimeZoneProviders.Tzdb["Europe/London"];
        public Instant now = SystemClock.Instance.GetCurrentInstant();
        public Form1()
        {
            InitializeComponent();
            ZonedDateTime zdt = now.InZone(timeZone);
            ZonedDateTime test = (Instant.FromDateTimeOffset(DateTime.Now)).InZone(timeZone);
            txtNodaTimeInstant.Text = now.ToString();
            
            cmbTimeZone.DataSource = DateTimeZoneProviders.Tzdb.Ids;
            cmbTimeZone.SelectedItem = timeZone.Id;
            cmbCultures.DataSource = TzdbDateTimeZoneSource.Default.ZoneLocations.OrderBy(o=>o.ZoneId).ToList();
            cmbCultures.DisplayMember = "ZoneId";
            cmbCultures.DataSource = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.SpecificCultures).ToList();
            cmbCultures.DisplayMember = "DisplayName";
            cmbCultures.SelectedItem = culture;

            updateFormattedDatetime();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimeZone tz = DateTimeZoneProviders.Tzdb["Europe/London"];
            var appointment = LocalDateTime.FromDateTime(DateTime.Now);
            
            MessageBox.Show(appointment.ToString());
            MessageBox.Show(appointment.InZoneStrictly(tz).ToString());
        }

        private void updateFormattedDatetime()
        {
            txtFormattedDate.Text = now.InZone(timeZone).ToString("dd/MM/yyyy HH:mm:ss", culture);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCultures.SelectedItem is CultureInfo newCulture)
            {
                culture = new CultureInfo(newCulture.Name);
            }
            updateFormattedDatetime();
            //Basic culture info
            txtCultureInfo.Clear();
            txtCultureInfo.Text = culture.Name;
            txtCultureInfo.Text += Environment.NewLine + DateTime.Now.ToString(culture);
            txtCultureInfo.Text += Environment.NewLine + String.Format(culture, "{0:C}", 10.545);
        }

        private void cmbTimeZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeZone = DateTimeZoneProviders.Tzdb[cmbTimeZone.SelectedItem.ToString()];
            updateFormattedDatetime();
            //Convert from a DateTime selection (assuming it is local time) back to Instant for db storage
            //Create a LocalTime using DateTime.Now
            LocalDateTime localDateTime = LocalDateTime.FromDateTime(DateTime.Now);
            ZonedDateTime zonedDateTime = localDateTime.InZoneLeniently(timeZone);
            Instant instant = zonedDateTime.ToInstant();
            txtTimeZoneInfo.Clear();
            txtTimeZoneInfo.Text = "DateTime.Now: " + DateTime.Now.ToString();
            txtTimeZoneInfo.Text += Environment.NewLine;
            txtTimeZoneInfo.Text += Environment.NewLine + "Local Date Time: " + localDateTime.ToString();
            txtTimeZoneInfo.Text += Environment.NewLine + " - LocalDateTime localDateTime = LocalDateTime.FromDateTime(DateTime.Now);";
            txtTimeZoneInfo.Text += Environment.NewLine;
            txtTimeZoneInfo.Text += Environment.NewLine + "Zoned Date Time: " + zonedDateTime.ToString();
            txtTimeZoneInfo.Text += Environment.NewLine + " - ZonedDateTime zonedDateTime = localDateTime.InZoneLeniently(timeZone);";
            txtTimeZoneInfo.Text += Environment.NewLine;
            txtTimeZoneInfo.Text += Environment.NewLine + "Instant: " + instant.ToString();
            txtTimeZoneInfo.Text += Environment.NewLine + " - Instant instant = zonedDateTime.ToInstant();";
        }
    }
}
