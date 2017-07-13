using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.Properties;

namespace i2TradePlus.WebProxy
{
    // Token: 0x02000107 RID: 263
    public class Https
    {
        // Token: 0x1400003B RID: 59
        // (add) Token: 0x06000C8B RID: 3211 RVA: 0x000E8E68 File Offset: 0x000E7268
        // (remove) Token: 0x06000C8C RID: 3212 RVA: 0x000E8E90 File Offset: 0x000E7290
        public Https.OnErrorHandler _OnError;
        public event Https.OnErrorHandler OnError
        {
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            add
            {
                this._OnError += value;
            }
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            remove
            {
                this._OnError -= value;
            }
        }

        // Token: 0x1400003C RID: 60
        // (add) Token: 0x06000C8D RID: 3213 RVA: 0x000E8EB8 File Offset: 0x000E72B8
        // (remove) Token: 0x06000C8E RID: 3214 RVA: 0x000E8EE0 File Offset: 0x000E72E0
        public Https.OnTransferHandler _OnTransfer;
        public event Https.OnTransferHandler OnTransfer
        {
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            add
            {
                this._OnTransfer += value;
            }
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            remove
            {
                this._OnTransfer -= value;
            }
        }

        // Token: 0x1400003D RID: 61
        // (add) Token: 0x06000C8F RID: 3215 RVA: 0x000E8F08 File Offset: 0x000E7308
        // (remove) Token: 0x06000C90 RID: 3216 RVA: 0x000E8F30 File Offset: 0x000E7330
        public Https.OnEndTransferHandler _OnEndTransfer;
        public event Https.OnEndTransferHandler OnEndTransfer
        {
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            add
            {
                this._OnEndTransfer += value;
            }
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            remove
            {
                this._OnEndTransfer -= value;
            }
        }

        // Token: 0x1400003E RID: 62
        // (add) Token: 0x06000C91 RID: 3217 RVA: 0x000E8F58 File Offset: 0x000E7358
        // (remove) Token: 0x06000C92 RID: 3218 RVA: 0x000E8F80 File Offset: 0x000E7380
        public Https.OnStartTransferHandler _OnStartTransfer;
        public event Https.OnStartTransferHandler OnStartTransfer
        {
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            add
            {
                this._OnStartTransfer += value;
            }
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            remove
            {
                this._OnStartTransfer -= value;
            }
        }

        // Token: 0x1400003F RID: 63
        // (add) Token: 0x06000C93 RID: 3219 RVA: 0x000E8FA8 File Offset: 0x000E73A8
        // (remove) Token: 0x06000C94 RID: 3220 RVA: 0x000E8FD0 File Offset: 0x000E73D0
        public Https.OnSSLServerAuthenticationHandler _OnSSLServerAuthentication;
        public event Https.OnSSLServerAuthenticationHandler OnSSLServerAuthentication
        {
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            add
            {
                this._OnSSLServerAuthentication += value;
            }
            [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
            remove
            {
                this._OnSSLServerAuthentication -= value;
            }
        }

        // Token: 0x170001C2 RID: 450
        // (get) Token: 0x06000C95 RID: 3221 RVA: 0x000E8FF8 File Offset: 0x000E73F8
        // (set) Token: 0x06000C96 RID: 3222 RVA: 0x000E9024 File Offset: 0x000E7424
        public int ReadBufferSize
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            get
            {
                while (false)
                {
                    ////object arg_0A_0 = null[0];
                }
                return this.readBufferSize;
            }
            [MethodImpl(MethodImplOptions.NoInlining)]
            set
            {
                while (false)
                {
                    ////object arg_0A_0 = null[0];
                }
                this.readBufferSize = value;
            }
        }

        // Token: 0x170001C3 RID: 451
        // (get) Token: 0x06000C97 RID: 3223 RVA: 0x000E903C File Offset: 0x000E743C
        // (set) Token: 0x06000C98 RID: 3224 RVA: 0x000E9068 File Offset: 0x000E7468
        public int TimeOut
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            get
            {
                while (false)
                {
                    ////object arg_0A_0 = null[0];
                }
                return this.timeOut;
            }
            [MethodImpl(MethodImplOptions.NoInlining)]
            set
            {
                while (false)
                {
                    ////object arg_0A_0 = null[0];
                }
                this.timeOut = value;
            }
        }

        // Token: 0x06000C99 RID: 3225 RVA: 0x000E9080 File Offset: 0x000E7480
        [MethodImpl(MethodImplOptions.NoInlining)]
        public string Get(string URL)
        {
            //object arg_0A_0;
            //while (false)
            //{
            //    arg_0A_0 = null[0];
            //}
            CookieContainer cookies = new CookieContainer();
            HttpWebRequest webRequest = this.GetWebRequest(new Uri(URL), cookies);
            ServicePointManager.ServerCertificateValidationCallback = delegate
            {
                while (false)
                {
                    ////object arg_0A_0 = null[0];
                }
                return true;
            };
            string result;
            try
            {
                if (this._OnStartTransfer != null)
                {
                    this._OnStartTransfer(1);
                }
                HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                char[] array = new char[this.ReadBufferSize];
                int i = streamReader.Read(array, 0, this.ReadBufferSize);
                string text = string.Empty;
                while (i > 0)
                {
                    string text2 = new string(array, 0, i);
                    text += text2;
                    i = streamReader.Read(array, 0, this.ReadBufferSize);
                    if (this._OnTransfer != null)
                    {
                        this._OnTransfer(text2);
                    }
                }
                streamReader.Close();
                responseStream.Close();
                httpWebResponse.Close();
                if (this._OnEndTransfer != null)
                {
                    this._OnEndTransfer(1);
                }
                result = text;
            }
            catch (Exception ex)
            {
                if (this._OnError != null)
                {
                    this._OnError(ex);
                }
                throw ex;
            }
            return result;
        }

        // Token: 0x06000C9A RID: 3226 RVA: 0x000E9218 File Offset: 0x000E7618
        [MethodImpl(MethodImplOptions.NoInlining)]
        private HttpWebRequest GetWebRequest(Uri uri, CookieContainer cookies)
        {
            while (false)
            {
                ////object arg_0A_0 = null[0];
            }
            HttpWebRequest result;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
                httpWebRequest.CookieContainer = cookies;
                httpWebRequest.Timeout = this.TimeOut;
                httpWebRequest.ReadWriteTimeout = 10000;
                httpWebRequest.KeepAlive = true;
                httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                if (ApplicationInfo.IsUseProxy)
                {
                    //if (this.proxy == null)
                    //{
                    //    this.proxy = new WebProxy(Settings.Default.ProxyHost, Settings.Default.ProxyPort);
                    //    this.proxy.Credentials = new NetworkCredential(Settings.Default.ProxyUsername, ApplicationInfo.ProxyPassword);
                    //}
                    //httpWebRequest.Proxy = this.proxy;
                }
                result = httpWebRequest;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Token: 0x06000C9B RID: 3227 RVA: 0x000E9308 File Offset: 0x000E7708
        [MethodImpl(MethodImplOptions.NoInlining)]
        public bool CertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            while (false)
            {
                ////object arg_0A_0 = null[0];
            }
            HttpsSSLServerAuthenticationEventArgs httpsSSLServerAuthenticationEventArgs = new HttpsSSLServerAuthenticationEventArgs();
            if (this._OnSSLServerAuthentication != null)
            {
                this._OnSSLServerAuthentication(httpsSSLServerAuthenticationEventArgs);
            }
            return httpsSSLServerAuthenticationEventArgs.Accept;
        }

        // Token: 0x06000C9C RID: 3228 RVA: 0x000E9354 File Offset: 0x000E7754
        [MethodImpl(MethodImplOptions.NoInlining)]
        public string GetCookies(string URL)
        {
            while (false)
            {
                ////object arg_0A_0 = null[0];
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Cookies) + "\\";
            Uri uri = new Uri(URL);
            string dnsSafeHost = uri.DnsSafeHost;
            string searchPattern = string.Empty;
            string text = Environment.UserName.ToLower();
            IPAddress iPAddress;
            if (IPAddress.TryParse(dnsSafeHost, out iPAddress))
            {
                string[] array = dnsSafeHost.Split(new char[]
				{
					'.'
				});
                searchPattern = string.Concat(new object[]
				{
					text,
					'@',
					array[0],
					'.',
					array[1],
					'.',
					array[2],
					'*'
				});
            }
            else
            {
                string[] array2 = dnsSafeHost.Split(new char[]
				{
					'.'
				});
                searchPattern = string.Concat(new object[]
				{
					text,
					'@',
					'*',
					array2[1],
					'*'
				});
            }
            string[] files = Directory.GetFiles(path, searchPattern);
            string result;
            if (files != null && files.Length > 0)
            {
                string text2 = File.ReadAllText(files[0]);
                string[] array3 = text2.Split(new char[]
				{
					'\n'
				});
                if (array3 != null && array3.Length > 2)
                {
                    result = array3[1];
                }
                else
                {
                    result = string.Empty;
                }
            }
            else
            {
                result = string.Empty;
            }
            return result;
        }

        // Token: 0x06000C9D RID: 3229 RVA: 0x000E9524 File Offset: 0x000E7924
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Https()
            : base()
        {
            while (false)
            {
                ////object arg_0A_0 = null[0];
            }
            QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
            this.readBufferSize = 1024;
            this.timeOut = 15000;
            //this.proxy = null;
        }

        // Token: 0x04000854 RID: 2132
        private int readBufferSize;

        // Token: 0x04000855 RID: 2133
        private int timeOut;

        // Token: 0x04000856 RID: 2134
        //private WebProxy proxy;

        // Token: 0x04000857 RID: 2135
        [CompilerGenerated]
        //private static RemoteCertificateValidationCallback <>9__CachedAnonymousMethodDelegate1;

        // Token: 0x02000108 RID: 264
        // (Invoke) Token: 0x06000CA0 RID: 3232
        public delegate void OnErrorHandler(Exception ex);

        // Token: 0x02000109 RID: 265
        // (Invoke) Token: 0x06000CA4 RID: 3236
        public delegate void OnTransferHandler(string text);

        // Token: 0x0200010A RID: 266
        // (Invoke) Token: 0x06000CA8 RID: 3240
        public delegate void OnEndTransferHandler(int direction);

        // Token: 0x0200010B RID: 267
        // (Invoke) Token: 0x06000CAC RID: 3244
        public delegate void OnStartTransferHandler(int direction);

        // Token: 0x0200010C RID: 268
        // (Invoke) Token: 0x06000CB0 RID: 3248
        public delegate void OnSSLServerAuthenticationHandler(HttpsSSLServerAuthenticationEventArgs e);
    }
}
