using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200017C RID: 380
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class LoadAllInformationIsoddCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001136 RID: 4406 RVA: 0x000F806C File Offset: 0x000F646C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadAllInformationIsoddCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x000F8098 File Offset: 0x000F6498
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

		// Token: 0x0400099F RID: 2463
		private object[] results;
	}
}
