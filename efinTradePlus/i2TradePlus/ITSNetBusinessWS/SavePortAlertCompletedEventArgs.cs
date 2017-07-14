using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000143 RID: 323
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SavePortAlertCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600108A RID: 4234 RVA: 0x000F757C File Offset: 0x000F597C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SavePortAlertCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x000F75A8 File Offset: 0x000F59A8
		public long Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (long)this.results[0];
			}
		}

		// Token: 0x04000983 RID: 2435
		private object[] results;
	}
}
