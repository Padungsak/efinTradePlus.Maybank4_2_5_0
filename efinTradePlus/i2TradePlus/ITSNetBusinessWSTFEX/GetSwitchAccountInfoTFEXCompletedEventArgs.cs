using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200028A RID: 650
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class GetSwitchAccountInfoTFEXCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x0014426C File Offset: 0x0014266C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetSwitchAccountInfoTFEXCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00144298 File Offset: 0x00142698
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

		// Token: 0x04000BEB RID: 3051
		private object[] results;
	}
}
