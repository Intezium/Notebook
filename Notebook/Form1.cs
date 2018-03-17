using System.ComponentModel;
using System.Windows.Forms;

namespace Notebook
{   
    public partial class Form1 : Form
    {
        BindingList<Contact> contacts;
        
        public Form1()
        {
            InitializeComponent();

            contacts = new BindingList<Contact>();

            ListBox_Notebook.DataSource = contacts;
        }

        private bool IsEmpty(params TextBox[] textBoxes)
        {
            for (int i = 0; i < textBoxes.Length; i++)
                if (string.IsNullOrEmpty(textBoxes[i].Text))
                    return true;

            return false;
        }
        private bool IsPositiveIndex()
        {
            return ListBox_Notebook.SelectedIndex > -1;
        }
        private void FillTextBoxes(object obj)
        {
            Contact contact = (Contact)obj;

            TextBox_FirstName.Text = contact.FirstName;
            TextBox_LastName.Text = contact.LastName;
            TextBox_Phone.Text = contact.Phone;
            TextBox_Description.Text = contact.Description;
        }

        private void Button_Add_Click(object sender, System.EventArgs e)
        {
            if(!IsEmpty(TextBox_FirstName, TextBox_LastName))
                contacts.Add(new Contact(TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_Phone.Text, TextBox_Description.Text));
        }
        private void Button_Edit_Click(object sender, System.EventArgs e)
        {
            if(IsPositiveIndex())
            {
                int index = ListBox_Notebook.SelectedIndex;

                contacts[index] = (new Contact(TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_Phone.Text, TextBox_Description.Text));
            }
        }
        private void Button_Remove_Click(object sender, System.EventArgs e)
        {
            if(IsPositiveIndex())
            {
                int index = ListBox_Notebook.SelectedIndex;

                contacts.RemoveAt(index);
            }
        }
        
        private void ListBox_Notebook_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (IsPositiveIndex())
                FillTextBoxes(ListBox_Notebook.SelectedItem);
        }
    }

    class Contact
    {
        public string FirstName
        {
            get;
        }
        public string LastName
        {
            get;
        }
        public string Phone
        {
            get;
        }
        public string Description
        {
            get;
        }

        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Contact(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
        public Contact(string firstName, string lastName, string phone, string description)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
