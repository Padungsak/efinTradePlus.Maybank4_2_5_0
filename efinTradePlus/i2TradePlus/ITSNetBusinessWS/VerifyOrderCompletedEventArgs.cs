using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000204 RID: 516
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class VerifyOrderCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012CE RID: 4814 RVA: 0x000F9AFC File Offset: 0x000F7EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal VerifyOrderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x000F9B28 File Offset: 0x000F7F28
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

		// Token: 0x040009E3 RID: 2531
		private object[] results;
	}
}
