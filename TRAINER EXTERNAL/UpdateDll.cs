using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAINER_EXTERNAL
{
    public partial class UpdateDll : Form
    {
        public UpdateDll()
        {
            InitializeComponent();
        }

        private void UpdateDll_Load(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri("http://www.sayka.com/downloads/front_view.jpg"),
                    // Param2 = Path to save
                    "D:\\Images\\front_view.jpg"
                );
            }
        }
        // Event to track the progress
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    }
}
