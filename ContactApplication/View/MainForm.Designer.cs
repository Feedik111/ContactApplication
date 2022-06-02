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
            this.ListBoxContacts = new System.Windows.Forms.ListBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.DateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.MaskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.GroupBoxSelectedContact = new System.Windows.Forms.GroupBox();
            this.TextBoxVK = new System.Windows.Forms.TextBox();
            this.LabelVK = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelDateOfBirth = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.GroupBoxSelectedContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxContacts
            // 
            this.ListBoxContacts.FormattingEnabled = true;
            this.ListBoxContacts.Location = new System.Drawing.Point(16, 25);
            this.ListBoxContacts.Name = "ListBoxContacts";
            this.ListBoxContacts.Size = new System.Drawing.Size(171, 355);
            this.ListBoxContacts.TabIndex = 0;
            this.ListBoxContacts.SelectedIndexChanged += new System.EventHandler(this.ListBoxContacts_SelectedIndexChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(81, 19);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(268, 20);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // DateTimePickerDateOfBirth
            // 
            this.DateTimePickerDateOfBirth.Location = new System.Drawing.Point(81, 66);
            this.DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
            this.DateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerDateOfBirth.TabIndex = 2;
            // 
            // MaskedTextBoxPhone
            // 
            this.MaskedTextBoxPhone.Location = new System.Drawing.Point(81, 103);
            this.MaskedTextBoxPhone.Mask = "+7 (999) 000-0000";
            this.MaskedTextBoxPhone.Name = "MaskedTextBoxPhone";
            this.MaskedTextBoxPhone.Size = new System.Drawing.Size(200, 20);
            this.MaskedTextBoxPhone.TabIndex = 3;
            this.MaskedTextBoxPhone.TextChanged += new System.EventHandler(this.PhoneMaskedTextBox_TextChanged);
            // 
            // GroupBoxSelectedContact
            // 
            this.GroupBoxSelectedContact.Controls.Add(this.TextBoxVK);
            this.GroupBoxSelectedContact.Controls.Add(this.LabelVK);
            this.GroupBoxSelectedContact.Controls.Add(this.LabelPhone);
            this.GroupBoxSelectedContact.Controls.Add(this.LabelDateOfBirth);
            this.GroupBoxSelectedContact.Controls.Add(this.LabelName);
            this.GroupBoxSelectedContact.Controls.Add(this.DateTimePickerDateOfBirth);
            this.GroupBoxSelectedContact.Controls.Add(this.TextBoxName);
            this.GroupBoxSelectedContact.Controls.Add(this.MaskedTextBoxPhone);
            this.GroupBoxSelectedContact.Location = new System.Drawing.Point(196, 25);
            this.GroupBoxSelectedContact.Name = "GroupBoxSelectedContact";
            this.GroupBoxSelectedContact.Size = new System.Drawing.Size(514, 236);
            this.GroupBoxSelectedContact.TabIndex = 5;
            this.GroupBoxSelectedContact.TabStop = false;
            this.GroupBoxSelectedContact.Text = "Selected Contact";
            // 
            // TextBoxVK
            // 
            this.TextBoxVK.Location = new System.Drawing.Point(81, 146);
            this.TextBoxVK.Name = "TextBoxVK";
            this.TextBoxVK.Size = new System.Drawing.Size(200, 20);
            this.TextBoxVK.TabIndex = 9;
            this.TextBoxVK.TextChanged += new System.EventHandler(this.TextBoxVK_TextChanged);
            // 
            // LabelVK
            // 
            this.LabelVK.AutoSize = true;
            this.LabelVK.Location = new System.Drawing.Point(51, 146);
            this.LabelVK.Name = "LabelVK";
            this.LabelVK.Size = new System.Drawing.Size(24, 13);
            this.LabelVK.TabIndex = 8;
            this.LabelVK.Text = "VK:";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Location = new System.Drawing.Point(34, 105);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(41, 13);
            this.LabelPhone.TabIndex = 7;
            this.LabelPhone.Text = "Phone:";
            // 
            // LabelDateOfBirth
            // 
            this.LabelDateOfBirth.AutoSize = true;
            this.LabelDateOfBirth.Location = new System.Drawing.Point(6, 69);
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
            // ButtonDelete
            // 
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Image = global::ContactApplication.Properties.Resources.remove_contact_24;
            this.ButtonDelete.Location = new System.Drawing.Point(58, 397);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(26, 26);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            this.ButtonDelete.MouseEnter += new System.EventHandler(this.ButtonDelete_MouseEnter);
            this.ButtonDelete.MouseLeave += new System.EventHandler(this.ButtonDelete_MouseLeave);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Image = global::ContactApplication.Properties.Resources.add_contact_24;
            this.ButtonAdd.Location = new System.Drawing.Point(16, 397);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(26, 26);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            this.ButtonAdd.MouseEnter += new System.EventHandler(this.ButtonAdd_MouseEnter);
            this.ButtonAdd.MouseLeave += new System.EventHandler(this.ButtonAdd_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.GroupBoxSelectedContact);
            this.Controls.Add(this.ListBoxContacts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "List Of Contacts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GroupBoxSelectedContact.ResumeLayout(false);
            this.GroupBoxSelectedContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxContacts;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateOfBirth;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPhone;
        private System.Windows.Forms.GroupBox GroupBoxSelectedContact;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDateOfBirth;
        private System.Windows.Forms.Label LabelVK;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.TextBox TextBoxVK;
    }
}

