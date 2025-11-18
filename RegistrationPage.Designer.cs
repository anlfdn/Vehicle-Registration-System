namespace Vehicle_Registration_System {
  partial class RegistrationPage {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      welcomeLabel = new Label();
      modelLabel = new Label();
      kennzeichenLabel = new Label();
      erstZulassungLabel = new Label();
      label5 = new Label();
      modelTextBox = new MaskedTextBox();
      kennzeichenTextBox = new MaskedTextBox();
      kmzustandTextBox = new MaskedTextBox();
      saveButton = new Button();
      menuStrip1 = new MenuStrip();
      brandsToolStripMenuItem = new ToolStripMenuItem();
      toolStripMenuItem1 = new ToolStripMenuItem();
      toolStripMenuItem2 = new ToolStripMenuItem();
      toolStripMenuItem3 = new ToolStripMenuItem();
      toolStripMenuItem4 = new ToolStripMenuItem();
      toolStripMenuItem5 = new ToolStripMenuItem();
      showListButton = new Button();
      textBoxPanel1 = new Panel();
      firstRegistrationDate = new DateTimePicker();
      menuStrip1.SuspendLayout();
      textBoxPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // welcomeLabel
      // 
      welcomeLabel.AutoSize = true;
      welcomeLabel.Font = new Font("Arial Narrow", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
      welcomeLabel.ImageAlign = ContentAlignment.MiddleRight;
      welcomeLabel.Location = new Point(168, 27);
      welcomeLabel.Name = "welcomeLabel";
      welcomeLabel.Size = new Size(361, 25);
      welcomeLabel.TabIndex = 0;
      welcomeLabel.Text = "Welcome to the Vehicle Registration System";
      // 
      // modelLabel
      // 
      modelLabel.AutoSize = true;
      modelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      modelLabel.Location = new Point(93, 138);
      modelLabel.Name = "modelLabel";
      modelLabel.Size = new Size(58, 21);
      modelLabel.TabIndex = 3;
      modelLabel.Text = "Modell";
      // 
      // kennzeichenLabel
      // 
      kennzeichenLabel.AutoSize = true;
      kennzeichenLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      kennzeichenLabel.Location = new Point(93, 195);
      kennzeichenLabel.Name = "kennzeichenLabel";
      kennzeichenLabel.Size = new Size(99, 21);
      kennzeichenLabel.TabIndex = 4;
      kennzeichenLabel.Text = "Licence Plate";
      // 
      // erstZulassungLabel
      // 
      erstZulassungLabel.AutoSize = true;
      erstZulassungLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      erstZulassungLabel.Location = new Point(93, 253);
      erstZulassungLabel.Name = "erstZulassungLabel";
      erstZulassungLabel.Size = new Size(128, 21);
      erstZulassungLabel.TabIndex = 5;
      erstZulassungLabel.Text = "First Registration";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label5.Location = new Point(93, 309);
      label5.Name = "label5";
      label5.Size = new Size(101, 21);
      label5.TabIndex = 6;
      label5.Text = "Mileage (km)";
      // 
      // modelTextBox
      // 
      modelTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      modelTextBox.Location = new Point(15, 16);
      modelTextBox.Name = "modelTextBox";
      modelTextBox.Size = new Size(167, 25);
      modelTextBox.TabIndex = 7;
      // 
      // kennzeichenTextBox
      // 
      kennzeichenTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      kennzeichenTextBox.Location = new Point(15, 73);
      kennzeichenTextBox.Name = "kennzeichenTextBox";
      kennzeichenTextBox.Size = new Size(167, 25);
      kennzeichenTextBox.TabIndex = 8;
      // 
      // kmzustandTextBox
      // 
      kmzustandTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      kmzustandTextBox.Location = new Point(15, 187);
      kmzustandTextBox.Mask = "000000";
      kmzustandTextBox.Name = "kmzustandTextBox";
      kmzustandTextBox.Size = new Size(167, 25);
      kmzustandTextBox.TabIndex = 10;
      kmzustandTextBox.ValidatingType = typeof(int);
      // 
      // saveButton
      // 
      saveButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      saveButton.Location = new Point(304, 379);
      saveButton.Name = "saveButton";
      saveButton.Size = new Size(84, 41);
      saveButton.TabIndex = 12;
      saveButton.Text = "Save";
      saveButton.UseVisualStyleBackColor = true;
      saveButton.Click += saveButton_Click;
      // 
      // menuStrip1
      // 
      menuStrip1.BackColor = Color.LightGray;
      menuStrip1.Dock = DockStyle.None;
      menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      menuStrip1.Items.AddRange(new ToolStripItem[] { brandsToolStripMenuItem });
      menuStrip1.Location = new Point(285, 77);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(124, 29);
      menuStrip1.TabIndex = 14;
      menuStrip1.Text = "menuStrip1";
      // 
      // brandsToolStripMenuItem
      // 
      brandsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5 });
      brandsToolStripMenuItem.Name = "brandsToolStripMenuItem";
      brandsToolStripMenuItem.Size = new Size(116, 25);
      brandsToolStripMenuItem.Text = "List of Brands";
      brandsToolStripMenuItem.DropDownItemClicked += brandsToolStripMenuItem_DropDownItemClicked;
      // 
      // toolStripMenuItem1
      // 
      toolStripMenuItem1.Name = "toolStripMenuItem1";
      toolStripMenuItem1.Size = new Size(147, 26);
      toolStripMenuItem1.Text = "BMW";
      // 
      // toolStripMenuItem2
      // 
      toolStripMenuItem2.Name = "toolStripMenuItem2";
      toolStripMenuItem2.Size = new Size(147, 26);
      toolStripMenuItem2.Text = "Mercedes";
      // 
      // toolStripMenuItem3
      // 
      toolStripMenuItem3.Name = "toolStripMenuItem3";
      toolStripMenuItem3.Size = new Size(147, 26);
      toolStripMenuItem3.Text = "Audi";
      // 
      // toolStripMenuItem4
      // 
      toolStripMenuItem4.Name = "toolStripMenuItem4";
      toolStripMenuItem4.Size = new Size(147, 26);
      toolStripMenuItem4.Text = "VW";
      // 
      // toolStripMenuItem5
      // 
      toolStripMenuItem5.Name = "toolStripMenuItem5";
      toolStripMenuItem5.Size = new Size(147, 26);
      toolStripMenuItem5.Text = "Skoda";
      // 
      // showListButton
      // 
      showListButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      showListButton.Location = new Point(207, 448);
      showListButton.Name = "showListButton";
      showListButton.Size = new Size(274, 32);
      showListButton.TabIndex = 15;
      showListButton.Text = "Show List";
      showListButton.UseVisualStyleBackColor = true;
      showListButton.Click += showListButton_Click;
      // 
      // textBoxPanel1
      // 
      textBoxPanel1.Controls.Add(firstRegistrationDate);
      textBoxPanel1.Controls.Add(modelTextBox);
      textBoxPanel1.Controls.Add(kennzeichenTextBox);
      textBoxPanel1.Controls.Add(kmzustandTextBox);
      textBoxPanel1.Location = new Point(252, 120);
      textBoxPanel1.Name = "textBoxPanel1";
      textBoxPanel1.Size = new Size(200, 234);
      textBoxPanel1.TabIndex = 16;
      // 
      // firstRegistrationDate
      // 
      firstRegistrationDate.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      firstRegistrationDate.CustomFormat = "        dd.MM.yyyy";
      firstRegistrationDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      firstRegistrationDate.Format = DateTimePickerFormat.Custom;
      firstRegistrationDate.Location = new Point(15, 133);
      firstRegistrationDate.Name = "firstRegistrationDate";
      firstRegistrationDate.Size = new Size(167, 29);
      firstRegistrationDate.TabIndex = 11;
      // 
      // RegistrationPage
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.RosyBrown;
      ClientSize = new Size(712, 550);
      Controls.Add(textBoxPanel1);
      Controls.Add(showListButton);
      Controls.Add(menuStrip1);
      Controls.Add(saveButton);
      Controls.Add(label5);
      Controls.Add(erstZulassungLabel);
      Controls.Add(kennzeichenLabel);
      Controls.Add(modelLabel);
      Controls.Add(welcomeLabel);
      FormBorderStyle = FormBorderStyle.Fixed3D;
      Name = "RegistrationPage";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Car Registration";
      Load += registrationPage_Load;
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      textBoxPanel1.ResumeLayout(false);
      textBoxPanel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label welcomeLabel;
    private Label modelLabel;
    private Label kennzeichenLabel;
    private Label erstZulassungLabel;
    private Label label5;
    private MaskedTextBox modelTextBox;
    private MaskedTextBox kennzeichenTextBox;
    private MaskedTextBox kmzustandTextBox;
    private Button saveButton;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem brandsToolStripMenuItem;
    private Button showListButton;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem toolStripMenuItem4;
    private ToolStripMenuItem toolStripMenuItem5;
    private Panel textBoxPanel1;
    private DateTimePicker firstRegistrationDate;
  }
}
