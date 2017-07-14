using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200011D RID: 285
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class VerifyPincode2CompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001018 RID: 4120 RVA: 0x000F6E10 File Offset: 0x000F5210
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal VerifyPincode2CompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x000F6E3C File Offset: 0x000F523C
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

		// Token: 0x04000970 RID: 2416
		private object[] results;
	}
}
