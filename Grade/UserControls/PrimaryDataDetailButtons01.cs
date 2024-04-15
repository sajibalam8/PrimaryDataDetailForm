using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Grade
{
  public partial class PrimaryDataDetailButtons01 : UserControl
  {
    private Main _main = null;
    public PrimaryDataDetailButtons01(Main main)
    {
      InitializeComponent();
      _main = main;
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      try
      {
        _main.screenContainerPanel.Visible = false;
        _main.screenContainerPanel.Controls.Clear();
        _main.screenContainerPanel.SuspendLayout();
        WelcomeScreen welcomeScreen = new WelcomeScreen();
        welcomeScreen.Dock = DockStyle.Fill;
        _main.screenContainerPanel.Controls.Add(welcomeScreen);
        _main.screenContainerPanel.ResumeLayout();
        _main.screenContainerPanel.Visible = true;

        _main.buttonContainerPanel.Controls.Clear();
      }
      catch (Exception ex)
      {
        Debug.Print(ex.Message);
      }
    }

    private void queryButton_Click(object sender, EventArgs e)
    {
      try
      {
        var primaryDataDetail = _main.screenContainerPanel.Controls[0] as PrimaryDataDetail;
        if (primaryDataDetail != null)
        {
          primaryDataDetail.textBoxSchedNo.ReadOnly = false;
          primaryDataDetail.textBoxConsNo.ReadOnly = false;

          _main.buttonContainerPanel.Visible = false;
          _main.buttonContainerPanel.Controls.Clear();
          _main.buttonContainerPanel.SuspendLayout();
          PrimaryDataDetailButtons02 primaryDataDetailButtons02 = new PrimaryDataDetailButtons02(_main);
          primaryDataDetailButtons02.Dock = DockStyle.Fill;
          _main.buttonContainerPanel.Controls.Add(primaryDataDetailButtons02);
          _main.buttonContainerPanel.ResumeLayout();
          _main.buttonContainerPanel.Visible = true;
        }
      }
      catch (Exception ex)
      {
        Debug.Print(ex.Message);
      }
    }
  }
}
