// automatically generated by the FlatBuffers compiler, do not modify

namespace FlatBuffersObject
{

using System;
using FlatBuffers;

public sealed class Person : Table {
  public static Person GetRootAsPerson(ByteBuffer _bb) { return GetRootAsPerson(_bb, new Person()); }
  public static Person GetRootAsPerson(ByteBuffer _bb, Person obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public Person __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Age { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool MutateAge(int age) { int o = __offset(4); if (o != 0) { bb.PutInt(o + bb_pos, age); return true; } else { return false; } }
  public string FirstName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetFirstNameBytes() { return __vector_as_arraysegment(6); }
  public string LastName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetLastNameBytes() { return __vector_as_arraysegment(8); }
  public Sex Sex { get { int o = __offset(10); return o != 0 ? (Sex)bb.GetSbyte(o + bb_pos) : Sex.Unknown; } }
  public bool MutateSex(Sex sex) { int o = __offset(10); if (o != 0) { bb.PutSbyte(o + bb_pos, (sbyte)sex); return true; } else { return false; } }

  public static Offset<Person> CreatePerson(FlatBufferBuilder builder,
      int age = 0,
      StringOffset firstNameOffset = default(StringOffset),
      StringOffset lastNameOffset = default(StringOffset),
      Sex sex = Sex.Unknown) {
    builder.StartObject(4);
    Person.AddLastName(builder, lastNameOffset);
    Person.AddFirstName(builder, firstNameOffset);
    Person.AddAge(builder, age);
    Person.AddSex(builder, sex);
    return Person.EndPerson(builder);
  }

  public static void StartPerson(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddAge(FlatBufferBuilder builder, int age) { builder.AddInt(0, age, 0); }
  public static void AddFirstName(FlatBufferBuilder builder, StringOffset firstNameOffset) { builder.AddOffset(1, firstNameOffset.Value, 0); }
  public static void AddLastName(FlatBufferBuilder builder, StringOffset lastNameOffset) { builder.AddOffset(2, lastNameOffset.Value, 0); }
  public static void AddSex(FlatBufferBuilder builder, Sex sex) { builder.AddSbyte(3, (sbyte)sex, 0); }
  public static Offset<Person> EndPerson(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Person>(o);
  }
  public static void FinishPersonBuffer(FlatBufferBuilder builder, Offset<Person> offset) { builder.Finish(offset.Value); }
};


}