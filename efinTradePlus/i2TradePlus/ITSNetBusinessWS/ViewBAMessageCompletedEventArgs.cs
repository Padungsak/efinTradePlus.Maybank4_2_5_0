using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200011F RID: 287
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewBAMessageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x000F6E74 File Offset: 0x000F5274
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewBAMessageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x000F6EA0 File Offset: 0x000F52A0
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

		// Token: 0x04000971 RID: 2417
		private object[] results;
	}
}
