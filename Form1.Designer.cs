namespace WinForms_RightToLeft
{
  partial class Form1
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.checkBoxRightToLeft = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.checkBoxRightToLeftLayout = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // checkBoxRightToLeft
      // 
      this.checkBoxRightToLeft.AutoSize = true;
      this.checkBoxRightToLeft.Location = new System.Drawing.Point(48, 45);
      this.checkBoxRightToLeft.Name = "checkBoxRightToLeft";
      this.checkBoxRightToLeft.Size = new System.Drawing.Size(88, 17);
      this.checkBoxRightToLeft.TabIndex = 0;
      this.checkBoxRightToLeft.Text = "Right-To-Left";
      this.checkBoxRightToLeft.UseVisualStyleBackColor = true;
      this.checkBoxRightToLeft.CheckedChanged += new System.EventHandler(this.checkBoxRightToLeft_CheckedChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(226, 84);
      this.button1.Name = "button1";
      this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(298, 24);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "Hello, world!";
      // 
      // checkBoxRightToLeftLayout
      // 
      this.checkBoxRightToLeftLayout.AutoSize = true;
      this.checkBoxRightToLeftLayout.Location = new System.Drawing.Point(48, 84);
      this.checkBoxRightToLeftLayout.Name = "checkBoxRightToLeftLayout";
      this.checkBoxRightToLeftLayout.Size = new System.Drawing.Size(123, 17);
      this.checkBoxRightToLeftLayout.TabIndex = 3;
      this.checkBoxRightToLeftLayout.Text = "Right-To-Left Layout";
      this.checkBoxRightToLeftLayout.UseVisualStyleBackColor = true;
      this.checkBoxRightToLeftLayout.CheckedChanged += new System.EventHandler(this.checkBoxRightToLeftLayout_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(430, 176);
      this.Controls.Add(this.checkBoxRightToLeftLayout);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.checkBoxRightToLeft);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxRightToLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxRightToLeftLayout;
    }
}

