namespace LicenceApp
{
    partial class FrmKorisnik
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();


            this.lstStudents.Location = new System.Drawing.Point(119, 231);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(409, 164);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.LstStudents_SelectedIndexChanged);


            this.lbName.Location = new System.Drawing.Point(549, 246);
            this.lbName.Text = "Ime: ";
            this.lbLastName.Location = new System.Drawing.Point(549, 273);
            this.lbLastName.Text = "Prezime: ";
            this.lbEmail.Location = new System.Drawing.Point(549, 305);
            this.lbEmail.Text = "Email: ";
            this.lbPassword.Location = new System.Drawing.Point(549, 332);
            this.lbPassword.Text = "Lozinka: ";
            this.lbRole.Location = new System.Drawing.Point(549, 361);
            this.lbRole.Text = "Uloga:";


            this.txName.Location = new System.Drawing.Point(632, 243);
            this.txName.Size = new System.Drawing.Size(216, 22);
            this.txtLastName.Location = new System.Drawing.Point(632, 273);
            this.txtLastName.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.Location = new System.Drawing.Point(632, 302);
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtPassword.Location = new System.Drawing.Point(632, 330);
            this.txtPassword.Size = new System.Drawing.Size(216, 22);
            this.cmbRole.Location = new System.Drawing.Point(632, 358);
            this.cmbRole.Size = new System.Drawing.Size(216, 24);


            this.btnAdd.Location = new System.Drawing.Point(904, 283);
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.btnEdit.Location = new System.Drawing.Point(904, 325);
            this.btnEdit.Text = "Uredi";
            this.btnEdit.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.btnDelete.Location = new System.Drawing.Point(904, 354);
            this.btnDelete.Text = "Obriši";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.btnMain.Location = new System.Drawing.Point(174, 401);
            this.btnMain.Text = "Izbornik";
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            this.btnBack.Location = new System.Drawing.Point(119, 401);
            this.btnBack.Text = "←";
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);


            this.ClientSize = new System.Drawing.Size(1189, 579);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lbName); this.Controls.Add(this.txName);
            this.Controls.Add(this.lbLastName); this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lbEmail); this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbPassword); this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbRole); this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnAdd); this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete); this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmKorisnik";
            this.Text = "Korisnici";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnBack;
    }
}