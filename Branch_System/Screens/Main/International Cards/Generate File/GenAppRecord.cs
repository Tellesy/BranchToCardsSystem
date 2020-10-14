using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTS.Database.Objects;
using System.Windows.Forms;
using CTS.FilesCreator;


namespace CTS.Screens.Main.International_Cards.Generate_File
{
    public partial class GenAppRecord : Form
    {
        public GenAppRecord()
        {
            InitializeComponent();
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenAllAppFiles_BTN_Click(object sender, EventArgs e)
        {
            PTSAppRecord record = new PTSAppRecord();

            record.ApplicationSubType = 'P';
            record.ApplicationType = 'M';
            record.BankCode = "444112";
            record.BranchAuthorizer = "daf";


            
        }
    }
}
