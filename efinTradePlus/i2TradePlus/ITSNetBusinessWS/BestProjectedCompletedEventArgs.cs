using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200018E RID: 398
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class BestProjectedCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600116C RID: 4460 RVA: 0x000F83F0 File Offset: 0x000F67F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal BestProjectedCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x000F841C File Offset: 0x000F681C
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

		// Token: 0x040009A8 RID: 2472
		private object[] results;
	}
}
