using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000192 RID: 402
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopActiveCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001178 RID: 4472 RVA: 0x000F84B8 File Offset: 0x000F68B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopActiveCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x000F84E4 File Offset: 0x000F68E4
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

		// Token: 0x040009AA RID: 2474
		private object[] results;
	}
}
