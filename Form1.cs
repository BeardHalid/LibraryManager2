namespace LibraryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new();
            homePage.Show();  
        }
    }
}
