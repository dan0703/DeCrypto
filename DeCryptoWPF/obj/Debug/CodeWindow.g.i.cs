﻿#pragma checksum "..\..\CodeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3C2CEADD9D1E36AB24EEE3C48DCF7B5E5D7CE7C00A5ED0653120E9CFFE29712A"
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
    /// CodeWindow
    /// </summary>
    public partial class CodeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\CodeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_CodeWindow_EnterCode;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CodeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_CodeWindow_Join;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CodeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Confirmations_Cancel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CodeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_CodeWindow_Code;
        
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
            System.Uri resourceLocater = new System.Uri("/DeCryptoWPF;component/codewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CodeWindow.xaml"
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
            this.Label_CodeWindow_EnterCode = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Button_CodeWindow_Join = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\CodeWindow.xaml"
            this.Button_CodeWindow_Join.Click += new System.Windows.RoutedEventHandler(this.Button_CodeWindow_Join_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_Confirmations_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\CodeWindow.xaml"
            this.Button_Confirmations_Cancel.Click += new System.Windows.RoutedEventHandler(this.Button_Confirmations_Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBox_CodeWindow_Code = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\CodeWindow.xaml"
            this.TextBox_CodeWindow_Code.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_CodeWindow_Code_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
