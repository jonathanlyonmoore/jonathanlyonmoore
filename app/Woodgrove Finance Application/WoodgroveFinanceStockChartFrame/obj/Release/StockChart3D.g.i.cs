﻿#pragma checksum "..\..\StockChart3D.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20B97944AC6A2211979A4ACE80EFD69751EA63B3"
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
using WoodgroveFinanceStockChart3D;


namespace WoodgroveFinanceStockChartFrame {
    
    
    /// <summary>
    /// StockChart3D
    /// </summary>
    public partial class StockChart3D : System.Windows.Controls.Grid, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\StockChart3D.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WoodgroveFinanceStockChartFrame.StockChart3D DocumentRoot;
        
        #line default
        #line hidden
        
        
        #line 631 "..\..\StockChart3D.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WoodgroveFinanceStockChart3D.List3D GraphList3D;
        
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
            System.Uri resourceLocater = new System.Uri("/WoodgroveFinanceStockChartFrame;component/stockchart3d.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StockChart3D.xaml"
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
            this.DocumentRoot = ((WoodgroveFinanceStockChartFrame.StockChart3D)(target));
            
            #line 10 "..\..\StockChart3D.xaml"
            this.DocumentRoot.Loaded += new System.Windows.RoutedEventHandler(this.OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GraphList3D = ((WoodgroveFinanceStockChart3D.List3D)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
