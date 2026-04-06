

namespace Module6_Contact_Lists
{
    public partial class ContactDisplay : ContentPage
    {
        public ContactDisplay()
        {
            InitializeComponent();
        }

        private void LvContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedContact = e.CurrentSelection.FirstOrDefault() as Contact;
            if (selectedContact == null) return;
            var contactViewModel = new DetailsViewModel { Contact = selectedContact };
            var contactDetails = new Details();
            contactDetails.BindingContext = contactViewModel;
            Navigation.PushAsync(contactDetails);
            InitializeComponent();
        }
    }

}
