using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000214 RID: 532
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class ChangeCustomerPasswordCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001300 RID: 4864 RVA: 0x000F9DB8 File Offset: 0x000F81B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ChangeCustomerPasswordCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x000F9DE4 File Offset: 0x000F81E4
		public bool Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (bool)this.results[0];
			}
		}

		// Token: 0x040009EA RID: 2538
		private object[] results;
	}
}
