﻿#pragma checksum "..\..\..\..\Pages\KinectPointerPointSample.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "34B5328CA554C8C7E377BE8AEC1C1D75"
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


namespace Microsoft.Samples.Kinect.ControlsBasics {
    
    
    /// <summary>
    /// KinectPointerPointSample
    /// </summary>
    public partial class KinectPointerPointSample : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Samples.Kinect.ControlsBasics.KinectPointerPointSample pageRoot;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pageTitle;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox details;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button quitProgram;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas mainScreen;
        
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
            System.Uri resourceLocater = new System.Uri("/KinectBoard;component/pages/kinectpointerpointsample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
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
            this.pageRoot = ((Microsoft.Samples.Kinect.ControlsBasics.KinectPointerPointSample)(target));
            return;
            case 2:
            this.pageTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.details = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
            this.details.Checked += new System.Windows.RoutedEventHandler(this.details_Checked);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
            this.details.Unchecked += new System.Windows.RoutedEventHandler(this.details_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.quitProgram = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Pages\KinectPointerPointSample.xaml"
            this.quitProgram.Click += new System.Windows.RoutedEventHandler(this.quitProgram_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mainScreen = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

