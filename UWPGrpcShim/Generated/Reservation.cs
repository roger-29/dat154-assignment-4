// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: reservation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HotelService {

  /// <summary>Holder for reflection information generated from reservation.proto</summary>
  public static partial class ReservationReflection {

    #region Descriptor
    /// <summary>File descriptor for reservation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFyZXNlcnZhdGlvbi5wcm90bxINaG90ZWxfc2VydmljZRofZ29vZ2xlL3By",
            "b3RvYnVmL3RpbWVzdGFtcC5wcm90byJRCgRSb29tEgoKAmlkGAEgASgJEg4K",
            "Bm51bWJlchgCIAEoBRIMCgRiZWRzGAMgASgFEgwKBHNpemUYBCABKAUSEQoJ",
            "YXZhaWxhYmxlGAUgASgIInoKC1Jlc2VydmF0aW9uEgoKAmlkGAEgASgJEiEK",
            "BHJvb20YAiABKAsyEy5ob3RlbF9zZXJ2aWNlLlJvb20SKAoEZGF0ZRgFIAEo",
            "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASEgoKY3VzdG9tZXJJZBgE",
            "IAEoCTJPCgZCb29rZXISRQoLUmVxdWVzdFJvb20SGi5ob3RlbF9zZXJ2aWNl",
            "LlJlc2VydmF0aW9uGhouaG90ZWxfc2VydmljZS5SZXNlcnZhdGlvbkIPqgIM",
            "SG90ZWxTZXJ2aWNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HotelService.Room), global::HotelService.Room.Parser, new[]{ "Id", "Number", "Beds", "Size", "Available" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotelService.Reservation), global::HotelService.Reservation.Parser, new[]{ "Id", "Room", "Date", "CustomerId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Room : pb::IMessage<Room> {
    private static readonly pb::MessageParser<Room> _parser = new pb::MessageParser<Room>(() => new Room());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Room> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotelService.ReservationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room(Room other) : this() {
      id_ = other.id_;
      number_ = other.number_;
      beds_ = other.beds_;
      size_ = other.size_;
      available_ = other.available_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Room Clone() {
      return new Room(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "number" field.</summary>
    public const int NumberFieldNumber = 2;
    private int number_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Number {
      get { return number_; }
      set {
        number_ = value;
      }
    }

    /// <summary>Field number for the "beds" field.</summary>
    public const int BedsFieldNumber = 3;
    private int beds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Beds {
      get { return beds_; }
      set {
        beds_ = value;
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 4;
    private int size_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "available" field.</summary>
    public const int AvailableFieldNumber = 5;
    private bool available_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Available {
      get { return available_; }
      set {
        available_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Room);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Room other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Number != other.Number) return false;
      if (Beds != other.Beds) return false;
      if (Size != other.Size) return false;
      if (Available != other.Available) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Number != 0) hash ^= Number.GetHashCode();
      if (Beds != 0) hash ^= Beds.GetHashCode();
      if (Size != 0) hash ^= Size.GetHashCode();
      if (Available != false) hash ^= Available.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Number != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Number);
      }
      if (Beds != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Beds);
      }
      if (Size != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Size);
      }
      if (Available != false) {
        output.WriteRawTag(40);
        output.WriteBool(Available);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Number != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Number);
      }
      if (Beds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Beds);
      }
      if (Size != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
      }
      if (Available != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Room other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Number != 0) {
        Number = other.Number;
      }
      if (other.Beds != 0) {
        Beds = other.Beds;
      }
      if (other.Size != 0) {
        Size = other.Size;
      }
      if (other.Available != false) {
        Available = other.Available;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            Number = input.ReadInt32();
            break;
          }
          case 24: {
            Beds = input.ReadInt32();
            break;
          }
          case 32: {
            Size = input.ReadInt32();
            break;
          }
          case 40: {
            Available = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Reservation : pb::IMessage<Reservation> {
    private static readonly pb::MessageParser<Reservation> _parser = new pb::MessageParser<Reservation>(() => new Reservation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Reservation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotelService.ReservationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Reservation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Reservation(Reservation other) : this() {
      id_ = other.id_;
      room_ = other.room_ != null ? other.room_.Clone() : null;
      date_ = other.date_ != null ? other.date_.Clone() : null;
      customerId_ = other.customerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Reservation Clone() {
      return new Reservation(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 2;
    private global::HotelService.Room room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HotelService.Room Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    /// <summary>Field number for the "customerId" field.</summary>
    public const int CustomerIdFieldNumber = 4;
    private string customerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Reservation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Reservation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(Room, other.Room)) return false;
      if (!object.Equals(Date, other.Date)) return false;
      if (CustomerId != other.CustomerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (room_ != null) hash ^= Room.GetHashCode();
      if (date_ != null) hash ^= Date.GetHashCode();
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (room_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Room);
      }
      if (CustomerId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CustomerId);
      }
      if (date_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Date);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Reservation other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          Room = new global::HotelService.Room();
        }
        Room.MergeFrom(other.Room);
      }
      if (other.date_ != null) {
        if (date_ == null) {
          Date = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Date.MergeFrom(other.Date);
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            if (room_ == null) {
              Room = new global::HotelService.Room();
            }
            input.ReadMessage(Room);
            break;
          }
          case 34: {
            CustomerId = input.ReadString();
            break;
          }
          case 42: {
            if (date_ == null) {
              Date = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Date);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code