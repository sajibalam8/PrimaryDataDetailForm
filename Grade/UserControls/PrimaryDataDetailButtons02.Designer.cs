
namespace Grade
{
  partial class PrimaryDataDetailButtons02
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.executeQueryButton = new System.Windows.Forms.Button();
            this.customTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customTableLayoutPanel1
            // 
            this.customTableLayoutPanel1.ColumnCount = 11;
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.customTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customTableLayoutPanel1.Controls.Add(this.cancelButton, 1, 0);
            this.customTableLayoutPanel1.Controls.Add(this.executeQueryButton, 3, 0);
            this.customTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.customTableLayoutPanel1.Name = "customTableLayoutPanel1";
            this.customTableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.customTableLayoutPanel1.RowCount = 1;
            this.customTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customTableLayoutPanel1.Size = new System.Drawing.Size(996, 50);
            this.customTableLayoutPanel1.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelButton.Location = new System.Drawing.Point(18, 8);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(144, 34);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // executeQueryButton
            // 
            this.executeQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.executeQueryButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.executeQueryButton.Location = new System.Drawing.Point(178, 8);
            this.executeQueryButton.Name = "executeQueryButton";
            this.executeQueryButton.Size = new System.Drawing.Size(144, 34);
            this.executeQueryButton.TabIndex = 1;
            this.executeQueryButton.Text = "&Execute Query";
            this.executeQueryButton.UseVisualStyleBackColor = true;
            this.executeQueryButton.Click += new System.EventHandler(this.executeQueryButton_Click);
            // 
            // PrimaryDataDetailButtons02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customTableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PrimaryDataDetailButtons02";
            this.Size = new System.Drawing.Size(996, 50);
            this.customTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private CustomTableLayoutPanel customTableLayoutPanel1;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button executeQueryButton;
  }
}
