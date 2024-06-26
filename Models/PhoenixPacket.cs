// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PhoenixPacket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PhoenixPacket.proto</summary>
public static partial class PhoenixPacketReflection {

  #region Descriptor
  /// <summary>File descriptor for PhoenixPacket.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PhoenixPacketReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNQaG9lbml4UGFja2V0LnByb3RvIvwBCg1QaG9lbml4UGFja2V0EhEKCUxh",
          "dHRpdHVkZRgBIAIoAhIRCglMb25naXR1ZGUYAiACKAISFQoNQWNjZWxlcmF0",
          "aW9uWBgDIAIoAhIVCg1BY2NlbGVyYXRpb25ZGAQgAigCEhUKDUFjY2VsZXJh",
          "dGlvbloYBSACKAISDQoFR3lyb1gYBiACKAISDQoFR3lyb1kYByACKAISDQoF",
          "R3lyb1oYCCACKAISEAoIQWx0aXR1ZGUYCSACKAISEwoLVGVtcGVyYXR1cmUY",
          "CiACKAISFgoORHJvZ3VlRGVwbG95ZWQYCyACKAgSFAoMTWFpbkRlcGxveWVk",
          "GAwgAigI"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PhoenixPacket), global::PhoenixPacket.Parser, new[]{ "Lattitude", "Longitude", "AccelerationX", "AccelerationY", "AccelerationZ", "GyroX", "GyroY", "GyroZ", "Altitude", "Temperature", "DrogueDeployed", "MainDeployed" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class PhoenixPacket : pb::IMessage<PhoenixPacket>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PhoenixPacket> _parser = new pb::MessageParser<PhoenixPacket>(() => new PhoenixPacket());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PhoenixPacket> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PhoenixPacketReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PhoenixPacket() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PhoenixPacket(PhoenixPacket other) : this() {
    _hasBits0 = other._hasBits0;
    lattitude_ = other.lattitude_;
    longitude_ = other.longitude_;
    accelerationX_ = other.accelerationX_;
    accelerationY_ = other.accelerationY_;
    accelerationZ_ = other.accelerationZ_;
    gyroX_ = other.gyroX_;
    gyroY_ = other.gyroY_;
    gyroZ_ = other.gyroZ_;
    altitude_ = other.altitude_;
    temperature_ = other.temperature_;
    drogueDeployed_ = other.drogueDeployed_;
    mainDeployed_ = other.mainDeployed_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PhoenixPacket Clone() {
    return new PhoenixPacket(this);
  }

  /// <summary>Field number for the "Lattitude" field.</summary>
  public const int LattitudeFieldNumber = 1;
  private readonly static float LattitudeDefaultValue = 0F;

  private float lattitude_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Lattitude {
    get { if ((_hasBits0 & 1) != 0) { return lattitude_; } else { return LattitudeDefaultValue; } }
    set {
      _hasBits0 |= 1;
      lattitude_ = value;
    }
  }
  /// <summary>Gets whether the "Lattitude" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasLattitude {
    get { return (_hasBits0 & 1) != 0; }
  }
  /// <summary>Clears the value of the "Lattitude" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearLattitude() {
    _hasBits0 &= ~1;
  }

  /// <summary>Field number for the "Longitude" field.</summary>
  public const int LongitudeFieldNumber = 2;
  private readonly static float LongitudeDefaultValue = 0F;

  private float longitude_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Longitude {
    get { if ((_hasBits0 & 2) != 0) { return longitude_; } else { return LongitudeDefaultValue; } }
    set {
      _hasBits0 |= 2;
      longitude_ = value;
    }
  }
  /// <summary>Gets whether the "Longitude" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasLongitude {
    get { return (_hasBits0 & 2) != 0; }
  }
  /// <summary>Clears the value of the "Longitude" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearLongitude() {
    _hasBits0 &= ~2;
  }

  /// <summary>Field number for the "AccelerationX" field.</summary>
  public const int AccelerationXFieldNumber = 3;
  private readonly static float AccelerationXDefaultValue = 0F;

  private float accelerationX_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float AccelerationX {
    get { if ((_hasBits0 & 4) != 0) { return accelerationX_; } else { return AccelerationXDefaultValue; } }
    set {
      _hasBits0 |= 4;
      accelerationX_ = value;
    }
  }
  /// <summary>Gets whether the "AccelerationX" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasAccelerationX {
    get { return (_hasBits0 & 4) != 0; }
  }
  /// <summary>Clears the value of the "AccelerationX" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearAccelerationX() {
    _hasBits0 &= ~4;
  }

  /// <summary>Field number for the "AccelerationY" field.</summary>
  public const int AccelerationYFieldNumber = 4;
  private readonly static float AccelerationYDefaultValue = 0F;

  private float accelerationY_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float AccelerationY {
    get { if ((_hasBits0 & 8) != 0) { return accelerationY_; } else { return AccelerationYDefaultValue; } }
    set {
      _hasBits0 |= 8;
      accelerationY_ = value;
    }
  }
  /// <summary>Gets whether the "AccelerationY" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasAccelerationY {
    get { return (_hasBits0 & 8) != 0; }
  }
  /// <summary>Clears the value of the "AccelerationY" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearAccelerationY() {
    _hasBits0 &= ~8;
  }

  /// <summary>Field number for the "AccelerationZ" field.</summary>
  public const int AccelerationZFieldNumber = 5;
  private readonly static float AccelerationZDefaultValue = 0F;

  private float accelerationZ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float AccelerationZ {
    get { if ((_hasBits0 & 16) != 0) { return accelerationZ_; } else { return AccelerationZDefaultValue; } }
    set {
      _hasBits0 |= 16;
      accelerationZ_ = value;
    }
  }
  /// <summary>Gets whether the "AccelerationZ" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasAccelerationZ {
    get { return (_hasBits0 & 16) != 0; }
  }
  /// <summary>Clears the value of the "AccelerationZ" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearAccelerationZ() {
    _hasBits0 &= ~16;
  }

  /// <summary>Field number for the "GyroX" field.</summary>
  public const int GyroXFieldNumber = 6;
  private readonly static float GyroXDefaultValue = 0F;

  private float gyroX_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float GyroX {
    get { if ((_hasBits0 & 32) != 0) { return gyroX_; } else { return GyroXDefaultValue; } }
    set {
      _hasBits0 |= 32;
      gyroX_ = value;
    }
  }
  /// <summary>Gets whether the "GyroX" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasGyroX {
    get { return (_hasBits0 & 32) != 0; }
  }
  /// <summary>Clears the value of the "GyroX" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearGyroX() {
    _hasBits0 &= ~32;
  }

  /// <summary>Field number for the "GyroY" field.</summary>
  public const int GyroYFieldNumber = 7;
  private readonly static float GyroYDefaultValue = 0F;

  private float gyroY_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float GyroY {
    get { if ((_hasBits0 & 64) != 0) { return gyroY_; } else { return GyroYDefaultValue; } }
    set {
      _hasBits0 |= 64;
      gyroY_ = value;
    }
  }
  /// <summary>Gets whether the "GyroY" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasGyroY {
    get { return (_hasBits0 & 64) != 0; }
  }
  /// <summary>Clears the value of the "GyroY" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearGyroY() {
    _hasBits0 &= ~64;
  }

  /// <summary>Field number for the "GyroZ" field.</summary>
  public const int GyroZFieldNumber = 8;
  private readonly static float GyroZDefaultValue = 0F;

  private float gyroZ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float GyroZ {
    get { if ((_hasBits0 & 128) != 0) { return gyroZ_; } else { return GyroZDefaultValue; } }
    set {
      _hasBits0 |= 128;
      gyroZ_ = value;
    }
  }
  /// <summary>Gets whether the "GyroZ" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasGyroZ {
    get { return (_hasBits0 & 128) != 0; }
  }
  /// <summary>Clears the value of the "GyroZ" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearGyroZ() {
    _hasBits0 &= ~128;
  }

  /// <summary>Field number for the "Altitude" field.</summary>
  public const int AltitudeFieldNumber = 9;
  private readonly static float AltitudeDefaultValue = 0F;

  private float altitude_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Altitude {
    get { if ((_hasBits0 & 256) != 0) { return altitude_; } else { return AltitudeDefaultValue; } }
    set {
      _hasBits0 |= 256;
      altitude_ = value;
    }
  }
  /// <summary>Gets whether the "Altitude" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasAltitude {
    get { return (_hasBits0 & 256) != 0; }
  }
  /// <summary>Clears the value of the "Altitude" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearAltitude() {
    _hasBits0 &= ~256;
  }

  /// <summary>Field number for the "Temperature" field.</summary>
  public const int TemperatureFieldNumber = 10;
  private readonly static float TemperatureDefaultValue = 0F;

  private float temperature_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Temperature {
    get { if ((_hasBits0 & 512) != 0) { return temperature_; } else { return TemperatureDefaultValue; } }
    set {
      _hasBits0 |= 512;
      temperature_ = value;
    }
  }
  /// <summary>Gets whether the "Temperature" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasTemperature {
    get { return (_hasBits0 & 512) != 0; }
  }
  /// <summary>Clears the value of the "Temperature" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearTemperature() {
    _hasBits0 &= ~512;
  }

  /// <summary>Field number for the "DrogueDeployed" field.</summary>
  public const int DrogueDeployedFieldNumber = 11;
  private readonly static bool DrogueDeployedDefaultValue = false;

  private bool drogueDeployed_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool DrogueDeployed {
    get { if ((_hasBits0 & 1024) != 0) { return drogueDeployed_; } else { return DrogueDeployedDefaultValue; } }
    set {
      _hasBits0 |= 1024;
      drogueDeployed_ = value;
    }
  }
  /// <summary>Gets whether the "DrogueDeployed" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasDrogueDeployed {
    get { return (_hasBits0 & 1024) != 0; }
  }
  /// <summary>Clears the value of the "DrogueDeployed" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearDrogueDeployed() {
    _hasBits0 &= ~1024;
  }

  /// <summary>Field number for the "MainDeployed" field.</summary>
  public const int MainDeployedFieldNumber = 12;
  private readonly static bool MainDeployedDefaultValue = false;

  private bool mainDeployed_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool MainDeployed {
    get { if ((_hasBits0 & 2048) != 0) { return mainDeployed_; } else { return MainDeployedDefaultValue; } }
    set {
      _hasBits0 |= 2048;
      mainDeployed_ = value;
    }
  }
  /// <summary>Gets whether the "MainDeployed" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasMainDeployed {
    get { return (_hasBits0 & 2048) != 0; }
  }
  /// <summary>Clears the value of the "MainDeployed" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearMainDeployed() {
    _hasBits0 &= ~2048;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PhoenixPacket);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PhoenixPacket other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Lattitude, other.Lattitude)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Longitude, other.Longitude)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccelerationX, other.AccelerationX)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccelerationY, other.AccelerationY)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccelerationZ, other.AccelerationZ)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GyroX, other.GyroX)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GyroY, other.GyroY)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GyroZ, other.GyroZ)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Altitude, other.Altitude)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Temperature, other.Temperature)) return false;
    if (DrogueDeployed != other.DrogueDeployed) return false;
    if (MainDeployed != other.MainDeployed) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (HasLattitude) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Lattitude);
    if (HasLongitude) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Longitude);
    if (HasAccelerationX) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccelerationX);
    if (HasAccelerationY) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccelerationY);
    if (HasAccelerationZ) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccelerationZ);
    if (HasGyroX) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GyroX);
    if (HasGyroY) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GyroY);
    if (HasGyroZ) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GyroZ);
    if (HasAltitude) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Altitude);
    if (HasTemperature) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Temperature);
    if (HasDrogueDeployed) hash ^= DrogueDeployed.GetHashCode();
    if (HasMainDeployed) hash ^= MainDeployed.GetHashCode();
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
    if (HasLattitude) {
      output.WriteRawTag(13);
      output.WriteFloat(Lattitude);
    }
    if (HasLongitude) {
      output.WriteRawTag(21);
      output.WriteFloat(Longitude);
    }
    if (HasAccelerationX) {
      output.WriteRawTag(29);
      output.WriteFloat(AccelerationX);
    }
    if (HasAccelerationY) {
      output.WriteRawTag(37);
      output.WriteFloat(AccelerationY);
    }
    if (HasAccelerationZ) {
      output.WriteRawTag(45);
      output.WriteFloat(AccelerationZ);
    }
    if (HasGyroX) {
      output.WriteRawTag(53);
      output.WriteFloat(GyroX);
    }
    if (HasGyroY) {
      output.WriteRawTag(61);
      output.WriteFloat(GyroY);
    }
    if (HasGyroZ) {
      output.WriteRawTag(69);
      output.WriteFloat(GyroZ);
    }
    if (HasAltitude) {
      output.WriteRawTag(77);
      output.WriteFloat(Altitude);
    }
    if (HasTemperature) {
      output.WriteRawTag(85);
      output.WriteFloat(Temperature);
    }
    if (HasDrogueDeployed) {
      output.WriteRawTag(88);
      output.WriteBool(DrogueDeployed);
    }
    if (HasMainDeployed) {
      output.WriteRawTag(96);
      output.WriteBool(MainDeployed);
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
    if (HasLattitude) {
      output.WriteRawTag(13);
      output.WriteFloat(Lattitude);
    }
    if (HasLongitude) {
      output.WriteRawTag(21);
      output.WriteFloat(Longitude);
    }
    if (HasAccelerationX) {
      output.WriteRawTag(29);
      output.WriteFloat(AccelerationX);
    }
    if (HasAccelerationY) {
      output.WriteRawTag(37);
      output.WriteFloat(AccelerationY);
    }
    if (HasAccelerationZ) {
      output.WriteRawTag(45);
      output.WriteFloat(AccelerationZ);
    }
    if (HasGyroX) {
      output.WriteRawTag(53);
      output.WriteFloat(GyroX);
    }
    if (HasGyroY) {
      output.WriteRawTag(61);
      output.WriteFloat(GyroY);
    }
    if (HasGyroZ) {
      output.WriteRawTag(69);
      output.WriteFloat(GyroZ);
    }
    if (HasAltitude) {
      output.WriteRawTag(77);
      output.WriteFloat(Altitude);
    }
    if (HasTemperature) {
      output.WriteRawTag(85);
      output.WriteFloat(Temperature);
    }
    if (HasDrogueDeployed) {
      output.WriteRawTag(88);
      output.WriteBool(DrogueDeployed);
    }
    if (HasMainDeployed) {
      output.WriteRawTag(96);
      output.WriteBool(MainDeployed);
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
    if (HasLattitude) {
      size += 1 + 4;
    }
    if (HasLongitude) {
      size += 1 + 4;
    }
    if (HasAccelerationX) {
      size += 1 + 4;
    }
    if (HasAccelerationY) {
      size += 1 + 4;
    }
    if (HasAccelerationZ) {
      size += 1 + 4;
    }
    if (HasGyroX) {
      size += 1 + 4;
    }
    if (HasGyroY) {
      size += 1 + 4;
    }
    if (HasGyroZ) {
      size += 1 + 4;
    }
    if (HasAltitude) {
      size += 1 + 4;
    }
    if (HasTemperature) {
      size += 1 + 4;
    }
    if (HasDrogueDeployed) {
      size += 1 + 1;
    }
    if (HasMainDeployed) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PhoenixPacket other) {
    if (other == null) {
      return;
    }
    if (other.HasLattitude) {
      Lattitude = other.Lattitude;
    }
    if (other.HasLongitude) {
      Longitude = other.Longitude;
    }
    if (other.HasAccelerationX) {
      AccelerationX = other.AccelerationX;
    }
    if (other.HasAccelerationY) {
      AccelerationY = other.AccelerationY;
    }
    if (other.HasAccelerationZ) {
      AccelerationZ = other.AccelerationZ;
    }
    if (other.HasGyroX) {
      GyroX = other.GyroX;
    }
    if (other.HasGyroY) {
      GyroY = other.GyroY;
    }
    if (other.HasGyroZ) {
      GyroZ = other.GyroZ;
    }
    if (other.HasAltitude) {
      Altitude = other.Altitude;
    }
    if (other.HasTemperature) {
      Temperature = other.Temperature;
    }
    if (other.HasDrogueDeployed) {
      DrogueDeployed = other.DrogueDeployed;
    }
    if (other.HasMainDeployed) {
      MainDeployed = other.MainDeployed;
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
        case 13: {
          Lattitude = input.ReadFloat();
          break;
        }
        case 21: {
          Longitude = input.ReadFloat();
          break;
        }
        case 29: {
          AccelerationX = input.ReadFloat();
          break;
        }
        case 37: {
          AccelerationY = input.ReadFloat();
          break;
        }
        case 45: {
          AccelerationZ = input.ReadFloat();
          break;
        }
        case 53: {
          GyroX = input.ReadFloat();
          break;
        }
        case 61: {
          GyroY = input.ReadFloat();
          break;
        }
        case 69: {
          GyroZ = input.ReadFloat();
          break;
        }
        case 77: {
          Altitude = input.ReadFloat();
          break;
        }
        case 85: {
          Temperature = input.ReadFloat();
          break;
        }
        case 88: {
          DrogueDeployed = input.ReadBool();
          break;
        }
        case 96: {
          MainDeployed = input.ReadBool();
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
        case 13: {
          Lattitude = input.ReadFloat();
          break;
        }
        case 21: {
          Longitude = input.ReadFloat();
          break;
        }
        case 29: {
          AccelerationX = input.ReadFloat();
          break;
        }
        case 37: {
          AccelerationY = input.ReadFloat();
          break;
        }
        case 45: {
          AccelerationZ = input.ReadFloat();
          break;
        }
        case 53: {
          GyroX = input.ReadFloat();
          break;
        }
        case 61: {
          GyroY = input.ReadFloat();
          break;
        }
        case 69: {
          GyroZ = input.ReadFloat();
          break;
        }
        case 77: {
          Altitude = input.ReadFloat();
          break;
        }
        case 85: {
          Temperature = input.ReadFloat();
          break;
        }
        case 88: {
          DrogueDeployed = input.ReadBool();
          break;
        }
        case 96: {
          MainDeployed = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code