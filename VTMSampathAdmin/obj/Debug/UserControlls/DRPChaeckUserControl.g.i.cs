﻿#pragma checksum "..\..\..\UserControlls\DRPChaeckUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37AB6E14F3EBF7110855AAF9B274D5889912BC28E999EF71A316A1A106944B51"
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
    /// DRPChaeckUserControl
    /// </summary>
    public partial class DRPChaeckUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\UserControlls\DRPChaeckUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRunDrp;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UserControlls\DRPChaeckUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\UserControlls\DRPChaeckUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/VTMSampathAdmin;component/usercontrolls/drpchaeckusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlls\DRPChaeckUserControl.xaml"
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
            this.BtnRunDrp = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UserControlls\DRPChaeckUserControl.xaml"
            this.BtnRunDrp.Click += new System.Windows.RoutedEventHandler(this.BtnRunDrp_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\UserControlls\DRPChaeckUserControl.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\UserControlls\DRPChaeckUserControl.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

