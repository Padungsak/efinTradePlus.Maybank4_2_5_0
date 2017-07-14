using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200018C RID: 396
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class BestOpenPriceCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x000F838C File Offset: 0x000F678C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BestOpenPriceCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x000F83B8 File Offset: 0x000F67B8
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

		// Token: 0x040009A7 RID: 2471
		private object[] results;
	}
}
