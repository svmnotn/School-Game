﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolGame.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Team2 : global::System.Configuration.ApplicationSettingsBase {
        
        private static Team2 defaultInstance = ((Team2)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Team2())));
        
        public static Team2 Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color Team2Color {
            get {
                return ((global::System.Drawing.Color)(this["Team2Color"]));
            }
            set {
                this["Team2Color"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red Team")]
        public string Team2Name {
            get {
                return ((string)(this["Team2Name"]));
            }
            set {
                this["Team2Name"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft Sans Serif, 8.25pt")]
        public global::System.Drawing.Font Team2Font {
            get {
                return ((global::System.Drawing.Font)(this["Team2Font"]));
            }
            set {
                this["Team2Font"] = value;
            }
        }
    }
}
