// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TestDemoE1 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static TestDemoE1 GetRootAsTestDemoE1(ByteBuffer _bb) { return GetRootAsTestDemoE1(_bb, new TestDemoE1()); }
  public static TestDemoE1 GetRootAsTestDemoE1(ByteBuffer _bb, TestDemoE1 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestDemoE1 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X1 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X3 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X4 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<cfg.TestDemoE1> CreateTestDemoE1(FlatBufferBuilder builder,
      int x1 = 0,
      int x3 = 0,
      int x4 = 0) {
    builder.StartTable(3);
    TestDemoE1.AddX4(builder, x4);
    TestDemoE1.AddX3(builder, x3);
    TestDemoE1.AddX1(builder, x1);
    return TestDemoE1.EndTestDemoE1(builder);
  }

  public static void StartTestDemoE1(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddX1(FlatBufferBuilder builder, int x1) { builder.AddInt(0, x1, 0); }
  public static void AddX3(FlatBufferBuilder builder, int x3) { builder.AddInt(1, x3, 0); }
  public static void AddX4(FlatBufferBuilder builder, int x4) { builder.AddInt(2, x4, 0); }
  public static Offset<cfg.TestDemoE1> EndTestDemoE1(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.TestDemoE1>(o);
  }
};


}
