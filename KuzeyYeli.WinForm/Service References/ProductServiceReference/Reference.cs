﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KuzeyYeli.WinForm.ProductServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceReference.IServiceOf_ProductDTO")]
    public interface IServiceOf_ProductDTO {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_ProductDTO/List", ReplyAction="http://tempuri.org/IServiceOf_ProductDTO/ListResponse")]
        System.Collections.Generic.List<KuzeyYeliDTO.ProductDTO> List();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_ProductDTO/List", ReplyAction="http://tempuri.org/IServiceOf_ProductDTO/ListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<KuzeyYeliDTO.ProductDTO>> ListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_ProductDTO/Insert", ReplyAction="http://tempuri.org/IServiceOf_ProductDTO/InsertResponse")]
        bool Insert(KuzeyYeliDTO.ProductDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_ProductDTO/Insert", ReplyAction="http://tempuri.org/IServiceOf_ProductDTO/InsertResponse")]
        System.Threading.Tasks.Task<bool> InsertAsync(KuzeyYeliDTO.ProductDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_ProductDTO/Update", ReplyAction="http://tempuri.org/IServiceOf_ProductDTO/UpdateResponse")]
        bool Update(KuzeyYeliDTO.ProductDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_ProductDTO/Update", ReplyAction="http://tempuri.org/IServiceOf_ProductDTO/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(KuzeyYeliDTO.ProductDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_ProductDTO/Delete", ReplyAction="http://tempuri.org/IServiceOf_ProductDTO/DeleteResponse")]
        bool Delete(KuzeyYeliDTO.ProductDTO dto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_ProductDTO/Delete", ReplyAction="http://tempuri.org/IServiceOf_ProductDTO/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(KuzeyYeliDTO.ProductDTO dto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceOf_ProductDTOChannel : KuzeyYeli.WinForm.ProductServiceReference.IServiceOf_ProductDTO, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceOf_ProductDTOClient : System.ServiceModel.ClientBase<KuzeyYeli.WinForm.ProductServiceReference.IServiceOf_ProductDTO>, KuzeyYeli.WinForm.ProductServiceReference.IServiceOf_ProductDTO {
        
        public ServiceOf_ProductDTOClient() {
        }
        
        public ServiceOf_ProductDTOClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceOf_ProductDTOClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOf_ProductDTOClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOf_ProductDTOClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<KuzeyYeliDTO.ProductDTO> List() {
            return base.Channel.List();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<KuzeyYeliDTO.ProductDTO>> ListAsync() {
            return base.Channel.ListAsync();
        }
        
        public bool Insert(KuzeyYeliDTO.ProductDTO dto) {
            return base.Channel.Insert(dto);
        }
        
        public System.Threading.Tasks.Task<bool> InsertAsync(KuzeyYeliDTO.ProductDTO dto) {
            return base.Channel.InsertAsync(dto);
        }
        
        public bool Update(KuzeyYeliDTO.ProductDTO dto) {
            return base.Channel.Update(dto);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(KuzeyYeliDTO.ProductDTO dto) {
            return base.Channel.UpdateAsync(dto);
        }
        
        public bool Delete(KuzeyYeliDTO.ProductDTO dto) {
            return base.Channel.Delete(dto);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(KuzeyYeliDTO.ProductDTO dto) {
            return base.Channel.DeleteAsync(dto);
        }
    }
}
