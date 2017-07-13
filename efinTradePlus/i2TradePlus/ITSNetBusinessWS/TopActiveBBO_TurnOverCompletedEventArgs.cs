using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001A4 RID: 420
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class TopActiveBBO_TurnOverCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011AE RID: 4526 RVA: 0x000F883C File Offset: 0x000F6C3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBO_TurnOverCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x000F8868 File Offset: 0x000F6C68
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

		// Token: 0x040009B3 RID: 2483
		private object[] results;
	}
}
