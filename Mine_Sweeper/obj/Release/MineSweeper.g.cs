﻿#pragma checksum "..\..\MineSweeper.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC7968179F7AD6075575D3A650F1A6D8354E13C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Mine_Sweeper;
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


namespace Mine_Sweeper {
    
    
    /// <summary>
    /// MineSweeper
    /// </summary>
    public partial class MineSweeper : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridApp;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBoxDifficulty;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonLow;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonMedium;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonHigh;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPlay;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid layoutGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelWon;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelWonScore;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelLost;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelLostScore;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label textBlockContact;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageFlag;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelSeparator;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelFlagCounter;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTimer;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MineSweeper.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBoxScore;
        
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
            System.Uri resourceLocater = new System.Uri("/Mine_Sweeper;component/minesweeper.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MineSweeper.xaml"
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
            this.gridApp = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.groupBoxDifficulty = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.radioButtonLow = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.radioButtonMedium = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.radioButtonHigh = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.buttonPlay = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\MineSweeper.xaml"
            this.buttonPlay.Click += new System.Windows.RoutedEventHandler(this.buttonPlay_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.layoutGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.labelWon = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.labelWonScore = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.labelLost = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.labelLostScore = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.textBlockContact = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            
            #line 31 "..\..\MineSweeper.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Contact_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.imageFlag = ((System.Windows.Controls.Image)(target));
            return;
            case 15:
            this.labelSeparator = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.labelFlagCounter = ((System.Windows.Controls.Label)(target));
            return;
            case 17:
            this.labelTimer = ((System.Windows.Controls.Label)(target));
            return;
            case 18:
            this.groupBoxScore = ((System.Windows.Controls.GroupBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

