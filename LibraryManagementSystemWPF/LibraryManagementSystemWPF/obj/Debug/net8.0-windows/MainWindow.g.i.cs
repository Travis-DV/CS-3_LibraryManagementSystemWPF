﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2273EC36FD9BA5E248F822CB574F43A44C9EC2EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryManagementSystemWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace LibraryManagementSystemWPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LB_Books;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LV_Books;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_NewBook;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LB_Borrowers;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LV_Borrowers;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_NewBorrower;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LB_Borrows;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LV_Borrows;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_NewBorrow;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_ListAll;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryManagementSystemWPF;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LB_Books = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LV_Books = ((System.Windows.Controls.ListBox)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.LV_Books.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Books_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BT_NewBook = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.BT_NewBook.Click += new System.Windows.RoutedEventHandler(this.NewBook_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LB_Borrowers = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.LV_Borrowers = ((System.Windows.Controls.ListBox)(target));
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.LV_Borrowers.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Borrowers_Clicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BT_NewBorrower = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\MainWindow.xaml"
            this.BT_NewBorrower.Click += new System.Windows.RoutedEventHandler(this.NewBorrower_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LB_Borrows = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.LV_Borrows = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.BT_NewBorrow = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\MainWindow.xaml"
            this.BT_NewBorrow.Click += new System.Windows.RoutedEventHandler(this.NewBorrow_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BT_ListAll = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\MainWindow.xaml"
            this.BT_ListAll.Click += new System.Windows.RoutedEventHandler(this.ListAll_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

