// Updated by XamlIntelliSenseFileGenerator 02/12/2023 07:02:12 ص
#pragma checksum "..\..\HomePage0.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA0F3FF3ED72EBB9A8B72B8EE79790F7999F88BB10487D4C5998A63E7D6F9B67"
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
using System.Windows.Shell;
using WpfApp17;


namespace WpfApp17
{


    /// <summary>
    /// Page3
    /// </summary>
    public partial class Page3 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 29 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;

#line default
#line hidden


#line 31 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTitle;

#line default
#line hidden


#line 33 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrice;

#line default
#line hidden


#line 48 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;

#line default
#line hidden


#line 49 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInsert;

#line default
#line hidden


#line 56 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;

#line default
#line hidden


#line 63 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefresh;

#line default
#line hidden


#line 65 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo;

#line default
#line hidden


#line 70 "..\..\HomePage0.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp17;component/homepage0.xaml", System.UriKind.Relative);

#line 1 "..\..\HomePage0.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.txtID = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.txtTitle = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.txtPrice = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:

#line 34 "..\..\HomePage0.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.update_Click);

#line default
#line hidden
                    return;
                case 5:

#line 41 "..\..\HomePage0.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.delet_Click_1);

#line default
#line hidden
                    return;
                case 6:
                    this.dataGrid = ((System.Windows.Controls.DataGrid)(target));

#line 48 "..\..\HomePage0.xaml"
                    this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.btnInsert = ((System.Windows.Controls.Button)(target));

#line 49 "..\..\HomePage0.xaml"
                    this.btnInsert.Click += new System.Windows.RoutedEventHandler(this.btnInsert_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.btnSearch = ((System.Windows.Controls.Button)(target));

#line 56 "..\..\HomePage0.xaml"
                    this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.btnRefresh = ((System.Windows.Controls.Button)(target));

#line 63 "..\..\HomePage0.xaml"
                    this.btnRefresh.Click += new System.Windows.RoutedEventHandler(this.btnRefresh_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.combo = ((System.Windows.Controls.ComboBox)(target));

#line 65 "..\..\HomePage0.xaml"
                    this.combo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combo_SelectionChanged);

#line default
#line hidden
                    return;
                case 11:
                    this.txtSearch = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 12:

#line 72 "..\..\HomePage0.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);

#line default
#line hidden
                    return;
                case 13:
                    this.auther_T = ((System.Windows.Controls.TextBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
