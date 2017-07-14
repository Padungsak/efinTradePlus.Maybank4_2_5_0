using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x02000274 RID: 628
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class SeriesByPricePageCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x00143E20 File Offset: 0x00142220
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SeriesByPricePageCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00143E4C File Offset: 0x0014224C
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

		// Token: 0x04000BE0 RID: 3040
		private object[] results;
	}
}
