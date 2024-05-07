using Ava.CodeProject.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;
using NP.Ava.Visuals.ThemingAndL10N;
using NP.Concepts.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ava.CodeProject.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public SettingsViewModel()
        {


        }

        //private ThemeLoader _themeLoader;
        public string? themeChange { get; set; }

        public void RequestThemeChange()
        {
            //var themeDark = ThemeVariant.Dark;

            //var themeLight = ThemeVariant.Light.ToString;


            if (themeChange == "Dark")
                themeChange = "Light";

            if (themeChange == "Light")
                themeChange = "Dark";


            //if ( == ThemeVariant.Dark)
            //{
            //    _themeLoader.SelectedThemeId = "Light";
            //}
            //var themeDark = ThemeVariant.Dark;
            //var themeLight = ThemeVariant.Light;
            //var themeSettings = SettingsView.RequestedThemeVariantProperty;
            //themeSettings(themeDark);

            //_themeLoader.SelectedThemeId = "Dark";
        }

        //public sealed record ThemeVariant
        //{
        //    public ThemeVariant(string v)
        //    {
        //    }

        //    public static ThemeVariant Light { get; } = new(nameof(Light));

        //    public static ThemeVariant Dark { get; } = new(nameof(Dark));
        //}
            

        //    //App.RequestedThemeVariantProperty
        //    var themeDark = Avalonia.Styling.ThemeVariant.Dark;
        //    //Avalonia.StyledProperty<themeDark>

        //    var themeLight = Avalonia.Styling.ThemeVariant.Light;

        //    StyledProperty<Avalonia.Styling.ThemeVariant> darkProp;

        //    darkProp.

        //    IThemeVariantProvider themeVariantProvider;

        //    themeVariantProvider.OwnerChanged = themeDark;

        //    if (App.RequestedThemeVariantProperty = Avalonia.Styling.ThemeVariant.Dark)
        //    {
        //        var darkstyled = StyledProperty<themeDark>
        //    }


    }

    
}
