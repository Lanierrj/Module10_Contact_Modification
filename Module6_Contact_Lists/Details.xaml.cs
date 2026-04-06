
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Contact_Lists;
public partial class Details : ContentPage
{
    public Details()
    {
        InitializeComponent();
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        ContactName.IsReadOnly = true;
        ContactPhoneNumber.IsReadOnly = true;
        ContactGmail.IsReadOnly = true;
        ContactDescription.IsReadOnly = true;
        Navigation.RemovePage(this);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        ContactName.IsReadOnly = false;
        ContactPhoneNumber.IsReadOnly = false;
        ContactGmail.IsReadOnly = false;
        ContactDescription.IsReadOnly = false;
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        ContactName.IsReadOnly = true;
        ContactPhoneNumber.IsReadOnly = true;
        ContactGmail.IsReadOnly = true;
        ContactDescription.IsReadOnly = true;
        InitializeComponent();
    }
}
