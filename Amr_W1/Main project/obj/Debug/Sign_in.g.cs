﻿#pragma checksum "..\..\Sign_in.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9796A4E2FF33A0986E31E4066706CEB156611788C83ED7614498C242C76578F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Main_project;
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


namespace Main_project {
    
    
    /// <summary>
    /// Sign_in
    /// </summary>
    public partial class Sign_in : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label User_Name;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox box1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pass;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Password;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forget_pass;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Sign_in.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sign_up;
        
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
            System.Uri resourceLocater = new System.Uri("/Main project;component/sign_in.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sign_in.xaml"
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
            this.User_Name = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.box1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.pass = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Password = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Login = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Sign_in.xaml"
            this.Login.Click += new System.Windows.RoutedEventHandler(this.Login_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.forget_pass = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Sign_in.xaml"
            this.forget_pass.Click += new System.Windows.RoutedEventHandler(this.forget_pass_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Sign_up = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Sign_in.xaml"
            this.Sign_up.Click += new System.Windows.RoutedEventHandler(this.Sign_up_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

