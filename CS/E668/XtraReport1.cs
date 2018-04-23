using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;

namespace E668
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void XrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {            
            MemoryStream ms = new MemoryStream((byte [])GetCurrentColumnValue("Picture"));
            ((XRPictureBox)sender).Image = Image.FromStream(ms);
        }

    }
}
