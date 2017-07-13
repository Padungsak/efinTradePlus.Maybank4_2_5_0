using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000171 RID: 369
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SaveUserConfigCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001114 RID: 4372 RVA: 0x000F7E78 File Offset: 0x000F6278
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SaveUserConfigCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x000F7EA4 File Offset: 0x000F62A4
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

		// Token: 0x0400099A RID: 2458
		private object[] results;
	}
}
