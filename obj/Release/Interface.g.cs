﻿#pragma checksum "..\..\Interface.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6FCED73465F34739642F6BD94D39BA738EB827D9E293A3EC5DA98DBD46EB12E7"
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
    /// Interface
    /// </summary>
    public partial class Interface : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Stock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AjoutClient;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ListeClients;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Interface.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Contenu;
        
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
            System.Uri resourceLocater = new System.Uri("/cistel_elec_ge;component/interface.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Interface.xaml"
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
            this.Stock = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Interface.xaml"
            this.Stock.Click += new System.Windows.RoutedEventHandler(this.Stock_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AjoutClient = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\Interface.xaml"
            this.AjoutClient.Click += new System.Windows.RoutedEventHandler(this.AjoutClient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListeClients = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\Interface.xaml"
            this.ListeClients.Click += new System.Windows.RoutedEventHandler(this.ListeClients_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Contenu = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

