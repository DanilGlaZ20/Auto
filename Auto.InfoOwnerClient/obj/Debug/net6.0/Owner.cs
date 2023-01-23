// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: owner.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Auto.InfoOwnerServer {

  /// <summary>Holder for reflection information generated from owner.proto</summary>
  public static partial class OwnerReflection {

    #region Descriptor
    /// <summary>File descriptor for owner.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OwnerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgtvd25lci5wcm90bxIFb3duZXIiPwoQT3duZXJJbmZvUmVxdWVzdBIWCg5y",
            "ZWdpc3Rlck51bWJlchgBIAEoCRITCgtwaG9uZU51bWJlchgCIAEoCSJRCg5P",
            "d25lckluZm9SZXBseRIQCghmdWxsbmFtZRgBIAEoCRIVCg1kcml2ZXJMaWNl",
            "bmNlGAIgASgJEhYKDnJlZ0NvZGVWZWhpY2xlGAMgASgJMksKCU93bmVySW5m",
            "bxI+CgxHZXRPd25lckluZm8SFy5vd25lci5Pd25lckluZm9SZXF1ZXN0GhUu",
            "b3duZXIuT3duZXJJbmZvUmVwbHlCF6oCFEF1dG8uSW5mb093bmVyU2VydmVy",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Auto.InfoOwnerServer.OwnerInfoRequest), global::Auto.InfoOwnerServer.OwnerInfoRequest.Parser, new[]{ "RegisterNumber", "PhoneNumber" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Auto.InfoOwnerServer.OwnerInfoReply), global::Auto.InfoOwnerServer.OwnerInfoReply.Parser, new[]{ "Fullname", "DriverLicence", "RegCodeVehicle" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class OwnerInfoRequest : pb::IMessage<OwnerInfoRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OwnerInfoRequest> _parser = new pb::MessageParser<OwnerInfoRequest>(() => new OwnerInfoRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OwnerInfoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Auto.InfoOwnerServer.OwnerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OwnerInfoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OwnerInfoRequest(OwnerInfoRequest other) : this() {
      registerNumber_ = other.registerNumber_;
      phoneNumber_ = other.phoneNumber_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OwnerInfoRequest Clone() {
      return new OwnerInfoRequest(this);
    }

    /// <summary>Field number for the "registerNumber" field.</summary>
    public const int RegisterNumberFieldNumber = 1;
    private string registerNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RegisterNumber {
      get { return registerNumber_; }
      set {
        registerNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "phoneNumber" field.</summary>
    public const int PhoneNumberFieldNumber = 2;
    private string phoneNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PhoneNumber {
      get { return phoneNumber_; }
      set {
        phoneNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OwnerInfoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OwnerInfoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RegisterNumber != other.RegisterNumber) return false;
      if (PhoneNumber != other.PhoneNumber) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RegisterNumber.Length != 0) hash ^= RegisterNumber.GetHashCode();
      if (PhoneNumber.Length != 0) hash ^= PhoneNumber.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (RegisterNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RegisterNumber);
      }
      if (PhoneNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PhoneNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (RegisterNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RegisterNumber);
      }
      if (PhoneNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PhoneNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (RegisterNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegisterNumber);
      }
      if (PhoneNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PhoneNumber);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OwnerInfoRequest other) {
      if (other == null) {
        return;
      }
      if (other.RegisterNumber.Length != 0) {
        RegisterNumber = other.RegisterNumber;
      }
      if (other.PhoneNumber.Length != 0) {
        PhoneNumber = other.PhoneNumber;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            RegisterNumber = input.ReadString();
            break;
          }
          case 18: {
            PhoneNumber = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            RegisterNumber = input.ReadString();
            break;
          }
          case 18: {
            PhoneNumber = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The response message containing the greetings.
  /// </summary>
  public sealed partial class OwnerInfoReply : pb::IMessage<OwnerInfoReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OwnerInfoReply> _parser = new pb::MessageParser<OwnerInfoReply>(() => new OwnerInfoReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OwnerInfoReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Auto.InfoOwnerServer.OwnerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OwnerInfoReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OwnerInfoReply(OwnerInfoReply other) : this() {
      fullname_ = other.fullname_;
      driverLicence_ = other.driverLicence_;
      regCodeVehicle_ = other.regCodeVehicle_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OwnerInfoReply Clone() {
      return new OwnerInfoReply(this);
    }

    /// <summary>Field number for the "fullname" field.</summary>
    public const int FullnameFieldNumber = 1;
    private string fullname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Fullname {
      get { return fullname_; }
      set {
        fullname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "driverLicence" field.</summary>
    public const int DriverLicenceFieldNumber = 2;
    private string driverLicence_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DriverLicence {
      get { return driverLicence_; }
      set {
        driverLicence_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "regCodeVehicle" field.</summary>
    public const int RegCodeVehicleFieldNumber = 3;
    private string regCodeVehicle_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RegCodeVehicle {
      get { return regCodeVehicle_; }
      set {
        regCodeVehicle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OwnerInfoReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OwnerInfoReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Fullname != other.Fullname) return false;
      if (DriverLicence != other.DriverLicence) return false;
      if (RegCodeVehicle != other.RegCodeVehicle) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Fullname.Length != 0) hash ^= Fullname.GetHashCode();
      if (DriverLicence.Length != 0) hash ^= DriverLicence.GetHashCode();
      if (RegCodeVehicle.Length != 0) hash ^= RegCodeVehicle.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Fullname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Fullname);
      }
      if (DriverLicence.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DriverLicence);
      }
      if (RegCodeVehicle.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RegCodeVehicle);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Fullname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Fullname);
      }
      if (DriverLicence.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DriverLicence);
      }
      if (RegCodeVehicle.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RegCodeVehicle);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Fullname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Fullname);
      }
      if (DriverLicence.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DriverLicence);
      }
      if (RegCodeVehicle.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegCodeVehicle);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OwnerInfoReply other) {
      if (other == null) {
        return;
      }
      if (other.Fullname.Length != 0) {
        Fullname = other.Fullname;
      }
      if (other.DriverLicence.Length != 0) {
        DriverLicence = other.DriverLicence;
      }
      if (other.RegCodeVehicle.Length != 0) {
        RegCodeVehicle = other.RegCodeVehicle;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Fullname = input.ReadString();
            break;
          }
          case 18: {
            DriverLicence = input.ReadString();
            break;
          }
          case 26: {
            RegCodeVehicle = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Fullname = input.ReadString();
            break;
          }
          case 18: {
            DriverLicence = input.ReadString();
            break;
          }
          case 26: {
            RegCodeVehicle = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code