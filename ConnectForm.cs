using Firebase.Database;
using System.Diagnostics;

namespace FirebaseOps
{
    public partial class ConnectForm : Form
    {
        private MainForm _mainForm;
        private FirebaseClient _firebaseClient;

        public event EventHandler<DataRetrievedEventArgs> DataRetrieved;

        public ConnectForm(MainForm mainForm, FirebaseClient firebaseClient)
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.URL;
            _mainForm = mainForm;
            _firebaseClient = firebaseClient;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                var firebaseUrl = "https://cigilabs-fded7-default-rtdb.europe-west1.firebasedatabase.app/";
                _firebaseClient = new FirebaseClient(firebaseUrl);
                MessageBox.Show("Connected to Firebase successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to Firebase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private async void ConnectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var firebaseData = await _firebaseClient.Child("users").OnceAsync<Dictionary<string, string>>();
                Debug.WriteLine($"firebaseData: {firebaseData}");

                List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();
                foreach (var item in firebaseData)
                {
                    dataList.Add(item.Object);
                }

                DataRetrieved?.Invoke(this, new DataRetrievedEventArgs(dataList));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }

    public class DataRetrievedEventArgs : EventArgs
    {
        public List<Dictionary<string, string>> FirebaseData { get; }

        public DataRetrievedEventArgs(List<Dictionary<string, string>> firebaseData)
        {
            FirebaseData = firebaseData;
        }
    }
}
