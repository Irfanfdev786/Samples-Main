﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21019.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiringRequestService.Contoso.OrgService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Samples.Organization")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HiringRequestService.Contoso.OrgService.Department DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ManagerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HiringRequestService.Contoso.OrgService.Position PositionField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HiringRequestService.Contoso.OrgService.Department Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ManagerId {
            get {
                return this.ManagerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ManagerIdField, value) != true)) {
                    this.ManagerIdField = value;
                    this.RaisePropertyChanged("ManagerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HiringRequestService.Contoso.OrgService.Position Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Department", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Samples.Organization")]
    [System.SerializableAttribute()]
    public partial class Department : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HiringRequestService.Contoso.OrgService.Employee OwnerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OwnerIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HiringRequestService.Contoso.OrgService.Employee Owner {
            get {
                return this.OwnerField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerField, value) != true)) {
                    this.OwnerField = value;
                    this.RaisePropertyChanged("Owner");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OwnerId {
            get {
                return this.OwnerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerIdField, value) != true)) {
                    this.OwnerIdField = value;
                    this.RaisePropertyChanged("OwnerId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Position", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Samples.Organization")]
    [System.SerializableAttribute()]
    public partial class Position : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HiringRequestService.Contoso.OrgService.PositionType PositionTypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HiringRequestService.Contoso.OrgService.PositionType PositionType {
            get {
                return this.PositionTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionTypeField, value) != true)) {
                    this.PositionTypeField = value;
                    this.RaisePropertyChanged("PositionType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PositionType", Namespace="http://schemas.datacontract.org/2004/07/Microsoft.Samples.Organization")]
    [System.SerializableAttribute()]
    public partial class PositionType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Contoso.OrgService.IOrgService")]
    public interface IOrgService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetEmployee", ReplyAction="http://tempuri.org/IOrgService/GetEmployeeResponse")]
        HiringRequestService.Contoso.OrgService.GetEmployeeResponse GetEmployee(HiringRequestService.Contoso.OrgService.GetEmployeeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetDepartment", ReplyAction="http://tempuri.org/IOrgService/GetDepartmentResponse")]
        HiringRequestService.Contoso.OrgService.GetDepartmentResponse GetDepartment(HiringRequestService.Contoso.OrgService.GetDepartmentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetPosition", ReplyAction="http://tempuri.org/IOrgService/GetPositionResponse")]
        HiringRequestService.Contoso.OrgService.GetPositionResponse GetPosition(HiringRequestService.Contoso.OrgService.GetPositionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetPositionType", ReplyAction="http://tempuri.org/IOrgService/GetPositionTypeResponse")]
        HiringRequestService.Contoso.OrgService.GetPositionTypeResponse GetPositionType(HiringRequestService.Contoso.OrgService.GetPositionTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetAllEmployees", ReplyAction="http://tempuri.org/IOrgService/GetAllEmployeesResponse")]
        HiringRequestService.Contoso.OrgService.GetAllEmployeesResponse GetAllEmployees(HiringRequestService.Contoso.OrgService.GetAllEmployeesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetEmployeesByPosition", ReplyAction="http://tempuri.org/IOrgService/GetEmployeesByPositionResponse")]
        HiringRequestService.Contoso.OrgService.GetEmployeesByPositionResponse GetEmployeesByPosition(HiringRequestService.Contoso.OrgService.GetEmployeesByPositionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetAllDepartments", ReplyAction="http://tempuri.org/IOrgService/GetAllDepartmentsResponse")]
        HiringRequestService.Contoso.OrgService.GetAllDepartmentsResponse GetAllDepartments(HiringRequestService.Contoso.OrgService.GetAllDepartmentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetAllPositions", ReplyAction="http://tempuri.org/IOrgService/GetAllPositionsResponse")]
        HiringRequestService.Contoso.OrgService.GetAllPositionsResponse GetAllPositions(HiringRequestService.Contoso.OrgService.GetAllPositionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrgService/GetAllPositionTypes", ReplyAction="http://tempuri.org/IOrgService/GetAllPositionTypesResponse")]
        HiringRequestService.Contoso.OrgService.GetAllPositionTypesResponse GetAllPositionTypes(HiringRequestService.Contoso.OrgService.GetAllPositionTypesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployee", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string employeeId;
        
        public GetEmployeeRequest() {
        }
        
        public GetEmployeeRequest(string employeeId) {
            this.employeeId = employeeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.Employee GetEmployeeResult;
        
        public GetEmployeeResponse() {
        }
        
        public GetEmployeeResponse(HiringRequestService.Contoso.OrgService.Employee GetEmployeeResult) {
            this.GetEmployeeResult = GetEmployeeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDepartment", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDepartmentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string departmentId;
        
        public GetDepartmentRequest() {
        }
        
        public GetDepartmentRequest(string departmentId) {
            this.departmentId = departmentId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDepartmentResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDepartmentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.Department GetDepartmentResult;
        
        public GetDepartmentResponse() {
        }
        
        public GetDepartmentResponse(HiringRequestService.Contoso.OrgService.Department GetDepartmentResult) {
            this.GetDepartmentResult = GetDepartmentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPosition", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPositionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string positionId;
        
        public GetPositionRequest() {
        }
        
        public GetPositionRequest(string positionId) {
            this.positionId = positionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPositionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPositionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.Position GetPositionResult;
        
        public GetPositionResponse() {
        }
        
        public GetPositionResponse(HiringRequestService.Contoso.OrgService.Position GetPositionResult) {
            this.GetPositionResult = GetPositionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPositionType", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPositionTypeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string positionTypeId;
        
        public GetPositionTypeRequest() {
        }
        
        public GetPositionTypeRequest(string positionTypeId) {
            this.positionTypeId = positionTypeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPositionTypeResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPositionTypeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.PositionType GetPositionTypeResult;
        
        public GetPositionTypeResponse() {
        }
        
        public GetPositionTypeResponse(HiringRequestService.Contoso.OrgService.PositionType GetPositionTypeResult) {
            this.GetPositionTypeResult = GetPositionTypeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllEmployees", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllEmployeesRequest {
        
        public GetAllEmployeesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllEmployeesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllEmployeesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.Employee[] GetAllEmployeesResult;
        
        public GetAllEmployeesResponse() {
        }
        
        public GetAllEmployeesResponse(HiringRequestService.Contoso.OrgService.Employee[] GetAllEmployeesResult) {
            this.GetAllEmployeesResult = GetAllEmployeesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeesByPosition", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeesByPositionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string positionId;
        
        public GetEmployeesByPositionRequest() {
        }
        
        public GetEmployeesByPositionRequest(string positionId) {
            this.positionId = positionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeesByPositionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeesByPositionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.Employee[] GetEmployeesByPositionResult;
        
        public GetEmployeesByPositionResponse() {
        }
        
        public GetEmployeesByPositionResponse(HiringRequestService.Contoso.OrgService.Employee[] GetEmployeesByPositionResult) {
            this.GetEmployeesByPositionResult = GetEmployeesByPositionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllDepartments", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllDepartmentsRequest {
        
        public GetAllDepartmentsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllDepartmentsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllDepartmentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.Department[] GetAllDepartmentsResult;
        
        public GetAllDepartmentsResponse() {
        }
        
        public GetAllDepartmentsResponse(HiringRequestService.Contoso.OrgService.Department[] GetAllDepartmentsResult) {
            this.GetAllDepartmentsResult = GetAllDepartmentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllPositions", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllPositionsRequest {
        
        public GetAllPositionsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllPositionsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllPositionsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.Position[] GetAllPositionsResult;
        
        public GetAllPositionsResponse() {
        }
        
        public GetAllPositionsResponse(HiringRequestService.Contoso.OrgService.Position[] GetAllPositionsResult) {
            this.GetAllPositionsResult = GetAllPositionsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllPositionTypes", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllPositionTypesRequest {
        
        public GetAllPositionTypesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllPositionTypesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllPositionTypesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public HiringRequestService.Contoso.OrgService.PositionType[] GetAllPositionTypesResult;
        
        public GetAllPositionTypesResponse() {
        }
        
        public GetAllPositionTypesResponse(HiringRequestService.Contoso.OrgService.PositionType[] GetAllPositionTypesResult) {
            this.GetAllPositionTypesResult = GetAllPositionTypesResult;
        }
    }
}
