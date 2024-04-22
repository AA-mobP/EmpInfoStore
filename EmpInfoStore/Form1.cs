using EmpInfoStore.BusinessLogic;
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
        clsEmployees context = new();

        private void OpacityDownEvent(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Up");
        }

        private void Base_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            context.Add(txtName.Text, (int)numSalary.Value, txtAddress.Text);

        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            context.Edit(txtName.Text, (int)numSalary.Value, txtAddress.Text, Convert.ToInt32(txtId.Text));
        }

        private void tsbtnFind_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtId.Text, out int Id))
                MessageBox.Show("Should be Numbers ONLY");
            else
            {
                EmployeeModel? emp = context.Get(Convert.ToInt32(txtId.Text));
                if (emp == null)
                    MessageBox.Show("Not Found!");
                else
                {
                    txtName.Text = emp.Name;
                    txtAddress.Text = emp.Address;
                    numSalary.Value = emp.Salary;
                }
            }
        }

        private void tsbtnShowAll_Click(object sender, EventArgs e)
        {
            List<EmployeeModel> list = context.GetAll();
            Form frm = new();
            frm.Size = Size;
            frm.Top = Top;
            frm.Left = Left;
            frm.BackColor = BackColor;
            frm.ForeColor = ForeColor;

            TextBox txt = new();
            frm.Controls.Add(txt);
            txt.Multiline = true;
            txt.Size = frm.Size;
            txt.Top = frm.Top;
            txt.Left = frm.Left;

            txt.Text = "";
            foreach (EmployeeModel emp in list)
            {
                txt.Text += $"{emp.Id}, {emp.Name}, {emp.Salary}, {emp.Address}, {emp.CreatedDate};\n";
            }
            frm.Show();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int Id))
                MessageBox.Show("Should be Numbers ONLY");
            else
            {
             context.Remove(Convert.ToInt32(txtId.Text));
            }
        }
    }
}
