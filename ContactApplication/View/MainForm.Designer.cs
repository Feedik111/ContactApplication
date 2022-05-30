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
            this.ListBoxContacts = new System.Windows.Forms.ListBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.DateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.MaskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBoxTelegram = new System.Windows.Forms.MaskedTextBox();
            this.GroupBoxSelectedContact = new System.Windows.Forms.GroupBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.GroupBoxSelectedContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxContacts
            // 
            this.ListBoxContacts.FormattingEnabled = true;
            this.ListBoxContacts.Location = new System.Drawing.Point(16, 25);
            this.ListBoxContacts.Name = "ListBoxContacts";
            this.ListBoxContacts.Size = new System.Drawing.Size(120, 355);
            this.ListBoxContacts.TabIndex = 0;
            this.ListBoxContacts.SelectedIndexChanged += new System.EventHandler(this.ListBoxContacts_SelectedIndexChanged);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(122, 19);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(268, 20);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // DateTimePickerDateOfBirth
            // 
            this.DateTimePickerDateOfBirth.Location = new System.Drawing.Point(122, 63);
            this.DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth";
            this.DateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerDateOfBirth.TabIndex = 2;
            // 
            // MaskedTextBoxPhone
            // 
            this.MaskedTextBoxPhone.Location = new System.Drawing.Point(122, 103);
            this.MaskedTextBoxPhone.Mask = "+7 (999) 000-0000";
            this.MaskedTextBoxPhone.Name = "MaskedTextBoxPhone";
            this.MaskedTextBoxPhone.Size = new System.Drawing.Size(200, 20);
            this.MaskedTextBoxPhone.TabIndex = 3;
            // 
            // MaskedTextBoxTelegram
            // 
            this.MaskedTextBoxTelegram.Location = new System.Drawing.Point(122, 145);
            this.MaskedTextBoxTelegram.Name = "MaskedTextBoxTelegram";
            this.MaskedTextBoxTelegram.Size = new System.Drawing.Size(200, 20);
            this.MaskedTextBoxTelegram.TabIndex = 4;
            // 
            // GroupBoxSelectedContact
            // 
            this.GroupBoxSelectedContact.Controls.Add(this.DateTimePickerDateOfBirth);
            this.GroupBoxSelectedContact.Controls.Add(this.MaskedTextBoxTelegram);
            this.GroupBoxSelectedContact.Controls.Add(this.TextBoxName);
            this.GroupBoxSelectedContact.Controls.Add(this.MaskedTextBoxPhone);
            this.GroupBoxSelectedContact.Location = new System.Drawing.Point(166, 25);
            this.GroupBoxSelectedContact.Name = "GroupBoxSelectedContact";
            this.GroupBoxSelectedContact.Size = new System.Drawing.Size(406, 200);
            this.GroupBoxSelectedContact.TabIndex = 5;
            this.GroupBoxSelectedContact.TabStop = false;
            this.GroupBoxSelectedContact.Text = "Selected Contact";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(16, 400);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "ButtonAdd";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(112, 400);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "ButtonDelete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.GroupBoxSelectedContact);
            this.Controls.Add(this.ListBoxContacts);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.GroupBoxSelectedContact.ResumeLayout(false);
            this.GroupBoxSelectedContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxContacts;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateOfBirth;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPhone;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxTelegram;
        private System.Windows.Forms.GroupBox GroupBoxSelectedContact;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
    }
}

