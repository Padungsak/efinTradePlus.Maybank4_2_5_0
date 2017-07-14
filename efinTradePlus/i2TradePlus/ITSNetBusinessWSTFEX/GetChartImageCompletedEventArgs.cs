using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000288 RID: 648
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code"), DebuggerStepThrough]
	public class GetChartImageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001766 RID: 5990 RVA: 0x00144208 File Offset: 0x00142608
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetChartImageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00144234 File Offset: 0x00142634
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

		// Token: 0x04000BEA RID: 3050
		private object[] results;
	}
}
