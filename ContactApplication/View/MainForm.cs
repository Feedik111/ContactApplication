using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactApplication.Model;
using Contact = ContactApplication.Model.Contact;

namespace ContactApplication
{
    public partial class MainForm : Form
    {

        private List<Contact> _contacts = new List<Contact>();

        private Contact _currentContact;
        public MainForm()
        {
            InitializeComponent();
            DateTimePickerDateOfBirth.MinDate = new DateTime(1900, 1, 1);
            DateTimePickerDateOfBirth.MaxDate = DateTime.Today;
        }

        private void UpdateContactList(List<Contact> contacts)
        {
            ListBoxContacts.Items.Clear();
            var orderedListContacts = from contact in _contacts
                                      orderby contact.FullName
                                      select contact;

            _contacts = orderedListContacts.ToList();
            for (int i = 0; i < _contacts.Count; i++)
            {
                ListBoxContacts.Items.Add(_contacts[i].FullName);
            }
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var contact = new Contact();
            contact.FullName = $"Новый контакт {contact.Id}";
            contact.DateOfBirth = DateTime.Today;
            _contacts.Add(contact);
            UpdateContactList(_contacts);
        }

        private void UpdateContactInfo()
        {
            var selectedIndex = ListBoxContacts.SelectedIndex;
            var contact = new Contact(_currentContact);
            _contacts[selectedIndex] = contact;
            UpdateContactList(_contacts);

            var indexOf = _contacts.IndexOf(contact);

            ListBoxContacts.SelectedIndex = indexOf;

        }

        private void DateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex != -1)
            {
                _contacts[ListBoxContacts.SelectedIndex].DateOfBirth = DateTimePickerDateOfBirth.Value;
            }
        }

        private void PhoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex != -1)
            {
                _contacts[ListBoxContacts.SelectedIndex].Number = MaskedTextBoxPhone.Text;
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex != -1)
            {
                try
                {
                    TextBoxName.BackColor = ProgrammColors.CorrectColor;
                    _currentContact.FullName = TextBoxName.Text;

                    if (TextBoxName.Focused) UpdateContactInfo();
                }

                catch
                {
                    TextBoxName.BackColor = ProgrammColors.ErrorColor;
                }
            }
        }

        private void MaskedTextBoxTelegram_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex != -1)
            {
                _contacts[ListBoxContacts.SelectedIndex].Telegram = MaskedTextBoxTelegram.Text;
            }
        }

        private void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex != -1)
            {
                _currentContact = _contacts[ListBoxContacts.SelectedIndex];
                
                TextBoxName.Text = _currentContact.FullName;
                DateTimePickerDateOfBirth.Value = _currentContact.DateOfBirth;
                MaskedTextBoxPhone.Text = _currentContact.Number;
                MaskedTextBoxTelegram.Text = _currentContact.Telegram;

            }
        }
    }
}
