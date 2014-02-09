﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18051.
// 
#pragma warning disable 1591

namespace Lost.Services {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SimpleServiceBinding", Namespace="http://mmcwong.com/soap/SimpleService")]
    public partial class SimpleService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ProcessSimpleTypeOperationCompleted;
        
        private System.Threading.SendOrPostCallback ProcessMyLocationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SimpleService() {
            this.Url = global::Lost.Properties.Settings.Default.Lost_Services_SimpleService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ProcessSimpleTypeCompletedEventHandler ProcessSimpleTypeCompleted;
        
        /// <remarks/>
        public event ProcessMyLocationCompletedEventHandler ProcessMyLocationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://mmcwong.com/services/location.php/ProcessSimpleType", RequestNamespace="http://sanity-free.org/services", ResponseNamespace="http://sanity-free.org/services")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string ProcessSimpleType(string name) {
            object[] results = this.Invoke("ProcessSimpleType", new object[] {
                        name});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ProcessSimpleTypeAsync(string name) {
            this.ProcessSimpleTypeAsync(name, null);
        }
        
        /// <remarks/>
        public void ProcessSimpleTypeAsync(string name, object userState) {
            if ((this.ProcessSimpleTypeOperationCompleted == null)) {
                this.ProcessSimpleTypeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcessSimpleTypeOperationCompleted);
            }
            this.InvokeAsync("ProcessSimpleType", new object[] {
                        name}, this.ProcessSimpleTypeOperationCompleted, userState);
        }
        
        private void OnProcessSimpleTypeOperationCompleted(object arg) {
            if ((this.ProcessSimpleTypeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcessSimpleTypeCompleted(this, new ProcessSimpleTypeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://mmcwong.com/services/location.php/ProcessMyLocation", RequestNamespace="http://sanity-free.org/services", ResponseNamespace="http://sanity-free.org/services")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string ProcessMyLocation(Location location) {
            object[] results = this.Invoke("ProcessMyLocation", new object[] {
                        location});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ProcessMyLocationAsync(Location location) {
            this.ProcessMyLocationAsync(location, null);
        }
        
        /// <remarks/>
        public void ProcessMyLocationAsync(Location location, object userState) {
            if ((this.ProcessMyLocationOperationCompleted == null)) {
                this.ProcessMyLocationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcessMyLocationOperationCompleted);
            }
            this.InvokeAsync("ProcessMyLocation", new object[] {
                        location}, this.ProcessMyLocationOperationCompleted, userState);
        }
        
        private void OnProcessMyLocationOperationCompleted(object arg) {
            if ((this.ProcessMyLocationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcessMyLocationCompleted(this, new ProcessMyLocationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://mmcwong.com/soap/SimpleService")]
    public partial class Location {
        
        private double longitudeField;
        
        private double latitudeField;
        
        /// <remarks/>
        public double Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        public double Latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ProcessSimpleTypeCompletedEventHandler(object sender, ProcessSimpleTypeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProcessSimpleTypeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ProcessSimpleTypeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ProcessMyLocationCompletedEventHandler(object sender, ProcessMyLocationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProcessMyLocationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ProcessMyLocationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591