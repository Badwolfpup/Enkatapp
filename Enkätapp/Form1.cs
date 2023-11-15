namespace Enkätapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createSurveryButton_Click(object sender, EventArgs e)
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Control c = Controls[i];
                Controls.Remove(c);
                c.Dispose();
            }

        }
    }
}