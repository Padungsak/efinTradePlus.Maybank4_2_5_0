using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;

namespace i2TradePlus
{
	// Token: 0x02000065 RID: 101
	internal class ExceptionManager
	{
		// Token: 0x06000491 RID: 1169 RVA: 0x0005F080 File Offset: 0x0005D480
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Show(ErrorItem error)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ExceptionManager.AddItem(error.Time, error.ModuleName, error.Function, error.Information, error.Description);
			}
			catch (Exception ex)
			{
				ExceptionManager.WriteEventLog("ExceptionManager-Show", ex.ToString());
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0005F0F8 File Offset: 0x0005D4F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Close()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (ExceptionManager.Items != null)
			{
				ExceptionManager.Items.Clear();
				ExceptionManager.Items = null;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0005F138 File Offset: 0x0005D538
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AddItem(DateTime time, string moduleName, string functionName, string information, string description)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				ExceptionManager.Error = new ErrorItem(DateTime.Now, moduleName, functionName, information, description);
				ExceptionManager.Items.Add(ExceptionManager.Error);
				if (Settings.Default.IsWriteErrorLog)
				{
					ExceptionManager.WriteEventLog(moduleName + "-" + functionName, information + "-" + description);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0005F1D0 File Offset: 0x0005D5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WriteEventLog(string source, string description)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			EventLog.WriteEntry("i2Trade", source + " : " + description, EventLogEntryType.Error);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0005F1FC File Offset: 0x0005D5FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Clear()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (ExceptionManager.Items != null)
			{
				ExceptionManager.Items.Clear();
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0005F234 File Offset: 0x0005D634
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExceptionManager() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor();
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0005F250 File Offset: 0x0005D650
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExceptionManager()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			ExceptionManager.Items = new List<ErrorItem>();
		}

		// Token: 0x040002E5 RID: 741
		private static ErrorItem Error;

		// Token: 0x040002E6 RID: 742
		public static List<ErrorItem> Items;
	}
}
