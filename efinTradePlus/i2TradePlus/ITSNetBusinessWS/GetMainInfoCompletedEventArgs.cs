using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200020A RID: 522
	[GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough, DesignerCategory("code")]
	public class GetMainInfoCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012E0 RID: 4832 RVA: 0x000F9C28 File Offset: 0x000F8028
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GetMainInfoCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000F9C54 File Offset: 0x000F8054
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

		// Token: 0x040009E6 RID: 2534
		private object[] results;
	}
}
