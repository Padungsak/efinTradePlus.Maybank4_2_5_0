using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000206 RID: 518
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class VerifyOrderFwCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012D4 RID: 4820 RVA: 0x000F9B60 File Offset: 0x000F7F60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal VerifyOrderFwCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000F9B8C File Offset: 0x000F7F8C
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

		// Token: 0x040009E4 RID: 2532
		private object[] results;
	}
}
