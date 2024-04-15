namespace PersonControlLib
{
    public partial class PersonUserControl : UserControl
    {

        public string ID
        {
            get => idText.Text;
            set => idText.Text = value;
        }
        public string FirstName 
        {
            get => nameText.Text;
            set => nameText.Text = value;
        }
        public string Surname
        {
            get => surnameText.Text;
            set => surnameText.Text = value;
        }
        public string lastName
        {
            get => lastNameText.Text;
            set => lastNameText.Text = value;
        }
        public string Age
        {
            get => ageText.Text;
            set => ageText.Text = value;
        }


        public PersonUserControl()
        {
            InitializeComponent();
        }


        public event EventHandler? Click
        {
            add
            {
                buttonEdit.Click += value;
                buttonDel.Click += value;
            }
            remove
            {
                buttonEdit.Click -= value;
                buttonDel.Click -= value;
            }
        }
        

        
    }
}