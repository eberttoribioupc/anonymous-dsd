﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSDServicesTEST.PacienteWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Paciente", Namespace="http://schemas.datacontract.org/2004/07/DSDServices.Dominio")]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaServiceOfPacientez_SY3AMPv", Namespace="http://schemas.datacontract.org/2004/07/DSDServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class RespuestaServiceOfPacientez_SY3AMPv : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DSDServicesTEST.PacienteWS.Paciente ClaseOrigenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeDescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MetodoOrigenField;
        
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
        public DSDServicesTEST.PacienteWS.Paciente ClaseOrigen {
            get {
                return this.ClaseOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaseOrigenField, value) != true)) {
                    this.ClaseOrigenField = value;
                    this.RaisePropertyChanged("ClaseOrigen");
                }
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
        public string MetodoOrigen {
            get {
                return this.MetodoOrigenField;
            }
            set {
                if ((object.ReferenceEquals(this.MetodoOrigenField, value) != true)) {
                    this.MetodoOrigenField = value;
                    this.RaisePropertyChanged("MetodoOrigen");
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
        DSDServicesTEST.PacienteWS.RespuestaServiceOfPacientez_SY3AMPv registrarPaciente(DSDServicesTEST.PacienteWS.Paciente paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPacientes/modificarPaciente", ReplyAction="http://tempuri.org/IPacientes/modificarPacienteResponse")]
        DSDServicesTEST.PacienteWS.RespuestaServiceOfPacientez_SY3AMPv modificarPaciente(DSDServicesTEST.PacienteWS.Paciente paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPacientes/listarPacientes", ReplyAction="http://tempuri.org/IPacientes/listarPacientesResponse")]
        DSDServicesTEST.PacienteWS.Paciente[] listarPacientes();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPacientesChannel : DSDServicesTEST.PacienteWS.IPacientes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PacientesClient : System.ServiceModel.ClientBase<DSDServicesTEST.PacienteWS.IPacientes>, DSDServicesTEST.PacienteWS.IPacientes {
        
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
        
        public DSDServicesTEST.PacienteWS.RespuestaServiceOfPacientez_SY3AMPv registrarPaciente(DSDServicesTEST.PacienteWS.Paciente paciente) {
            return base.Channel.registrarPaciente(paciente);
        }
        
        public DSDServicesTEST.PacienteWS.RespuestaServiceOfPacientez_SY3AMPv modificarPaciente(DSDServicesTEST.PacienteWS.Paciente paciente) {
            return base.Channel.modificarPaciente(paciente);
        }
        
        public DSDServicesTEST.PacienteWS.Paciente[] listarPacientes() {
            return base.Channel.listarPacientes();
        }
    }
}
