﻿#pragma checksum "..\..\..\UserControlls\CustomerStatusUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7D8FFFEAFFDC92C4D4771803C35A0775478383E421F7E2677D7D33756D266C9E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
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
using VTMSampathAdmin.UserControlls;


namespace VTMSampathAdmin.UserControlls {
    
    
    /// <summary>
    /// CustomerStatusUserControl
    /// </summary>
    public partial class CustomerStatusUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome BtnNewCustomerIcon;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNewCustomer;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome BtnExistingCustomerIcon;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExistingCustomer;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNext;
        
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
            System.Uri resourceLocater = new System.Uri("/VTMSampathAdmin;component/usercontrolls/customerstatususercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
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
            this.BtnNewCustomerIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 2:
            this.BtnNewCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
            this.BtnNewCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnNewCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnExistingCustomerIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 4:
            this.BtnExistingCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
            this.BtnExistingCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnExistingCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnNext = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\UserControlls\CustomerStatusUserControl.xaml"
            this.BtnNext.Click += new System.Windows.RoutedEventHandler(this.BtnNext_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
