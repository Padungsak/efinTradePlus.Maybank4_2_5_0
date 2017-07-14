using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x020001C2 RID: 450
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class TopBBOadCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06001208 RID: 4616 RVA: 0x000F8E18 File Offset: 0x000F7218
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TopBBOadCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x000F8E44 File Offset: 0x000F7244
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

		// Token: 0x040009C2 RID: 2498
		private object[] results;
	}
}
