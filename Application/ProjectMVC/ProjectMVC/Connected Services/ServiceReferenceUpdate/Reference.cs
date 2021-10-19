﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.ServiceReferenceUpdate {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUpdate.WebServiceUpdateSoap")]
    public interface WebServiceUpdateSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        ProjectMVC.ServiceReferenceUpdate.UpdateResponse Update(ProjectMVC.ServiceReferenceUpdate.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReferenceUpdate.UpdateResponse> UpdateAsync(ProjectMVC.ServiceReferenceUpdate.UpdateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReferenceUpdate.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(ProjectMVC.ServiceReferenceUpdate.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string telephone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string question;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string answer;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(string name, string telephone, string email, string address, string question, string answer) {
            this.name = name;
            this.telephone = telephone;
            this.email = email;
            this.address = address;
            this.question = question;
            this.answer = answer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReferenceUpdate.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(ProjectMVC.ServiceReferenceUpdate.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateResponseBody {
        
        public UpdateResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceUpdateSoapChannel : ProjectMVC.ServiceReferenceUpdate.WebServiceUpdateSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceUpdateSoapClient : System.ServiceModel.ClientBase<ProjectMVC.ServiceReferenceUpdate.WebServiceUpdateSoap>, ProjectMVC.ServiceReferenceUpdate.WebServiceUpdateSoap {
        
        public WebServiceUpdateSoapClient() {
        }
        
        public WebServiceUpdateSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceUpdateSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceUpdateSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceUpdateSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectMVC.ServiceReferenceUpdate.UpdateResponse ProjectMVC.ServiceReferenceUpdate.WebServiceUpdateSoap.Update(ProjectMVC.ServiceReferenceUpdate.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public void Update(string name, string telephone, string email, string address, string question, string answer) {
            ProjectMVC.ServiceReferenceUpdate.UpdateRequest inValue = new ProjectMVC.ServiceReferenceUpdate.UpdateRequest();
            inValue.Body = new ProjectMVC.ServiceReferenceUpdate.UpdateRequestBody();
            inValue.Body.name = name;
            inValue.Body.telephone = telephone;
            inValue.Body.email = email;
            inValue.Body.address = address;
            inValue.Body.question = question;
            inValue.Body.answer = answer;
            ProjectMVC.ServiceReferenceUpdate.UpdateResponse retVal = ((ProjectMVC.ServiceReferenceUpdate.WebServiceUpdateSoap)(this)).Update(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReferenceUpdate.UpdateResponse> ProjectMVC.ServiceReferenceUpdate.WebServiceUpdateSoap.UpdateAsync(ProjectMVC.ServiceReferenceUpdate.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ServiceReferenceUpdate.UpdateResponse> UpdateAsync(string name, string telephone, string email, string address, string question, string answer) {
            ProjectMVC.ServiceReferenceUpdate.UpdateRequest inValue = new ProjectMVC.ServiceReferenceUpdate.UpdateRequest();
            inValue.Body = new ProjectMVC.ServiceReferenceUpdate.UpdateRequestBody();
            inValue.Body.name = name;
            inValue.Body.telephone = telephone;
            inValue.Body.email = email;
            inValue.Body.address = address;
            inValue.Body.question = question;
            inValue.Body.answer = answer;
            return ((ProjectMVC.ServiceReferenceUpdate.WebServiceUpdateSoap)(this)).UpdateAsync(inValue);
        }
    }
}