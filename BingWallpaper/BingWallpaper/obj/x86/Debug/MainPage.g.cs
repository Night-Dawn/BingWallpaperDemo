﻿#pragma checksum "C:\Users\Night_Dawn\Documents\GitHub\BingWallpaperDemo\BingWallpaper\BingWallpaper\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A5451949B7A377FBB84E68801CFB7C58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BingWallpaper
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.showMorePicture = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 5: // MainPage.xaml line 273
                {
                    global::Windows.UI.Xaml.Controls.Grid element5 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element5).Loaded += this.Grid_Loaded;
                    ((global::Windows.UI.Xaml.Controls.Grid)element5).Loading += this.Grid_Loading;
                }
                break;
            case 6: // MainPage.xaml line 279
                {
                    this.TitlePanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 7: // MainPage.xaml line 301
                {
                    global::Windows.UI.Xaml.Controls.Grid element7 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element7).Tapped += this.Grid_Tapped;
                }
                break;
            case 8: // MainPage.xaml line 316
                {
                    this.topStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9: // MainPage.xaml line 324
                {
                    this.topTransform = (global::Windows.UI.Xaml.Media.TranslateTransform)(target);
                }
                break;
            case 10: // MainPage.xaml line 328
                {
                    this.minus_bar = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.minus_bar).Click += this.Minus_bar_Click;
                }
                break;
            case 11: // MainPage.xaml line 329
                {
                    this.DayNumber = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // MainPage.xaml line 330
                {
                    this.plus_bar = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.plus_bar).Click += this.Plus_bar_Click;
                }
                break;
            case 13: // MainPage.xaml line 314
                {
                    this.MyImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 14: // MainPage.xaml line 308
                {
                    this.copyrightTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // MainPage.xaml line 280
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element15 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element15).Tapped += this.TextBlock_Tapped;
                }
                break;
            case 16: // MainPage.xaml line 286
                {
                    this.timeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

