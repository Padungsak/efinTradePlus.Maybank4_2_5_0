using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000169 RID: 361
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetDataForSmartClickCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010FC RID: 4348 RVA: 0x000F7CE8 File Offset: 0x000F60E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetDataForSmartClickCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x000F7D14 File Offset: 0x000F6114
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

		// Token: 0x04000996 RID: 2454
		private object[] results;
	}
}
