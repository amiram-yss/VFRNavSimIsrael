﻿#pragma checksum "..\..\..\Custom Controls\RoundedButton.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "97C8E3191EA6E9FF5CE01C6F530A9076645EEF1A2A27BA2144ECBA2917A01241"
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
using System.Windows.Forms.Integration;
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
using VFRNavSim.Custom_Controls;


namespace VFRNavSim.Custom_Controls {
    
    
    /// <summary>
    /// RoundedButton
    /// </summary>
    public partial class RoundedButton : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Custom Controls\RoundedButton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brdFrame;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Custom Controls\RoundedButton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt;
        
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
            System.Uri resourceLocater = new System.Uri("/VFRNavSim;component/custom%20controls/roundedbutton.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Custom Controls\RoundedButton.xaml"
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
            
            #line 8 "..\..\..\Custom Controls\RoundedButton.xaml"
            ((VFRNavSim.Custom_Controls.RoundedButton)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.UserControl_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.brdFrame = ((System.Windows.Controls.Border)(target));
            
            #line 12 "..\..\..\Custom Controls\RoundedButton.xaml"
            this.brdFrame.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Border_MouseEnter);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Custom Controls\RoundedButton.xaml"
            this.brdFrame.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BrdFrame_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Custom Controls\RoundedButton.xaml"
            this.brdFrame.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BrdFrame_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Custom Controls\RoundedButton.xaml"
            this.brdFrame.MouseLeave += new System.Windows.Input.MouseEventHandler(this.BrdFrame_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

