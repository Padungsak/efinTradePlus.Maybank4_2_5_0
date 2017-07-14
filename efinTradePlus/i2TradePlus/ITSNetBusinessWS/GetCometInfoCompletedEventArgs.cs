using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001FE RID: 510
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class GetCometInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012BC RID: 4796 RVA: 0x000F99D0 File Offset: 0x000F7DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetCometInfoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x000F99FC File Offset: 0x000F7DFC
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

		// Token: 0x040009E0 RID: 2528
		private object[] results;
	}
}
