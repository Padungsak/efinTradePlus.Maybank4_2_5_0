using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200015F RID: 351
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class GetUserAlertCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060010DE RID: 4318 RVA: 0x000F7AF4 File Offset: 0x000F5EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetUserAlertCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000F7B20 File Offset: 0x000F5F20
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

		// Token: 0x04000991 RID: 2449
		private object[] results;
	}
}
