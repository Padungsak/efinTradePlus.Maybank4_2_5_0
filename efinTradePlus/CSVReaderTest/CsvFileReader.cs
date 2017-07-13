using System;
using System.IO;
using System.Runtime.CompilerServices;
using Abv9LVGLme6DnuTi2C;

namespace CSVReaderTest
{
	// Token: 0x020000F3 RID: 243
	public class CsvFileReader : StreamReader
	{
		// Token: 0x06000B65 RID: 2917 RVA: 0x000CFAE8 File Offset: 0x000CDEE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CsvFileReader(Stream stream) : base(stream)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000CFB08 File Offset: 0x000CDF08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CsvFileReader(string filename) : base(filename)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000CFB28 File Offset: 0x000CDF28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ReadRow(CsvRow row)
		{
			while (false)
			{
				////object arg_0A_0 = null[0];
			}
			row.LineText = this.ReadLine();
			bool result;
			if (string.IsNullOrEmpty(row.LineText))
			{
				result = false;
			}
			else
			{
				int i = 0;
				int num = 0;
				while (i < row.LineText.Length)
				{
					string text;
					if (row.LineText[i] == '"')
					{
						i++;
						int num2 = i;
						while (i < row.LineText.Length)
						{
							if (row.LineText[i] == '"')
							{
								i++;
								if (i >= row.LineText.Length || row.LineText[i] != '"')
								{
									i--;
									break;
								}
							}
							i++;
						}
						text = row.LineText.Substring(num2, i - num2);
						text = text.Replace("\"\"", "\"");
					}
					else
					{
						int num2 = i;
						while (i < row.LineText.Length && row.LineText[i] != ',')
						{
							i++;
						}
						text = row.LineText.Substring(num2, i - num2);
					}
					if (num < row.Count)
					{
						row[num] = text;
					}
					else
					{
						row.Add(text);
					}
					num++;
					while (i < row.LineText.Length && row.LineText[i] != ',')
					{
						i++;
					}
					if (i < row.LineText.Length)
					{
						i++;
					}
				}
				while (row.Count > num)
				{
					row.RemoveAt(num);
				}
				result = (row.Count > 0);
			}
			return result;
		}
	}
}
