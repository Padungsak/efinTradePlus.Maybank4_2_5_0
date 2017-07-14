using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001A8 RID: 424
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class InvestorTypeCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060011BA RID: 4538 RVA: 0x000F8904 File Offset: 0x000F6D04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal InvestorTypeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x000F8930 File Offset: 0x000F6D30
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

		// Token: 0x040009B5 RID: 2485
		private object[] results;
	}
}
