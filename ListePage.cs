using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Vehicle_Registration_System {
  public partial class TheList : Form {
    string oldValue = null;
    string newValue = null;
    int columnIndex = 0;
    int rowNumber = 0;
    bool buttonSaveActive = false;
    bool buttonDeleteActive = false;
    



    public TheList() {
      InitializeComponent();
      DatenAnzeigen();
    }

    private void DatenAnzeigen() {
     
      string sentence = string.Empty;
      string[] data = null;
      StreamReader reader = new StreamReader(RegistrationPage.txtAdress, Encoding.UTF8);

      while (!reader.EndOfStream)
      {

        sentence = reader.ReadLine();
        data = sentence.Split('-');

        this.savedDataList.Rows.Add(data[0], data[1], data[2], data[3], data[4]);
       
      }

      reader.Close();

    }
    private List<Car> DataChanging() {
      List<Car> carList = new List<Car>();

      carList = Car.WriteDataToList();

      for (int i = 0; i < carList.Count; i++)
      {

        if (i == rowNumber)
        {

          switch (columnIndex)
          {

            case 0:
              carList[i].Brand = newValue;
              break;
            case 1:
              carList[i].Model = newValue;
              break;
            case 2:
              carList[i].LicencePlate = newValue;
              break;
            case 3:
              carList[i].FirstRegistration = newValue;
              break;
            case 4:
              carList[i].Mileage = newValue;
              break;
          }

        }

      }

      return carList;
    }
    internal void ListWritingAfterChanged(List<Car> carList) {
      List<Car> changedList = new List<Car>();
      changedList = carList;
      //File.Delete(RegistrationPage.txtAdress);
      File.Delete(RegistrationPage.txtAdress);
      using (StreamWriter writer = new(RegistrationPage.txtAdress, true, Encoding.UTF8))
      {

        foreach (Car element2 in changedList)
        {

          writer.WriteLine(element2.ToString());

        }

      }
      
      timerLabel.Start();

    }

    private void backToRegistration_Click(object sender, EventArgs e) {
      RegistrationPage backToPage = new RegistrationPage();

      /*Show form2*/
      backToPage.Show();

      /*hide this form */
      this.Hide();
    }

    private void savedDataList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
      oldValue = savedDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

      columnIndex = e.ColumnIndex;
      rowNumber = e.RowIndex;


    }

    private void savedDataList_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
      newValue = savedDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

    }

    private void saveButtonListPage_Click(object sender, EventArgs e) {

      ListWritingAfterChanged(DataChanging());
      
      buttonSaveActive = true;

    }

    private void labelTimer_Tick(object sender, EventArgs e) {
      int i = 0;

      while (i < 25)
      {

        i++;

      }
      if (buttonSaveActive)
      {

        labelTimerText.Text = "Successfully saved.";
        labelTimerText.ForeColor = Color.FromArgb(0, 255, 0); // renk degisimi 
      }
      if (buttonDeleteActive) {

        labelTimerText.Text = "Successfully deleted.";
        labelTimerText.ForeColor = Color.FromArgb(255, 0, 100, 0); // renk degisimi 
      }

    }

    private void deleteButton_Click(object sender, EventArgs e) {
      List<Car> carListRowDelete = new List<Car>();

      carListRowDelete = Car.WriteDataToList();
      for (int i = 0; i < carListRowDelete.Count; i++) {

        if (i == rowNumber) {

          carListRowDelete.RemoveAt(i);
        }
      
      }
      ListWritingAfterChanged(carListRowDelete);
      buttonDeleteActive = true;

    }
  }


}
