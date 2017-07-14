using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.ITSNetBusinessWS
{
	// Token: 0x02000111 RID: 273
	[DebuggerStepThrough, GeneratedCode("System.Web.Services", "2.0.50727.5483"), DesignerCategory("code")]
	public class SendCancelOrder_AfterCloseFwCompletedEventArgs : AsyncCompletedEventArgs
	{
		// Token: 0x06000FF4 RID: 4084 RVA: 0x000F6BB8 File Offset: 0x000F4FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SendCancelOrder_AfterCloseFwCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			
			this.results = results;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x000F6BE4 File Offset: 0x000F4FE4
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

		// Token: 0x0400096A RID: 2410
		private object[] results;
	}
}
