﻿#pragma checksum "..\..\delete.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D36BF8458D3D8DF83596E785E0270FD201EEFAF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Diary_Of_Information;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Diary_Of_Information {
    
    
    /// <summary>
    /// delete
    /// </summary>
    public partial class delete : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_phone;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button home;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Diary Of Information;component/delete.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\delete.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txt_phone = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\delete.xaml"
            this.txt_phone.GotFocus += new System.Windows.RoutedEventHandler(this.txt_phone_focus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.del = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\delete.xaml"
            this.del.Click += new System.Windows.RoutedEventHandler(this.del_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.home = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\delete.xaml"
            this.home.Click += new System.Windows.RoutedEventHandler(this.home_btn_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

