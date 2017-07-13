using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000137 RID: 311
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class GetChartImageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x000F7324 File Offset: 0x000F5724
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetChartImageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x000F7350 File Offset: 0x000F5750
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

		// Token: 0x0400097D RID: 2429
		private object[] results;
	}
}
