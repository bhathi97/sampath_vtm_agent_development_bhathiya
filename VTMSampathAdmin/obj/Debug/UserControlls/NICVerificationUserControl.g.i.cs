﻿#pragma checksum "..\..\..\UserControlls\NICVerificationUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC851E00DAE1B180C6CCDE6F18633B6388382DFC38D7BF2792746E3ED0649240"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// NICVerificationUserControl
    /// </summary>
    public partial class NICVerificationUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNicInput;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNext;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnShowGuidance;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgNICFront;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnScan;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgNICRear;
        
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
            System.Uri resourceLocater = new System.Uri("/VTMSampathAdmin;component/usercontrolls/nicverificationusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
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
            this.TbNicInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BtnNext = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
            this.BtnNext.Click += new System.Windows.RoutedEventHandler(this.BtnNext_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnShowGuidance = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
            this.BtnShowGuidance.Click += new System.Windows.RoutedEventHandler(this.BtnShowGuidance_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ImgNICFront = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.BtnScan = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\UserControlls\NICVerificationUserControl.xaml"
            this.BtnScan.Click += new System.Windows.RoutedEventHandler(this.BtnScan_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImgNICRear = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

