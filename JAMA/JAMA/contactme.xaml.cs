﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JAMA
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class contactme : ContentPage
	{
		public contactme ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            DisplayAlert("Success!","Your Message Has Been Sent!","Ok");
        }
	}
}