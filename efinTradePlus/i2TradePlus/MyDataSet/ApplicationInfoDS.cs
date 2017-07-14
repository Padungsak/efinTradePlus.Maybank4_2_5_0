using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Abv9LVGLme6DnuTi2C;

namespace i2TradePlus.MyDataSet
{
	// Token: 0x020000CE RID: 206
	[XmlRoot("ApplicationInfoDS"), HelpKeyword("vs.data.DataSet"), ToolboxItem(true), XmlSchemaProvider("GetTypedDataSetSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DesignerCategory("code")]
	[Serializable]
	public class ApplicationInfoDS : DataSet
	{
		// Token: 0x0600097A RID: 2426 RVA: 0x000BCA64 File Offset: 0x000BAE64
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ApplicationInfoDS() : base()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000BCAD0 File Offset: 0x000BAED0
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ApplicationInfoDS(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
			this._schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
			}
			else
			{
				string s = (string)info.GetValue("XmlSchema", typeof(string));
				if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
				{
					DataSet dataSet = new DataSet();
					dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
					if (dataSet.Tables["Info"] != null)
					{
						base.Tables.Add(new ApplicationInfoDS.InfoDataTable(dataSet.Tables["Info"]));
					}
					base.DataSetName = dataSet.DataSetName;
					base.Prefix = dataSet.Prefix;
					base.Namespace = dataSet.Namespace;
					base.Locale = dataSet.Locale;
					base.CaseSensitive = dataSet.CaseSensitive;
					base.EnforceConstraints = dataSet.EnforceConstraints;
					base.Merge(dataSet, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				else
				{
					base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				}
				base.GetSerializationData(info, context);
				CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.SchemaChanged);
				base.Tables.CollectionChanged += value2;
				this.Relations.CollectionChanged += value2;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x000BCC80 File Offset: 0x000BB080
		[Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ApplicationInfoDS.InfoDataTable Info
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableInfo;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000BCCAC File Offset: 0x000BB0AC
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000BCCD8 File Offset: 0x000BB0D8
		[Browsable(true), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this._schemaSerializationMode;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000BCCF0 File Offset: 0x000BB0F0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Tables;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x000BCD1C File Offset: 0x000BB11C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Relations;
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000BCD48 File Offset: 0x000BB148
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitializeDerivedDataSet()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000BCD70 File Offset: 0x000BB170
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DataSet Clone()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ApplicationInfoDS applicationInfoDS = (ApplicationInfoDS)base.Clone();
			applicationInfoDS.InitVars();
			applicationInfoDS.SchemaSerializationMode = this.SchemaSerializationMode;
			return applicationInfoDS;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000BCDB4 File Offset: 0x000BB1B4
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool ShouldSerializeTables()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000BCDD8 File Offset: 0x000BB1D8
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool ShouldSerializeRelations()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000BCDFC File Offset: 0x000BB1FC
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["Info"] != null)
				{
					base.Tables.Add(new ApplicationInfoDS.InfoDataTable(dataSet.Tables["Info"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXml(reader);
				this.InitVars();
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000BCEF8 File Offset: 0x000BB2F8
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override XmlSchema GetSchemaSerializable()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x000BCF44 File Offset: 0x000BB344
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InitVars()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.InitVars(true);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000BCF60 File Offset: 0x000BB360
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InitVars(bool initTable)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tableInfo = (ApplicationInfoDS.InfoDataTable)base.Tables["Info"];
			if (initTable)
			{
				if (this.tableInfo != null)
				{
					this.tableInfo.InitVars();
				}
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000BCFC4 File Offset: 0x000BB3C4
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitClass()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.DataSetName = "ApplicationInfoDS";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/ApplicationInfoDS.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableInfo = new ApplicationInfoDS.InfoDataTable();
			base.Tables.Add(this.tableInfo);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000BD034 File Offset: 0x000BB434
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeInfo()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000BD058 File Offset: 0x000BB458
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000BD090 File Offset: 0x000BB490
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			ApplicationInfoDS applicationInfoDS = new ApplicationInfoDS();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = applicationInfoDS.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = applicationInfoDS.GetSchemaSerializable();
			XmlSchemaComplexType result;
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								result = xmlSchemaComplexType;
								return result;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			result = xmlSchemaComplexType;
			return result;
		}

		// Token: 0x04000682 RID: 1666
		private ApplicationInfoDS.InfoDataTable tableInfo;

		// Token: 0x04000683 RID: 1667
		private SchemaSerializationMode _schemaSerializationMode;

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x0600098E RID: 2446
		public delegate void InfoRowChangeEventHandler(object sender, ApplicationInfoDS.InfoRowChangeEvent e);

		// Token: 0x020000D0 RID: 208
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class InfoDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000991 RID: 2449 RVA: 0x000BD260 File Offset: 0x000BB660
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public InfoDataTable() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = "Info";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000992 RID: 2450 RVA: 0x000BD2A0 File Offset: 0x000BB6A0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal InfoDataTable(DataTable table) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000993 RID: 2451 RVA: 0x000BD384 File Offset: 0x000BB784
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected InfoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.InitVars();
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000994 RID: 2452 RVA: 0x000BD3AC File Offset: 0x000BB7AC
			[DebuggerNonUserCode]
			public DataColumn TPBlinkColorColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnTPBlinkColor;
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000995 RID: 2453 RVA: 0x000BD3D8 File Offset: 0x000BB7D8
			[DebuggerNonUserCode]
			public DataColumn ValidatePolicyColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnValidatePolicy;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000996 RID: 2454 RVA: 0x000BD404 File Offset: 0x000BB804
			[DebuggerNonUserCode]
			public DataColumn AlertEnableColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnAlertEnable;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000997 RID: 2455 RVA: 0x000BD430 File Offset: 0x000BB830
			[DebuggerNonUserCode]
			public DataColumn AlertAutoPopupColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnAlertAutoPopup;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000998 RID: 2456 RVA: 0x000BD45C File Offset: 0x000BB85C
			[DebuggerNonUserCode]
			public DataColumn AlertSoundColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnAlertSound;
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000999 RID: 2457 RVA: 0x000BD488 File Offset: 0x000BB888
			[Browsable(false), DebuggerNonUserCode]
			public int Count
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return base.Rows.Count;
				}
			}

			// Token: 0x17000132 RID: 306
			[DebuggerNonUserCode]
			public ApplicationInfoDS.InfoRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (ApplicationInfoDS.InfoRow)base.Rows[index];
				}
			}

			// Token: 0x1400002A RID: 42
			// (add) Token: 0x0600099B RID: 2459 RVA: 0x000BD4EC File Offset: 0x000BB8EC
			// (remove) Token: 0x0600099C RID: 2460 RVA: 0x000BD514 File Offset: 0x000BB914
            public ApplicationInfoDS.InfoRowChangeEventHandler _InfoRowChanging;
			public event ApplicationInfoDS.InfoRowChangeEventHandler InfoRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._InfoRowChanging += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._InfoRowChanging -= value;
				}
			}

			// Token: 0x1400002B RID: 43
			// (add) Token: 0x0600099D RID: 2461 RVA: 0x000BD53C File Offset: 0x000BB93C
			// (remove) Token: 0x0600099E RID: 2462 RVA: 0x000BD564 File Offset: 0x000BB964
            public ApplicationInfoDS.InfoRowChangeEventHandler _InfoRowChanged;
			public event ApplicationInfoDS.InfoRowChangeEventHandler InfoRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._InfoRowChanged += value;
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._InfoRowChanged -= value;
                }
			}

			// Token: 0x1400002C RID: 44
			// (add) Token: 0x0600099F RID: 2463 RVA: 0x000BD58C File Offset: 0x000BB98C
			// (remove) Token: 0x060009A0 RID: 2464 RVA: 0x000BD5B4 File Offset: 0x000BB9B4
            public ApplicationInfoDS.InfoRowChangeEventHandler _InfoRowDeleting;
			public event ApplicationInfoDS.InfoRowChangeEventHandler InfoRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._InfoRowDeleting += value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._InfoRowDeleting -= value;
				}
			}

			// Token: 0x1400002D RID: 45
			// (add) Token: 0x060009A1 RID: 2465 RVA: 0x000BD5DC File Offset: 0x000BB9DC
			// (remove) Token: 0x060009A2 RID: 2466 RVA: 0x000BD604 File Offset: 0x000BBA04
            public ApplicationInfoDS.InfoRowChangeEventHandler _InfoRowDeleted;
			public event ApplicationInfoDS.InfoRowChangeEventHandler InfoRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{

                    this._InfoRowDeleted += value; 
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._InfoRowDeleted -= value;
                }
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x000BD62C File Offset: 0x000BBA2C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddInfoRow(ApplicationInfoDS.InfoRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x000BD64C File Offset: 0x000BBA4C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ApplicationInfoDS.InfoRow AddInfoRow(string TPBlinkColor, bool ValidatePolicy, bool AlertEnable, bool AlertAutoPopup, bool AlertSound)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfoDS.InfoRow infoRow = (ApplicationInfoDS.InfoRow)base.NewRow();
				object[] itemArray = new object[]
				{
					TPBlinkColor,
					ValidatePolicy,
					AlertEnable,
					AlertAutoPopup,
					AlertSound
				};
				infoRow.ItemArray = itemArray;
				base.Rows.Add(infoRow);
				return infoRow;
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x000BD6C4 File Offset: 0x000BBAC4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual IEnumerator GetEnumerator()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.Rows.GetEnumerator();
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x000BD6F4 File Offset: 0x000BBAF4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				ApplicationInfoDS.InfoDataTable infoDataTable = (ApplicationInfoDS.InfoDataTable)base.Clone();
				infoDataTable.InitVars();
				return infoDataTable;
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x000BD72C File Offset: 0x000BBB2C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new ApplicationInfoDS.InfoDataTable();
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x000BD754 File Offset: 0x000BBB54
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnTPBlinkColor = base.Columns["TPBlinkColor"];
				this.columnValidatePolicy = base.Columns["ValidatePolicy"];
				this.columnAlertEnable = base.Columns["AlertEnable"];
				this.columnAlertAutoPopup = base.Columns["AlertAutoPopup"];
				this.columnAlertSound = base.Columns["AlertSound"];
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x000BD7E0 File Offset: 0x000BBBE0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnTPBlinkColor = new DataColumn("TPBlinkColor", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTPBlinkColor);
				this.columnValidatePolicy = new DataColumn("ValidatePolicy", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnValidatePolicy);
				this.columnAlertEnable = new DataColumn("AlertEnable", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnAlertEnable);
				this.columnAlertAutoPopup = new DataColumn("AlertAutoPopup", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnAlertAutoPopup);
				this.columnAlertSound = new DataColumn("AlertSound", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnAlertSound);
				this.columnTPBlinkColor.AllowDBNull = false;
				this.columnTPBlinkColor.DefaultValue = "";
				this.columnValidatePolicy.AllowDBNull = false;
				this.columnValidatePolicy.DefaultValue = false;
				this.columnAlertEnable.AllowDBNull = false;
				this.columnAlertEnable.DefaultValue = false;
				this.columnAlertAutoPopup.AllowDBNull = false;
				this.columnAlertAutoPopup.DefaultValue = false;
				this.columnAlertSound.AllowDBNull = false;
				this.columnAlertSound.DefaultValue = true;
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x000BD97C File Offset: 0x000BBD7C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ApplicationInfoDS.InfoRow NewInfoRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (ApplicationInfoDS.InfoRow)base.NewRow();
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x000BD9AC File Offset: 0x000BBDAC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new ApplicationInfoDS.InfoRow(builder);
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x000BD9D8 File Offset: 0x000BBDD8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(ApplicationInfoDS.InfoRow);
			}

			// Token: 0x060009AD RID: 2477 RVA: 0x000BDA08 File Offset: 0x000BBE08
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this._InfoRowChanged != null)
				{
					this._InfoRowChanged(this, new ApplicationInfoDS.InfoRowChangeEvent((ApplicationInfoDS.InfoRow)e.Row, e.Action));
				}
			}

			// Token: 0x060009AE RID: 2478 RVA: 0x000BDA64 File Offset: 0x000BBE64
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this._InfoRowChanging != null)
				{
					this._InfoRowChanging(this, new ApplicationInfoDS.InfoRowChangeEvent((ApplicationInfoDS.InfoRow)e.Row, e.Action));
				}
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x000BDAC0 File Offset: 0x000BBEC0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this._InfoRowDeleted != null)
				{
					this._InfoRowDeleted(this, new ApplicationInfoDS.InfoRowChangeEvent((ApplicationInfoDS.InfoRow)e.Row, e.Action));
				}
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x000BDB1C File Offset: 0x000BBF1C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this._InfoRowDeleting != null)
				{
					this._InfoRowDeleting(this, new ApplicationInfoDS.InfoRowChangeEvent((ApplicationInfoDS.InfoRow)e.Row, e.Action));
				}
			}

			// Token: 0x060009B1 RID: 2481 RVA: 0x000BDB78 File Offset: 0x000BBF78
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveInfoRow(ApplicationInfoDS.InfoRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x000BDB98 File Offset: 0x000BBF98
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				ApplicationInfoDS applicationInfoDS = new ApplicationInfoDS();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = 79228162514264337593543950335m;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = applicationInfoDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "InfoDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = applicationInfoDS.GetSchemaSerializable();
				XmlSchemaComplexType result;
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							XmlSchema xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									result = xmlSchemaComplexType;
									return result;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				result = xmlSchemaComplexType;
				return result;
			}

			// Token: 0x04000684 RID: 1668
			private DataColumn columnTPBlinkColor;

			// Token: 0x04000685 RID: 1669
			private DataColumn columnValidatePolicy;

			// Token: 0x04000686 RID: 1670
			private DataColumn columnAlertEnable;

			// Token: 0x04000687 RID: 1671
			private DataColumn columnAlertAutoPopup;

			// Token: 0x04000688 RID: 1672
			private DataColumn columnAlertSound;
		}

		// Token: 0x020000D1 RID: 209
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class InfoRow : DataRow
		{
			// Token: 0x060009B3 RID: 2483 RVA: 0x000BDE28 File Offset: 0x000BC228
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal InfoRow(DataRowBuilder rb) : base(rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.tableInfo = (ApplicationInfoDS.InfoDataTable)base.Table;
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000BDE58 File Offset: 0x000BC258
			// (set) Token: 0x060009B5 RID: 2485 RVA: 0x000BDE94 File Offset: 0x000BC294
			[DebuggerNonUserCode]
			public string TPBlinkColor
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (string)base[this.tableInfo.TPBlinkColorColumn];
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableInfo.TPBlinkColorColumn] = value;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060009B6 RID: 2486 RVA: 0x000BDEB8 File Offset: 0x000BC2B8
			// (set) Token: 0x060009B7 RID: 2487 RVA: 0x000BDEF4 File Offset: 0x000BC2F4
			[DebuggerNonUserCode]
			public bool ValidatePolicy
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (bool)base[this.tableInfo.ValidatePolicyColumn];
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableInfo.ValidatePolicyColumn] = value;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060009B8 RID: 2488 RVA: 0x000BDF20 File Offset: 0x000BC320
			// (set) Token: 0x060009B9 RID: 2489 RVA: 0x000BDF5C File Offset: 0x000BC35C
			[DebuggerNonUserCode]
			public bool AlertEnable
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (bool)base[this.tableInfo.AlertEnableColumn];
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableInfo.AlertEnableColumn] = value;
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060009BA RID: 2490 RVA: 0x000BDF88 File Offset: 0x000BC388
			// (set) Token: 0x060009BB RID: 2491 RVA: 0x000BDFC4 File Offset: 0x000BC3C4
			[DebuggerNonUserCode]
			public bool AlertAutoPopup
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (bool)base[this.tableInfo.AlertAutoPopupColumn];
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableInfo.AlertAutoPopupColumn] = value;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060009BC RID: 2492 RVA: 0x000BDFF0 File Offset: 0x000BC3F0
			// (set) Token: 0x060009BD RID: 2493 RVA: 0x000BE02C File Offset: 0x000BC42C
			[DebuggerNonUserCode]
			public bool AlertSound
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (bool)base[this.tableInfo.AlertSoundColumn];
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableInfo.AlertSoundColumn] = value;
				}
			}

			// Token: 0x0400068D RID: 1677
			private ApplicationInfoDS.InfoDataTable tableInfo;
		}

		// Token: 0x020000D2 RID: 210
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class InfoRowChangeEvent : EventArgs
		{
			// Token: 0x060009BE RID: 2494 RVA: 0x000BE058 File Offset: 0x000BC458
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public InfoRowChangeEvent(ApplicationInfoDS.InfoRow row, DataRowAction action) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060009BF RID: 2495 RVA: 0x000BE084 File Offset: 0x000BC484
			[DebuggerNonUserCode]
			public ApplicationInfoDS.InfoRow Row
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventRow;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060009C0 RID: 2496 RVA: 0x000BE0B0 File Offset: 0x000BC4B0
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.eventAction;
				}
			}

			// Token: 0x0400068E RID: 1678
			private ApplicationInfoDS.InfoRow eventRow;

			// Token: 0x0400068F RID: 1679
			private DataRowAction eventAction;
		}
	}
}
