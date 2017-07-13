using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200013F RID: 319
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SavePushAccountCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600107E RID: 4222 RVA: 0x000F74B4 File Offset: 0x000F58B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SavePushAccountCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x000F74E0 File Offset: 0x000F58E0
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

		// Token: 0x04000981 RID: 2433
		private object[] results;
	}
}
