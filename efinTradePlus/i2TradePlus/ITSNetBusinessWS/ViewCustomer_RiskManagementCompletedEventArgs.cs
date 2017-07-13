using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001E8 RID: 488
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class ViewCustomer_RiskManagementCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x0600127A RID: 4730 RVA: 0x000F9584 File Offset: 0x000F7984
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ViewCustomer_RiskManagementCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000F95B0 File Offset: 0x000F79B0
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

		// Token: 0x040009D5 RID: 2517
		private object[] results;
	}
}
