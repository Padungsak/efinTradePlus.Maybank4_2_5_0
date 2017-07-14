using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000200 RID: 512
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class GetTunnelConfigCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012C2 RID: 4802 RVA: 0x000F9A34 File Offset: 0x000F7E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetTunnelConfigCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x000F9A60 File Offset: 0x000F7E60
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

		// Token: 0x040009E1 RID: 2529
		private object[] results;
	}
}
