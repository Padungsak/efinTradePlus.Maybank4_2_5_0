using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200028C RID: 652
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SeriesSaleByTimeCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001772 RID: 6002 RVA: 0x001442D0 File Offset: 0x001426D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SeriesSaleByTimeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x001442FC File Offset: 0x001426FC
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

		// Token: 0x04000BEC RID: 3052
		private object[] results;
	}
}
