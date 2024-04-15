using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Grade
{
  public partial class Main : Form
  {
    
    public Main()
    {
      InitializeComponent();
      CheckForIllegalCrossThreadCalls = false;
    }

    private void PrimaryDataDetail_Load(object sender, EventArgs e)
    {
      try
      {
        screenContainerPanel.Visible = false;
        screenContainerPanel.Controls.Clear();
        screenContainerPanel.SuspendLayout();
        WelcomeScreen welcomeScreen = new WelcomeScreen();
        welcomeScreen.Dock = DockStyle.Fill;
        screenContainerPanel.Controls.Add(welcomeScreen);
        screenContainerPanel.ResumeLayout();
        screenContainerPanel.Visible = true;
      }
      catch (Exception ex)
      {
        Debug.Print(ex.Message);
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        Application.Exit();
      }
      catch (Exception ex)
      {
        Debug.Print(ex.Message);
      }
    }

    private void primaryDataDetailToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      try
      {
        screenContainerPanel.Visible = false;
        screenContainerPanel.Controls.Clear();
        screenContainerPanel.SuspendLayout();
        PrimaryDataDetail primaryDataDetail = new PrimaryDataDetail();
        primaryDataDetail.Dock = DockStyle.Fill;
        screenContainerPanel.Controls.Add(primaryDataDetail);
        screenContainerPanel.ResumeLayout();
        screenContainerPanel.Visible = true;

        buttonContainerPanel.Visible = false;
        buttonContainerPanel.Controls.Clear();
        buttonContainerPanel.SuspendLayout();
        PrimaryDataDetailButtons01 primaryDataDetailButtons01 = new PrimaryDataDetailButtons01(this);
        primaryDataDetailButtons01.Dock = DockStyle.Fill;
        buttonContainerPanel.Controls.Add(primaryDataDetailButtons01);
        buttonContainerPanel.ResumeLayout();
        buttonContainerPanel.Visible = true;
      }
      catch (Exception ex)
      {
        Debug.Print(ex.Message);
      }
    }
  }
}
