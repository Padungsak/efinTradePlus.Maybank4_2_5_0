using System;
using System.Net;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.ITSNetBusinessWS;
using i2TradePlus.Properties;
using i2TradePlus.WebProxy;

namespace i2TradePlus
{
    // Token: 0x0200022E RID: 558
    internal class BusinessService : Service
    {
        // Token: 0x06001471 RID: 5233 RVA: 0x00116CF0 File Offset: 0x001150F0
        [MethodImpl(MethodImplOptions.NoInlining)]
        protected override WebRequest GetWebRequest(Uri uri)
        {
            //while (false)
            //{
            //    ////object arg_0A_0 = null[0];
            //}
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            if (this.isFirstOpen)
            {
                httpWebRequest.Timeout = 30000;
                httpWebRequest.ReadWriteTimeout = 30000;
            }
            else
            {
                httpWebRequest.Timeout = 30000;
                httpWebRequest.ReadWriteTimeout = 10000;
            }
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
            this.isFirstOpen = false;
            return httpWebRequest;
        }

        // Token: 0x06001472 RID: 5234 RVA: 0x00116DF8 File Offset: 0x001151F8
        [MethodImpl(MethodImplOptions.NoInlining)]
        public BusinessService()
            : base()
        {
            //while (false)
            //{
            //    ////object arg_0A_0 = null[0];
            //}
            QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
            this.isFirstOpen = true;
            //this.proxy = null;

        }

        // Token: 0x04000AC2 RID: 2754
        private bool isFirstOpen;

        // Token: 0x04000AC3 RID: 2755
        //private WebProxy proxy;
    }
}
