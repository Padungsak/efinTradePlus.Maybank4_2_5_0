using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200019A RID: 410
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class TopActiveBBO_CMPRCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001190 RID: 4496 RVA: 0x000F8648 File Offset: 0x000F6A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBO_CMPRCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000F8674 File Offset: 0x000F6A74
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

		// Token: 0x040009AE RID: 2478
		private object[] results;
	}
}
