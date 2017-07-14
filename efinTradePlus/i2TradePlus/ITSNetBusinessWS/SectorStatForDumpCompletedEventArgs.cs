using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001B0 RID: 432
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SectorStatForDumpCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011D2 RID: 4562 RVA: 0x000F8A94 File Offset: 0x000F6E94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SectorStatForDumpCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000F8AC0 File Offset: 0x000F6EC0
		public string Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (string)this.results[0];
			}
		}

		// Token: 0x040009B9 RID: 2489
		private object[] results;
	}
}
