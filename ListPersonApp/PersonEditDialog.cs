using PersonControlLib;

namespace ListPersonApp
{
    public partial class PersonEditDialog : Form
    {
        public PersonEditDialog(PersonUserControl user)
        {
            InitializeComponent();
        }

        public string Id
        {
            get => IDTextBox.Text;
            set => IDTextBox.Text = value;
        }

        public string FirstName
        {
            get => NameTextBox.Text;
            set => NameTextBox.Text = value;
        }

        public string Surname
        {
            get => SecondNameTextBox.Text;
            set => SecondNameTextBox.Text = value;
        }

        public string lastName
        {
            get => ThirdNameTextBox.Text;
            set => ThirdNameTextBox.Text = value;
        }

        public string Age
        {
            get => AgeTextBox.Text;
            set => AgeTextBox.Text = value;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
