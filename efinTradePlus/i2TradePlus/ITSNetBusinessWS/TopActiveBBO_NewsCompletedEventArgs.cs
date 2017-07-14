using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001A2 RID: 418
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopActiveBBO_NewsCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011A8 RID: 4520 RVA: 0x000F87D8 File Offset: 0x000F6BD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBO_NewsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000F8804 File Offset: 0x000F6C04
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

		// Token: 0x040009B2 RID: 2482
		private object[] results;
	}
}
