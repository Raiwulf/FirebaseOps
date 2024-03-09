using Firebase.Database;

namespace FirebaseOps
{
    public partial class MainForm : Form
    {
        private FirebaseClient _firebaseClient;

        public MainForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm(this, _firebaseClient);
            connectForm.DataRetrieved += ConnectForm_DataRetrieved;
            connectForm.Show();
        }

        private void ConnectForm_DataRetrieved(object sender, DataRetrievedEventArgs e)
        {
            var firebaseData = e.FirebaseData;
            int yOffset = 16;
            List<String> comboData = new List<String>();
            scrollPanel.Controls.Clear();

            foreach (var data in firebaseData)
            {
                GroupBox entryGroup = new GroupBox(); // Create a new group box for each set of data
                entryGroup.Location = new Point(0, yOffset);
                entryGroup.AutoSize = true;

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        Label label = new Label();
                        label.Text = item.Key + ":";
                        label.Location = new Point(20, yOffset);
                        label.AutoSize = true;

                        TextBox textBox = new TextBox();
                        textBox.Text = item.Value;
                        textBox.Location = new Point(120, yOffset);
                        textBox.Size = new Size(200, 20);

                        // Add label text to comboData only if it doesn't already exist
                        if (!comboData.Contains(label.Text))
                        {
                            comboData.Add(label.Text);
                        }

                        entryGroup.Controls.Add(label);
                        entryGroup.Controls.Add(textBox);

                        yOffset += 32;
                    }
                }
                // Add the group box to the scroll panel
                scrollPanel.Controls.Add(entryGroup);
                yOffset += 16;
            }
        }
    }
}
