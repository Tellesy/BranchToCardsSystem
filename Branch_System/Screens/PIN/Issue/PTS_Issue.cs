using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CTS.Database;

namespace CTS.Screens.PTS.Issue
{
    public partial class PTS_Issue : Form
    {
        public PTS_Issue()
        {
            InitializeComponent();
        }

        List<Country> CountriesWithPhoneCode;
        List<Country> CountriesWithISOCode;


        private void PTS_Issue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cTS_PTS_Programs.PTS_Program' table. You can move, or remove it, as needed.
            this.pTS_ProgramTableAdapter.Fill(this.cTS_PTS_Programs.PTS_Program);
            //Test

            CountriesWithPhoneCode =  CountryInfo.getCountriesWithPhoneCode();
            CountriesWithISOCode = CountryInfo.getCountriesWithISOCode();

            for(int i =0;i< CountriesWithPhoneCode.Count; i++)
            {
                CountryPhoneCode_CBox.Items.Insert(i, CountriesWithPhoneCode[i].name + " " + CountriesWithPhoneCode[i].code);
            }

            for (int i = 0; i < CountriesWithISOCode.Count; i++)
            {
                Nationality_CBOX.Items.Insert(i, CountriesWithISOCode[i].name + " " + CountriesWithISOCode[i].isoCode);
            }


        }
    }
}
