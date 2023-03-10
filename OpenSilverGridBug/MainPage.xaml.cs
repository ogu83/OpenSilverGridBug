using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverGridBug
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            //this.mainGrid.Children.Add(new Page1());
            for (int i = 0; i < 20; i++)
            {
                tcWorkspaceTabs2.Items.Add(new TabItem { Header = $"Tab Item {i}" });
            }
        }
    }
}