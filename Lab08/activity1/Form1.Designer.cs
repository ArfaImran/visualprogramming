namespace Lab8_Activity1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            customerName = new TextBox();
            countryName = new TextBox();
            groupBoxGender = new GroupBox();
            radioFemale = new RadioButton();
            radioMale = new RadioButton();
            groupBoxHobbies = new GroupBox();
            checkBoxWriting = new CheckBox();
            checkBoxReading = new CheckBox();
            btn_preview = new Button();
            groupBoxStatus = new GroupBox();
            radioButtonUnMarried = new RadioButton();
            radioButtonMarried = new RadioButton();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            Preview = new Button();
            groupBoxGender.SuspendLayout();
            groupBoxHobbies.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Country: ";
            // 
            // customerName
            // 
            customerName.Location = new Point(141, 32);
            customerName.Name = "customerName";
            customerName.Size = new Size(189, 27);
            customerName.TabIndex = 2;
            customerName.TextChanged += textBox1_TextChanged;
            // 
            // countryName
            // 
            countryName.Location = new Point(141, 73);
            countryName.Name = "countryName";
            countryName.Size = new Size(189, 27);
            countryName.TabIndex = 3;
            countryName.TextChanged += countryName_TextChanged;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(radioFemale);
            groupBoxGender.Controls.Add(radioMale);
            groupBoxGender.Location = new Point(12, 131);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(338, 58);
            groupBoxGender.TabIndex = 4;
            groupBoxGender.TabStop = false;
            groupBoxGender.Text = "Gender";
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Location = new Point(206, 26);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(78, 24);
            radioFemale.TabIndex = 1;
            radioFemale.TabStop = true;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Location = new Point(68, 26);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(63, 24);
            radioMale.TabIndex = 0;
            radioMale.TabStop = true;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // groupBoxHobbies
            // 
            groupBoxHobbies.Controls.Add(checkBoxWriting);
            groupBoxHobbies.Controls.Add(checkBoxReading);
            groupBoxHobbies.Location = new Point(12, 209);
            groupBoxHobbies.Name = "groupBoxHobbies";
            groupBoxHobbies.Size = new Size(338, 66);
            groupBoxHobbies.TabIndex = 5;
            groupBoxHobbies.TabStop = false;
            groupBoxHobbies.Text = "Hobbies";
            // 
            // checkBoxWriting
            // 
            checkBoxWriting.AutoSize = true;
            checkBoxWriting.Location = new Point(206, 26);
            checkBoxWriting.Name = "checkBoxWriting";
            checkBoxWriting.Size = new Size(80, 24);
            checkBoxWriting.TabIndex = 1;
            checkBoxWriting.Text = "Writing";
            checkBoxWriting.UseVisualStyleBackColor = true;
            // 
            // checkBoxReading
            // 
            checkBoxReading.AutoSize = true;
            checkBoxReading.Location = new Point(68, 26);
            checkBoxReading.Name = "checkBoxReading";
            checkBoxReading.Size = new Size(86, 24);
            checkBoxReading.TabIndex = 0;
            checkBoxReading.Text = "Reading";
            checkBoxReading.UseVisualStyleBackColor = true;
            // 
            // btn_preview
            // 
            btn_preview.Location = new Point(12, 386);
            btn_preview.Name = "btn_preview";
            btn_preview.Size = new Size(94, 29);
            btn_preview.TabIndex = 2;
            btn_preview.Text = "Add";
            btn_preview.UseVisualStyleBackColor = true;
            btn_preview.Click += btn_preview_Click;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Controls.Add(radioButtonUnMarried);
            groupBoxStatus.Controls.Add(radioButtonMarried);
            groupBoxStatus.Location = new Point(12, 297);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Size = new Size(338, 66);
            groupBoxStatus.TabIndex = 6;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Status";
            // 
            // radioButtonUnMarried
            // 
            radioButtonUnMarried.AutoSize = true;
            radioButtonUnMarried.Location = new Point(206, 26);
            radioButtonUnMarried.Name = "radioButtonUnMarried";
            radioButtonUnMarried.Size = new Size(100, 24);
            radioButtonUnMarried.TabIndex = 1;
            radioButtonUnMarried.TabStop = true;
            radioButtonUnMarried.Text = "UnMarried";
            radioButtonUnMarried.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarried
            // 
            radioButtonMarried.AutoSize = true;
            radioButtonMarried.Location = new Point(72, 26);
            radioButtonMarried.Name = "radioButtonMarried";
            radioButtonMarried.Size = new Size(82, 24);
            radioButtonMarried.TabIndex = 0;
            radioButtonMarried.TabStop = true;
            radioButtonMarried.Text = "Married";
            radioButtonMarried.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(620, 406);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 386);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(256, 386);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Preview
            // 
            Preview.Location = new Point(98, 421);
            Preview.Name = "Preview";
            Preview.Size = new Size(166, 29);
            Preview.TabIndex = 10;
            Preview.Text = "Preview/Refresh";
            Preview.UseVisualStyleBackColor = true;
            Preview.Click += Preview_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 450);
            Controls.Add(Preview);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxStatus);
            Controls.Add(btn_preview);
            Controls.Add(groupBoxHobbies);
            Controls.Add(groupBoxGender);
            Controls.Add(countryName);
            Controls.Add(customerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            groupBoxHobbies.ResumeLayout(false);
            groupBoxHobbies.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox customerName;
        private TextBox countryName;
        private GroupBox groupBoxGender;
        private RadioButton radioFemale;
        private RadioButton radioMale;
        private GroupBox groupBoxHobbies;
        private Button btn_preview;
        private CheckBox checkBoxWriting;
        private CheckBox checkBoxReading;
        private GroupBox groupBoxStatus;
        private RadioButton radioButtonUnMarried;
        private RadioButton radioButtonMarried;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button Preview;
    }
}
