using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x0200012B RID: 299
	[DesignerCategory("code"), GeneratedCode("System.Web.Services", "2.0.50727.5483"), DebuggerStepThrough]
	public class DeleteStockNicknameCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001042 RID: 4162 RVA: 0x000F70CC File Offset: 0x000F54CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DeleteStockNicknameCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x000F70F8 File Offset: 0x000F54F8
		public bool Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.RaiseExceptionIfNecessary();
				return (bool)this.results[0];
			}
		}

		// Token: 0x04000977 RID: 2423
		private object[] results;
	}
}
