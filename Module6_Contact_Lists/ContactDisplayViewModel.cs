using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Module6_Contact_Lists
{
    partial class ContactDisplayViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Contact> contacts = new();

        [ObservableProperty]
        private Contact contact = new();

        [RelayCommand]
        private void Add()
        {
            Contacts.Add(contact);
            contact = new();
        }
    }
}
