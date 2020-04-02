using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Module9_TP06.Entities;
using Xamarin_Module9_TP06.Services;

namespace Xamarin_Module9_TP06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTweets : ContentPage
    {
        public ListTweets()
        {
            InitializeComponent();            
            listTweets.ItemsSource = new TwitterServiceImpl().Tweets;
        }

        
    }
}
