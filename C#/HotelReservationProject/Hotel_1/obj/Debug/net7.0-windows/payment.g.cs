﻿#pragma checksum "..\..\..\payment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69A3789CA10EF8BE0171B6B84A14B5F174EDC4A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hotel_1;
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


namespace Hotel_1 {
    
    
    /// <summary>
    /// payment
    /// </summary>
    public partial class payment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PaymentTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrentBillLabel;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FoodBillLabel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TaxLabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TotalLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CardNumberText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonthComboBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox YearComboBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CVCTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PaymnetTypeLabel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MonthLabel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label YearLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\payment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CardTypeCombobox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hotel_1;component/payment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\payment.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PaymentTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\payment.xaml"
            this.PaymentTypeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PaymentTypeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CurrentBillLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.FoodBillLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TaxLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.TotalLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.CardNumberText = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\payment.xaml"
            this.CardNumberText.KeyDown += new System.Windows.Input.KeyEventHandler(this.CardNumberText_KeyDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\payment.xaml"
            this.CardNumberText.KeyUp += new System.Windows.Input.KeyEventHandler(this.CardNumberText_KeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MonthComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\payment.xaml"
            this.MonthComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MonthComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.YearComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\payment.xaml"
            this.YearComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.YearComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 25 "..\..\..\payment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CVCTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\payment.xaml"
            this.CVCTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.CVCTextBox_KeyDown);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\payment.xaml"
            this.CVCTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.CVCTextBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PaymnetTypeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.MonthLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.YearLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.CardTypeCombobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

