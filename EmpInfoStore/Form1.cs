using EmpInfoStore.Models;

namespace EmpInfoStore
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        //properties
        
        
        private void OpacityDownEvent(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Up");
        }

        private void Base_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
