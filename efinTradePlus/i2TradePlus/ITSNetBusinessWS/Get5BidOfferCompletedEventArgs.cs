using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001C6 RID: 454
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class Get5BidOfferCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001214 RID: 4628 RVA: 0x000F8EE0 File Offset: 0x000F72E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Get5BidOfferCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x000F8F0C File Offset: 0x000F730C
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

		// Token: 0x040009C4 RID: 2500
		private object[] results;
	}
}
