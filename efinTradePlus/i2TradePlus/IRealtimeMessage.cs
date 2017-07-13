using System;
using i2TradePlus.Information;
using ITSNet.Common.BIZ;

namespace i2TradePlus
{
	// Token: 0x02000015 RID: 21
	internal interface IRealtimeMessage
	{
		// Token: 0x0600009A RID: 154
		void ReceiveMessage(IBroadcastMessage message, StockList.StockInformation realtimeStockInfo);

		// Token: 0x0600009B RID: 155
		void ReceiveTfexMessage(IBroadcastMessage message, SeriesList.SeriesInformation realtimeSeriesInfo);
	}
}
