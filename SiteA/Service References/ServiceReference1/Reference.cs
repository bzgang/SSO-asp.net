﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSO.SiteA.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.passport.com/", ConfigurationName="ServiceReference1.PassportServiceSoap")]
    public interface PassportServiceSoap {
        
        // CODEGEN: 命名空间 http://www.passport.com/ 的元素名称 token 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.passport.com/TokenGetCert", ReplyAction="*")]
        SSO.SiteA.ServiceReference1.TokenGetCertResponse TokenGetCert(SSO.SiteA.ServiceReference1.TokenGetCertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.passport.com/TokenGetCert", ReplyAction="*")]
        System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenGetCertResponse> TokenGetCertAsync(SSO.SiteA.ServiceReference1.TokenGetCertRequest request);
        
        // CODEGEN: 命名空间 http://www.passport.com/ 的元素名称 token 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.passport.com/TokenGetDbTokenActive", ReplyAction="*")]
        SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveResponse TokenGetDbTokenActive(SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.passport.com/TokenGetDbTokenActive", ReplyAction="*")]
        System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveResponse> TokenGetDbTokenActiveAsync(SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequest request);
        
        // CODEGEN: 命名空间 http://www.passport.com/ 的元素名称 token 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.passport.com/TokenClear", ReplyAction="*")]
        SSO.SiteA.ServiceReference1.TokenClearResponse TokenClear(SSO.SiteA.ServiceReference1.TokenClearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.passport.com/TokenClear", ReplyAction="*")]
        System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenClearResponse> TokenClearAsync(SSO.SiteA.ServiceReference1.TokenClearRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TokenGetCertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TokenGetCert", Namespace="http://www.passport.com/", Order=0)]
        public SSO.SiteA.ServiceReference1.TokenGetCertRequestBody Body;
        
        public TokenGetCertRequest() {
        }
        
        public TokenGetCertRequest(SSO.SiteA.ServiceReference1.TokenGetCertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.passport.com/")]
    public partial class TokenGetCertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        public TokenGetCertRequestBody() {
        }
        
        public TokenGetCertRequestBody(string token) {
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TokenGetCertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TokenGetCertResponse", Namespace="http://www.passport.com/", Order=0)]
        public SSO.SiteA.ServiceReference1.TokenGetCertResponseBody Body;
        
        public TokenGetCertResponse() {
        }
        
        public TokenGetCertResponse(SSO.SiteA.ServiceReference1.TokenGetCertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.passport.com/")]
    public partial class TokenGetCertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public object TokenGetCertResult;
        
        public TokenGetCertResponseBody() {
        }
        
        public TokenGetCertResponseBody(object TokenGetCertResult) {
            this.TokenGetCertResult = TokenGetCertResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TokenGetDbTokenActiveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TokenGetDbTokenActive", Namespace="http://www.passport.com/", Order=0)]
        public SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequestBody Body;
        
        public TokenGetDbTokenActiveRequest() {
        }
        
        public TokenGetDbTokenActiveRequest(SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.passport.com/")]
    public partial class TokenGetDbTokenActiveRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        public TokenGetDbTokenActiveRequestBody() {
        }
        
        public TokenGetDbTokenActiveRequestBody(string token) {
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TokenGetDbTokenActiveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TokenGetDbTokenActiveResponse", Namespace="http://www.passport.com/", Order=0)]
        public SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveResponseBody Body;
        
        public TokenGetDbTokenActiveResponse() {
        }
        
        public TokenGetDbTokenActiveResponse(SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.passport.com/")]
    public partial class TokenGetDbTokenActiveResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool TokenGetDbTokenActiveResult;
        
        public TokenGetDbTokenActiveResponseBody() {
        }
        
        public TokenGetDbTokenActiveResponseBody(bool TokenGetDbTokenActiveResult) {
            this.TokenGetDbTokenActiveResult = TokenGetDbTokenActiveResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TokenClearRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TokenClear", Namespace="http://www.passport.com/", Order=0)]
        public SSO.SiteA.ServiceReference1.TokenClearRequestBody Body;
        
        public TokenClearRequest() {
        }
        
        public TokenClearRequest(SSO.SiteA.ServiceReference1.TokenClearRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.passport.com/")]
    public partial class TokenClearRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string token;
        
        public TokenClearRequestBody() {
        }
        
        public TokenClearRequestBody(string token) {
            this.token = token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TokenClearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TokenClearResponse", Namespace="http://www.passport.com/", Order=0)]
        public SSO.SiteA.ServiceReference1.TokenClearResponseBody Body;
        
        public TokenClearResponse() {
        }
        
        public TokenClearResponse(SSO.SiteA.ServiceReference1.TokenClearResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class TokenClearResponseBody {
        
        public TokenClearResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PassportServiceSoapChannel : SSO.SiteA.ServiceReference1.PassportServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PassportServiceSoapClient : System.ServiceModel.ClientBase<SSO.SiteA.ServiceReference1.PassportServiceSoap>, SSO.SiteA.ServiceReference1.PassportServiceSoap {
        
        public PassportServiceSoapClient() {
        }
        
        public PassportServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PassportServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassportServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PassportServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SSO.SiteA.ServiceReference1.TokenGetCertResponse SSO.SiteA.ServiceReference1.PassportServiceSoap.TokenGetCert(SSO.SiteA.ServiceReference1.TokenGetCertRequest request) {
            return base.Channel.TokenGetCert(request);
        }
        
        public object TokenGetCert(string token) {
            SSO.SiteA.ServiceReference1.TokenGetCertRequest inValue = new SSO.SiteA.ServiceReference1.TokenGetCertRequest();
            inValue.Body = new SSO.SiteA.ServiceReference1.TokenGetCertRequestBody();
            inValue.Body.token = token;
            SSO.SiteA.ServiceReference1.TokenGetCertResponse retVal = ((SSO.SiteA.ServiceReference1.PassportServiceSoap)(this)).TokenGetCert(inValue);
            return retVal.Body.TokenGetCertResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenGetCertResponse> SSO.SiteA.ServiceReference1.PassportServiceSoap.TokenGetCertAsync(SSO.SiteA.ServiceReference1.TokenGetCertRequest request) {
            return base.Channel.TokenGetCertAsync(request);
        }
        
        public System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenGetCertResponse> TokenGetCertAsync(string token) {
            SSO.SiteA.ServiceReference1.TokenGetCertRequest inValue = new SSO.SiteA.ServiceReference1.TokenGetCertRequest();
            inValue.Body = new SSO.SiteA.ServiceReference1.TokenGetCertRequestBody();
            inValue.Body.token = token;
            return ((SSO.SiteA.ServiceReference1.PassportServiceSoap)(this)).TokenGetCertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveResponse SSO.SiteA.ServiceReference1.PassportServiceSoap.TokenGetDbTokenActive(SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequest request) {
            return base.Channel.TokenGetDbTokenActive(request);
        }
        
        public bool TokenGetDbTokenActive(string token) {
            SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequest inValue = new SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequest();
            inValue.Body = new SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequestBody();
            inValue.Body.token = token;
            SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveResponse retVal = ((SSO.SiteA.ServiceReference1.PassportServiceSoap)(this)).TokenGetDbTokenActive(inValue);
            return retVal.Body.TokenGetDbTokenActiveResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveResponse> SSO.SiteA.ServiceReference1.PassportServiceSoap.TokenGetDbTokenActiveAsync(SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequest request) {
            return base.Channel.TokenGetDbTokenActiveAsync(request);
        }
        
        public System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveResponse> TokenGetDbTokenActiveAsync(string token) {
            SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequest inValue = new SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequest();
            inValue.Body = new SSO.SiteA.ServiceReference1.TokenGetDbTokenActiveRequestBody();
            inValue.Body.token = token;
            return ((SSO.SiteA.ServiceReference1.PassportServiceSoap)(this)).TokenGetDbTokenActiveAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SSO.SiteA.ServiceReference1.TokenClearResponse SSO.SiteA.ServiceReference1.PassportServiceSoap.TokenClear(SSO.SiteA.ServiceReference1.TokenClearRequest request) {
            return base.Channel.TokenClear(request);
        }
        
        public void TokenClear(string token) {
            SSO.SiteA.ServiceReference1.TokenClearRequest inValue = new SSO.SiteA.ServiceReference1.TokenClearRequest();
            inValue.Body = new SSO.SiteA.ServiceReference1.TokenClearRequestBody();
            inValue.Body.token = token;
            SSO.SiteA.ServiceReference1.TokenClearResponse retVal = ((SSO.SiteA.ServiceReference1.PassportServiceSoap)(this)).TokenClear(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenClearResponse> SSO.SiteA.ServiceReference1.PassportServiceSoap.TokenClearAsync(SSO.SiteA.ServiceReference1.TokenClearRequest request) {
            return base.Channel.TokenClearAsync(request);
        }
        
        public System.Threading.Tasks.Task<SSO.SiteA.ServiceReference1.TokenClearResponse> TokenClearAsync(string token) {
            SSO.SiteA.ServiceReference1.TokenClearRequest inValue = new SSO.SiteA.ServiceReference1.TokenClearRequest();
            inValue.Body = new SSO.SiteA.ServiceReference1.TokenClearRequestBody();
            inValue.Body.token = token;
            return ((SSO.SiteA.ServiceReference1.PassportServiceSoap)(this)).TokenClearAsync(inValue);
        }
    }
}
