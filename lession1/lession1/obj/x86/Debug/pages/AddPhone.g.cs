﻿#pragma checksum "C:\Users\crist\Source\Repos\C_Sharp\lession1\lession1\pages\AddPhone.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6382775A4358C50CE9EEEAE1EE0FCC3F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lession1.pages
{
    partial class AddPhone : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // pages\AddPhone.xaml line 13
                {
                    this.txtName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // pages\AddPhone.xaml line 14
                {
                    this.txtTel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // pages\AddPhone.xaml line 16
                {
                    this.cbTypeContact = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 5: // pages\AddPhone.xaml line 22
                {
                    this.add = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.add).Click += this.Button_Click;
                }
                break;
            case 6: // pages\AddPhone.xaml line 23
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Button_Click_1;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

