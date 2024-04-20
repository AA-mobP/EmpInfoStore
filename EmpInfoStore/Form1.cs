namespace EmpInfoStore
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        



        void OpacityUp()
        {
            this.Opacity = 0.95;
        }

        private void Base_Load(object sender, EventArgs e)
        {


        }

        private void Base_Click(object sender, EventArgs e)
        {
        }

        private void Base_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Base_KeyDown(object sender, KeyEventArgs e)
        {
            Opacity = 0.75;
        }

        private void Base_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Down");
        }

        private void Base_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Up");
        }
        private void OpacityDownEvent(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Up");
        }
    }
}
