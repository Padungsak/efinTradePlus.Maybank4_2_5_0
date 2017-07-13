using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;
using Abv9LVGLme6DnuTi2C;
using i2TradePlus.WebProxy;

namespace i2TradePlus
{
    // Token: 0x020000AD RID: 173
    public class i2InfoWS
    {
        // Token: 0x17000112 RID: 274
        // (get) Token: 0x06000815 RID: 2069 RVA: 0x0009D4C4 File Offset: 0x0009B8C4
        // (set) Token: 0x06000816 RID: 2070 RVA: 0x0009D4EC File Offset: 0x0009B8EC
        //public static WebProxy Proxy
        //{
        //    [MethodImpl(MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        while (false)
        //        {
        //            //////object arg_0A_0 = null[0];
        //        }
        //        return i2InfoWS.proxy;
        //    }
        //    [MethodImpl(MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        while (false)
        //        {
        //            //////object arg_0A_0 = null[0];
        //        }
        //        i2InfoWS.proxy = value;
        //    }
        //}

        // Token: 0x06000817 RID: 2071 RVA: 0x0009D504 File Offset: 0x0009B904
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static i2WSResult GetConnectionInfo(string host, string device)
        {
            //while (false)
            //{
            //    //////object arg_0A_0 = null[0];
            //}
            i2WSResult i2WSResult = default(i2WSResult);
            i2WSResult result;
            try
            {
                i2InfoWS.i2API = new Https();
                string uRL = host + "?device=" + device;
                string xml = i2InfoWS.i2API.Get(uRL);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                i2WSResult.Code = xmlDocument.GetElementsByTagName("code").Item(0).Attributes["value"].Value;
                if (i2WSResult.Code == "0")
                {
                    i2WSResult.Version = xmlDocument.GetElementsByTagName("version").Item(0).Attributes["value"].Value;
                    i2WSResult.Installerurl = xmlDocument.GetElementsByTagName("installerurl").Item(0).Attributes["value"].Value;
                    i2WSResult.UpdateURL = xmlDocument.GetElementsByTagName("updateurl").Item(0).Attributes["value"].Value;
                    i2WSResult.WsURL = xmlDocument.GetElementsByTagName("servername").Item(0).Attributes["value"].Value;
                    i2WSResult.WsDURL = xmlDocument.GetElementsByTagName("servernamed").Item(0).Attributes["value"].Value;
                    i2WSResult.SessionID = xmlDocument.GetElementsByTagName("session").Item(0).Attributes["value"].Value;
                    i2WSResult.Description = "Successed";
                    if (xmlDocument.SelectSingleNode("//cefurl") != null)
                    {
                        i2WSResult.CefUrl = xmlDocument.GetElementsByTagName("cefurl").Item(0).Attributes["value"].Value;
                    }
                }
                result = i2WSResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Token: 0x06000818 RID: 2072 RVA: 0x0009D72C File Offset: 0x0009BB2C
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static i2WSResult GetConnectionInfoMulti(string host, string device)
        {
            //while (false)
            //{
            //    //////object arg_0A_0 = null[0];
            //}
            i2WSResult i2WSResult = default(i2WSResult);
            i2WSResult result;
            try
            {
                i2InfoWS.i2API = new Https();
                string uRL = host + "?device=" + device;
                string xml = i2InfoWS.i2API.Get(uRL);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                i2WSResult.Code = xmlDocument.GetElementsByTagName("code").Item(0).Attributes["value"].Value;
                if (i2WSResult.Code == "0")
                {
                    i2WSResult.Version = xmlDocument.GetElementsByTagName("version").Item(0).Attributes["value"].Value;
                    i2WSResult.Installerurl = xmlDocument.GetElementsByTagName("installerurl").Item(0).Attributes["value"].Value;
                    i2WSResult.UpdateURL = xmlDocument.GetElementsByTagName("updateurl").Item(0).Attributes["value"].Value;
                    i2WSResult.WsURL = xmlDocument.GetElementsByTagName("servername").Item(0).Attributes["value"].Value;
                    if (xmlDocument.SelectSingleNode("//servernameorder") != null)
                    {
                        i2WSResult.WsOrderURL = xmlDocument.GetElementsByTagName("servernameorder").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernameuser") != null)
                    {
                        i2WSResult.WsMainURL = xmlDocument.GetElementsByTagName("servernameuser").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernamemain_tfex") != null)
                    {
                        i2WSResult.WsMainTfexURL = xmlDocument.GetElementsByTagName("servernamemain_tfex").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernamealert") != null)
                    {
                        i2WSResult.WsAlertURL = xmlDocument.GetElementsByTagName("servernamealert").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//cefurl") != null)
                    {
                        i2WSResult.CefUrl = xmlDocument.GetElementsByTagName("cefurl").Item(0).Attributes["value"].Value;
                    }
                    i2WSResult.WsDURL = xmlDocument.GetElementsByTagName("servernamed").Item(0).Attributes["value"].Value;
                    i2WSResult.SessionID = xmlDocument.GetElementsByTagName("session").Item(0).Attributes["value"].Value;
                    i2WSResult.Description = "Successed";
                }
                result = i2WSResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Token: 0x06000819 RID: 2073 RVA: 0x0009DA60 File Offset: 0x0009BE60
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static i2WSResult GetConnectionInfoWithGrade(string host, string device, string custGrade)
        {
            while (false)
            {
                //////object arg_0A_0 = null[0];
            }
            i2WSResult i2WSResult = default(i2WSResult);
            i2WSResult result;
            try
            {
                i2InfoWS.i2API = new Https();
                string uRL = string.Concat(new string[]
				{
					host,
					"?device=",
					device,
					"&cust_grade=",
					custGrade
				});
                string xml = i2InfoWS.i2API.Get(uRL);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                i2WSResult.Code = xmlDocument.GetElementsByTagName("code").Item(0).Attributes["value"].Value;
                if (i2WSResult.Code == "0")
                {
                    i2WSResult.Version = xmlDocument.GetElementsByTagName("version").Item(0).Attributes["value"].Value;
                    if (xmlDocument.SelectSingleNode("//servername") != null)
                    {
                        i2WSResult.WsURL = xmlDocument.GetElementsByTagName("servername").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernameorder") != null)
                    {
                        i2WSResult.WsOrderURL = xmlDocument.GetElementsByTagName("servernameorder").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernameuser") != null)
                    {
                        i2WSResult.WsMainURL = xmlDocument.GetElementsByTagName("servernameuser").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernamealert") != null)
                    {
                        i2WSResult.WsAlertURL = xmlDocument.GetElementsByTagName("servernamealert").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//cefurl") != null)
                    {
                        i2WSResult.CefUrl = xmlDocument.GetElementsByTagName("cefurl").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servergrade") != null)
                    {
                        ApplicationInfo.Grade_Server = xmlDocument.GetElementsByTagName("servergrade").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernamed") != null)
                    {
                        i2WSResult.WsDURL = xmlDocument.GetElementsByTagName("servernamed").Item(0).Attributes["value"].Value;
                    }
                    i2WSResult.SessionID = xmlDocument.GetElementsByTagName("session").Item(0).Attributes["value"].Value;
                    i2WSResult.Description = "Successed";
                }
                result = i2WSResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Token: 0x0600081A RID: 2074 RVA: 0x0009DD8C File Offset: 0x0009C18C
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static i2WSResult GetServerGrade(string host, string device)
        {
            while (false)
            {
                //////object arg_0A_0 = null[0];
            }
            i2WSResult i2WSResult = default(i2WSResult);
            i2WSResult result;
            try
            {
                i2InfoWS.i2API = new Https();
                string uRL = host + "?device=" + device + "?get_keserver=Y";
                string xml = i2InfoWS.i2API.Get(uRL);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                i2WSResult.Code = xmlDocument.GetElementsByTagName("code").Item(0).Attributes["value"].Value;
                if (i2WSResult.Code == "0")
                {
                    i2WSResult.Version = xmlDocument.GetElementsByTagName("version").Item(0).Attributes["value"].Value;
                    i2WSResult.Installerurl = xmlDocument.GetElementsByTagName("installerurl").Item(0).Attributes["value"].Value;
                    i2WSResult.UpdateURL = xmlDocument.GetElementsByTagName("updateurl").Item(0).Attributes["value"].Value;
                    i2WSResult.WsURL = xmlDocument.GetElementsByTagName("servername").Item(0).Attributes["value"].Value;
                    if (xmlDocument.SelectSingleNode("//servernameorder") != null)
                    {
                        i2WSResult.WsOrderURL = xmlDocument.GetElementsByTagName("servernameorder").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernameuser") != null)
                    {
                        i2WSResult.WsMainURL = xmlDocument.GetElementsByTagName("servernameuser").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//servernamealert") != null)
                    {
                        i2WSResult.WsAlertURL = xmlDocument.GetElementsByTagName("servernamealert").Item(0).Attributes["value"].Value;
                    }
                    if (xmlDocument.SelectSingleNode("//cefurl") != null)
                    {
                        i2WSResult.CefUrl = xmlDocument.GetElementsByTagName("cefurl").Item(0).Attributes["value"].Value;
                    }
                    i2WSResult.WsDURL = xmlDocument.GetElementsByTagName("servernamed").Item(0).Attributes["value"].Value;
                    i2WSResult.SessionID = xmlDocument.GetElementsByTagName("session").Item(0).Attributes["value"].Value;
                    i2WSResult.Description = "Successed";
                }
                result = i2WSResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Token: 0x0600081B RID: 2075 RVA: 0x0009E080 File Offset: 0x0009C480
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetServerVersion(string url)
        {
            while (false)
            {
                //////object arg_0A_0 = null[0];
            }
            string result;
            try
            {
                i2InfoWS.i2API = new Https();
                string uRL = url + "/i2TradePlus.Start.application";
                string xml = i2InfoWS.i2API.Get(uRL);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                string value = xmlDocument.GetElementsByTagName("assemblyIdentity").Item(0).Attributes["version"].Value;
                result = value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Token: 0x0600081C RID: 2076 RVA: 0x0009E11C File Offset: 0x0009C51C
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetLocalVersion(string savePath)
        {
            while (false)
            {
                //////object arg_0A_0 = null[0];
            }
            string result = "";
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(savePath + "i2TradePlus.Start.exe.manifest");
            for (int i = 0; i < xmlDocument.GetElementsByTagName("asmv1:assemblyIdentity").Count; i++)
            {
                XmlNode xmlNode = xmlDocument.GetElementsByTagName("asmv1:assemblyIdentity").Item(i);
                if (xmlNode.Attributes["name"].Value == "i2TradePlus.Start.exe")
                {
                    result = xmlNode.Attributes["version"].Value;
                    break;
                }
            }
            return result;
        }

        // Token: 0x0600081D RID: 2077 RVA: 0x0009E1E4 File Offset: 0x0009C5E4
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetAppManifestURL(string url)
        {
            while (false)
            {
                //////object arg_0A_0 = null[0];
            }
            string result;
            try
            {
                i2InfoWS.i2API = new Https();
                string uRL = url + "/i2TradePlus.Start.application";
                string xml = i2InfoWS.i2API.Get(uRL);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                string value = xmlDocument.GetElementsByTagName("dependentAssembly").Item(0).Attributes["codebase"].Value;
                result = value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Token: 0x0600081E RID: 2078 RVA: 0x0009E280 File Offset: 0x0009C680
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void GetAppFileList(string url, ref List<string> fileList)
        {
            while (false)
            {
                //////object arg_0A_0 = null[0];
            }
            List<string> list = fileList;
            try
            {
                i2InfoWS.i2API = new Https();
                string xml = i2InfoWS.i2API.Get(url);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);
                for (int i = 0; i < xmlDocument.GetElementsByTagName("dependentAssembly").Count; i++)
                {
                    if (xmlDocument.GetElementsByTagName("dependentAssembly").Item(i).Attributes["codebase"] != null)
                    {
                        list.Add(xmlDocument.GetElementsByTagName("dependentAssembly").Item(i).Attributes["codebase"].Value);
                    }
                }
                for (int i = 0; i < xmlDocument.GetElementsByTagName("file").Count; i++)
                {
                    if (xmlDocument.GetElementsByTagName("file").Item(i).Attributes["name"] != null)
                    {
                        list.Add(xmlDocument.GetElementsByTagName("file").Item(i).Attributes["name"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Token: 0x0600081F RID: 2079 RVA: 0x0009E3F4 File Offset: 0x0009C7F4
        [MethodImpl(MethodImplOptions.NoInlining)]
        public i2InfoWS()
            : base()
        {
            while (false)
            {
                //////object arg_0A_0 = null[0];
            }
            QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();

        }

        // Token: 0x06000820 RID: 2080 RVA: 0x0009E410 File Offset: 0x0009C810
        [MethodImpl(MethodImplOptions.NoInlining)]
        static i2InfoWS()
        {
            // Note: this type is marked as 'beforefieldinit'.
            while (false)
            {
                //////object arg_0A_0 = null[0];
            }
            QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
            i2InfoWS.Hostproxy = string.Empty;
            i2InfoWS.Portproxy = string.Empty;
            i2InfoWS.Usernameproxy = string.Empty;
            i2InfoWS.Passwordproxy = string.Empty;
            i2InfoWS.MBKET_I2INFO_URL = string.Empty;
            i2InfoWS.CNS_I2INFO_URL = string.Empty;
            i2InfoWS.ASP_I2INFO_URL = string.Empty;
            i2InfoWS.STI_I2INFO_URL = "http://203.145.118.18/i2Trade";
            i2InfoWS.I2INFO_URL = "http://203.145.118.18/i2Trade";
            i2InfoWS.BrokerId = 0;
            //i2InfoWS.proxy = null;
        }

        // Token: 0x040004E7 RID: 1255
        public const string DEVICE = "P";

        // Token: 0x040004E8 RID: 1256
        public const string WS_TYPE = "ashx";

        // Token: 0x040004E9 RID: 1257
        public const int BROKER_CNS = 1;

        // Token: 0x040004EA RID: 1258
        public const int BROKER_KTZ = 2;

        // Token: 0x040004EB RID: 1259
        public const int BROKER_BFIT = 3;

        // Token: 0x040004EC RID: 1260
        public const int BROKER_KIMENG = 4;

        // Token: 0x040004ED RID: 1261
        public const int BROKER_AIRA = 7;

        // Token: 0x040004EE RID: 1262
        public const int BROKER_ASIA_PLUS = 8;

        // Token: 0x040004EF RID: 1263
        public static string Hostproxy;

        // Token: 0x040004F0 RID: 1264
        public static string Portproxy;

        // Token: 0x040004F1 RID: 1265
        public static string Usernameproxy;

        // Token: 0x040004F2 RID: 1266
        public static string Passwordproxy;

        // Token: 0x040004F3 RID: 1267
        private static Https i2API;

        // Token: 0x040004F4 RID: 1268
        public static string MBKET_I2INFO_URL;

        // Token: 0x040004F5 RID: 1269
        public static string CNS_I2INFO_URL;

        // Token: 0x040004F6 RID: 1270
        public static string ASP_I2INFO_URL;

        // Token: 0x040004F7 RID: 1271
        public static string STI_I2INFO_URL;

        // Token: 0x040004F8 RID: 1272
        public static string I2INFO_URL;

        // Token: 0x040004F9 RID: 1273
        public static int BrokerId;

        // Token: 0x040004FA RID: 1274
        //private static WebProxy proxy;
    }
}
