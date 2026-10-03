using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using J5weVgMsfAbmils3SEt;
using Quicker.Domain;
using Quicker.Utilities;

namespace d4tWy4Mv65mxaXtw8eI;

internal class gGjMwBMgfVwrmpjVjDh<VfBroQMVRQnqDtgdmTB, avjtJAMFbw7ruDyRMDq> where VfBroQMVRQnqDtgdmTB : struct where avjtJAMFbw7ruDyRMDq : IComparable
{
	private readonly int kUSLOQPX3Et;

	private readonly Func<VfBroQMVRQnqDtgdmTB, avjtJAMFbw7ruDyRMDq> IWMLOjr1Emw;

	private readonly ConcurrentDictionary<VfBroQMVRQnqDtgdmTB, R8qykAMnCbYMyhVuo4M<avjtJAMFbw7ruDyRMDq>> YPJLOn1LqsG = new ConcurrentDictionary<VfBroQMVRQnqDtgdmTB, R8qykAMnCbYMyhVuo4M<avjtJAMFbw7ruDyRMDq>>();

	public gGjMwBMgfVwrmpjVjDh(int int_1, Func<VfBroQMVRQnqDtgdmTB, avjtJAMFbw7ruDyRMDq> func_1)
	{
		Ensure.NotNull(func_1, "valueFunc");
		kUSLOQPX3Et = int_1;
		IWMLOjr1Emw = func_1;
	}

	public avjtJAMFbw7ruDyRMDq fH3LOB69sE2(VfBroQMVRQnqDtgdmTB G5dTluMNXUyD2IdfGOI)
	{
		if (YPJLOn1LqsG.TryGetValue(G5dTluMNXUyD2IdfGOI, out var value) && value.LpcLO4bynX0() > AppState.TickCount)
		{
			return value.Value;
		}
		avjtJAMFbw7ruDyRMDq val = IWMLOjr1Emw(G5dTluMNXUyD2IdfGOI);
		if (EqualityComparer<avjtJAMFbw7ruDyRMDq>.Default.Equals(val, default(avjtJAMFbw7ruDyRMDq)))
		{
			return default(avjtJAMFbw7ruDyRMDq);
		}
		ConcurrentDictionary<VfBroQMVRQnqDtgdmTB, R8qykAMnCbYMyhVuo4M<avjtJAMFbw7ruDyRMDq>> yPJLOn1LqsG = YPJLOn1LqsG;
		R8qykAMnCbYMyhVuo4M<avjtJAMFbw7ruDyRMDq> r8qykAMnCbYMyhVuo4M = new R8qykAMnCbYMyhVuo4M<avjtJAMFbw7ruDyRMDq>();
		r8qykAMnCbYMyhVuo4M.CsxLO5obrlX(AppState.TickCount + kUSLOQPX3Et);
		r8qykAMnCbYMyhVuo4M.Value = val;
		yPJLOn1LqsG[G5dTluMNXUyD2IdfGOI] = r8qykAMnCbYMyhVuo4M;
		return val;
	}
}
