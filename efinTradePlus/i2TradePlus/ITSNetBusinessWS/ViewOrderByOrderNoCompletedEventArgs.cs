using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001CE RID: 462
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewOrderByOrderNoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x000F9070 File Offset: 0x000F7470
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewOrderByOrderNoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x000F909C File Offset: 0x000F749C
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

		// Token: 0x040009C8 RID: 2504
		private object[] results;
	}
}
