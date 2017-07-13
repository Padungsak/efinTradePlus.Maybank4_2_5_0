using System;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.WebProxy
{
	// Token: 0x020000B1 RID: 177
	internal class TransferEventArgs : EventArgs
	{
		// Token: 0x06000831 RID: 2097 RVA: 0x0009F978 File Offset: 0x0009DD78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TransferEventArgs()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.code = 0;
			this.text = string.Empty;
			this.exception = null;
			base..ctor();
			throw new Exception("ต้องใช้ แบบ มี Parameter เท่านั้น");
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0009F9B8 File Offset: 0x0009DDB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TransferEventArgs(string text)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.code = 0;
			this.text = string.Empty;
			this.exception = null;
			base..ctor();
			this.code = 0;
			this.text = text;
			this.exception = null;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0009FA10 File Offset: 0x0009DE10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TransferEventArgs(int code, string text)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.code = 0;
			this.text = string.Empty;
			this.exception = null;
			base..ctor();
			this.code = code;
			this.text = text;
			if (code == -1)
			{
				this.exception = new Exception(text);
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0009FA7C File Offset: 0x0009DE7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TransferEventArgs(Exception exception)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.code = 0;
			this.text = string.Empty;
			this.exception = null;
			base..ctor();
			this.code = -1;
			this.exception = exception;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0009FACC File Offset: 0x0009DECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TransferEventArgs(string text, Exception exception)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.code = 0;
			this.text = string.Empty;
			this.exception = null;
			base..ctor();
			this.code = -1;
			this.text = text;
			this.exception = exception;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x0009FB24 File Offset: 0x0009DF24
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x0009FB50 File Offset: 0x0009DF50
		internal int Code
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.code;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.code = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x0009FB68 File Offset: 0x0009DF68
		internal string Text
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.text;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0009FB94 File Offset: 0x0009DF94
		internal Exception Exception
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.exception;
			}
		}

		// Token: 0x04000519 RID: 1305
		private int code;

		// Token: 0x0400051A RID: 1306
		private string text;

		// Token: 0x0400051B RID: 1307
		private Exception exception;
	}
}
