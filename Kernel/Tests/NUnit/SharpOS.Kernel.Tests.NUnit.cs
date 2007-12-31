//
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Mircea-Cristian Racasan <darx_kies@gmx.net>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using NUnit.Framework;

[TestFixture]
public class KernelTests {
	[Test]
	public void SharpOS_Kernel_Tests_IL_ConditionChecking_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ConditionChecking.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.ConditionChecking.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_MethodArguments_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.MethodArguments.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.MethodArguments.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_MethodArguments_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.MethodArguments.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.MethodArguments.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_MethodArguments_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.MethodArguments.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.MethodArguments.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ConstantLoading_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ConstantLoading.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.ConstantLoading.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ConstantLoading_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ConstantLoading.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.ConstantLoading.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ConversionOperations_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ConversionOperations.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.ConversionOperations.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_Addition_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.Addition.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.Addition.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_Addition_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.Addition.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.Addition.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP3 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP4 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP5 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP6 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP6 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP6' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP7 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP7 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP7' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP8 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP8 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP8' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP9 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP9 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP9' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHR_CMP10 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHR.CMP10 () == 1, "'SharpOS.Kernel.Tests.IL.SHR.CMP10' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP3 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP4 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP5 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP6 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP6 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP6' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP7 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP7 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP7' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP8 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP8 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP8' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP9 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP9 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP9' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP10 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP10 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP10' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP11 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP11 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP11' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP12 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP12 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP12' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP13 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP13 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP13' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP14 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP14 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP14' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP15 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP15 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP15' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP16 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP16 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP16' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHL_CMP17 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHL.CMP17 () == 1, "'SharpOS.Kernel.Tests.IL.SHL.CMP17' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP3 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP4 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_ADD_CMP5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.ADD.CMP5 () == 1, "'SharpOS.Kernel.Tests.IL.ADD.CMP5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP1 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP2 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP3 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP4 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP4 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP4' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP5 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP5 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP5' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP6 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP6 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP6' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP7 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP7 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP7' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP8 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP8 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP8' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP9 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP9 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP9' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP10 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP10 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP10' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SHRUN_CMP11 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SHRUN.CMP11 () == 1, "'SharpOS.Kernel.Tests.IL.SHRUN.CMP11' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_IL_SUB_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.IL.SUB.CMP0 () == 1, "'SharpOS.Kernel.Tests.IL.SUB.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arguments_CMPArguments1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arguments.CMPArguments1 () == 1, "'SharpOS.Kernel.Tests.CS.Arguments.CMPArguments1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arguments_CMPArguments2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arguments.CMPArguments2 () == 1, "'SharpOS.Kernel.Tests.CS.Arguments.CMPArguments2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPVoidP2ByteP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ByteP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ByteP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPVoidP2ShortP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ShortP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2ShortP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPVoidP2IntP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2IntP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2IntP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPVoidP2LongP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2LongP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPVoidP2LongP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPByteP2VoidP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPByteP2VoidP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPByteP2VoidP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPShortP2VoidP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPShortP2VoidP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPShortP2VoidP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPIntP2VoidP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPIntP2VoidP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPIntP2VoidP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_PointerCast_CMPLongP2VoidP ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.PointerCast.CMPLongP2VoidP () == 1, "'SharpOS.Kernel.Tests.CS.PointerCast.CMPLongP2VoidP' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPLiteralToInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToInt () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPLiteralToInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPIntToLiteral ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPIntToLiteral () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPIntToLiteral' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPConstantComparison ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPConstantComparison () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPConstantComparison' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPValueComparison ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPValueComparison () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPValueComparison' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPSimpleFlags ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPSimpleFlags () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPSimpleFlags' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Enum_CMPEnumReturn ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Enum.CMPEnumReturn () == 1, "'SharpOS.Kernel.Tests.CS.Enum.CMPEnumReturn' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_WhileLoop_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.WhileLoop.CMP0 () == 1, "'SharpOS.Kernel.Tests.CS.WhileLoop.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMP1 () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMP2 () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Misc_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Misc.CMP0 () == 1, "'SharpOS.Kernel.Tests.CS.Misc.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUInt2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2SByte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPInt2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUInt2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPByte2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Int () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPSByte2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2UInt () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPByte2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Short () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPByte2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPSByte2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2Short () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPSByte2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPShort2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUShort2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUShort2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Int () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUShort2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPShort2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2UInt () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPShort2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPUInt2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Short () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPUInt2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerCast_CMPInt2UShort ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2UShort () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerCast.CMPInt2UShort' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_ByteString_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.ByteString.CMP0 () == 1, "'SharpOS.Kernel.Tests.CS.ByteString.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_X86_CMPPushArgument ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.X86.CMPPushArgument () == 1, "'SharpOS.Kernel.Tests.CS.X86.CMPPushArgument' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_X86_CMPReadArgument ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.X86.CMPReadArgument () == 1, "'SharpOS.Kernel.Tests.CS.X86.CMPReadArgument' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_X86_CMPLabelHandling ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.X86.CMPLabelHandling () == 1, "'SharpOS.Kernel.Tests.CS.X86.CMPLabelHandling' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPConstructor ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPConstructor () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPConstructor' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPStructPointer ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPStructPointer2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer2 () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPStructPointer2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPEmptyStruct ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPEmptyStruct () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPEmptyStruct' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPStructParameter ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPStructParameter () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPStructParameter' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPNoChanges ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPNoChanges () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPNoChanges' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPCopy ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPCopy () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPCopy' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPReturn ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPReturn () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPReturn' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPSizeof1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPSizeof1 () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPSizeof1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Struct_CMPSizeof2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Struct.CMPSizeof2 () == 1, "'SharpOS.Kernel.Tests.CS.Struct.CMPSizeof2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Boolean_CMPSimpleAnd ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleAnd () == 1, "'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleAnd' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Boolean_CMPSimpleOr ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleOr () == 1, "'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleOr' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Boolean_CMPSimpleNot ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleNot () == 1, "'SharpOS.Kernel.Tests.CS.Boolean.CMPSimpleNot' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleAdd ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleAdd' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleSubtract ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleSubtract' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleMultiply ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleMultiply' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Arithmetic_CMPSimpleDivide ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide () == 1, "'SharpOS.Kernel.Tests.CS.Arithmetic.CMPSimpleDivide' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPGetLength ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPGetLength () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPGetLength' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPGetChars ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPGetChars () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPGetChars' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPGetChars2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPGetChars2 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPGetChars2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPBumperIndexing1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing1 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPBumperIndexing2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing2 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPBumperIndexing2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPBumperLength ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPBumperLength () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPBumperLength' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPCStringStub1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPCStringStub1 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPCStringStub1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_String_CMPConstIndexing3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.String.CMPConstIndexing3 () == 1, "'SharpOS.Kernel.Tests.CS.String.CMPConstIndexing3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BooleanOrderOfOperations_CMPConstants ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPConstants () == 1, "'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPConstants' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BooleanOrderOfOperations_CMPValues ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValues () == 1, "'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValues' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BooleanOrderOfOperations_CMPValuesAndConstants ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValuesAndConstants () == 1, "'SharpOS.Kernel.Tests.CS.BooleanOrderOfOperations.CMPValuesAndConstants' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Byte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Short () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Int () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2Long ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Long () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2Long' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2SByte () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2UShort ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UShort () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UShort' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UInt () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_MixedIntegerPointerCast_CMPVoidP2ULong ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2ULong () == 1, "'SharpOS.Kernel.Tests.CS.MixedIntegerPointerCast.CMPVoidP2ULong' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_StaticConstructor_CMPStaticConstructor ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.StaticConstructor.CMPStaticConstructor () == 1, "'SharpOS.Kernel.Tests.CS.StaticConstructor.CMPStaticConstructor' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_OrderOfOperations_CMPConstants ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPConstants () == 1, "'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPConstants' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_OrderOfOperations_CMPValues ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValues () == 1, "'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValues' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_OrderOfOperations_CMPValuesAndConstants ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValuesAndConstants () == 1, "'SharpOS.Kernel.Tests.CS.OrderOfOperations.CMPValuesAndConstants' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleAND ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleAND () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleAND' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleOR ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleOR () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleOR' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleXOR ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleXOR () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleXOR' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleShiftLeft ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftLeft () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftLeft' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPUnsignedShiftLeft ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPUnsignedShiftLeft () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPUnsignedShiftLeft' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_BitwiseOperators_CMPSimpleShiftRight ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftRight () == 1, "'SharpOS.Kernel.Tests.CS.BitwiseOperators.CMPSimpleShiftRight' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPUInt2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2Byte () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPByte2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UInt () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPByte2UShort ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UShort () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPByte2UShort' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPUShort2Byte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2Byte () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2Byte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPUShort2UInt ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2UInt () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUShort2UInt' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_UnsignedIntegerCast_CMPUInt2UShort ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2UShort () == 1, "'SharpOS.Kernel.Tests.CS.UnsignedIntegerCast.CMPUInt2UShort' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMP0 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMP0 () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMP0' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMP1 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMP1 () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMP1' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMP2 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMP2 () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMP2' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMP3 ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMP3 () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMP3' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMPMisc2a ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2a () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2a' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMPMisc2b ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2b () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2b' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_Switch_CMPMisc2c ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.Switch.CMPMisc2c () == 1, "'SharpOS.Kernel.Tests.CS.Switch.CMPMisc2c' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPInt2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2SByte () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPSByte2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Int () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPSByte2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Short () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPSByte2Short' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPShort2SByte ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2SByte () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2SByte' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPShort2Int ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2Int () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPShort2Int' failed.");
	}
	[Test]
	public void SharpOS_Kernel_Tests_CS_SignedIntegerCast_CMPInt2Short ()
	{
		Assert.IsTrue (SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2Short () == 1, "'SharpOS.Kernel.Tests.CS.SignedIntegerCast.CMPInt2Short' failed.");
	}
}