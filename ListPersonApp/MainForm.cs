using PersonControlLib;

namespace ListPersonApp
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
        }

       

        private void Add_button(object sender, EventArgs e)
        {
            PersonUserControl userControl = new PersonUserControl();
            userControl.Click += UserControl_Click;
            PanelUsers.Controls.Add(userControl);
            usersAmount.Text = PanelUsers.Controls.Count.ToString();

        }

        private void UserControl_Click(object? sender, EventArgs e)
        {
            var userControl = (PersonUserControl)((Control)sender).Parent;
            if (((Button)sender).Name == "buttonEdit")
            {
                PersonEditDialog editDialog = new PersonEditDialog(userControl);
                editDialog.Id = userControl.ID;
                editDialog.FirstName = userControl.FirstName?.ToString();
                editDialog.Surname = userControl.Surname?.ToString();
                editDialog.lastName = userControl.lastName?.ToString();
                editDialog.Age = userControl.Age?.ToString();

                if (editDialog.ShowDialog() == DialogResult.OK)
                {
                    userControl.ID = editDialog.Id;
                    userControl.FirstName = editDialog.FirstName;
                    userControl.Surname = editDialog.Surname;
                    userControl.lastName = editDialog.lastName;
                    userControl.Age = editDialog.Age;
                    ageSum.Text = FindAgeSum();
                }
                else
                {
                    PanelUsers.Controls.Remove(userControl);
                    usersAmount.Text = PanelUsers.Controls.Count.ToString();
                    ageSum.Text = FindAgeSum();
                }
            }
            else if (((Button)sender).Name == "buttonDel")
            {
                PanelUsers.Controls.Remove(userControl);
                usersAmount.Text = PanelUsers.Controls.Count.ToString();
                ageSum.Text = FindAgeSum();
            }
        }

        private string FindAgeSum()
        {
            int sum = 0;

            foreach (PersonUserControl control in PanelUsers.Controls)
            {
                if (int.TryParse(control.Age?.ToString(), out int age))
                {
                    sum += age;
                }
            }
            return sum.ToString();
        }

    }
}