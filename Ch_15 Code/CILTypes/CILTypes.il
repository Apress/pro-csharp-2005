.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 1:0:5000:0
}

// Our assembly.
.assembly CILTypes 
{ 
  .ver 1:0:0:0
}
// The module of our single file assembly. 
.module CILTypes.dll

.namespace MyNamespace
{
  // An interface definition. 
  .class public interface IMyInterface {}

  // A class definition.
  .class public MyBaseClass{}    

  // DerivedTestClass now implements IMyInterface.
  .class public MyDerivedClass
    extends MyNamespace.MyBaseClass
    implements MyNamespace.IMyInterface {}    

  // Extending interfaces in terms of CIL.
  .class public interface IMyInterface {}
  .class public interface IMyOtherInterface
     implements MyNamespace. IMyInterface {}

  // A structure definition is always sealed.
  .class public sealed MyStruct 
    extends [mscorlib]System.ValueType{}

  // An enum.
  .class public sealed MyEnum 
    extends [mscorlib]System.Enum
    {
     .field public static literal valuetype 
          MyNamespace.MyEnum NameOne = int32(0)
     .field public static literal valuetype 
          MyNamespace.MyEnum NameTwo = int32(1)
     .field public static literal valuetype 
          MyNamespace.MyEnum NameThree = int32(2)
    }

}
