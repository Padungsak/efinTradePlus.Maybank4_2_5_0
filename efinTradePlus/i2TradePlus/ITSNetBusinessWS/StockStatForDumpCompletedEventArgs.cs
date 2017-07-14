using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001B2 RID: 434
	[DebuggerStepThrough, DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class StockStatForDumpCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011D8 RID: 4568 RVA: 0x000F8AF8 File Offset: 0x000F6EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal StockStatForDumpCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000F8B24 File Offset: 0x000F6F24
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

		// Token: 0x040009BA RID: 2490
		private object[] results;
	}
}
