using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x0200026A RID: 618
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class LoadMktStatusCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600170C RID: 5900 RVA: 0x00143C2C File Offset: 0x0014202C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LoadMktStatusCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x00143C58 File Offset: 0x00142058
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

		// Token: 0x04000BDB RID: 3035
		private object[] results;
	}
}
