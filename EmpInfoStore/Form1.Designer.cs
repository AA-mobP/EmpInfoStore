namespace EmpInfoStore
{
    partial class Base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numSalary = new NumericUpDown();
            picPerson = new PictureBox();
            toolStripContainer1 = new ToolStripContainer();
            toolStrip1 = new ToolStrip();
            tsbtnAdd = new ToolStripButton();
            tsbtnEdit = new ToolStripButton();
            tsbtnShowAll = new ToolStripButton();
            tsbtnDelete = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPerson).BeginInit();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(106, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 29);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(302, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(373, 29);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(302, 108);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(373, 29);
            txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 108);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 6;
            label4.Text = "Salary:";
            // 
            // numSalary
            // 
            numSalary.Location = new Point(106, 109);
            numSalary.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numSalary.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(104, 29);
            numSalary.TabIndex = 7;
            numSalary.TextAlign = HorizontalAlignment.Center;
            numSalary.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // picPerson
            // 
            picPerson.Cursor = Cursors.Hand;
            picPerson.Location = new Point(712, 21);
            picPerson.Name = "picPerson";
            picPerson.Size = new Size(291, 287);
            picPerson.TabIndex = 8;
            picPerson.TabStop = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(picPerson);
            toolStripContainer1.ContentPanel.Size = new Size(1048, 548);
            toolStripContainer1.ContentPanel.HelpRequested += OpacityDownEvent;
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1048, 573);
            toolStripContainer1.TabIndex = 9;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnAdd, tsbtnEdit, tsbtnShowAll, tsbtnDelete });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(368, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            tsbtnAdd.BackColor = Color.Silver;
            tsbtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnAdd.ForeColor = Color.Black;
            tsbtnAdd.Image = (Image)resources.GetObject("tsbtnAdd.Image");
            tsbtnAdd.ImageTransparentColor = Color.Magenta;
            tsbtnAdd.Margin = new Padding(10, 1, 10, 2);
            tsbtnAdd.Name = "tsbtnAdd";
            tsbtnAdd.Padding = new Padding(10, 0, 10, 0);
            tsbtnAdd.Size = new Size(53, 22);
            tsbtnAdd.Text = "Add";
            tsbtnAdd.Click += tsbtnAdd_Click;
            // 
            // tsbtnEdit
            // 
            tsbtnEdit.BackColor = Color.Silver;
            tsbtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnEdit.ForeColor = Color.Black;
            tsbtnEdit.Image = (Image)resources.GetObject("tsbtnEdit.Image");
            tsbtnEdit.ImageTransparentColor = Color.Magenta;
            tsbtnEdit.Margin = new Padding(10, 1, 10, 2);
            tsbtnEdit.Name = "tsbtnEdit";
            tsbtnEdit.Padding = new Padding(10, 0, 10, 0);
            tsbtnEdit.Size = new Size(51, 22);
            tsbtnEdit.Text = "Edit";
            // 
            // tsbtnShowAll
            // 
            tsbtnShowAll.BackColor = Color.Silver;
            tsbtnShowAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnShowAll.ForeColor = Color.Black;
            tsbtnShowAll.Image = (Image)resources.GetObject("tsbtnShowAll.Image");
            tsbtnShowAll.ImageTransparentColor = Color.Magenta;
            tsbtnShowAll.Margin = new Padding(10, 1, 10, 2);
            tsbtnShowAll.Name = "tsbtnShowAll";
            tsbtnShowAll.Padding = new Padding(10, 0, 10, 0);
            tsbtnShowAll.Size = new Size(77, 22);
            tsbtnShowAll.Text = "Show All";
            // 
            // tsbtnDelete
            // 
            tsbtnDelete.BackColor = Color.Silver;
            tsbtnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnDelete.ForeColor = Color.Black;
            tsbtnDelete.Image = (Image)resources.GetObject("tsbtnDelete.Image");
            tsbtnDelete.ImageTransparentColor = Color.Magenta;
            tsbtnDelete.Margin = new Padding(10, 1, 10, 2);
            tsbtnDelete.Name = "tsbtnDelete";
            tsbtnDelete.Padding = new Padding(10, 0, 10, 0);
            tsbtnDelete.Size = new Size(64, 22);
            tsbtnDelete.Text = "Delete";
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1048, 573);
            Controls.Add(numSalary);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(toolStripContainer1);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.White;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Base";
            Opacity = 0.95D;
            Text = "Employees Store";
            Load += Base_Load;
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPerson).EndInit();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private Label label4;
        private NumericUpDown numSalary;
        private PictureBox picPerson;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnAdd;
        private ToolStripButton tsbtnEdit;
        private ToolStripButton tsbtnShowAll;
        private ToolStripButton tsbtnDelete;
    }
}
