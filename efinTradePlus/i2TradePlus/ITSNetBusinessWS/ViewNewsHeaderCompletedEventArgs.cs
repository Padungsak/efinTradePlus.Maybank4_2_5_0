using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001D0 RID: 464
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewNewsHeaderCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001232 RID: 4658 RVA: 0x000F90D4 File Offset: 0x000F74D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewNewsHeaderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x000F9100 File Offset: 0x000F7500
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

		// Token: 0x040009C9 RID: 2505
		private object[] results;
	}
}
