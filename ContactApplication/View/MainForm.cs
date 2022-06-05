using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ContactApplication.Model;
using ContactApplication.Properties;
using static System.Environment;
using Contact = ContactApplication.Model.Contact;

namespace ContactApplication
{
    /// <summary>
    /// Представляет реализацию главного окна программы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит путь до папки AppData.
        /// </summary>

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DateOfBirthDateTimePicker.MinDate = new DateTime(1900, 1, 1);
            DateOfBirthDateTimePicker.MaxDate = DateTime.Today;
            DateOfBirthDateTimePicker.Value = DateTime.Today;

            ProjectSerializer.CreateFilesToAppData();
            _contacts = ProjectSerializer.LoadFromFile();
            UpdateContactList(_contacts);
            if (_contacts.Count >= 1) ContactsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="UpdateContactList"/>.
        /// </summary>  
        /// <param name="contacts">Коллекция контактов.</param>
        private void UpdateContactList(List<Contact> contacts)
        {
            ContactsListBox.Items.Clear();
            var orderedListContacts = from contact in _contacts
                orderby contact.FullName
                select contact;

            _contacts = orderedListContacts.ToList();
            for (int i = 0; i < _contacts.Count; i++)
            {
                ContactsListBox.Items.Add(_contacts[i].FullName);
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="UpdateContactInfo"/>.
        /// </summary>
        private void UpdateContactInfo()
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            var contact = new Contact(_currentContact);
            _contacts[selectedIndex] = contact;
            UpdateContactList(_contacts);

            var indexOf = _contacts.IndexOf(contact);

            ContactsListBox.SelectedIndex = indexOf;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var contact = new Contact();
            contact.FullName = $"Новый контакт {contact.Id}";
            contact.DateOfBirth = DateTime.Today;
            _contacts.Add(contact);
            UpdateContactList(_contacts);
            ContactsListBox.SelectedIndex = contact.Id;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                _contacts.RemoveAt(ContactsListBox.SelectedIndex);
                UpdateContactList(_contacts);
                ContactsListBox.SelectedIndex = 0;
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                _contacts[ContactsListBox.SelectedIndex].DateOfBirth = DateOfBirthDateTimePicker.Value;
            }
        }

        private void PhoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                _contacts[ContactsListBox.SelectedIndex].Number = PhoneMaskedTextBox.Text;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
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

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                _currentContact = _contacts[ContactsListBox.SelectedIndex];

                TextBoxName.Text = _currentContact.FullName;
                DateOfBirthDateTimePicker.Value = _currentContact.DateOfBirth;
                PhoneMaskedTextBox.Text = _currentContact.Number;
                VKTextBox.Text = _currentContact.Vk;
            }
        }


        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = Resources.add_contact_enter_24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Resources.add_contact_24;
        }

        private void ButtonDelete_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = Resources.remove_contact_enter_24;
        }

        private void ButtonDelete_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = Resources.remove_contact_24;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SaveToFile(_contacts);
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                _contacts[ContactsListBox.SelectedIndex].Vk = VKTextBox.Text;
            }
        }
    }
}