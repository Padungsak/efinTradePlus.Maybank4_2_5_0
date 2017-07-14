using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001C0 RID: 448
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopBBOCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001202 RID: 4610 RVA: 0x000F8DB4 File Offset: 0x000F71B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopBBOCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000F8DE0 File Offset: 0x000F71E0
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

		// Token: 0x040009C1 RID: 2497
		private object[] results;
	}
}
