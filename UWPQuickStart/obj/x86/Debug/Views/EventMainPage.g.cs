﻿#pragma checksum "C:\Users\dajaco\Source\Repos\UWPQuickStart\UWPQuickStart\Views\EventMainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "33BC2AED77F1EB3C51DF7CE150BFAC7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWPQuickStart
{
    partial class EventMainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.rootSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.TogglePaneButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 62 "..\..\..\Views\EventMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.TogglePaneButton).Unchecked += this.TogglePaneButton_Checked;
                    #line default
                }
                break;
            case 3:
                {
                    this.navMenuList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 35 "..\..\..\Views\EventMainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.navMenuList).ItemClick += this.NavMenu_ItemClickHandler;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

