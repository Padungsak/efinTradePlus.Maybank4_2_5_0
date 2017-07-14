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
	// Token: 0x020002AE RID: 686
	[XmlSchemaProvider("GetTypedDataSetSchema"), HelpKeyword("vs.data.DataSet"), ToolboxItem(true), XmlRoot("OrderQueueDS"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DesignerCategory("code")]
	[Serializable]
	public class OrderQueueDS : DataSet
	{
		// Token: 0x060017D8 RID: 6104 RVA: 0x00144974 File Offset: 0x00142D74
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrderQueueDS() : base()
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

		// Token: 0x060017D9 RID: 6105 RVA: 0x001449E0 File Offset: 0x00142DE0
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected OrderQueueDS(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
					if (dataSet.Tables["OrderRecord"] != null)
					{
						base.Tables.Add(new OrderQueueDS.OrderRecordDataTable(dataSet.Tables["OrderRecord"]));
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

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x00144B90 File Offset: 0x00142F90
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode]
		public OrderQueueDS.OrderRecordDataTable OrderRecord
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableOrderRecord;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x00144BBC File Offset: 0x00142FBC
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x00144BE8 File Offset: 0x00142FE8
		[DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(true)]
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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00144C00 File Offset: 0x00143000
		[DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x00144C2C File Offset: 0x0014302C
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

		// Token: 0x060017DF RID: 6111 RVA: 0x00144C58 File Offset: 0x00143058
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

		// Token: 0x060017E0 RID: 6112 RVA: 0x00144C80 File Offset: 0x00143080
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DataSet Clone()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			OrderQueueDS orderQueueDS = (OrderQueueDS)base.Clone();
			orderQueueDS.InitVars();
			orderQueueDS.SchemaSerializationMode = this.SchemaSerializationMode;
			return orderQueueDS;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00144CC4 File Offset: 0x001430C4
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

		// Token: 0x060017E2 RID: 6114 RVA: 0x00144CE8 File Offset: 0x001430E8
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

		// Token: 0x060017E3 RID: 6115 RVA: 0x00144D0C File Offset: 0x0014310C
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
				if (dataSet.Tables["OrderRecord"] != null)
				{
					base.Tables.Add(new OrderQueueDS.OrderRecordDataTable(dataSet.Tables["OrderRecord"]));
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

		// Token: 0x060017E4 RID: 6116 RVA: 0x00144E08 File Offset: 0x00143208
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

		// Token: 0x060017E5 RID: 6117 RVA: 0x00144E54 File Offset: 0x00143254
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

		// Token: 0x060017E6 RID: 6118 RVA: 0x00144E70 File Offset: 0x00143270
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InitVars(bool initTable)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tableOrderRecord = (OrderQueueDS.OrderRecordDataTable)base.Tables["OrderRecord"];
			if (initTable)
			{
				if (this.tableOrderRecord != null)
				{
					this.tableOrderRecord.InitVars();
				}
			}
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00144ED4 File Offset: 0x001432D4
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitClass()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.DataSetName = "OrderQueueDS";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/OrderQueueDS.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableOrderRecord = new OrderQueueDS.OrderRecordDataTable();
			base.Tables.Add(this.tableOrderRecord);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00144F44 File Offset: 0x00143344
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeOrderRecord()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00144F68 File Offset: 0x00143368
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

		// Token: 0x060017EA RID: 6122 RVA: 0x00144FA0 File Offset: 0x001433A0
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			OrderQueueDS orderQueueDS = new OrderQueueDS();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = orderQueueDS.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = orderQueueDS.GetSchemaSerializable();
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

		// Token: 0x04000BFD RID: 3069
		private OrderQueueDS.OrderRecordDataTable tableOrderRecord;

		// Token: 0x04000BFE RID: 3070
		private SchemaSerializationMode _schemaSerializationMode;

		// Token: 0x020002AF RID: 687
		// (Invoke) Token: 0x060017EC RID: 6124
		public delegate void OrderRecordRowChangeEventHandler(object sender, OrderQueueDS.OrderRecordRowChangeEvent e);

		// Token: 0x020002B0 RID: 688
		[XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[Serializable]
		public class OrderRecordDataTable : DataTable, IEnumerable
		{
			// Token: 0x060017EF RID: 6127 RVA: 0x00145170 File Offset: 0x00143570
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public OrderRecordDataTable() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = "OrderRecord";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060017F0 RID: 6128 RVA: 0x001451B0 File Offset: 0x001435B0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal OrderRecordDataTable(DataTable table) : base()
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

			// Token: 0x060017F1 RID: 6129 RVA: 0x00145294 File Offset: 0x00143694
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected OrderRecordDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.InitVars();
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x060017F2 RID: 6130 RVA: 0x001452BC File Offset: 0x001436BC
			[DebuggerNonUserCode]
			public DataColumn sideColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnside;
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x060017F3 RID: 6131 RVA: 0x001452E8 File Offset: 0x001436E8
			[DebuggerNonUserCode]
			public DataColumn stockColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnstock;
				}
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00145314 File Offset: 0x00143714
			[DebuggerNonUserCode]
			public DataColumn ttfColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnttf;
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x060017F5 RID: 6133 RVA: 0x00145340 File Offset: 0x00143740
			[DebuggerNonUserCode]
			public DataColumn volumeColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnvolume;
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0014536C File Offset: 0x0014376C
			[DebuggerNonUserCode]
			public DataColumn priceColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnprice;
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00145398 File Offset: 0x00143798
			[DebuggerNonUserCode]
			public DataColumn pubvolColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnpubvol;
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x060017F8 RID: 6136 RVA: 0x001453C4 File Offset: 0x001437C4
			[DebuggerNonUserCode]
			public DataColumn conditionColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columncondition;
				}
			}

			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x060017F9 RID: 6137 RVA: 0x001453F0 File Offset: 0x001437F0
			[DebuggerNonUserCode]
			public DataColumn depositColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columndeposit;
				}
			}

			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x060017FA RID: 6138 RVA: 0x0014541C File Offset: 0x0014381C
			[DebuggerNonUserCode, Browsable(false)]
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

			// Token: 0x170002C4 RID: 708
			[DebuggerNonUserCode]
			public OrderQueueDS.OrderRecordRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (OrderQueueDS.OrderRecordRow)base.Rows[index];
				}
			}

			// Token: 0x140000F3 RID: 243
			// (add) Token: 0x060017FC RID: 6140 RVA: 0x00145480 File Offset: 0x00143880
			// (remove) Token: 0x060017FD RID: 6141 RVA: 0x001454A8 File Offset: 0x001438A8
			public OrderQueueDS.OrderRecordRowChangeEventHandler _OrderRecordRowChanging;
			public event OrderQueueDS.OrderRecordRowChangeEventHandler OrderRecordRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._OrderRecordRowChanging += value;
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._OrderRecordRowChanging -= value;
				}
			}

			// Token: 0x140000F4 RID: 244
			// (add) Token: 0x060017FE RID: 6142 RVA: 0x001454D0 File Offset: 0x001438D0
			// (remove) Token: 0x060017FF RID: 6143 RVA: 0x001454F8 File Offset: 0x001438F8
			public OrderQueueDS.OrderRecordRowChangeEventHandler _OrderRecordRowChanged;
			public event OrderQueueDS.OrderRecordRowChangeEventHandler OrderRecordRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._OrderRecordRowChanged += value;
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._OrderRecordRowChanged -= value;
                }
			}

			// Token: 0x140000F5 RID: 245
			// (add) Token: 0x06001800 RID: 6144 RVA: 0x00145520 File Offset: 0x00143920
			// (remove) Token: 0x06001801 RID: 6145 RVA: 0x00145548 File Offset: 0x00143948
			public OrderQueueDS.OrderRecordRowChangeEventHandler _OrderRecordRowDeleting;
			public event OrderQueueDS.OrderRecordRowChangeEventHandler OrderRecordRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
                    this._OrderRecordRowDeleting += value;
                }
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._OrderRecordRowDeleting -= value;
				}
			}

			// Token: 0x140000F6 RID: 246
			// (add) Token: 0x06001802 RID: 6146 RVA: 0x00145570 File Offset: 0x00143970
			// (remove) Token: 0x06001803 RID: 6147 RVA: 0x00145598 File Offset: 0x00143998
            public OrderQueueDS.OrderRecordRowChangeEventHandler _OrderRecordRowDeleted;
			public event OrderQueueDS.OrderRecordRowChangeEventHandler OrderRecordRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					this._OrderRecordRowDeleted +=  value;
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
                    this._OrderRecordRowDeleted -= value;
                }
			}

			// Token: 0x06001804 RID: 6148 RVA: 0x001455C0 File Offset: 0x001439C0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddOrderRecordRow(OrderQueueDS.OrderRecordRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x06001805 RID: 6149 RVA: 0x001455E0 File Offset: 0x001439E0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public OrderQueueDS.OrderRecordRow AddOrderRecordRow(string side, string stock, string ttf, string volume, string price, string pubvol, string condition, string deposit)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				OrderQueueDS.OrderRecordRow orderRecordRow = (OrderQueueDS.OrderRecordRow)base.NewRow();
				object[] itemArray = new object[]
				{
					side,
					stock,
					ttf,
					volume,
					price,
					pubvol,
					condition,
					deposit
				};
				orderRecordRow.ItemArray = itemArray;
				base.Rows.Add(orderRecordRow);
				return orderRecordRow;
			}

			// Token: 0x06001806 RID: 6150 RVA: 0x00145654 File Offset: 0x00143A54
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

			// Token: 0x06001807 RID: 6151 RVA: 0x00145684 File Offset: 0x00143A84
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				OrderQueueDS.OrderRecordDataTable orderRecordDataTable = (OrderQueueDS.OrderRecordDataTable)base.Clone();
				orderRecordDataTable.InitVars();
				return orderRecordDataTable;
			}

			// Token: 0x06001808 RID: 6152 RVA: 0x001456BC File Offset: 0x00143ABC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new OrderQueueDS.OrderRecordDataTable();
			}

			// Token: 0x06001809 RID: 6153 RVA: 0x001456E4 File Offset: 0x00143AE4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnside = base.Columns["side"];
				this.columnstock = base.Columns["stock"];
				this.columnttf = base.Columns["ttf"];
				this.columnvolume = base.Columns["volume"];
				this.columnprice = base.Columns["price"];
				this.columnpubvol = base.Columns["pubvol"];
				this.columncondition = base.Columns["condition"];
				this.columndeposit = base.Columns["deposit"];
			}

			// Token: 0x0600180A RID: 6154 RVA: 0x001457B0 File Offset: 0x00143BB0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnside = new DataColumn("side", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnside);
				this.columnstock = new DataColumn("stock", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnstock);
				this.columnttf = new DataColumn("ttf", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnttf);
				this.columnvolume = new DataColumn("volume", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnvolume);
				this.columnprice = new DataColumn("price", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnprice);
				this.columnpubvol = new DataColumn("pubvol", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnpubvol);
				this.columncondition = new DataColumn("condition", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncondition);
				this.columndeposit = new DataColumn("deposit", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndeposit);
				this.columnside.DefaultValue = "";
				this.columnstock.DefaultValue = "";
				this.columnttf.DefaultValue = "";
				this.columnvolume.DefaultValue = "";
				this.columnprice.DefaultValue = "";
				this.columnpubvol.DefaultValue = "";
				this.columncondition.DefaultValue = "";
				this.columndeposit.DefaultValue = "";
			}

			// Token: 0x0600180B RID: 6155 RVA: 0x001459C4 File Offset: 0x00143DC4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public OrderQueueDS.OrderRecordRow NewOrderRecordRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (OrderQueueDS.OrderRecordRow)base.NewRow();
			}

			// Token: 0x0600180C RID: 6156 RVA: 0x001459F4 File Offset: 0x00143DF4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new OrderQueueDS.OrderRecordRow(builder);
			}

			// Token: 0x0600180D RID: 6157 RVA: 0x00145A20 File Offset: 0x00143E20
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(OrderQueueDS.OrderRecordRow);
			}

			// Token: 0x0600180E RID: 6158 RVA: 0x00145A50 File Offset: 0x00143E50
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this._OrderRecordRowChanged != null)
				{
					this._OrderRecordRowChanged(this, new OrderQueueDS.OrderRecordRowChangeEvent((OrderQueueDS.OrderRecordRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600180F RID: 6159 RVA: 0x00145AAC File Offset: 0x00143EAC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this._OrderRecordRowChanging != null)
				{
					this._OrderRecordRowChanging(this, new OrderQueueDS.OrderRecordRowChangeEvent((OrderQueueDS.OrderRecordRow)e.Row, e.Action));
				}
			}

			// Token: 0x06001810 RID: 6160 RVA: 0x00145B08 File Offset: 0x00143F08
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this._OrderRecordRowDeleted != null)
				{
					this._OrderRecordRowDeleted(this, new OrderQueueDS.OrderRecordRowChangeEvent((OrderQueueDS.OrderRecordRow)e.Row, e.Action));
				}
			}

			// Token: 0x06001811 RID: 6161 RVA: 0x00145B64 File Offset: 0x00143F64
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this._OrderRecordRowDeleting != null)
				{
					this._OrderRecordRowDeleting(this, new OrderQueueDS.OrderRecordRowChangeEvent((OrderQueueDS.OrderRecordRow)e.Row, e.Action));
				}
			}

			// Token: 0x06001812 RID: 6162 RVA: 0x00145BC0 File Offset: 0x00143FC0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveOrderRecordRow(OrderQueueDS.OrderRecordRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x06001813 RID: 6163 RVA: 0x00145BE0 File Offset: 0x00143FE0
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
				OrderQueueDS orderQueueDS = new OrderQueueDS();
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
				xmlSchemaAttribute.FixedValue = orderQueueDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "OrderRecordDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = orderQueueDS.GetSchemaSerializable();
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

			// Token: 0x04000BFF RID: 3071
			private DataColumn columnside;

			// Token: 0x04000C00 RID: 3072
			private DataColumn columnstock;

			// Token: 0x04000C01 RID: 3073
			private DataColumn columnttf;

			// Token: 0x04000C02 RID: 3074
			private DataColumn columnvolume;

			// Token: 0x04000C03 RID: 3075
			private DataColumn columnprice;

			// Token: 0x04000C04 RID: 3076
			private DataColumn columnpubvol;

			// Token: 0x04000C05 RID: 3077
			private DataColumn columncondition;

			// Token: 0x04000C06 RID: 3078
			private DataColumn columndeposit;
		}

		// Token: 0x020002B1 RID: 689
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class OrderRecordRow : DataRow
		{
			// Token: 0x06001814 RID: 6164 RVA: 0x00145E70 File Offset: 0x00144270
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal OrderRecordRow(DataRowBuilder rb) : base(rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.tableOrderRecord = (OrderQueueDS.OrderRecordDataTable)base.Table;
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x06001815 RID: 6165 RVA: 0x00145EA0 File Offset: 0x001442A0
			// (set) Token: 0x06001816 RID: 6166 RVA: 0x00145EFC File Offset: 0x001442FC
			[DebuggerNonUserCode]
			public string side
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableOrderRecord.sideColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'side' in table 'OrderRecord' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableOrderRecord.sideColumn] = value;
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x06001817 RID: 6167 RVA: 0x00145F20 File Offset: 0x00144320
			// (set) Token: 0x06001818 RID: 6168 RVA: 0x00145F7C File Offset: 0x0014437C
			[DebuggerNonUserCode]
			public string stock
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableOrderRecord.stockColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'stock' in table 'OrderRecord' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableOrderRecord.stockColumn] = value;
				}
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x06001819 RID: 6169 RVA: 0x00145FA0 File Offset: 0x001443A0
			// (set) Token: 0x0600181A RID: 6170 RVA: 0x00145FFC File Offset: 0x001443FC
			[DebuggerNonUserCode]
			public string ttf
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableOrderRecord.ttfColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ttf' in table 'OrderRecord' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableOrderRecord.ttfColumn] = value;
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x0600181B RID: 6171 RVA: 0x00146020 File Offset: 0x00144420
			// (set) Token: 0x0600181C RID: 6172 RVA: 0x0014607C File Offset: 0x0014447C
			[DebuggerNonUserCode]
			public string volume
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableOrderRecord.volumeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'volume' in table 'OrderRecord' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableOrderRecord.volumeColumn] = value;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x0600181D RID: 6173 RVA: 0x001460A0 File Offset: 0x001444A0
			// (set) Token: 0x0600181E RID: 6174 RVA: 0x001460FC File Offset: 0x001444FC
			[DebuggerNonUserCode]
			public string price
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableOrderRecord.priceColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'price' in table 'OrderRecord' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableOrderRecord.priceColumn] = value;
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x0600181F RID: 6175 RVA: 0x00146120 File Offset: 0x00144520
			// (set) Token: 0x06001820 RID: 6176 RVA: 0x0014617C File Offset: 0x0014457C
			[DebuggerNonUserCode]
			public string pubvol
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableOrderRecord.pubvolColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'pubvol' in table 'OrderRecord' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableOrderRecord.pubvolColumn] = value;
				}
			}

			// Token: 0x170002CB RID: 715
			// (get) Token: 0x06001821 RID: 6177 RVA: 0x001461A0 File Offset: 0x001445A0
			// (set) Token: 0x06001822 RID: 6178 RVA: 0x001461FC File Offset: 0x001445FC
			[DebuggerNonUserCode]
			public string condition
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableOrderRecord.conditionColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'condition' in table 'OrderRecord' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableOrderRecord.conditionColumn] = value;
				}
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x06001823 RID: 6179 RVA: 0x00146220 File Offset: 0x00144620
			// (set) Token: 0x06001824 RID: 6180 RVA: 0x0014627C File Offset: 0x0014467C
			[DebuggerNonUserCode]
			public string deposit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					try
					{
						result = (string)base[this.tableOrderRecord.depositColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'deposit' in table 'OrderRecord' is DBNull.", innerException);
					}
					return result;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					base[this.tableOrderRecord.depositColumn] = value;
				}
			}

			// Token: 0x06001825 RID: 6181 RVA: 0x001462A0 File Offset: 0x001446A0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IssideNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableOrderRecord.sideColumn);
			}

			// Token: 0x06001826 RID: 6182 RVA: 0x001462D4 File Offset: 0x001446D4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetsideNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableOrderRecord.sideColumn] = Convert.DBNull;
			}

			// Token: 0x06001827 RID: 6183 RVA: 0x001462FC File Offset: 0x001446FC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsstockNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableOrderRecord.stockColumn);
			}

			// Token: 0x06001828 RID: 6184 RVA: 0x00146330 File Offset: 0x00144730
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetstockNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableOrderRecord.stockColumn] = Convert.DBNull;
			}

			// Token: 0x06001829 RID: 6185 RVA: 0x00146358 File Offset: 0x00144758
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsttfNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableOrderRecord.ttfColumn);
			}

			// Token: 0x0600182A RID: 6186 RVA: 0x0014638C File Offset: 0x0014478C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetttfNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableOrderRecord.ttfColumn] = Convert.DBNull;
			}

			// Token: 0x0600182B RID: 6187 RVA: 0x001463B4 File Offset: 0x001447B4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsvolumeNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableOrderRecord.volumeColumn);
			}

			// Token: 0x0600182C RID: 6188 RVA: 0x001463E8 File Offset: 0x001447E8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetvolumeNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableOrderRecord.volumeColumn] = Convert.DBNull;
			}

			// Token: 0x0600182D RID: 6189 RVA: 0x00146410 File Offset: 0x00144810
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IspriceNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableOrderRecord.priceColumn);
			}

			// Token: 0x0600182E RID: 6190 RVA: 0x00146444 File Offset: 0x00144844
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetpriceNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableOrderRecord.priceColumn] = Convert.DBNull;
			}

			// Token: 0x0600182F RID: 6191 RVA: 0x0014646C File Offset: 0x0014486C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IspubvolNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableOrderRecord.pubvolColumn);
			}

			// Token: 0x06001830 RID: 6192 RVA: 0x001464A0 File Offset: 0x001448A0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetpubvolNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableOrderRecord.pubvolColumn] = Convert.DBNull;
			}

			// Token: 0x06001831 RID: 6193 RVA: 0x001464C8 File Offset: 0x001448C8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsconditionNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableOrderRecord.conditionColumn);
			}

			// Token: 0x06001832 RID: 6194 RVA: 0x001464FC File Offset: 0x001448FC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetconditionNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableOrderRecord.conditionColumn] = Convert.DBNull;
			}

			// Token: 0x06001833 RID: 6195 RVA: 0x00146524 File Offset: 0x00144924
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsdepositNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableOrderRecord.depositColumn);
			}

			// Token: 0x06001834 RID: 6196 RVA: 0x00146558 File Offset: 0x00144958
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetdepositNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableOrderRecord.depositColumn] = Convert.DBNull;
			}

			// Token: 0x04000C0B RID: 3083
			private OrderQueueDS.OrderRecordDataTable tableOrderRecord;
		}

		// Token: 0x020002B2 RID: 690
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class OrderRecordRowChangeEvent : EventArgs
		{
			// Token: 0x06001835 RID: 6197 RVA: 0x00146580 File Offset: 0x00144980
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public OrderRecordRowChangeEvent(OrderQueueDS.OrderRecordRow row, DataRowAction action) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x06001836 RID: 6198 RVA: 0x001465AC File Offset: 0x001449AC
			[DebuggerNonUserCode]
			public OrderQueueDS.OrderRecordRow Row
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

			// Token: 0x170002CE RID: 718
			// (get) Token: 0x06001837 RID: 6199 RVA: 0x001465D8 File Offset: 0x001449D8
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

			// Token: 0x04000C0C RID: 3084
			private OrderQueueDS.OrderRecordRow eventRow;

			// Token: 0x04000C0D RID: 3085
			private DataRowAction eventAction;
		}
	}
}
