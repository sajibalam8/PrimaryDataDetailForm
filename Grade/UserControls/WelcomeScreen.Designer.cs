
namespace Grade
{
  partial class WelcomeScreen
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.customTableLayoutPanel1 = new Grade.CustomTableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.customTableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // customTableLayoutPanel1
      // 
      this.customTableLayoutPanel1.BackColor = System.Drawing.Color.White;
      this.customTableLayoutPanel1.ColumnCount = 1;
      this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.customTableLayoutPanel1.Controls.Add(this.label2, 0, 3);
      this.customTableLayoutPanel1.Controls.Add(this.label1, 0, 1);
      this.customTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.customTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.customTableLayoutPanel1.Name = "customTableLayoutPanel1";
      this.customTableLayoutPanel1.RowCount = 5;
      this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
      this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.customTableLayoutPanel1.Size = new System.Drawing.Size(996, 670);
      this.customTableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(3, 295);
      this.label1.Margin = new System.Windows.Forms.Padding(3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(990, 34);
      this.label1.TabIndex = 1;
      this.label1.Text = "Level II";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(3, 340);
      this.label2.Margin = new System.Windows.Forms.Padding(3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(990, 34);
      this.label2.TabIndex = 2;
      this.label2.Text = "Cleveland-Cliffs Inc. 86\" Hot Strip Mill";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // WelcomeScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.customTableLayoutPanel1);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
      this.Margin = new System.Windows.Forms.Padding(0);
      this.Name = "WelcomeScreen";
      this.Size = new System.Drawing.Size(996, 670);
      this.customTableLayoutPanel1.ResumeLayout(false);
      this.customTableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomTableLayoutPanel customTableLayoutPanel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}
