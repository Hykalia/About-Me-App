using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JAMA
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class myskills : ContentPage
	{
        public List<string> Skills { get; set; }
		public myskills ()
		{
			InitializeComponent ();
            this.Skills = new List<string>();
		}
	}
}
}