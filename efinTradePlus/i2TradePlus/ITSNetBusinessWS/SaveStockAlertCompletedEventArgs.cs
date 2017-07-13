using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000141 RID: 321
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SaveStockAlertCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x000F7518 File Offset: 0x000F5918
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveStockAlertCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x000F7544 File Offset: 0x000F5944
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

		// Token: 0x04000982 RID: 2434
		private object[] results;
	}
}
