﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_WpfDesigner.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDesignerService")]
    public interface IDesignerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/LoadReport", ReplyAction="http://tempuri.org/IDesignerService/LoadReportResponse")]
        byte[] LoadReport();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/LoadReport", ReplyAction="http://tempuri.org/IDesignerService/LoadReportResponse")]
        System.Threading.Tasks.Task<byte[]> LoadReportAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/RenderingInteractions", ReplyAction="http://tempuri.org/IDesignerService/RenderingInteractionsResponse")]
        string RenderingInteractions(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/RenderingInteractions", ReplyAction="http://tempuri.org/IDesignerService/RenderingInteractionsResponse")]
        System.Threading.Tasks.Task<string> RenderingInteractionsAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/RequestFromUserRenderReport", ReplyAction="http://tempuri.org/IDesignerService/RequestFromUserRenderReportResponse")]
        string RequestFromUserRenderReport(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/RequestFromUserRenderReport", ReplyAction="http://tempuri.org/IDesignerService/RequestFromUserRenderReportResponse")]
        System.Threading.Tasks.Task<string> RequestFromUserRenderReportAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/ExportDocument", ReplyAction="http://tempuri.org/IDesignerService/ExportDocumentResponse")]
        byte[] ExportDocument(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/ExportDocument", ReplyAction="http://tempuri.org/IDesignerService/ExportDocumentResponse")]
        System.Threading.Tasks.Task<byte[]> ExportDocumentAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/PrepareRequestFromUserVariables", ReplyAction="http://tempuri.org/IDesignerService/PrepareRequestFromUserVariablesResponse")]
        string PrepareRequestFromUserVariables(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/PrepareRequestFromUserVariables", ReplyAction="http://tempuri.org/IDesignerService/PrepareRequestFromUserVariablesResponse")]
        System.Threading.Tasks.Task<string> PrepareRequestFromUserVariablesAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/InteractiveDataBandSelection", ReplyAction="http://tempuri.org/IDesignerService/InteractiveDataBandSelectionResponse")]
        string InteractiveDataBandSelection(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/InteractiveDataBandSelection", ReplyAction="http://tempuri.org/IDesignerService/InteractiveDataBandSelectionResponse")]
        System.Threading.Tasks.Task<string> InteractiveDataBandSelectionAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/SaveReport", ReplyAction="http://tempuri.org/IDesignerService/SaveReportResponse")]
        bool SaveReport(byte[] buffer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/SaveReport", ReplyAction="http://tempuri.org/IDesignerService/SaveReportResponse")]
        System.Threading.Tasks.Task<bool> SaveReportAsync(byte[] buffer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/LoadConfiguration", ReplyAction="http://tempuri.org/IDesignerService/LoadConfigurationResponse")]
        string LoadConfiguration();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/LoadConfiguration", ReplyAction="http://tempuri.org/IDesignerService/LoadConfigurationResponse")]
        System.Threading.Tasks.Task<string> LoadConfigurationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/RenderReport", ReplyAction="http://tempuri.org/IDesignerService/RenderReportResponse")]
        string RenderReport(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/RenderReport", ReplyAction="http://tempuri.org/IDesignerService/RenderReportResponse")]
        System.Threading.Tasks.Task<string> RenderReportAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/TestConnection", ReplyAction="http://tempuri.org/IDesignerService/TestConnectionResponse")]
        string TestConnection(string settings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/TestConnection", ReplyAction="http://tempuri.org/IDesignerService/TestConnectionResponse")]
        System.Threading.Tasks.Task<string> TestConnectionAsync(string settings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/BuildObjects", ReplyAction="http://tempuri.org/IDesignerService/BuildObjectsResponse")]
        string BuildObjects(string settings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/BuildObjects", ReplyAction="http://tempuri.org/IDesignerService/BuildObjectsResponse")]
        System.Threading.Tasks.Task<string> BuildObjectsAsync(string settings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/RetrieveColumns", ReplyAction="http://tempuri.org/IDesignerService/RetrieveColumnsResponse")]
        string RetrieveColumns(string settings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/RetrieveColumns", ReplyAction="http://tempuri.org/IDesignerService/RetrieveColumnsResponse")]
        System.Threading.Tasks.Task<string> RetrieveColumnsAsync(string settings);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsGetDocuments", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsGetDocumentsResponse")]
        string GoogleDocsGetDocuments(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsGetDocuments", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsGetDocumentsResponse")]
        System.Threading.Tasks.Task<string> GoogleDocsGetDocumentsAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsCreateCollection", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsCreateCollectionResponse")]
        string GoogleDocsCreateCollection(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsCreateCollection", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsCreateCollectionResponse")]
        System.Threading.Tasks.Task<string> GoogleDocsCreateCollectionAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsDelete", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsDeleteResponse")]
        string GoogleDocsDelete(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsDelete", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsDeleteResponse")]
        System.Threading.Tasks.Task<string> GoogleDocsDeleteAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsOpen", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsOpenResponse")]
        string GoogleDocsOpen(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsOpen", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsOpenResponse")]
        System.Threading.Tasks.Task<string> GoogleDocsOpenAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsSave", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsSaveResponse")]
        string GoogleDocsSave(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/GoogleDocsSave", ReplyAction="http://tempuri.org/IDesignerService/GoogleDocsSaveResponse")]
        System.Threading.Tasks.Task<string> GoogleDocsSaveAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/OpenReportScript", ReplyAction="http://tempuri.org/IDesignerService/OpenReportScriptResponse")]
        string OpenReportScript(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/OpenReportScript", ReplyAction="http://tempuri.org/IDesignerService/OpenReportScriptResponse")]
        System.Threading.Tasks.Task<string> OpenReportScriptAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/SaveReportScript", ReplyAction="http://tempuri.org/IDesignerService/SaveReportScriptResponse")]
        string SaveReportScript(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/SaveReportScript", ReplyAction="http://tempuri.org/IDesignerService/SaveReportScriptResponse")]
        System.Threading.Tasks.Task<string> SaveReportScriptAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/CheckReport", ReplyAction="http://tempuri.org/IDesignerService/CheckReportResponse")]
        string CheckReport(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDesignerService/CheckReport", ReplyAction="http://tempuri.org/IDesignerService/CheckReportResponse")]
        System.Threading.Tasks.Task<string> CheckReportAsync(string xml);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDesignerServiceChannel : WCF_WpfDesigner.ServiceReference1.IDesignerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DesignerServiceClient : System.ServiceModel.ClientBase<WCF_WpfDesigner.ServiceReference1.IDesignerService>, WCF_WpfDesigner.ServiceReference1.IDesignerService {
        
        public DesignerServiceClient() {
        }
        
        public DesignerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DesignerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DesignerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DesignerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte[] LoadReport() {
            return base.Channel.LoadReport();
        }
        
        public System.Threading.Tasks.Task<byte[]> LoadReportAsync() {
            return base.Channel.LoadReportAsync();
        }
        
        public string RenderingInteractions(string xml) {
            return base.Channel.RenderingInteractions(xml);
        }
        
        public System.Threading.Tasks.Task<string> RenderingInteractionsAsync(string xml) {
            return base.Channel.RenderingInteractionsAsync(xml);
        }
        
        public string RequestFromUserRenderReport(string xml) {
            return base.Channel.RequestFromUserRenderReport(xml);
        }
        
        public System.Threading.Tasks.Task<string> RequestFromUserRenderReportAsync(string xml) {
            return base.Channel.RequestFromUserRenderReportAsync(xml);
        }
        
        public byte[] ExportDocument(string xml) {
            return base.Channel.ExportDocument(xml);
        }
        
        public System.Threading.Tasks.Task<byte[]> ExportDocumentAsync(string xml) {
            return base.Channel.ExportDocumentAsync(xml);
        }
        
        public string PrepareRequestFromUserVariables(string xml) {
            return base.Channel.PrepareRequestFromUserVariables(xml);
        }
        
        public System.Threading.Tasks.Task<string> PrepareRequestFromUserVariablesAsync(string xml) {
            return base.Channel.PrepareRequestFromUserVariablesAsync(xml);
        }
        
        public string InteractiveDataBandSelection(string xml) {
            return base.Channel.InteractiveDataBandSelection(xml);
        }
        
        public System.Threading.Tasks.Task<string> InteractiveDataBandSelectionAsync(string xml) {
            return base.Channel.InteractiveDataBandSelectionAsync(xml);
        }
        
        public bool SaveReport(byte[] buffer) {
            return base.Channel.SaveReport(buffer);
        }
        
        public System.Threading.Tasks.Task<bool> SaveReportAsync(byte[] buffer) {
            return base.Channel.SaveReportAsync(buffer);
        }
        
        public string LoadConfiguration() {
            return base.Channel.LoadConfiguration();
        }
        
        public System.Threading.Tasks.Task<string> LoadConfigurationAsync() {
            return base.Channel.LoadConfigurationAsync();
        }
        
        public string RenderReport(string xml) {
            return base.Channel.RenderReport(xml);
        }
        
        public System.Threading.Tasks.Task<string> RenderReportAsync(string xml) {
            return base.Channel.RenderReportAsync(xml);
        }
        
        public string TestConnection(string settings) {
            return base.Channel.TestConnection(settings);
        }
        
        public System.Threading.Tasks.Task<string> TestConnectionAsync(string settings) {
            return base.Channel.TestConnectionAsync(settings);
        }
        
        public string BuildObjects(string settings) {
            return base.Channel.BuildObjects(settings);
        }
        
        public System.Threading.Tasks.Task<string> BuildObjectsAsync(string settings) {
            return base.Channel.BuildObjectsAsync(settings);
        }
        
        public string RetrieveColumns(string settings) {
            return base.Channel.RetrieveColumns(settings);
        }
        
        public System.Threading.Tasks.Task<string> RetrieveColumnsAsync(string settings) {
            return base.Channel.RetrieveColumnsAsync(settings);
        }
        
        public string GoogleDocsGetDocuments(string xml) {
            return base.Channel.GoogleDocsGetDocuments(xml);
        }
        
        public System.Threading.Tasks.Task<string> GoogleDocsGetDocumentsAsync(string xml) {
            return base.Channel.GoogleDocsGetDocumentsAsync(xml);
        }
        
        public string GoogleDocsCreateCollection(string xml) {
            return base.Channel.GoogleDocsCreateCollection(xml);
        }
        
        public System.Threading.Tasks.Task<string> GoogleDocsCreateCollectionAsync(string xml) {
            return base.Channel.GoogleDocsCreateCollectionAsync(xml);
        }
        
        public string GoogleDocsDelete(string xml) {
            return base.Channel.GoogleDocsDelete(xml);
        }
        
        public System.Threading.Tasks.Task<string> GoogleDocsDeleteAsync(string xml) {
            return base.Channel.GoogleDocsDeleteAsync(xml);
        }
        
        public string GoogleDocsOpen(string xml) {
            return base.Channel.GoogleDocsOpen(xml);
        }
        
        public System.Threading.Tasks.Task<string> GoogleDocsOpenAsync(string xml) {
            return base.Channel.GoogleDocsOpenAsync(xml);
        }
        
        public string GoogleDocsSave(string xml) {
            return base.Channel.GoogleDocsSave(xml);
        }
        
        public System.Threading.Tasks.Task<string> GoogleDocsSaveAsync(string xml) {
            return base.Channel.GoogleDocsSaveAsync(xml);
        }
        
        public string OpenReportScript(string xml) {
            return base.Channel.OpenReportScript(xml);
        }
        
        public System.Threading.Tasks.Task<string> OpenReportScriptAsync(string xml) {
            return base.Channel.OpenReportScriptAsync(xml);
        }
        
        public string SaveReportScript(string xml) {
            return base.Channel.SaveReportScript(xml);
        }
        
        public System.Threading.Tasks.Task<string> SaveReportScriptAsync(string xml) {
            return base.Channel.SaveReportScriptAsync(xml);
        }
        
        public string CheckReport(string xml) {
            return base.Channel.CheckReport(xml);
        }
        
        public System.Threading.Tasks.Task<string> CheckReportAsync(string xml) {
            return base.Channel.CheckReportAsync(xml);
        }
    }
}
