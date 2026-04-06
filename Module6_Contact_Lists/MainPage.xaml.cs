namespace Module6_Contact_Lists
{
    
    public partial class MainPage : ContentPage
    {
        private ContactDisplayViewModel contactsViewModel;
        public MainPage()
        {
            InitializeComponent();
            contactsViewModel = new ContactDisplayViewModel();
            BindingContext = contactsViewModel;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var contactDisplay = new ContactDisplay();
            contactDisplay.BindingContext = contactsViewModel;
            Navigation.PushAsync(contactDisplay);
            InitializeComponent();
        }


    }

}
