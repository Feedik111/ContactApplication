namespace ContactApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GroupBoxSelectedContact = new System.Windows.Forms.GroupBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.LabelVK = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelDateOfBirth = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.GroupBoxSelectedContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(16, 25);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(171, 355);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(81, 19);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(200, 20);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(81, 61);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthDateTimePicker.TabIndex = 2;
            this.DateOfBirthDateTimePicker.ValueChanged += new System.EventHandler(this.DateOfBirthDateTimePicker_ValueChanged);
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(81, 98);
            this.PhoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.PhoneMaskedTextBox.TabIndex = 3;
            this.PhoneMaskedTextBox.TextChanged += new System.EventHandler(this.PhoneMaskedTextBox_TextChanged);
            // 
            // GroupBoxSelectedContact
            // 
            this.GroupBoxSelectedContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxSelectedContact.Controls.Add(this.VKTextBox);
            this.GroupBoxSelectedContact.Controls.Add(this.LabelVK);
            this.GroupBoxSelectedContact.Controls.Add(this.LabelPhone);
            this.GroupBoxSelectedContact.Controls.Add(this.LabelDateOfBirth);
            this.GroupBoxSelectedContact.Controls.Add(this.LabelName);
            this.GroupBoxSelectedContact.Controls.Add(this.DateOfBirthDateTimePicker);
            this.GroupBoxSelectedContact.Controls.Add(this.TextBoxName);
            this.GroupBoxSelectedContact.Controls.Add(this.PhoneMaskedTextBox);
            this.GroupBoxSelectedContact.Location = new System.Drawing.Point(196, 25);
            this.GroupBoxSelectedContact.Name = "GroupBoxSelectedContact";
            this.GroupBoxSelectedContact.Size = new System.Drawing.Size(514, 236);
            this.GroupBoxSelectedContact.TabIndex = 5;
            this.GroupBoxSelectedContact.TabStop = false;
            this.GroupBoxSelectedContact.Text = "Selected Contact";
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(81, 137);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(200, 20);
            this.VKTextBox.TabIndex = 9;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // LabelVK
            // 
            this.LabelVK.AutoSize = true;
            this.LabelVK.Location = new System.Drawing.Point(51, 139);
            this.LabelVK.Name = "LabelVK";
            this.LabelVK.Size = new System.Drawing.Size(24, 13);
            this.LabelVK.TabIndex = 8;
            this.LabelVK.Text = "VK:";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Location = new System.Drawing.Point(34, 99);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(41, 13);
            this.LabelPhone.TabIndex = 7;
            this.LabelPhone.Text = "Phone:";
            // 
            // LabelDateOfBirth
            // 
            this.LabelDateOfBirth.AutoSize = true;
            this.LabelDateOfBirth.Location = new System.Drawing.Point(6, 63);
            this.LabelDateOfBirth.Name = "LabelDateOfBirth";
            this.LabelDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.LabelDateOfBirth.TabIndex = 6;
            this.LabelDateOfBirth.Text = "Date of Birth:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(18, 22);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(57, 13);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Full Name:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::ContactApplication.Properties.Resources.remove_contact_24;
            this.DeleteButton.Location = new System.Drawing.Point(58, 397);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(26, 26);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.ButtonDelete_Click);
            this.DeleteButton.MouseEnter += new System.EventHandler(this.ButtonDelete_MouseEnter);
            this.DeleteButton.MouseLeave += new System.EventHandler(this.ButtonDelete_MouseLeave);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::ContactApplication.Properties.Resources.add_contact_24;
            this.AddButton.Location = new System.Drawing.Point(16, 397);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(26, 26);
            this.AddButton.TabIndex = 6;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.ButtonAdd_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GroupBoxSelectedContact);
            this.Controls.Add(this.ContactsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "List Of Contacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GroupBoxSelectedContact.ResumeLayout(false);
            this.GroupBoxSelectedContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.GroupBox GroupBoxSelectedContact;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDateOfBirth;
        private System.Windows.Forms.Label LabelVK;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.TextBox VKTextBox;
    }
}

