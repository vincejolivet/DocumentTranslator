﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TranslationAssistant.DocumentTranslationInterface.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class DocumentTranslator : global::System.Configuration.ApplicationSettingsBase {
        
        private static DocumentTranslator defaultInstance = ((DocumentTranslator)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DocumentTranslator())));
        
        public static DocumentTranslator Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultSourceLanguage {
            get {
                return ((string)(this["DefaultSourceLanguage"]));
            }
            set {
                this["DefaultSourceLanguage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultTargetLanguage {
            get {
                return ((string)(this["DefaultTargetLanguage"]));
            }
            set {
                this["DefaultTargetLanguage"] = value;
            }
        }
    }
}
