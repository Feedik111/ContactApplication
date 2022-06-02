using System;
using System.Collections.Generic;
using System.IO;
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
        private string appDataFolder = Environment.GetFolderPath(SpecialFolder.ApplicationData);

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
            DateTimePickerDateOfBirth.MinDate = new DateTime(1900, 1, 1);
            DateTimePickerDateOfBirth.MaxDate = DateTime.Today;
            DateTimePickerDateOfBirth.Value = DateTime.Today;

            CreateFilesToAppData();
            _contacts = ProjectSerializer.LoadFromFile(appDataFolder + "\\List Of Contacts");
            UpdateContactList(_contacts);
            if (_contacts.Count >= 1) ListBoxContacts.SelectedIndex = 0;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="UpdateContactList"/>.
        /// </summary>
        /// <param name="contacts">Коллекция контактов.</param>
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

        /// <summary>
        /// Создает экземпляр класса <see cref="UpdateContactInfo"/>.
        /// </summary>
        private void UpdateContactInfo()
        {
            var selectedIndex = ListBoxContacts.SelectedIndex;
            var contact = new Contact(_currentContact);
            _contacts[selectedIndex] = contact;
            UpdateContactList(_contacts);

            var indexOf = _contacts.IndexOf(contact);

            ListBoxContacts.SelectedIndex = indexOf;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="CreateFilesToAppData"/>.
        /// </summary>
        private static void CreateFilesToAppData()
        {
            try
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var directory = Path.Combine(appDataPath, "List Of Contacts");

                if (Directory.Exists(directory)) return;
                Directory.CreateDirectory(directory);

                var filePath = Path.Combine(directory, "contacts.json");

                if (File.Exists(filePath)) return;
                File.Create(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex != -1)
            {
                _contacts.RemoveAt(ListBoxContacts.SelectedIndex);
                UpdateContactList(_contacts);
                ListBoxContacts.SelectedIndex = 0;
            }

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

        private void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex != -1)
            {
                _currentContact = _contacts[ListBoxContacts.SelectedIndex];
                
                TextBoxName.Text = _currentContact.FullName;
                DateTimePickerDateOfBirth.Value = _currentContact.DateOfBirth;
                MaskedTextBoxPhone.Text = _currentContact.Number;
                TextBoxVK.Text = _currentContact.Vk;

            }
        }


        private void ButtonAdd_MouseEnter(object sender, EventArgs e)
        {
            ButtonAdd.Image = Resources.add_contact_enter_24;
        }

        private void ButtonAdd_MouseLeave(object sender, EventArgs e)
        {
            ButtonAdd.Image = Resources.add_contact_24;
        }

        private void ButtonDelete_MouseEnter(object sender, EventArgs e)
        {
            ButtonDelete.Image = Resources.remove_contact_enter_24;
        }

        private void ButtonDelete_MouseLeave(object sender, EventArgs e)
        {
            ButtonDelete.Image = Resources.remove_contact_24;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var filePath = Path.Combine(appDataFolder, "List Of Contacts");
            ProjectSerializer.SaveToFile(_contacts, filePath);
        }

        private void TextBoxVK_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex != -1)
            {
                _contacts[ListBoxContacts.SelectedIndex].Vk = TextBoxVK.Text;
            }
        }
    }
}
