﻿#pragma checksum "C:\Users\Marcin\Desktop\Rezerwacja\Rezerwacja\DodaniePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "67716862ED390F2E2DFEF73E5563B1ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Rezerwacja {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox ImieTextBox;
        
        internal System.Windows.Controls.TextBox NazwiskoTextBox;
        
        internal System.Windows.Controls.Slider IloscSlider;
        
        internal System.Windows.Controls.TextBlock ObiektText;
        
        internal System.Windows.Controls.TextBlock DataTextBlock;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Rezerwacja;component/DodaniePage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ImieTextBox = ((System.Windows.Controls.TextBox)(this.FindName("ImieTextBox")));
            this.NazwiskoTextBox = ((System.Windows.Controls.TextBox)(this.FindName("NazwiskoTextBox")));
            this.IloscSlider = ((System.Windows.Controls.Slider)(this.FindName("IloscSlider")));
            this.ObiektText = ((System.Windows.Controls.TextBlock)(this.FindName("ObiektText")));
            this.DataTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("DataTextBlock")));
        }
    }
}

