using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWSTFEX
{
	// Token: 0x020002A0 RID: 672
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomersAllCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060017AE RID: 6062 RVA: 0x001446B8 File Offset: 0x00142AB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomersAllCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x001446E4 File Offset: 0x00142AE4
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

		// Token: 0x04000BF6 RID: 3062
		private object[] results;
	}
}
