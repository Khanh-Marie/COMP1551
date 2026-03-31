using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

public class MainMenu : Form
{
    SqlConnection myConnection;
    private ComboBox comboBox3;
    private Label welcomeText;
    private TabPage addPage;
    private Button addButton;
    private TextBox subjectsInput;
    private TextBox salaryInput;
    private TextBox emailInput;
    private TextBox nameInput;
    private ComboBox fullPartBox;
    private ComboBox roleBox;
    private Label workingHoursText;
    private Label fullPartText;
    private Label subjectsText;
    private Label salaryText;
    private Label roleText;
    private Label emailText;
    private Label nameText;
    private TabPage viewPage;
    private Button viewAllButton;
    private Button filterButton;
    private ComboBox filterBox;
    private TabControl tabControl1;
    private TabPage editPage;
    private TabPage deletePage;
    private DataGridView dataGridView1;
    private ComboBox workingHoursBox;
    private Button viewCURButton;
    private DataGridView dataGridView2;
    private Button saveButton;
    private DataGridView dataGridView3;
    private Button viewDeleteButton;
    private Button deleteButton;
    private TextBox deleteIDInput;
    private System.ComponentModel.IContainer components;

    private void InitializeComponent()
    {
        welcomeText = new Label();
        addPage = new TabPage();
        workingHoursBox = new ComboBox();
        addButton = new Button();
        subjectsInput = new TextBox();
        salaryInput = new TextBox();
        emailInput = new TextBox();
        nameInput = new TextBox();
        fullPartBox = new ComboBox();
        roleBox = new ComboBox();
        workingHoursText = new Label();
        fullPartText = new Label();
        subjectsText = new Label();
        salaryText = new Label();
        roleText = new Label();
        emailText = new Label();
        nameText = new Label();
        viewPage = new TabPage();
        dataGridView1 = new DataGridView();
        viewAllButton = new Button();
        filterButton = new Button();
        filterBox = new ComboBox();
        tabControl1 = new TabControl();
        editPage = new TabPage();
        saveButton = new Button();
        dataGridView2 = new DataGridView();
        viewCURButton = new Button();
        deletePage = new TabPage();
        deleteIDInput = new TextBox();
        deleteButton = new Button();
        dataGridView3 = new DataGridView();
        viewDeleteButton = new Button();
        addPage.SuspendLayout();
        viewPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        tabControl1.SuspendLayout();
        editPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        deletePage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
        SuspendLayout();
        // 
        // welcomeText
        // 
        welcomeText.AutoSize = true;
        welcomeText.Location = new Point(16, 9);
        welcomeText.Name = "welcomeText";
        welcomeText.Size = new Size(57, 15);
        welcomeText.TabIndex = 1;
        welcomeText.Text = "Welcome";
        // 
        // addPage
        // 
        addPage.Controls.Add(workingHoursBox);
        addPage.Controls.Add(addButton);
        addPage.Controls.Add(subjectsInput);
        addPage.Controls.Add(salaryInput);
        addPage.Controls.Add(emailInput);
        addPage.Controls.Add(nameInput);
        addPage.Controls.Add(fullPartBox);
        addPage.Controls.Add(roleBox);
        addPage.Controls.Add(workingHoursText);
        addPage.Controls.Add(fullPartText);
        addPage.Controls.Add(subjectsText);
        addPage.Controls.Add(salaryText);
        addPage.Controls.Add(roleText);
        addPage.Controls.Add(emailText);
        addPage.Controls.Add(nameText);
        addPage.Location = new Point(4, 24);
        addPage.Name = "addPage";
        addPage.Padding = new Padding(3);
        addPage.Size = new Size(855, 572);
        addPage.TabIndex = 1;
        addPage.Text = "Add";
        addPage.UseVisualStyleBackColor = true;
        // 
        // workingHoursBox
        // 
        workingHoursBox.FormattingEnabled = true;
        workingHoursBox.Items.AddRange(new object[] { "8h-12h", "13h-17h" });
        workingHoursBox.Location = new Point(125, 271);
        workingHoursBox.Name = "workingHoursBox";
        workingHoursBox.Size = new Size(185, 23);
        workingHoursBox.TabIndex = 15;
        // 
        // addButton
        // 
        addButton.Location = new Point(177, 300);
        addButton.Name = "addButton";
        addButton.Size = new Size(75, 23);
        addButton.TabIndex = 14;
        addButton.Text = "Add";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // subjectsInput
        // 
        subjectsInput.Location = new Point(125, 169);
        subjectsInput.Name = "subjectsInput";
        subjectsInput.Size = new Size(185, 23);
        subjectsInput.TabIndex = 11;
        // 
        // salaryInput
        // 
        salaryInput.Location = new Point(125, 198);
        salaryInput.Name = "salaryInput";
        salaryInput.Size = new Size(185, 23);
        salaryInput.TabIndex = 10;
        // 
        // emailInput
        // 
        emailInput.Location = new Point(125, 84);
        emailInput.Name = "emailInput";
        emailInput.Size = new Size(185, 23);
        emailInput.TabIndex = 9;
        // 
        // nameInput
        // 
        nameInput.Location = new Point(125, 44);
        nameInput.Name = "nameInput";
        nameInput.Size = new Size(185, 23);
        nameInput.TabIndex = 8;
        // 
        // fullPartBox
        // 
        fullPartBox.FormattingEnabled = true;
        fullPartBox.Items.AddRange(new object[] { "Full-Time", "Part-Time" });
        fullPartBox.Location = new Point(125, 234);
        fullPartBox.Name = "fullPartBox";
        fullPartBox.Size = new Size(185, 23);
        fullPartBox.TabIndex = 12;
        // 
        // roleBox
        // 
        roleBox.FormattingEnabled = true;
        roleBox.Location = new Point(125, 128);
        roleBox.Name = "roleBox";
        roleBox.Size = new Size(185, 23);
        roleBox.TabIndex = 7;
        // 
        // workingHoursText
        // 
        workingHoursText.AutoSize = true;
        workingHoursText.Location = new Point(32, 274);
        workingHoursText.Name = "workingHoursText";
        workingHoursText.Size = new Size(87, 15);
        workingHoursText.TabIndex = 6;
        workingHoursText.Text = "Working Hours";
        // 
        // fullPartText
        // 
        fullPartText.AutoSize = true;
        fullPartText.Location = new Point(67, 237);
        fullPartText.Name = "fullPartText";
        fullPartText.Size = new Size(52, 15);
        fullPartText.TabIndex = 5;
        fullPartText.Text = "Full/Part";
        // 
        // subjectsText
        // 
        subjectsText.AutoSize = true;
        subjectsText.Location = new Point(68, 172);
        subjectsText.Name = "subjectsText";
        subjectsText.Size = new Size(51, 15);
        subjectsText.TabIndex = 4;
        subjectsText.Text = "Subjects";
        // 
        // salaryText
        // 
        salaryText.AutoSize = true;
        salaryText.Location = new Point(81, 201);
        salaryText.Name = "salaryText";
        salaryText.Size = new Size(38, 15);
        salaryText.TabIndex = 3;
        salaryText.Text = "Salary";
        // 
        // roleText
        // 
        roleText.AutoSize = true;
        roleText.Location = new Point(89, 131);
        roleText.Name = "roleText";
        roleText.Size = new Size(30, 15);
        roleText.TabIndex = 2;
        roleText.Text = "Role";
        // 
        // emailText
        // 
        emailText.AutoSize = true;
        emailText.Location = new Point(83, 92);
        emailText.Name = "emailText";
        emailText.Size = new Size(36, 15);
        emailText.TabIndex = 1;
        emailText.Text = "Email";
        // 
        // nameText
        // 
        nameText.AutoSize = true;
        nameText.Location = new Point(80, 52);
        nameText.Name = "nameText";
        nameText.Size = new Size(39, 15);
        nameText.TabIndex = 0;
        nameText.Text = "Name";
        // 
        // viewPage
        // 
        viewPage.Controls.Add(dataGridView1);
        viewPage.Controls.Add(viewAllButton);
        viewPage.Controls.Add(filterButton);
        viewPage.Controls.Add(filterBox);
        viewPage.Location = new Point(4, 24);
        viewPage.Name = "viewPage";
        viewPage.Padding = new Padding(3);
        viewPage.Size = new Size(855, 572);
        viewPage.TabIndex = 0;
        viewPage.Text = "View";
        viewPage.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(0, 35);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.Size = new Size(853, 440);
        dataGridView1.TabIndex = 4;
        // 
        // viewAllButton
        // 
        viewAllButton.Location = new Point(3, 6);
        viewAllButton.Name = "viewAllButton";
        viewAllButton.Size = new Size(104, 23);
        viewAllButton.TabIndex = 3;
        viewAllButton.Text = "View All";
        viewAllButton.UseVisualStyleBackColor = true;
        viewAllButton.Click += viewAllbutton_Click;
        // 
        // filterButton
        // 
        filterButton.Location = new Point(257, 7);
        filterButton.Name = "filterButton";
        filterButton.Size = new Size(75, 23);
        filterButton.TabIndex = 2;
        filterButton.Text = "Filter";
        filterButton.UseVisualStyleBackColor = true;
        filterButton.Click += filterButton_Click;
        // 
        // filterBox
        // 
        filterBox.FormattingEnabled = true;
        filterBox.Items.AddRange(new object[] { "Teacher", "Student", "Admin" });
        filterBox.Location = new Point(113, 7);
        filterBox.Name = "filterBox";
        filterBox.Size = new Size(138, 23);
        filterBox.TabIndex = 1;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(viewPage);
        tabControl1.Controls.Add(addPage);
        tabControl1.Controls.Add(editPage);
        tabControl1.Controls.Add(deletePage);
        tabControl1.Location = new Point(12, 27);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(863, 600);
        tabControl1.TabIndex = 0;
        // 
        // editPage
        // 
        editPage.Controls.Add(saveButton);
        editPage.Controls.Add(dataGridView2);
        editPage.Controls.Add(viewCURButton);
        editPage.Location = new Point(4, 24);
        editPage.Name = "editPage";
        editPage.Padding = new Padding(3);
        editPage.Size = new Size(855, 572);
        editPage.TabIndex = 2;
        editPage.Text = "Edit";
        editPage.UseVisualStyleBackColor = true;
        // 
        // saveButton
        // 
        saveButton.Location = new Point(151, 6);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(96, 23);
        saveButton.TabIndex = 3;
        saveButton.Text = "Save Changes";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // dataGridView2
        // 
        dataGridView2.AllowUserToAddRows = false;
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(0, 35);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.Size = new Size(852, 440);
        dataGridView2.TabIndex = 2;
        // 
        // viewCURButton
        // 
        viewCURButton.Location = new Point(6, 6);
        viewCURButton.Name = "viewCURButton";
        viewCURButton.Size = new Size(139, 23);
        viewCURButton.TabIndex = 1;
        viewCURButton.Text = "View";
        viewCURButton.UseVisualStyleBackColor = true;
        viewCURButton.Click += viewCURButton_Click;
        // 
        // deletePage
        // 
        deletePage.Controls.Add(deleteIDInput);
        deletePage.Controls.Add(deleteButton);
        deletePage.Controls.Add(dataGridView3);
        deletePage.Controls.Add(viewDeleteButton);
        deletePage.Location = new Point(4, 24);
        deletePage.Name = "deletePage";
        deletePage.Padding = new Padding(3);
        deletePage.Size = new Size(855, 572);
        deletePage.TabIndex = 3;
        deletePage.Text = "Delete";
        deletePage.UseVisualStyleBackColor = true;
        // 
        // deleteIDInput
        // 
        deleteIDInput.Location = new Point(151, 10);
        deleteIDInput.Name = "deleteIDInput";
        deleteIDInput.Size = new Size(100, 23);
        deleteIDInput.TabIndex = 6;
        // 
        // deleteButton
        // 
        deleteButton.Location = new Point(257, 9);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(75, 23);
        deleteButton.TabIndex = 5;
        deleteButton.Text = "Delete ID";
        deleteButton.UseVisualStyleBackColor = true;
        deleteButton.Click += deleteButton_Click;
        // 
        // dataGridView3
        // 
        dataGridView3.AllowUserToAddRows = false;
        dataGridView3.AllowUserToDeleteRows = false;
        dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView3.Location = new Point(0, 38);
        dataGridView3.Name = "dataGridView3";
        dataGridView3.Size = new Size(852, 440);
        dataGridView3.TabIndex = 4;
        // 
        // viewDeleteButton
        // 
        viewDeleteButton.Location = new Point(6, 9);
        viewDeleteButton.Name = "viewDeleteButton";
        viewDeleteButton.Size = new Size(139, 23);
        viewDeleteButton.TabIndex = 3;
        viewDeleteButton.Text = "View";
        viewDeleteButton.UseVisualStyleBackColor = true;
        viewDeleteButton.Click += viewDeleteButton_Click;
        // 
        // MainMenu
        // 
        ClientSize = new Size(939, 600);
        Controls.Add(welcomeText);
        Controls.Add(tabControl1);
        Name = "MainMenu";
        addPage.ResumeLayout(false);
        addPage.PerformLayout();
        viewPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        tabControl1.ResumeLayout(false);
        editPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        deletePage.ResumeLayout(false);
        deletePage.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    //Store the logged in user's role
    private string currentUserRole;
    public MainMenu(string role)
    {
        //Stores the role from Form1 as currentUserRole
        currentUserRole = role;
        InitializeComponent();
        //App Appeareance
        this.Text = "Education Centre Management System";
        this.Size = new System.Drawing.Size(900, 600);
        this.StartPosition = FormStartPosition.CenterScreen;

        //Change text to fit the current user role in the edit and delete tab
        viewCURButton.Text = $"View {currentUserRole} records";
        viewDeleteButton.Text = $"View {currentUserRole} records";

        //Initialize accessControl funcion by using the currentUserRole variable
        accessControl();

        //Connect to a database
        String connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MYDATABASE;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=0";
        myConnection = new SqlConnection(connectionString);
    }

    //accessControl function is used to limit the access of each role.
    //For example, if the current user is a student, then adding a new student record; the student attributes should not contain salary like teacher or admin.
    private void accessControl()
    {
        switch (currentUserRole)
        {
            case "student":
                roleBox.Items.Add(currentUserRole);
                salaryText.Enabled = false;
                salaryInput.Enabled = false;
                fullPartBox.Enabled = false;
                fullPartText.Enabled = false;
                workingHoursBox.Enabled = false;
                workingHoursText.Enabled = false;
                break;

            case "teacher":
                roleBox.Items.Add(currentUserRole);
                fullPartBox.Enabled = false;
                fullPartText.Enabled = false;
                workingHoursBox.Enabled = false;
                workingHoursText.Enabled = false;
                break;

            case "admin":
                roleBox.Items.Add(currentUserRole);
                subjectsInput.Enabled = false;
                subjectsText.Enabled = false;
                break;

            default:
                break;
        }
    }

    //View all button function to list out all data from all tables regardless of additional data from each tables
    private void viewAllbutton_Click(object sender, EventArgs e)
    {
        try
        {
            myConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(@"
             SELECT 
                'Student' AS Role,
                id, 
                name, 
                email, 
                subjects AS Subjects,
                NULL AS Salary,
                NULL AS FullPart,
                NULL AS WorkingHours
            FROM student
            
            UNION ALL
            
            SELECT 
                'Teacher' AS Role,
                id, 
                name, 
                email, 
                subjects AS Subjects,
                salary AS Salary,
                NULL AS FullPart,
                NULL AS WorkingHours
            FROM teacher
            
            UNION ALL
            
            SELECT 
                'Admin' AS Role,
                id, 
                name, 
                email, 
                NULL AS Subjects,
                salary AS Salary,
                fullPart AS FullPart,
                workingHours AS WorkingHours
            FROM admin;", myConnection);
            SqlDataReader result = sqlCommand.ExecuteReader();

            //Stores all the data from above to a table format
            DataTable dt = new DataTable();
            dt.Load(result);

            //Load data to the data grid
            dataGridView1.DataSource = dt;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        myConnection.Close();
    }

    //Filter button function used to list out data by role (e.g. student, teacher, admin)
    private void filterButton_Click(object sender, EventArgs e)
    {
        try
        {
            myConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"select * from {filterBox.Text}", myConnection);
            SqlDataReader filteredResult = sqlCommand.ExecuteReader();
            DataTable filteredTable = new DataTable();
            filteredTable.Load(filteredResult);
            dataGridView1.DataSource = filteredTable;
        }
        catch (Exception ex)
        {
            //Error message if users has not input anything or invalid input
            if (string.IsNullOrWhiteSpace(filterBox.Text))
            {
                MessageBox.Show("Please choose a filter");
                return;
            }
            else
            {
                MessageBox.Show(ex.Message);
            }
        }
        myConnection.Close();
    }

    //Add new record based on current user role
    private void addButton_Click(object sender, EventArgs e)
    {
        //This section checks if the fields are empty or not
        //The IsNullOrEmpty checks for empty and allow for white spaces, while IsNullOrWhiteSpace checks for empty but does not allow white spaces
        //Check for common attributes like name, email, role are empty or not before adding with message box if they are empty or wrong format
        if (string.IsNullOrEmpty(nameInput.Text))
        {
            MessageBox.Show("Name is required");
            return;
        }

        if (string.IsNullOrWhiteSpace(emailInput.Text))
        {
            MessageBox.Show("Email is required");
            return;
        }
        else if (!emailInput.Text.Contains("@gmail.com"))
        {
            MessageBox.Show("Please enter the correct format for email");
            return;
        }

        if (string.IsNullOrEmpty(roleBox.Text))
        {
            MessageBox.Show("Role is required");
            return;
        }

        //Check for common attribute "subjects" for student and teacher only
        if (currentUserRole == "student" && string.IsNullOrEmpty(subjectsInput.Text))
        {
            MessageBox.Show("Please enter 2 subjects for student");
            return;
        }

        else if (currentUserRole == "teacher" && string.IsNullOrEmpty(subjectsInput.Text))
        {
            MessageBox.Show("Please enter 3 subjects for teacher");
            return;
        }

        //Check for common attribute "salary" for teacher and admin only
        if (currentUserRole == "teacher" || currentUserRole == "admin")
        {
            if (string.IsNullOrWhiteSpace(salaryInput.Text))
            {
                MessageBox.Show("Salary is required for " + currentUserRole);
                return;
            }
        }

        //Check for admin specific attributes only
        if (currentUserRole == "admin")
        {
            if (string.IsNullOrEmpty(fullPartBox.Text))
            {
                MessageBox.Show("Full/Part time is required for admin");
                return;
            }
            if (string.IsNullOrWhiteSpace(workingHoursBox.Text))
            {
                MessageBox.Show("Working Hours is required for admin");
                return;
            }
        }

        //Adding a new record based on current user role
        try
        {
            myConnection.Open();
            switch (currentUserRole)
            {
                case "student":
                    SqlCommand studentCommand = new SqlCommand($"INSERT INTO student(name, email, role, subjects) " +
                        $"VALUES ('{nameInput.Text}', '{emailInput.Text}', '{roleBox.Text}', '{subjectsInput.Text}');", myConnection);
                    int rowsAffected = studentCommand.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Student record has been added successfully");
                    }
                    break;

                case "teacher":
                    SqlCommand teacherCommand = new SqlCommand($"INSERT INTO teacher(name, email, role, salary, subjects) " +
                        $"VALUES ('{nameInput.Text}', '{emailInput.Text}', '{roleBox.Text}', '{float.Parse(salaryInput.Text)}', '{subjectsInput.Text}');", myConnection);
                    rowsAffected = teacherCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Teacher record has been added successfully");
                    }
                    break;

                case "admin":
                    SqlCommand adminCommand = new SqlCommand($"INSERT INTO admin(name, email, role, salary, fullPart, workingHours) " +
                        $"VALUES ('{nameInput.Text}', '{emailInput.Text}', '{roleBox.Text}', '{float.Parse(salaryInput.Text)}', '{fullPartBox.Text}', '{workingHoursBox.Text}');", myConnection);
                    rowsAffected = adminCommand.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Admin record has been added successfully");
                    }
                    break;

                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        myConnection.Close();
    }

    //List out all records based on the current user role in the editing tab
    private void viewCURButton_Click(object sender, EventArgs e)
    {
        try
        {
            myConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"select * from {currentUserRole}", myConnection);
            SqlDataReader editResult = sqlCommand.ExecuteReader();
            DataTable editTable = new DataTable();
            editTable.Load(editResult);
            dataGridView2.DataSource = editTable;
        }
        catch (Exception ex)
        {

        }
        myConnection.Close();
    }

    //This function allows the current user to edit and save changes based on their role
    private void saveButton_Click(object sender, EventArgs e)
    {
        DataTable curTable = (DataTable)dataGridView2.DataSource;
        switch (currentUserRole)
        {
            case "student":
                foreach (DataRow row in curTable.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(
                            "UPDATE student SET name = @name, email = @email, subjects = @subjects WHERE id = @id", myConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@name", row["name"]);
                            sqlCommand.Parameters.AddWithValue("@email", row["email"]);
                            sqlCommand.Parameters.AddWithValue("@subjects", row["subjects"]);
                            sqlCommand.Parameters.AddWithValue("@id", row["id"]);
                            myConnection.Open();
                            int rowsAffected = sqlCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                dataGridView2.Refresh();
                                MessageBox.Show("Changes Saved Successfully");
                            }
                            myConnection.Close();
                        }
                    }
                }
                break;

            case "teacher":
                foreach (DataRow row in curTable.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(
                            "UPDATE teacher SET name = @name, email = @email, salary = @salary, subjects = @subjects WHERE id = @id", myConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@name", row["name"]);
                            sqlCommand.Parameters.AddWithValue("@email", row["email"]);
                            sqlCommand.Parameters.AddWithValue("@salary", row["salary"]);
                            sqlCommand.Parameters.AddWithValue("@subjects", row["subjects"]);
                            sqlCommand.Parameters.AddWithValue("@id", row["id"]);
                            myConnection.Open();
                            int rowsAffected = sqlCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                dataGridView2.Refresh();
                                MessageBox.Show("Edit Successfully");
                            }
                            myConnection.Close();
                        }
                    }
                }

                break;
            case "admin":
                foreach (DataRow row in curTable.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(
                            "UPDATE admin SET name = @name, email = @email, salary = @salary, fullPart = @fullPart, workingHours = @workingHours WHERE id = @id", myConnection))
                        {
                            sqlCommand.Parameters.AddWithValue("@name", row["name"]);
                            sqlCommand.Parameters.AddWithValue("@email", row["email"]);
                            sqlCommand.Parameters.AddWithValue("@salary", row["salary"]);
                            sqlCommand.Parameters.AddWithValue("@fullPart", row["fullPart"]);
                            sqlCommand.Parameters.AddWithValue("@workingHours", row["workingHours"]);
                            sqlCommand.Parameters.AddWithValue("@id", row["id"]);
                            myConnection.Open();
                            int rowsAffected = sqlCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                dataGridView2.Refresh();
                                MessageBox.Show("Edit Successfully");
                            }
                            myConnection.Close();
                        }
                    }
                }
                break;

            default:
                break;
        }
    }

    //List out all records based on the current user role in the delete tab
    private void viewDeleteButton_Click(object sender, EventArgs e)
    {
        try
        {
            myConnection.Open();
            SqlCommand sqlCommand = new SqlCommand($"select * from {currentUserRole}", myConnection);
            SqlDataReader deleteResult = sqlCommand.ExecuteReader();
            DataTable deleteTable = new DataTable();
            deleteTable.Load(deleteResult);
            dataGridView3.DataSource = deleteTable;
        }
        catch (Exception ex)
        {

        }
        myConnection.Close();
    }

    //Delete function based on current user role
    private void deleteButton_Click(object sender, EventArgs e)
    {
        //Warning message asking for confirmation
        DialogResult delete = MessageBox.Show($"Are you sure you want to delete this {currentUserRole} record ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if(delete == DialogResult.Yes)
        {
            //Check for empty or white space input
            if(string.IsNullOrWhiteSpace(deleteIDInput.Text))
            {
                MessageBox.Show("Invalid ID Input");
            }
            else
            {
                try
                {
                    myConnection.Open();
                    SqlCommand deleteCmd = new SqlCommand($"DELETE FROM {currentUserRole} WHERE id={deleteIDInput.Text}", myConnection);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Delete Successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete: {ex.Message}");
                }
                myConnection.Close();
            }
        }
        else
        {
            return;
        }
    }
}
