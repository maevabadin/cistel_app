#pragma checksum "..\..\clientsDarkMode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF6033FBA5675B37A0D21EE69257BA6436B732CF93BCE03577ED31803AD9CEFE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using cistel_elec_ge;


namespace cistel_elec_ge {
    
    
    /// <summary>
    /// clientsDarkMode
    /// </summary>
    public partial class clientsDarkMode : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\clientsDarkMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label clientLabel;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\clientsDarkMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label searchLabel;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\clientsDarkMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\clientsDarkMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchButton;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\clientsDarkMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu LastNameCM;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\clientsDarkMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu CityCM;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\clientsDarkMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu EmailCM;
        
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
            System.Uri resourceLocater = new System.Uri("/cistel_elec_ge;component/clientsdarkmode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\clientsDarkMode.xaml"
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
            this.clientLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.searchLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.searchButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.LastNameCM = ((System.Windows.Controls.ContextMenu)(target));
            
            #line 93 "..\..\clientsDarkMode.xaml"
            this.LastNameCM.AddHandler(System.Windows.Controls.MenuItem.ClickEvent, new System.Windows.RoutedEventHandler(this.LastNameCM_Click));
            
            #line default
            #line hidden
            return;
            case 6:
            this.CityCM = ((System.Windows.Controls.ContextMenu)(target));
            
            #line 106 "..\..\clientsDarkMode.xaml"
            this.CityCM.AddHandler(System.Windows.Controls.MenuItem.ClickEvent, new System.Windows.RoutedEventHandler(this.CityCM_Click));
            
            #line default
            #line hidden
            return;
            case 7:
            this.EmailCM = ((System.Windows.Controls.ContextMenu)(target));
            
            #line 116 "..\..\clientsDarkMode.xaml"
            this.EmailCM.AddHandler(System.Windows.Controls.MenuItem.ClickEvent, new System.Windows.RoutedEventHandler(this.EmailCM_Click));
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

