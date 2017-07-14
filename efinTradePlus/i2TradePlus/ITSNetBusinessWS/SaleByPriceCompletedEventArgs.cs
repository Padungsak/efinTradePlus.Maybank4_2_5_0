using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001AC RID: 428
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SaleByPriceCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011C6 RID: 4550 RVA: 0x000F89CC File Offset: 0x000F6DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaleByPriceCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x000F89F8 File Offset: 0x000F6DF8
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

		// Token: 0x040009B7 RID: 2487
		private object[] results;
	}
}
