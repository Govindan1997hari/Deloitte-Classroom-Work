﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ilogin")]
    public interface ilogin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ilogin/authenticate", ReplyAction="http://tempuri.org/ilogin/authenticateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/ilogin/authenticateArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool authenticate(int id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ilogin/authenticate", ReplyAction="http://tempuri.org/ilogin/authenticateResponse")]
        System.Threading.Tasks.Task<bool> authenticateAsync(int id, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface iloginChannel : client.ServiceReference1.ilogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class iloginClient : System.ServiceModel.ClientBase<client.ServiceReference1.ilogin>, client.ServiceReference1.ilogin {
        
        public iloginClient() {
        }
        
        public iloginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public iloginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public iloginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public iloginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool authenticate(int id, string password) {
            return base.Channel.authenticate(id, password);
        }
        
        public System.Threading.Tasks.Task<bool> authenticateAsync(int id, string password) {
            return base.Channel.authenticateAsync(id, password);
        }
    }
}
