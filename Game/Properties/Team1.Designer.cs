﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolGame.Game.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Team1 : global::System.Configuration.ApplicationSettingsBase {
        
        private static Team1 defaultInstance = ((Team1)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Team1())));
        
        public static Team1 Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Blue")]
        public global::System.Drawing.Color Team1Color {
            get {
                return ((global::System.Drawing.Color)(this["Team1Color"]));
            }
            set {
                this["Team1Color"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Blue Team")]
        public string Team1Name {
            get {
                return ((string)(this["Team1Name"]));
            }
            set {
                this["Team1Name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft Sans Serif, 8.25pt")]
        public global::System.Drawing.Font Team1Font {
            get {
                return ((global::System.Drawing.Font)(this["Team1Font"]));
            }
            set {
                this["Team1Font"] = value;
            }
        }
    }
}