﻿#pragma checksum "..\..\PolarCharts.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "04E1C6E1692CEE146E6205376A75558B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
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


namespace Specialized2DCharts {
    
    
    /// <summary>
    /// PolarCharts
    /// </summary>
    public partial class PolarCharts : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\PolarCharts.xaml"
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PolarCharts.xaml"
        internal System.Windows.Controls.Grid chartGrid;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PolarCharts.xaml"
        internal System.Windows.Controls.Canvas chartCanvas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Specialized2DCharts;component/polarcharts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PolarCharts.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.chartGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 18 "..\..\PolarCharts.xaml"
            this.chartGrid.SizeChanged += new System.Windows.SizeChangedEventHandler(this.chartGrid_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chartCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
