﻿#pragma checksum "..\..\..\Pages\Exec.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "31CBE59DCC6DD71F0A8C098F1C77C00B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GroupProject.Pages;
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


namespace GroupProject.Pages {
    
    
    /// <summary>
    /// Exec
    /// </summary>
    public partial class Exec : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Pages\Exec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ___GroupProject_component_Final_logo_for_group_project_jpg;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Pages\Exec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout_Button;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Pages\Exec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Admin_Button;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\Exec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1_Copy;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\Exec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SupplierListBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\Exec.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SupplierData;
        
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
            System.Uri resourceLocater = new System.Uri("/GroupProject;component/pages/exec.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Exec.xaml"
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
            
            #line 8 "..\..\..\Pages\Exec.xaml"
            ((GroupProject.Pages.Exec)(target)).Initialized += new System.EventHandler(this.UserControl_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.___GroupProject_component_Final_logo_for_group_project_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Logout_Button = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Pages\Exec.xaml"
            this.Logout_Button.Click += new System.Windows.RoutedEventHandler(this.Logout_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Admin_Button = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Pages\Exec.xaml"
            this.Admin_Button.Click += new System.Windows.RoutedEventHandler(this.Admin_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button1_Copy = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.SupplierListBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\Pages\Exec.xaml"
            this.SupplierListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SupplierListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SupplierData = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
