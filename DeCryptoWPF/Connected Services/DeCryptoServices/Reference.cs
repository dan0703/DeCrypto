﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeCryptoWPF.DeCryptoServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/Domain.data")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool emailVerifyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nicknameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] profileImageField;
        
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool emailVerify {
            get {
                return this.emailVerifyField;
            }
            set {
                if ((this.emailVerifyField.Equals(value) != true)) {
                    this.emailVerifyField = value;
                    this.RaisePropertyChanged("emailVerify");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nickname {
            get {
                return this.nicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.nicknameField, value) != true)) {
                    this.nicknameField = value;
                    this.RaisePropertyChanged("nickname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] profileImage {
            get {
                return this.profileImageField;
            }
            set {
                if ((object.ReferenceEquals(this.profileImageField, value) != true)) {
                    this.profileImageField = value;
                    this.RaisePropertyChanged("profileImage");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Domain.data")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string accountNicknameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string birthDayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string accountNickname {
            get {
                return this.accountNicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.accountNicknameField, value) != true)) {
                    this.accountNicknameField = value;
                    this.RaisePropertyChanged("accountNickname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string birthDay {
            get {
                return this.birthDayField;
            }
            set {
                if ((object.ReferenceEquals(this.birthDayField, value) != true)) {
                    this.birthDayField = value;
                    this.RaisePropertyChanged("birthDay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idUser {
            get {
                return this.idUserField;
            }
            set {
                if ((this.idUserField.Equals(value) != true)) {
                    this.idUserField = value;
                    this.RaisePropertyChanged("idUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DeCryptoServices.IAccountServices")]
    public interface IAccountServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountServices/RegisterAccount", ReplyAction="http://tempuri.org/IAccountServices/RegisterAccountResponse")]
        bool RegisterAccount(DeCryptoWPF.DeCryptoServices.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountServices/RegisterAccount", ReplyAction="http://tempuri.org/IAccountServices/RegisterAccountResponse")]
        System.Threading.Tasks.Task<bool> RegisterAccountAsync(DeCryptoWPF.DeCryptoServices.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountServices/Login", ReplyAction="http://tempuri.org/IAccountServices/LoginResponse")]
        DeCryptoWPF.DeCryptoServices.Account Login(DeCryptoWPF.DeCryptoServices.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountServices/Login", ReplyAction="http://tempuri.org/IAccountServices/LoginResponse")]
        System.Threading.Tasks.Task<DeCryptoWPF.DeCryptoServices.Account> LoginAsync(DeCryptoWPF.DeCryptoServices.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountServices/SendToken", ReplyAction="http://tempuri.org/IAccountServices/SendTokenResponse")]
        bool SendToken(string email, string title, string message, int code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountServices/SendToken", ReplyAction="http://tempuri.org/IAccountServices/SendTokenResponse")]
        System.Threading.Tasks.Task<bool> SendTokenAsync(string email, string title, string message, int code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServicesChannel : DeCryptoWPF.DeCryptoServices.IAccountServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServicesClient : System.ServiceModel.ClientBase<DeCryptoWPF.DeCryptoServices.IAccountServices>, DeCryptoWPF.DeCryptoServices.IAccountServices {
        
        public AccountServicesClient() {
        }
        
        public AccountServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool RegisterAccount(DeCryptoWPF.DeCryptoServices.Account account) {
            return base.Channel.RegisterAccount(account);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAccountAsync(DeCryptoWPF.DeCryptoServices.Account account) {
            return base.Channel.RegisterAccountAsync(account);
        }
        
        public DeCryptoWPF.DeCryptoServices.Account Login(DeCryptoWPF.DeCryptoServices.Account account) {
            return base.Channel.Login(account);
        }
        
        public System.Threading.Tasks.Task<DeCryptoWPF.DeCryptoServices.Account> LoginAsync(DeCryptoWPF.DeCryptoServices.Account account) {
            return base.Channel.LoginAsync(account);
        }
        
        public bool SendToken(string email, string title, string message, int code) {
            return base.Channel.SendToken(email, title, message, code);
        }
        
        public System.Threading.Tasks.Task<bool> SendTokenAsync(string email, string title, string message, int code) {
            return base.Channel.SendTokenAsync(email, title, message, code);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DeCryptoServices.IPlayerServices")]
    public interface IPlayerServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerServices/RegisterPlayer", ReplyAction="http://tempuri.org/IPlayerServices/RegisterPlayerResponse")]
        bool RegisterPlayer(DeCryptoWPF.DeCryptoServices.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayerServices/RegisterPlayer", ReplyAction="http://tempuri.org/IPlayerServices/RegisterPlayerResponse")]
        System.Threading.Tasks.Task<bool> RegisterPlayerAsync(DeCryptoWPF.DeCryptoServices.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPlayerServicesChannel : DeCryptoWPF.DeCryptoServices.IPlayerServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PlayerServicesClient : System.ServiceModel.ClientBase<DeCryptoWPF.DeCryptoServices.IPlayerServices>, DeCryptoWPF.DeCryptoServices.IPlayerServices {
        
        public PlayerServicesClient() {
        }
        
        public PlayerServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PlayerServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool RegisterPlayer(DeCryptoWPF.DeCryptoServices.User user) {
            return base.Channel.RegisterPlayer(user);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterPlayerAsync(DeCryptoWPF.DeCryptoServices.User user) {
            return base.Channel.RegisterPlayerAsync(user);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DeCryptoServices.IJoinToGame", CallbackContract=typeof(DeCryptoWPF.DeCryptoServices.IJoinToGameCallback))]
    public interface IJoinToGame {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJoinToGame/CreateRoom", ReplyAction="http://tempuri.org/IJoinToGame/CreateRoomResponse")]
        int CreateRoom();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJoinToGame/CreateRoom", ReplyAction="http://tempuri.org/IJoinToGame/CreateRoomResponse")]
        System.Threading.Tasks.Task<int> CreateRoomAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IJoinToGame/JoinToRoom")]
        void JoinToRoom(int code, string nickname);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IJoinToGame/JoinToRoom")]
        System.Threading.Tasks.Task JoinToRoomAsync(int code, string nickname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJoinToGame/LeaveRoom", ReplyAction="http://tempuri.org/IJoinToGame/LeaveRoomResponse")]
        void LeaveRoom(string nickname, int code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJoinToGame/LeaveRoom", ReplyAction="http://tempuri.org/IJoinToGame/LeaveRoomResponse")]
        System.Threading.Tasks.Task LeaveRoomAsync(string nickname, int code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJoinToGameCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJoinToGame/RecivePlayers", ReplyAction="http://tempuri.org/IJoinToGame/RecivePlayersResponse")]
        void RecivePlayers(System.Collections.Generic.Dictionary<string, byte[]> profiles);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJoinToGameChannel : DeCryptoWPF.DeCryptoServices.IJoinToGame, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JoinToGameClient : System.ServiceModel.DuplexClientBase<DeCryptoWPF.DeCryptoServices.IJoinToGame>, DeCryptoWPF.DeCryptoServices.IJoinToGame {
        
        public JoinToGameClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public JoinToGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public JoinToGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public JoinToGameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public JoinToGameClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int CreateRoom() {
            return base.Channel.CreateRoom();
        }
        
        public System.Threading.Tasks.Task<int> CreateRoomAsync() {
            return base.Channel.CreateRoomAsync();
        }
        
        public void JoinToRoom(int code, string nickname) {
            base.Channel.JoinToRoom(code, nickname);
        }
        
        public System.Threading.Tasks.Task JoinToRoomAsync(int code, string nickname) {
            return base.Channel.JoinToRoomAsync(code, nickname);
        }
        
        public void LeaveRoom(string nickname, int code) {
            base.Channel.LeaveRoom(nickname, code);
        }
        
        public System.Threading.Tasks.Task LeaveRoomAsync(string nickname, int code) {
            return base.Channel.LeaveRoomAsync(nickname, code);
        }
    }
}
