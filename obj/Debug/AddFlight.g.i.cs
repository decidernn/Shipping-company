﻿#pragma checksum "..\..\AddFlight.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AF649809CD5E8A9C5BAA84A4E94A15570075772EA26DC5A422B9DC988CAB7CF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SudCompany;
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


namespace SudCompany {
    
    
    /// <summary>
    /// AddFlight
    /// </summary>
    public partial class AddFlight : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboShip;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboAdmin;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboClient;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerOut;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerIn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCityOut;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCityIn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCargo;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCapitaneOfShip;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddFlight;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboStatus;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStatus;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddFlight.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/SudCompany;component/addflight.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddFlight.xaml"
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
            this.comboShip = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\AddFlight.xaml"
            this.comboShip.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboShip_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboAdmin = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\AddFlight.xaml"
            this.comboAdmin.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboAdmin_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboClient = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\AddFlight.xaml"
            this.comboClient.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboClient_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DatePickerOut = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.DatePickerIn = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.txtCityOut = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtCityIn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtCargo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtCapitaneOfShip = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnAddFlight = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\AddFlight.xaml"
            this.btnAddFlight.Click += new System.Windows.RoutedEventHandler(this.btnAddFlight_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.comboStatus = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\AddFlight.xaml"
            this.comboStatus.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboShip_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lblStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\AddFlight.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

