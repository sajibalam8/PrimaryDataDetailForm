using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Grade
{
    public partial class PrimaryDataDetailButtons02 : UserControl
    {
        private Main _main = null;
        public PrimaryDataDetailButtons02(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                _main.buttonContainerPanel.Visible = false;
                _main.buttonContainerPanel.Controls.Clear();
                _main.buttonContainerPanel.SuspendLayout();
                PrimaryDataDetailButtons01 primaryDataDetailButtons01 = new PrimaryDataDetailButtons01(_main);
                primaryDataDetailButtons01.Dock = DockStyle.Fill;
                _main.buttonContainerPanel.Controls.Add(primaryDataDetailButtons01);
                _main.buttonContainerPanel.ResumeLayout();
                _main.buttonContainerPanel.Visible = true;

                var primaryDataDetail = _main.screenContainerPanel.Controls[0] as PrimaryDataDetail;
                if (primaryDataDetail != null)
                {
                    primaryDataDetail.textBoxSchedNo.ReadOnly = true;
                    primaryDataDetail.textBoxConsNo.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var primaryDataDetail = _main.screenContainerPanel.Controls[0] as PrimaryDataDetail;
                if (primaryDataDetail != null)
                {
                    var schedNo = primaryDataDetail.textBoxSchedNo.Text.Trim();
                    var consNo = primaryDataDetail.textBoxConsNo.Text.Trim();
                    if (string.IsNullOrEmpty(schedNo))
                    {
                        MessageBox.Show("SCHED NUMBER is required.");
                        return;
                    }

                    if (string.IsNullOrEmpty(consNo))
                    {
                        MessageBox.Show("CONS NUMBER is required.");
                        return;
                    }

                    var schedCons = $"{schedNo}-{consNo}";
                    primaryDataDetail.schedCons = schedCons;
                    primaryDataDetail.backgroundWorkerPrimaryDataDetail.RunWorkerAsync();
                    cancelButton.PerformClick();
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }
    }
}
