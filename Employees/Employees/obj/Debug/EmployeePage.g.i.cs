﻿#pragma checksum "D:\workspaces\WindowsPhone\Employees\Employees\EmployeePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FBAFD4FF5D701924DB6252D3881A18C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
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


namespace Employees {
    
    
    public partial class EmployeePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image image;
        
        internal System.Windows.Controls.TextBlock lastName;
        
        internal System.Windows.Controls.TextBlock firstName;
        
        internal System.Windows.Controls.TextBlock title;
        
        internal System.Windows.Controls.TextBlock room;
        
        internal System.Windows.Controls.TextBlock phone;
        
        internal System.Windows.Controls.TextBlock sms;
        
        internal System.Windows.Controls.TextBlock mail;
        
        internal System.Windows.Controls.TextBlock info;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Employees;component/EmployeePage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
            this.lastName = ((System.Windows.Controls.TextBlock)(this.FindName("lastName")));
            this.firstName = ((System.Windows.Controls.TextBlock)(this.FindName("firstName")));
            this.title = ((System.Windows.Controls.TextBlock)(this.FindName("title")));
            this.room = ((System.Windows.Controls.TextBlock)(this.FindName("room")));
            this.phone = ((System.Windows.Controls.TextBlock)(this.FindName("phone")));
            this.sms = ((System.Windows.Controls.TextBlock)(this.FindName("sms")));
            this.mail = ((System.Windows.Controls.TextBlock)(this.FindName("mail")));
            this.info = ((System.Windows.Controls.TextBlock)(this.FindName("info")));
        }
    }
}
