﻿#pragma checksum "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC52D45FF25215D9E0158CDDDEA54AD4530024CB9BFD0BC56DBDC96FC1152808"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfTest2012.Pages;


namespace WpfTest2012.Pages {
    
    
    /// <summary>
    /// UpdateInfoAboutEmployee
    /// </summary>
    public partial class UpdateInfoAboutEmployee : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbLogin;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PsbPassUser;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbNameUser;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbSurnameUser;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPatronymicUser;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoleCombBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreateUser;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfTest2012;component/pages/afterfinduserpage/updateinfoaboutemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
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
            this.TxbLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PsbPassUser = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.TxbNameUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxbSurnameUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxbPatronymicUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.RoleCombBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BtnCreateUser = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Pages\AfterFindUserPage\UpdateInfoAboutEmployee.xaml"
            this.BtnCreateUser.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateUserInfo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

