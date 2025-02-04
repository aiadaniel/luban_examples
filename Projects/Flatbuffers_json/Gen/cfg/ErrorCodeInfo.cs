// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ErrorCodeInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static ErrorCodeInfo GetRootAsErrorCodeInfo(ByteBuffer _bb) { return GetRootAsErrorCodeInfo(_bb, new ErrorCodeInfo()); }
  public static ErrorCodeInfo GetRootAsErrorCodeInfo(ByteBuffer _bb, ErrorCodeInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ErrorCodeInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public cfg.ErrorEErrorCode Code { get { int o = __p.__offset(4); return o != 0 ? (cfg.ErrorEErrorCode)__p.bb.GetInt(o + __p.bb_pos) : cfg.ErrorEErrorCode.ErrorEErrorCode_OK; } }
  public string Key { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKeyBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetKeyBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetKeyArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<cfg.ErrorCodeInfo> CreateErrorCodeInfo(FlatBufferBuilder builder,
      cfg.ErrorEErrorCode code = cfg.ErrorEErrorCode.ErrorEErrorCode_OK,
      StringOffset keyOffset = default(StringOffset)) {
    builder.StartTable(2);
    ErrorCodeInfo.AddKey(builder, keyOffset);
    ErrorCodeInfo.AddCode(builder, code);
    return ErrorCodeInfo.EndErrorCodeInfo(builder);
  }

  public static void StartErrorCodeInfo(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddCode(FlatBufferBuilder builder, cfg.ErrorEErrorCode code) { builder.AddInt(0, (int)code, 0); }
  public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset) { builder.AddOffset(1, keyOffset.Value, 0); }
  public static Offset<cfg.ErrorCodeInfo> EndErrorCodeInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.ErrorCodeInfo>(o);
  }
};


}
