using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000184 RID: 388
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class LoadOddLotInformationCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600114E RID: 4430 RVA: 0x000F81FC File Offset: 0x000F65FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadOddLotInformationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000F8228 File Offset: 0x000F6628
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

		// Token: 0x040009A3 RID: 2467
		private object[] results;
	}
}
