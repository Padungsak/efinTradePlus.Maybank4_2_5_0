using System;
using System.Net;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.ITSNetBusinessWSTFEX;
using i2TradePlus.Properties;

namespace i2TradePlus
{
    // Token: 0x02000230 RID: 560
    internal class BusinessTfexService : Service
    {
        // Token: 0x06001552 RID: 5458 RVA: 0x0011A998 File Offset: 0x00118D98
        [MethodImpl(MethodImplOptions.NoInlining)]
        protected override WebRequest GetWebRequest(Uri uri)
        {
            //while (false)
            //{
            //    //////object arg_0A_0 = null[0];
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

        // Token: 0x06001553 RID: 5459 RVA: 0x0011AAA0 File Offset: 0x00118EA0
        [MethodImpl(MethodImplOptions.NoInlining)]
        public BusinessTfexService()
            : base()
        {
            //while (false)
            //{
            //    //////object arg_0A_0 = null[0];
            //}
            QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
            this.isFirstOpen = true;
            //this.proxy = null;
        }

        // Token: 0x04000B0D RID: 2829
        private bool isFirstOpen;

        // Token: 0x04000B0E RID: 2830
        //private WebProxy proxy;
    }
}
