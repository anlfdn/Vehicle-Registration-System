using System.Security.Policy;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Vehicle_Registration_System {

  public partial class RegistrationPage : Form {
    string brand = string.Empty;
    string orginalBrandMenuName = string.Empty;

    public  static string txtAdress = "c:\\wifiProject\\VehicleData.txt";
    //List<Car> carList = new List<Car>();

    
    Car car;
    public RegistrationPage() {
      InitializeComponent();
    }

    //public RegistrationPage (string brand, string model, string kennzeichen, string zulassung, string kmZustand){
    //  this.brandsToolStripMenuItem.Text = brand;
    //  this.modelTextBox.Text = model;
    //  this.kennzeichenTextBox.Text = kennzeichen;
    //  this.erstZulassungTextBox.Text = zulassung;
    //  this.kmzustandTextBox.Text = kmZustand;

    //}

    private void registrationPage_Load(object sender, EventArgs e) {

    }
    private void brandsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
      brand = e.ClickedItem.Text;
      orginalBrandMenuName = brandsToolStripMenuItem.Text;
      brandsToolStripMenuItem.Text = brand;

    }

    private void saveButton_Click(object sender, EventArgs e) {

      

      /*writing the informations into the txt datei*/
      // using close the txt.datei
      using (StreamWriter writer = new(txtAdress, true, Encoding.UTF8))
      {

        
          string model = this.modelTextBox.Text;
          string kennzeichen = this.kennzeichenTextBox.Text;
          string zulassung = this.firstRegistrationDate.Text;
          string kmzustand = this.kmzustandTextBox.Text;
        

        if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(kennzeichen) || string.IsNullOrEmpty(zulassung) || string.IsNullOrEmpty(kmzustand))
        {
          MessageBox.Show("you forgot to select an option. Vehicle information hasn't been saved ");

          //this.brandsToolStripMenuItem.Text = orginalBrandMenuName; // it takes again the orginal name = list of vehicles.

          MakeTheTextBoxEmpty();

        } else 
        {
          car = new Car(brand, model, kennzeichen, zulassung, kmzustand);

          
          writer.WriteLine(car.ToString());

          /*show the accept of saving*/
          MessageBox.Show("Vehicle information has been saved");
          MakeTheTextBoxEmpty();

        }
      }


    }

    private void deleteButton_Click(object sender, EventArgs e) {
      /*show the accept of deleting*/
      MessageBox.Show("Vehicle information has been deleted.");
    }

    private void updateButton_Click(object sender, EventArgs e) {

      /*show the accept of updating*/
      MessageBox.Show("Vehicle information has been updated.");
    }

    private void showListButton_Click(object sender, EventArgs e) {
      TheList theList = new();

      /*Show form2*/
      theList.Show();

      /*hide this form */
      this.Hide();

    }
    private void MakeTheTextBoxEmpty() {
      this.brandsToolStripMenuItem.Text = orginalBrandMenuName;
      foreach (var element in textBoxPanel1.Controls)
      {

        if (element is MaskedTextBox tb)
        {
          tb.Clear();
        }
      }



    }
  }
}
