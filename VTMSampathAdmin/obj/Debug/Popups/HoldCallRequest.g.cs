﻿#pragma checksum "..\..\..\Popups\HoldCallRequest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4482CB7D9B9B63622B542FA30EC59E54D31AB0B2941FC5D1D52E1451C8D8376B"
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
using VTMSampathAdmin.Popups;


namespace VTMSampathAdmin.Popups {
    
    
    /// <summary>
    /// HoldCallRequest
    /// </summary>
    public partial class HoldCallRequest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Popups\HoldCallRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome ImgClose;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Popups\HoldCallRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblBranchName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Popups\HoldCallRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbHoldTimes;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Popups\HoldCallRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnHold;
        
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
            System.Uri resourceLocater = new System.Uri("/VTMSampathAdmin;component/popups/holdcallrequest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Popups\HoldCallRequest.xaml"
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
            this.ImgClose = ((FontAwesome.WPF.ImageAwesome)(target));
            
            #line 18 "..\..\..\Popups\HoldCallRequest.xaml"
            this.ImgClose.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgClose_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LblBranchName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.CmbHoldTimes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.BtnHold = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Popups\HoldCallRequest.xaml"
            this.BtnHold.Click += new System.Windows.RoutedEventHandler(this.BtnHold_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

