using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000194 RID: 404
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopActiveBBOCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600117E RID: 4478 RVA: 0x000F851C File Offset: 0x000F691C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveBBOCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000F8548 File Offset: 0x000F6948
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

		// Token: 0x040009AB RID: 2475
		private object[] results;
	}
}
