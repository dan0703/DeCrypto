﻿#pragma checksum "..\..\GameSettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C60DDB05963E7D1E01436EC7B65922861B93CF5D26A08C7B9C0FC86A317A80FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using DeCryptoWPF;
using DeCryptoWPF.Properties;
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


namespace DeCryptoWPF {
    
    
    /// <summary>
    /// GameSettings
    /// </summary>
    public partial class GameSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\GameSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_GameSettings_StartingConfiguration;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\GameSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_GameSettings_Rounds;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\GameSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_GameSettings_InCaseTie;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GameSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_GameSettings_Rounds;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\GameSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_GameSettings_InCaseTie;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\GameSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_ConfirmationButtons_Save;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\GameSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_ConfirmationButtons_Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/DeCryptoWPF;component/gamesettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameSettings.xaml"
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
            this.Label_GameSettings_StartingConfiguration = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Label_GameSettings_Rounds = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Label_GameSettings_InCaseTie = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ComboBox_GameSettings_Rounds = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\GameSettings.xaml"
            this.ComboBox_GameSettings_Rounds.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_GameSettings_Rounds_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComboBox_GameSettings_InCaseTie = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\GameSettings.xaml"
            this.ComboBox_GameSettings_InCaseTie.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_GameSettings_InCaseTie_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Button_ConfirmationButtons_Save = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\GameSettings.xaml"
            this.Button_ConfirmationButtons_Save.Click += new System.Windows.RoutedEventHandler(this.Button_Confirmations_Save_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Button_ConfirmationButtons_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\GameSettings.xaml"
            this.Button_ConfirmationButtons_Cancel.Click += new System.Windows.RoutedEventHandler(this.Button_Confirmations_Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
