using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000173 RID: 371
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SaveUserConfigAllCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600111A RID: 4378 RVA: 0x000F7EDC File Offset: 0x000F62DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveUserConfigAllCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x000F7F08 File Offset: 0x000F6308
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

		// Token: 0x0400099B RID: 2459
		private object[] results;
	}
}
