﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18449
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPServicesTest.PacienteWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Paciente", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Paciente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApeMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApePaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContrasenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroDocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDocumentoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApeMaterno {
            get {
                return this.ApeMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApeMaternoField, value) != true)) {
                    this.ApeMaternoField = value;
                    this.RaisePropertyChanged("ApeMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApePaterno {
            get {
                return this.ApePaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApePaternoField, value) != true)) {
                    this.ApePaternoField = value;
                    this.RaisePropertyChanged("ApePaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contrasena {
            get {
                return this.ContrasenaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContrasenaField, value) != true)) {
                    this.ContrasenaField = value;
                    this.RaisePropertyChanged("Contrasena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroDocumento {
            get {
                return this.NumeroDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroDocumentoField, value) != true)) {
                    this.NumeroDocumentoField = value;
                    this.RaisePropertyChanged("NumeroDocumento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDocumento {
            get {
                return this.TipoDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDocumentoField, value) != true)) {
                    this.TipoDocumentoField = value;
                    this.RaisePropertyChanged("TipoDocumento");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Mensaje", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Mensaje : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeDescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServicioOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoMensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeDescripcion {
            get {
                return this.MensajeDescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeDescripcionField, value) != true)) {
                    this.MensajeDescripcionField = value;
                    this.RaisePropertyChanged("MensajeDescripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServicioOrigen {
            get {
                return this.ServicioOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.ServicioOrigenField, value) != true)) {
                    this.ServicioOrigenField = value;
                    this.RaisePropertyChanged("ServicioOrigen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoMensaje {
            get {
                return this.TipoMensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoMensajeField, value) != true)) {
                    this.TipoMensajeField = value;
                    this.RaisePropertyChanged("TipoMensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PacienteWS.IPacientes")]
    public interface IPacientes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPacientes/registrarPaciente", ReplyAction="http://tempuri.org/IPacientes/registrarPacienteResponse")]
        SOAPServicesTest.PacienteWS.Mensaje registrarPaciente(SOAPServicesTest.PacienteWS.Paciente paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPacientes/modificarPaciente", ReplyAction="http://tempuri.org/IPacientes/modificarPacienteResponse")]
        SOAPServicesTest.PacienteWS.Mensaje modificarPaciente(SOAPServicesTest.PacienteWS.Paciente paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPacientes/listarPacientes", ReplyAction="http://tempuri.org/IPacientes/listarPacientesResponse")]
        SOAPServicesTest.PacienteWS.Paciente[] listarPacientes();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPacientesChannel : SOAPServicesTest.PacienteWS.IPacientes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PacientesClient : System.ServiceModel.ClientBase<SOAPServicesTest.PacienteWS.IPacientes>, SOAPServicesTest.PacienteWS.IPacientes {
        
        public PacientesClient() {
        }
        
        public PacientesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PacientesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PacientesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PacientesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServicesTest.PacienteWS.Mensaje registrarPaciente(SOAPServicesTest.PacienteWS.Paciente paciente) {
            return base.Channel.registrarPaciente(paciente);
        }
        
        public SOAPServicesTest.PacienteWS.Mensaje modificarPaciente(SOAPServicesTest.PacienteWS.Paciente paciente) {
            return base.Channel.modificarPaciente(paciente);
        }
        
        public SOAPServicesTest.PacienteWS.Paciente[] listarPacientes() {
            return base.Channel.listarPacientes();
        }
    }
}
