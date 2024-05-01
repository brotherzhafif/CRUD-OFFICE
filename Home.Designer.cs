namespace CRUD_CRUD_CRUD
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name_home = new System.Windows.Forms.Label();
            this.lbl_atas = new System.Windows.Forms.Label();
            this.lbl_judul = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_view_transaction = new System.Windows.Forms.Button();
            this.btn_transaction_package = new System.Windows.Forms.Button();
            this.btn_transaction = new System.Windows.Forms.Button();
            this.btn_package = new System.Windows.Forms.Button();
            this.btn_costumer = new System.Windows.Forms.Button();
            this.btn_service = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.DGV_employee = new System.Windows.Forms.DataGridView();
            this.idemploeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idjobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Data_Set = new CRUD_CRUD_CRUD.Employee_Data_Set();
            this.employeeTableAdapter = new CRUD_CRUD_CRUD.Employee_Data_SetTableAdapters.employeeTableAdapter();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phone_number = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_confirm_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_phone_number = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_job = new System.Windows.Forms.Label();
            this.lbl_birth_DTP = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_birth_DTP = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_id_employee = new System.Windows.Forms.TextBox();
            this.txt_search_param = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Data_Set)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbl_name_home);
            this.panel1.Controls.Add(this.lbl_atas);
            this.panel1.Controls.Add(this.lbl_judul);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // lbl_name_home
            // 
            this.lbl_name_home.AutoSize = true;
            this.lbl_name_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name_home.Location = new System.Drawing.Point(632, 9);
            this.lbl_name_home.Name = "lbl_name_home";
            this.lbl_name_home.Size = new System.Drawing.Size(120, 20);
            this.lbl_name_home.TabIndex = 12;
            this.lbl_name_home.Text = "Ini Nama Orang";
            // 
            // lbl_atas
            // 
            this.lbl_atas.AutoSize = true;
            this.lbl_atas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_atas.Location = new System.Drawing.Point(577, 9);
            this.lbl_atas.Name = "lbl_atas";
            this.lbl_atas.Size = new System.Drawing.Size(49, 20);
            this.lbl_atas.TabIndex = 11;
            this.lbl_atas.Text = "Hello,";
            // 
            // lbl_judul
            // 
            this.lbl_judul.AutoSize = true;
            this.lbl_judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_judul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_judul.Location = new System.Drawing.Point(51, 9);
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Size = new System.Drawing.Size(128, 20);
            this.lbl_judul.TabIndex = 10;
            this.lbl_judul.Text = "Esemka Laundry";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time.Location = new System.Drawing.Point(387, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(76, 20);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "Ini Waktu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(758, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.DarkGray;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(45, 40);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Hom";
            this.btn_home.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_view_transaction);
            this.panel2.Controls.Add(this.btn_transaction_package);
            this.panel2.Controls.Add(this.btn_transaction);
            this.panel2.Controls.Add(this.btn_package);
            this.panel2.Controls.Add(this.btn_costumer);
            this.panel2.Controls.Add(this.btn_service);
            this.panel2.Controls.Add(this.btn_employee);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 410);
            this.panel2.TabIndex = 1;
            // 
            // btn_view_transaction
            // 
            this.btn_view_transaction.BackColor = System.Drawing.Color.Gray;
            this.btn_view_transaction.Location = new System.Drawing.Point(0, 236);
            this.btn_view_transaction.Name = "btn_view_transaction";
            this.btn_view_transaction.Size = new System.Drawing.Size(42, 40);
            this.btn_view_transaction.TabIndex = 8;
            this.btn_view_transaction.Text = "VTR";
            this.btn_view_transaction.UseVisualStyleBackColor = false;
            // 
            // btn_transaction_package
            // 
            this.btn_transaction_package.BackColor = System.Drawing.Color.Gray;
            this.btn_transaction_package.Location = new System.Drawing.Point(0, 190);
            this.btn_transaction_package.Name = "btn_transaction_package";
            this.btn_transaction_package.Size = new System.Drawing.Size(42, 40);
            this.btn_transaction_package.TabIndex = 7;
            this.btn_transaction_package.Text = "TPC";
            this.btn_transaction_package.UseVisualStyleBackColor = false;
            // 
            // btn_transaction
            // 
            this.btn_transaction.BackColor = System.Drawing.Color.Gray;
            this.btn_transaction.Location = new System.Drawing.Point(0, 144);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(42, 40);
            this.btn_transaction.TabIndex = 6;
            this.btn_transaction.Text = "Trs";
            this.btn_transaction.UseVisualStyleBackColor = false;
            // 
            // btn_package
            // 
            this.btn_package.BackColor = System.Drawing.Color.Gray;
            this.btn_package.Location = new System.Drawing.Point(0, 98);
            this.btn_package.Name = "btn_package";
            this.btn_package.Size = new System.Drawing.Size(42, 40);
            this.btn_package.TabIndex = 5;
            this.btn_package.Text = "Pac";
            this.btn_package.UseVisualStyleBackColor = false;
            // 
            // btn_costumer
            // 
            this.btn_costumer.BackColor = System.Drawing.Color.Gray;
            this.btn_costumer.Location = new System.Drawing.Point(0, 282);
            this.btn_costumer.Name = "btn_costumer";
            this.btn_costumer.Size = new System.Drawing.Size(42, 40);
            this.btn_costumer.TabIndex = 4;
            this.btn_costumer.Text = "Cos";
            this.btn_costumer.UseVisualStyleBackColor = false;
            // 
            // btn_service
            // 
            this.btn_service.BackColor = System.Drawing.Color.Gray;
            this.btn_service.Location = new System.Drawing.Point(0, 52);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(42, 40);
            this.btn_service.TabIndex = 3;
            this.btn_service.Text = "Ser";
            this.btn_service.UseVisualStyleBackColor = false;
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.Gray;
            this.btn_employee.Location = new System.Drawing.Point(0, 6);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(42, 40);
            this.btn_employee.TabIndex = 2;
            this.btn_employee.Text = "Emp";
            this.btn_employee.UseVisualStyleBackColor = false;
            // 
            // DGV_employee
            // 
            this.DGV_employee.AllowUserToAddRows = false;
            this.DGV_employee.AllowUserToDeleteRows = false;
            this.DGV_employee.AutoGenerateColumns = false;
            this.DGV_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idemploeeDataGridViewTextBoxColumn,
            this.nameemployeeDataGridViewTextBoxColumn,
            this.emailemployeeDataGridViewTextBoxColumn,
            this.phonenumberemployeeDataGridViewTextBoxColumn,
            this.addressemployeeDataGridViewTextBoxColumn,
            this.dateofbirthemployeeDataGridViewTextBoxColumn,
            this.idjobDataGridViewTextBoxColumn,
            this.salaryemployeeDataGridViewTextBoxColumn});
            this.DGV_employee.DataSource = this.employeeBindingSource;
            this.DGV_employee.Location = new System.Drawing.Point(48, 92);
            this.DGV_employee.Name = "DGV_employee";
            this.DGV_employee.ReadOnly = true;
            this.DGV_employee.Size = new System.Drawing.Size(746, 178);
            this.DGV_employee.TabIndex = 2;
            this.DGV_employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_employee_CellClick);
            // 
            // idemploeeDataGridViewTextBoxColumn
            // 
            this.idemploeeDataGridViewTextBoxColumn.DataPropertyName = "id_emploee";
            this.idemploeeDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idemploeeDataGridViewTextBoxColumn.Name = "idemploeeDataGridViewTextBoxColumn";
            this.idemploeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idemploeeDataGridViewTextBoxColumn.Width = 25;
            // 
            // nameemployeeDataGridViewTextBoxColumn
            // 
            this.nameemployeeDataGridViewTextBoxColumn.DataPropertyName = "name_employee";
            this.nameemployeeDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameemployeeDataGridViewTextBoxColumn.Name = "nameemployeeDataGridViewTextBoxColumn";
            this.nameemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailemployeeDataGridViewTextBoxColumn
            // 
            this.emailemployeeDataGridViewTextBoxColumn.DataPropertyName = "email_employee";
            this.emailemployeeDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailemployeeDataGridViewTextBoxColumn.Name = "emailemployeeDataGridViewTextBoxColumn";
            this.emailemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberemployeeDataGridViewTextBoxColumn
            // 
            this.phonenumberemployeeDataGridViewTextBoxColumn.DataPropertyName = "phone_number_employee";
            this.phonenumberemployeeDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phonenumberemployeeDataGridViewTextBoxColumn.Name = "phonenumberemployeeDataGridViewTextBoxColumn";
            this.phonenumberemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumberemployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressemployeeDataGridViewTextBoxColumn
            // 
            this.addressemployeeDataGridViewTextBoxColumn.DataPropertyName = "address_employee";
            this.addressemployeeDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressemployeeDataGridViewTextBoxColumn.Name = "addressemployeeDataGridViewTextBoxColumn";
            this.addressemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofbirthemployeeDataGridViewTextBoxColumn
            // 
            this.dateofbirthemployeeDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth_employee";
            this.dateofbirthemployeeDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateofbirthemployeeDataGridViewTextBoxColumn.Name = "dateofbirthemployeeDataGridViewTextBoxColumn";
            this.dateofbirthemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idjobDataGridViewTextBoxColumn
            // 
            this.idjobDataGridViewTextBoxColumn.DataPropertyName = "id_job";
            this.idjobDataGridViewTextBoxColumn.HeaderText = "Job_Id";
            this.idjobDataGridViewTextBoxColumn.Name = "idjobDataGridViewTextBoxColumn";
            this.idjobDataGridViewTextBoxColumn.ReadOnly = true;
            this.idjobDataGridViewTextBoxColumn.Width = 50;
            // 
            // salaryemployeeDataGridViewTextBoxColumn
            // 
            this.salaryemployeeDataGridViewTextBoxColumn.DataPropertyName = "salary_employee";
            this.salaryemployeeDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryemployeeDataGridViewTextBoxColumn.Name = "salaryemployeeDataGridViewTextBoxColumn";
            this.salaryemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.employeeDataSetBindingSource;
            // 
            // employeeDataSetBindingSource
            // 
            this.employeeDataSetBindingSource.DataSource = this.employee_Data_Set;
            this.employeeDataSetBindingSource.Position = 0;
            // 
            // employee_Data_Set
            // 
            this.employee_Data_Set.DataSetName = "Employee_Data_Set";
            this.employee_Data_Set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_password.Location = new System.Drawing.Point(188, 421);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(147, 23);
            this.txt_confirm_password.TabIndex = 3;
            this.txt_confirm_password.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(52, 288);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name";
            this.lbl_name.Visible = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(52, 322);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 17);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email";
            this.lbl_email.Visible = false;
            // 
            // lbl_phone_number
            // 
            this.lbl_phone_number.AutoSize = true;
            this.lbl_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone_number.Location = new System.Drawing.Point(52, 354);
            this.lbl_phone_number.Name = "lbl_phone_number";
            this.lbl_phone_number.Size = new System.Drawing.Size(103, 17);
            this.lbl_phone_number.TabIndex = 6;
            this.lbl_phone_number.Text = "Phone Number";
            this.lbl_phone_number.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(52, 391);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password";
            this.lbl_password.Visible = false;
            // 
            // lbl_confirm_password
            // 
            this.lbl_confirm_password.AutoSize = true;
            this.lbl_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_password.Location = new System.Drawing.Point(52, 424);
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            this.lbl_confirm_password.Size = new System.Drawing.Size(121, 17);
            this.lbl_confirm_password.TabIndex = 8;
            this.lbl_confirm_password.Text = "Confirm Password";
            this.lbl_confirm_password.Visible = false;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(188, 385);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(147, 23);
            this.txt_password.TabIndex = 9;
            this.txt_password.Visible = false;
            // 
            // txt_phone_number
            // 
            this.txt_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone_number.Location = new System.Drawing.Point(188, 348);
            this.txt_phone_number.Name = "txt_phone_number";
            this.txt_phone_number.Size = new System.Drawing.Size(147, 23);
            this.txt_phone_number.TabIndex = 10;
            this.txt_phone_number.Visible = false;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(122, 316);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(213, 23);
            this.txt_email.TabIndex = 11;
            this.txt_email.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(122, 280);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(213, 23);
            this.txt_name.TabIndex = 12;
            this.txt_name.Visible = false;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(361, 290);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(51, 17);
            this.lbl_address.TabIndex = 13;
            this.lbl_address.Text = "Alamat";
            this.lbl_address.Visible = false;
            // 
            // lbl_job
            // 
            this.lbl_job.AutoSize = true;
            this.lbl_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_job.Location = new System.Drawing.Point(361, 351);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(62, 17);
            this.lbl_job.TabIndex = 14;
            this.lbl_job.Text = "Job Title";
            this.lbl_job.Visible = false;
            // 
            // lbl_birth_DTP
            // 
            this.lbl_birth_DTP.AutoSize = true;
            this.lbl_birth_DTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birth_DTP.Location = new System.Drawing.Point(361, 388);
            this.lbl_birth_DTP.Name = "lbl_birth_DTP";
            this.lbl_birth_DTP.Size = new System.Drawing.Size(90, 17);
            this.lbl_birth_DTP.TabIndex = 15;
            this.lbl_birth_DTP.Text = "Date Of Birth";
            this.lbl_birth_DTP.Visible = false;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(462, 282);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(251, 51);
            this.txt_address.TabIndex = 16;
            this.txt_address.Text = "";
            this.txt_address.Visible = false;
            // 
            // txt_job
            // 
            this.txt_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_job.Location = new System.Drawing.Point(462, 348);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(110, 23);
            this.txt_job.TabIndex = 17;
            this.txt_job.Visible = false;
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salary.Location = new System.Drawing.Point(578, 351);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(48, 17);
            this.lbl_salary.TabIndex = 18;
            this.lbl_salary.Text = "Salary";
            this.lbl_salary.Visible = false;
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(632, 348);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(81, 23);
            this.txt_salary.TabIndex = 19;
            this.txt_salary.Visible = false;
            // 
            // txt_birth_DTP
            // 
            this.txt_birth_DTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birth_DTP.Location = new System.Drawing.Point(462, 386);
            this.txt_birth_DTP.Name = "txt_birth_DTP";
            this.txt_birth_DTP.Size = new System.Drawing.Size(135, 23);
            this.txt_birth_DTP.TabIndex = 20;
            this.txt_birth_DTP.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gray;
            this.btn_cancel.Location = new System.Drawing.Point(719, 401);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 34);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gray;
            this.btn_update.Location = new System.Drawing.Point(719, 282);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 34);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.method);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Gray;
            this.btn_save.Location = new System.Drawing.Point(719, 361);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gray;
            this.btn_delete.Location = new System.Drawing.Point(719, 322);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 34);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.method);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Gray;
            this.btn_insert.Location = new System.Drawing.Point(48, 56);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(125, 30);
            this.btn_insert.TabIndex = 24;
            this.btn_insert.Text = "Insert Data";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.method);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Manage Employee";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(581, 63);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(95, 23);
            this.txt_search.TabIndex = 26;
            // 
            // txt_id_employee
            // 
            this.txt_id_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_employee.Location = new System.Drawing.Point(462, 421);
            this.txt_id_employee.Name = "txt_id_employee";
            this.txt_id_employee.Size = new System.Drawing.Size(87, 23);
            this.txt_id_employee.TabIndex = 27;
            // 
            // txt_search_param
            // 
            this.txt_search_param.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_param.Location = new System.Drawing.Point(693, 63);
            this.txt_search_param.Name = "txt_search_param";
            this.txt_search_param.Size = new System.Drawing.Size(95, 23);
            this.txt_search_param.TabIndex = 28;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_search_param);
            this.Controls.Add(this.txt_id_employee);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_birth_DTP);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.txt_job);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lbl_birth_DTP);
            this.Controls.Add(this.lbl_job);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone_number);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_confirm_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_phone_number);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.DGV_employee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Data_Set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_service;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Label lbl_name_home;
        private System.Windows.Forms.Label lbl_atas;
        private System.Windows.Forms.Label lbl_judul;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_view_transaction;
        private System.Windows.Forms.Button btn_transaction_package;
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Button btn_package;
        private System.Windows.Forms.Button btn_costumer;
        private System.Windows.Forms.DataGridView DGV_employee;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private Employee_Data_Set employee_Data_Set;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Employee_Data_SetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone_number;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_confirm_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_phone_number;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.Label lbl_birth_DTP;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.DateTimePicker txt_birth_DTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemploeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_id_employee;
        private System.Windows.Forms.TextBox txt_search_param;
    }
}