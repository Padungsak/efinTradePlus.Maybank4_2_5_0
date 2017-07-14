using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200028E RID: 654
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SeriesSaleByPriceCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001778 RID: 6008 RVA: 0x00144334 File Offset: 0x00142734
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SeriesSaleByPriceCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x00144360 File Offset: 0x00142760
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

		// Token: 0x04000BED RID: 3053
		private object[] results;
	}
}
