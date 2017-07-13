using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000208 RID: 520
	[DesignerCategory("code"), DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483")]
	public class VerifyOrderMktCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x060012DA RID: 4826 RVA: 0x000F9BC4 File Offset: 0x000F7FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal VerifyOrderMktCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			base..ctor(exception, cancelled, userState);
			this.results = results;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000F9BF0 File Offset: 0x000F7FF0
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

		// Token: 0x040009E5 RID: 2533
		private object[] results;
	}
}
