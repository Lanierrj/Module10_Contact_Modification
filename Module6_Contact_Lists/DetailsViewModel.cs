using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Contact_Lists
{
    partial class DetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Contact contact;

    }
}
