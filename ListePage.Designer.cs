namespace Vehicle_Registration_System {
  partial class TheList {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      components = new System.ComponentModel.Container();
      DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
      savedDataList = new DataGridView();
      backToRegistration = new Button();
      saveButtonListPage = new Button();
      deleteButton = new Button();
      labelTimerText = new Label();
      timerLabel = new System.Windows.Forms.Timer(components);
      brand = new DataGridViewTextBoxColumn();
      model = new DataGridViewTextBoxColumn();
      LicencePlate = new DataGridViewTextBoxColumn();
      firstRegistration = new DataGridViewTextBoxColumn();
      mileage = new DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)savedDataList).BeginInit();
      SuspendLayout();
      // 
      // savedDataList
      // 
      dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      savedDataList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      savedDataList.BackgroundColor = SystemColors.Control;
      dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.BackColor = SystemColors.Control;
      dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
      dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      savedDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      savedDataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      savedDataList.Columns.AddRange(new DataGridViewColumn[] { brand, model, LicencePlate, firstRegistration, mileage });
      savedDataList.Location = new Point(0, 0);
      savedDataList.Name = "savedDataList";
      savedDataList.Size = new Size(1039, 281);
      savedDataList.TabIndex = 0;
      savedDataList.CellBeginEdit += savedDataList_CellBeginEdit;
      savedDataList.CellEndEdit += savedDataList_CellEndEdit;
      // 
      // backToRegistration
      // 
      backToRegistration.Location = new Point(196, 451);
      backToRegistration.Name = "backToRegistration";
      backToRegistration.Size = new Size(614, 42);
      backToRegistration.TabIndex = 1;
      backToRegistration.Text = "Back to Car Registration Page";
      backToRegistration.UseVisualStyleBackColor = true;
      backToRegistration.Click += backToRegistration_Click;
      // 
      // saveButtonListPage
      // 
      saveButtonListPage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      saveButtonListPage.Location = new Point(304, 360);
      saveButtonListPage.Name = "saveButtonListPage";
      saveButtonListPage.Size = new Size(110, 44);
      saveButtonListPage.TabIndex = 2;
      saveButtonListPage.Text = "Update";
      saveButtonListPage.UseVisualStyleBackColor = true;
      saveButtonListPage.Click += saveButtonListPage_Click;
      // 
      // deleteButton
      // 
      deleteButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      deleteButton.Location = new Point(611, 360);
      deleteButton.Name = "deleteButton";
      deleteButton.Size = new Size(109, 44);
      deleteButton.TabIndex = 3;
      deleteButton.Text = "Delete";
      deleteButton.UseVisualStyleBackColor = true;
      deleteButton.Click += deleteButton_Click;
      // 
      // labelTimerText
      // 
      labelTimerText.AutoSize = true;
      labelTimerText.BackColor = Color.Transparent;
      labelTimerText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      labelTimerText.Location = new Point(424, 410);
      labelTimerText.Name = "labelTimerText";
      labelTimerText.Size = new Size(0, 25);
      labelTimerText.TabIndex = 4;
      // 
      // timerLabel
      // 
      timerLabel.Interval = 25;
      timerLabel.Tick += labelTimer_Tick;
      // 
      // brand
      // 
      dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
      brand.DefaultCellStyle = dataGridViewCellStyle3;
      brand.HeaderText = "Brand";
      brand.Name = "brand";
      brand.Width = 200;
      // 
      // model
      // 
      dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
      model.DefaultCellStyle = dataGridViewCellStyle4;
      model.HeaderText = "Model";
      model.Name = "model";
      model.Width = 200;
      // 
      // LicencePlate
      // 
      dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
      LicencePlate.DefaultCellStyle = dataGridViewCellStyle5;
      LicencePlate.HeaderText = "Licence Plate";
      LicencePlate.Name = "LicencePlate";
      LicencePlate.Width = 200;
      // 
      // firstRegistration
      // 
      dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
      firstRegistration.DefaultCellStyle = dataGridViewCellStyle6;
      firstRegistration.HeaderText = "First Registration";
      firstRegistration.Name = "firstRegistration";
      firstRegistration.Width = 200;
      // 
      // mileage
      // 
      dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
      mileage.DefaultCellStyle = dataGridViewCellStyle7;
      mileage.HeaderText = "Mileage(Km)";
      mileage.Name = "mileage";
      mileage.Width = 200;
      // 
      // TheList
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.RosyBrown;
      ClientSize = new Size(1040, 558);
      Controls.Add(labelTimerText);
      Controls.Add(deleteButton);
      Controls.Add(saveButtonListPage);
      Controls.Add(backToRegistration);
      Controls.Add(savedDataList);
      Name = "TheList";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Liste";
      ((System.ComponentModel.ISupportInitialize)savedDataList).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private DataGridView savedDataList;
    private Button backToRegistration;
    private Button saveButtonListPage;
    private Button deleteButton;
    private Label labelTimerText;
    private System.Windows.Forms.Timer timerLabel;
    private DataGridViewTextBoxColumn brand;
    private DataGridViewTextBoxColumn model;
    private DataGridViewTextBoxColumn LicencePlate;
    private DataGridViewTextBoxColumn firstRegistration;
    private DataGridViewTextBoxColumn mileage;
  }
}