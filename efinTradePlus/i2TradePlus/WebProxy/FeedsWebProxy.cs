using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.WebProxy
{
	// Token: 0x0200004D RID: 77
	internal class FeedsWebProxy
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0003B0B4 File Offset: 0x000394B4
		internal bool SSLEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.sslEnabled;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0003B0E0 File Offset: 0x000394E0
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0003B10C File Offset: 0x0003950C
		internal int TimeOut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.timeOut;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.timeOut = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0003B124 File Offset: 0x00039524
		internal bool CanConnectServer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.canConnectServer;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0003B150 File Offset: 0x00039550
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0003B17C File Offset: 0x0003957C
		internal string UrlForSyncHandler
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.urlForSyncHandler;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.urlForSyncHandler = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0003B194 File Offset: 0x00039594
		internal bool IsServiceStarted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.isServiceStarted;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600035C RID: 860 RVA: 0x0003B1C0 File Offset: 0x000395C0
		// (remove) Token: 0x0600035D RID: 861 RVA: 0x0003B1E8 File Offset: 0x000395E8
		internal event FeedsWebProxy.OnDataInHandler OnDataIN
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnDataIN = (FeedsWebProxy.OnDataInHandler)Delegate.Combine(this.OnDataIN, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnDataIN = (FeedsWebProxy.OnDataInHandler)Delegate.Remove(this.OnDataIN, value);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600035E RID: 862 RVA: 0x0003B210 File Offset: 0x00039610
		// (remove) Token: 0x0600035F RID: 863 RVA: 0x0003B238 File Offset: 0x00039638
		internal event FeedsWebProxy.OnErrorHandler OnError
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnError = (FeedsWebProxy.OnErrorHandler)Delegate.Combine(this.OnError, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnError = (FeedsWebProxy.OnErrorHandler)Delegate.Remove(this.OnError, value);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000360 RID: 864 RVA: 0x0003B260 File Offset: 0x00039660
		// (remove) Token: 0x06000361 RID: 865 RVA: 0x0003B288 File Offset: 0x00039688
		internal event EventHandler OnGettingHttp
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnGettingHttp = (EventHandler)Delegate.Combine(this.OnGettingHttp, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnGettingHttp = (EventHandler)Delegate.Remove(this.OnGettingHttp, value);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000362 RID: 866 RVA: 0x0003B2B0 File Offset: 0x000396B0
		// (remove) Token: 0x06000363 RID: 867 RVA: 0x0003B2D8 File Offset: 0x000396D8
		internal event EventHandler OnGettedHttp
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnGettedHttp = (EventHandler)Delegate.Combine(this.OnGettedHttp, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnGettedHttp = (EventHandler)Delegate.Remove(this.OnGettedHttp, value);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000364 RID: 868 RVA: 0x0003B300 File Offset: 0x00039700
		// (remove) Token: 0x06000365 RID: 869 RVA: 0x0003B328 File Offset: 0x00039728
		internal event EventHandler OnStarted
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnStarted = (EventHandler)Delegate.Combine(this.OnStarted, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnStarted = (EventHandler)Delegate.Remove(this.OnStarted, value);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000366 RID: 870 RVA: 0x0003B350 File Offset: 0x00039750
		// (remove) Token: 0x06000367 RID: 871 RVA: 0x0003B378 File Offset: 0x00039778
		internal event EventHandler OnStoped
		{
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnStoped = (EventHandler)Delegate.Combine(this.OnStoped, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.OnStoped = (EventHandler)Delegate.Remove(this.OnStoped, value);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0003B3A0 File Offset: 0x000397A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal FeedsWebProxy() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this.US_CHAR_RECORD_SEPERATOR = Convert.ToChar(23);
			this.US_CHAR3 = Convert.ToChar(3);
			this._dataInQueue = null;
			this._lastSeqRecv = -1;
			this._recvMessage = string.Empty;
			this.sslEnabled = false;
			this.timeOut = 5;
			this.canConnectServer = false;
			this.urlForSyncHandler = string.Empty;
			this.isServiceStarted = false;
			this.isAreadySendOnStarted = false;
			this.isRecv = false;
			
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0003B430 File Offset: 0x00039830
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Start()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.https != null)
				{
					this.https = null;
				}
				this.https = new Https();
				this.https.OnError -= new Https.OnErrorHandler(this.https_OnError);
				this.https.OnError += new Https.OnErrorHandler(this.https_OnError);
				this.https.OnTransfer -= new Https.OnTransferHandler(this.https_OnTransfer);
				this.https.OnTransfer += new Https.OnTransferHandler(this.https_OnTransfer);
				this.https.OnSSLServerAuthentication -= new Https.OnSSLServerAuthenticationHandler(this.https_OnSSLServerAuthentication);
				this.https.OnSSLServerAuthentication += new Https.OnSSLServerAuthenticationHandler(this.https_OnSSLServerAuthentication);
				this.https.OnEndTransfer -= new Https.OnEndTransferHandler(this.https_OnEndTransfer);
				this.https.OnEndTransfer += new Https.OnEndTransferHandler(this.https_OnEndTransfer);
				this.https.OnStartTransfer -= new Https.OnStartTransferHandler(this.https_OnStartTransfer);
				this.https.OnStartTransfer += new Https.OnStartTransferHandler(this.https_OnStartTransfer);
				this.canConnectServer = false;
				this.isRecv = false;
				if (this._dataInQueue != null)
				{
					lock (((ICollection)this._dataInQueue).SyncRoot)
					{
						this._dataInQueue.Clear();
					}
				}
				else
				{
					this._dataInQueue = new Queue<string>();
				}
				this.isAreadySendOnStarted = false;
				this.isServiceStarted = true;
				Thread thread = new Thread(new ThreadStart(this.SplitMessage));
				thread.Start();
				this._lastSeqRecv = -1;
				if (this.timerForRefresh == null)
				{
					this.timerForRefresh = new System.Timers.Timer();
					this.timerForRefresh.Elapsed += new ElapsedEventHandler(this.timerForRefresh_Elapsed);
				}
				this.timerForRefresh.Stop();
				this.timerForRefresh.Interval = (double)ApplicationInfo.PullInterval;
				this.timerForRefresh.Start();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0003B690 File Offset: 0x00039A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Stop()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timerForRefresh.Enabled = false;
				this.canConnectServer = false;
				this.isServiceStarted = false;
				this._lastSeqRecv = -1;
				if (this._dataInQueue != null)
				{
					lock (((ICollection)this._dataInQueue).SyncRoot)
					{
						this._dataInQueue.Clear();
					}
				}
				if (this.OnStoped != null)
				{
					this.OnStoped(this, EventArgs.Empty);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0003B75C File Offset: 0x00039B5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void https_OnError(Exception ex)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.isRecv = false;
			this._lastSeqRecv = -1;
			this.isAreadySendOnStarted = false;
			this.canConnectServer = false;
			if (this.isServiceStarted)
			{
				if (this.OnError != null)
				{
					this.OnError(new TransferEventArgs(ex));
				}
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0003B7C8 File Offset: 0x00039BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void https_OnSSLServerAuthentication(HttpsSSLServerAuthenticationEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			e.Accept = true;
			this.sslEnabled = true;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0003B7E8 File Offset: 0x00039BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void https_OnStartTransfer(int direction)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.isRecv = true;
			this._recvMessage = string.Empty;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0003B80C File Offset: 0x00039C0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void https_OnTransfer(string text)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this._recvMessage += text;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0003B830 File Offset: 0x00039C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void https_OnEndTransfer(int direction)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (this.isServiceStarted)
				{
					string[] array = this._recvMessage.Split(new char[]
					{
						this.US_CHAR3
					});
					if (array.Length == 3)
					{
						lock (((ICollection)this._dataInQueue).SyncRoot)
						{
							this._dataInQueue.Enqueue(array[2]);
						}
						int.TryParse(array[1], out this._lastSeqRecv);
					}
					array = null;
				}
				this.isRecv = false;
			}
			catch (Exception exception)
			{
				this.isRecv = false;
				if (this.OnError != null)
				{
					this.OnError(new TransferEventArgs(exception));
				}
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0003B930 File Offset: 0x00039D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SplitMessage()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				string text = string.Empty;
				while (this.isServiceStarted)
				{
					int i;
					lock (((ICollection)this._dataInQueue).SyncRoot)
					{
						i = this._dataInQueue.Count;
					}
					while (i > 0)
					{
						lock (((ICollection)this._dataInQueue).SyncRoot)
						{
							text = this._dataInQueue.Dequeue();
						}
						i--;
						if (this.OnDataIN != null)
						{
							string[] array = text.Split(new char[]
							{
								this.US_CHAR_RECORD_SEPERATOR
							});
							if (array.Length > 0)
							{
								for (int j = 0; j < array.Length; j++)
								{
									this.OnDataIN(array[j]);
								}
							}
						}
					}
					Thread.Sleep(50);
				}
			}
			catch (Exception exception)
			{
				if (this.OnError != null)
				{
					this.OnError(new TransferEventArgs(exception));
				}
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0003BADC File Offset: 0x00039EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ICollection(Queue<string> dataInQueue)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0003BB04 File Offset: 0x00039F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void timerForRefresh_Elapsed(object sender, ElapsedEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				this.timerForRefresh.Stop();
				if (this.isServiceStarted)
				{
					this.GetHttp(this._lastSeqRecv);
					this.timerForRefresh.Start();
				}
			}
			catch
			{
				if (this.isServiceStarted)
				{
					this.timerForRefresh.Start();
				}
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0003BB94 File Offset: 0x00039F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetHttp(int seq)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			try
			{
				if (!this.isRecv)
				{
					if (this.OnGettingHttp != null)
					{
						this.OnGettingHttp(this, EventArgs.Empty);
					}
					this.https.Get(string.Concat(new object[]
					{
						this.UrlForSyncHandler,
						"?seq=",
						seq,
						"&session=",
						ApplicationInfo.AccInfo.CurrentAccount
					}));
					this.canConnectServer = true;
					if (!this.isAreadySendOnStarted && this.isServiceStarted)
					{
						if (this.OnStarted != null)
						{
							this.isAreadySendOnStarted = true;
							this.OnStarted(this, EventArgs.Empty);
						}
					}
				}
			}
			catch (Exception exception)
			{
				this.isRecv = false;
				this._lastSeqRecv = -1;
				this.canConnectServer = false;
				this.isAreadySendOnStarted = false;
				if (this.isServiceStarted)
				{
					if (this.OnError != null)
					{
						this.OnError(new TransferEventArgs(exception));
					}
				}
			}
			finally
			{
				if (this.OnGettedHttp != null)
				{
					this.OnGettedHttp(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x040001F5 RID: 501
		private char US_CHAR_RECORD_SEPERATOR;

		// Token: 0x040001F6 RID: 502
		private char US_CHAR3;

		// Token: 0x040001F7 RID: 503
		private System.Timers.Timer timerForRefresh;

		// Token: 0x040001F8 RID: 504
		private Https https;

		// Token: 0x040001F9 RID: 505
		private Queue<string> _dataInQueue;

		// Token: 0x040001FA RID: 506
		private int _lastSeqRecv;

		// Token: 0x040001FB RID: 507
		private string _recvMessage;

		// Token: 0x040001FC RID: 508
		private bool sslEnabled;

		// Token: 0x040001FD RID: 509
		private int timeOut;

		// Token: 0x040001FE RID: 510
		private bool canConnectServer;

		// Token: 0x040001FF RID: 511
		private string urlForSyncHandler;

		// Token: 0x04000200 RID: 512
		private bool isServiceStarted;

		// Token: 0x04000207 RID: 519
		private bool isAreadySendOnStarted;

		// Token: 0x04000208 RID: 520
		private bool isRecv;

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000375 RID: 885
		internal delegate void OnDataInHandler(string message);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x06000379 RID: 889
		internal delegate void OnErrorHandler(TransferEventArgs e);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x0600037D RID: 893
		internal delegate void GetHttpCallBack(int seq);
	}
}
