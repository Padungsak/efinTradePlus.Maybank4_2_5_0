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
	// Token: 0x020000DF RID: 223
	[DesignerCategory("code"), HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema"), ToolboxItem(true), XmlRoot("UserWorkingProfileDS"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[Serializable]
	public class UserWorkingProfileDS : DataSet
	{
		// Token: 0x06000A76 RID: 2678 RVA: 0x000C4794 File Offset: 0x000C2B94
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public UserWorkingProfileDS() : base()
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

		// Token: 0x06000A77 RID: 2679 RVA: 0x000C4800 File Offset: 0x000C2C00
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected UserWorkingProfileDS(SerializationInfo info, StreamingContext context) : base(info, context, false)
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
					if (dataSet.Tables["TemplateRoots"] != null)
					{
						base.Tables.Add(new UserWorkingProfileDS.TemplateRootsDataTable(dataSet.Tables["TemplateRoots"]));
					}
					if (dataSet.Tables["TemplateItem"] != null)
					{
						base.Tables.Add(new UserWorkingProfileDS.TemplateItemDataTable(dataSet.Tables["TemplateItem"]));
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

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x000C49F0 File Offset: 0x000C2DF0
		[DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public UserWorkingProfileDS.TemplateRootsDataTable TemplateRoots
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableTemplateRoots;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000C4A1C File Offset: 0x000C2E1C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
		public UserWorkingProfileDS.TemplateItemDataTable TemplateItem
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return this.tableTemplateItem;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x000C4A48 File Offset: 0x000C2E48
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x000C4A74 File Offset: 0x000C2E74
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(true), DebuggerNonUserCode]
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

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000C4A8C File Offset: 0x000C2E8C
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000C4AB8 File Offset: 0x000C2EB8
		[DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06000A7E RID: 2686 RVA: 0x000C4AE4 File Offset: 0x000C2EE4
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

		// Token: 0x06000A7F RID: 2687 RVA: 0x000C4B0C File Offset: 0x000C2F0C
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DataSet Clone()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			UserWorkingProfileDS userWorkingProfileDS = (UserWorkingProfileDS)base.Clone();
			userWorkingProfileDS.InitVars();
			userWorkingProfileDS.SchemaSerializationMode = this.SchemaSerializationMode;
			return userWorkingProfileDS;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000C4B50 File Offset: 0x000C2F50
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

		// Token: 0x06000A81 RID: 2689 RVA: 0x000C4B74 File Offset: 0x000C2F74
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

		// Token: 0x06000A82 RID: 2690 RVA: 0x000C4B98 File Offset: 0x000C2F98
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
				if (dataSet.Tables["TemplateRoots"] != null)
				{
					base.Tables.Add(new UserWorkingProfileDS.TemplateRootsDataTable(dataSet.Tables["TemplateRoots"]));
				}
				if (dataSet.Tables["TemplateItem"] != null)
				{
					base.Tables.Add(new UserWorkingProfileDS.TemplateItemDataTable(dataSet.Tables["TemplateItem"]));
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

		// Token: 0x06000A83 RID: 2691 RVA: 0x000C4CD0 File Offset: 0x000C30D0
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

		// Token: 0x06000A84 RID: 2692 RVA: 0x000C4D1C File Offset: 0x000C311C
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

		// Token: 0x06000A85 RID: 2693 RVA: 0x000C4D38 File Offset: 0x000C3138
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InitVars(bool initTable)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			this.tableTemplateRoots = (UserWorkingProfileDS.TemplateRootsDataTable)base.Tables["TemplateRoots"];
			if (initTable)
			{
				if (this.tableTemplateRoots != null)
				{
					this.tableTemplateRoots.InitVars();
				}
			}
			this.tableTemplateItem = (UserWorkingProfileDS.TemplateItemDataTable)base.Tables["TemplateItem"];
			if (initTable)
			{
				if (this.tableTemplateItem != null)
				{
					this.tableTemplateItem.InitVars();
				}
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000C4DE0 File Offset: 0x000C31E0
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitClass()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			base.DataSetName = "UserWorkingProfileDS";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/UserWorkingProfileDS.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableTemplateRoots = new UserWorkingProfileDS.TemplateRootsDataTable();
			base.Tables.Add(this.tableTemplateRoots);
			this.tableTemplateItem = new UserWorkingProfileDS.TemplateItemDataTable();
			base.Tables.Add(this.tableTemplateItem);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000C4E6C File Offset: 0x000C326C
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeTemplateRoots()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000C4E90 File Offset: 0x000C3290
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeTemplateItem()
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			return false;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000C4EB4 File Offset: 0x000C32B4
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

		// Token: 0x06000A8A RID: 2698 RVA: 0x000C4EEC File Offset: 0x000C32EC
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			while (false)
			{
				//object arg_0A_0 = null[0];
			}
			UserWorkingProfileDS userWorkingProfileDS = new UserWorkingProfileDS();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = userWorkingProfileDS.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = userWorkingProfileDS.GetSchemaSerializable();
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

		// Token: 0x04000708 RID: 1800
		private UserWorkingProfileDS.TemplateRootsDataTable tableTemplateRoots;

		// Token: 0x04000709 RID: 1801
		private UserWorkingProfileDS.TemplateItemDataTable tableTemplateItem;

		// Token: 0x0400070A RID: 1802
		private SchemaSerializationMode _schemaSerializationMode;

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x06000A8C RID: 2700
		public delegate void TemplateRootsRowChangeEventHandler(object sender, UserWorkingProfileDS.TemplateRootsRowChangeEvent e);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x06000A90 RID: 2704
		public delegate void TemplateItemRowChangeEventHandler(object sender, UserWorkingProfileDS.TemplateItemRowChangeEvent e);

		// Token: 0x020000E2 RID: 226
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class TemplateRootsDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000A93 RID: 2707 RVA: 0x000C50BC File Offset: 0x000C34BC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateRootsDataTable() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = "TemplateRoots";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000A94 RID: 2708 RVA: 0x000C50FC File Offset: 0x000C34FC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TemplateRootsDataTable(DataTable table) : base()
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

			// Token: 0x06000A95 RID: 2709 RVA: 0x000C51E0 File Offset: 0x000C35E0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected TemplateRootsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.InitVars();
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x06000A96 RID: 2710 RVA: 0x000C5208 File Offset: 0x000C3608
			[DebuggerNonUserCode]
			public DataColumn TemplateNameColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnTemplateName;
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x06000A97 RID: 2711 RVA: 0x000C5234 File Offset: 0x000C3634
			[DebuggerNonUserCode]
			public DataColumn ListIndexColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnListIndex;
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x06000A98 RID: 2712 RVA: 0x000C5260 File Offset: 0x000C3660
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

			// Token: 0x1700017A RID: 378
			[DebuggerNonUserCode]
			public UserWorkingProfileDS.TemplateRootsRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (UserWorkingProfileDS.TemplateRootsRow)base.Rows[index];
				}
			}

			// Token: 0x1400002F RID: 47
			// (add) Token: 0x06000A9A RID: 2714 RVA: 0x000C52C4 File Offset: 0x000C36C4
			// (remove) Token: 0x06000A9B RID: 2715 RVA: 0x000C52EC File Offset: 0x000C36EC
			public event UserWorkingProfileDS.TemplateRootsRowChangeEventHandler TemplateRootsRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateRootsRowChanging = (UserWorkingProfileDS.TemplateRootsRowChangeEventHandler)Delegate.Combine(this.TemplateRootsRowChanging, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateRootsRowChanging = (UserWorkingProfileDS.TemplateRootsRowChangeEventHandler)Delegate.Remove(this.TemplateRootsRowChanging, value);
				}
			}

			// Token: 0x14000030 RID: 48
			// (add) Token: 0x06000A9C RID: 2716 RVA: 0x000C5314 File Offset: 0x000C3714
			// (remove) Token: 0x06000A9D RID: 2717 RVA: 0x000C533C File Offset: 0x000C373C
			public event UserWorkingProfileDS.TemplateRootsRowChangeEventHandler TemplateRootsRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateRootsRowChanged = (UserWorkingProfileDS.TemplateRootsRowChangeEventHandler)Delegate.Combine(this.TemplateRootsRowChanged, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateRootsRowChanged = (UserWorkingProfileDS.TemplateRootsRowChangeEventHandler)Delegate.Remove(this.TemplateRootsRowChanged, value);
				}
			}

			// Token: 0x14000031 RID: 49
			// (add) Token: 0x06000A9E RID: 2718 RVA: 0x000C5364 File Offset: 0x000C3764
			// (remove) Token: 0x06000A9F RID: 2719 RVA: 0x000C538C File Offset: 0x000C378C
			public event UserWorkingProfileDS.TemplateRootsRowChangeEventHandler TemplateRootsRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateRootsRowDeleting = (UserWorkingProfileDS.TemplateRootsRowChangeEventHandler)Delegate.Combine(this.TemplateRootsRowDeleting, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateRootsRowDeleting = (UserWorkingProfileDS.TemplateRootsRowChangeEventHandler)Delegate.Remove(this.TemplateRootsRowDeleting, value);
				}
			}

			// Token: 0x14000032 RID: 50
			// (add) Token: 0x06000AA0 RID: 2720 RVA: 0x000C53B4 File Offset: 0x000C37B4
			// (remove) Token: 0x06000AA1 RID: 2721 RVA: 0x000C53DC File Offset: 0x000C37DC
			public event UserWorkingProfileDS.TemplateRootsRowChangeEventHandler TemplateRootsRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateRootsRowDeleted = (UserWorkingProfileDS.TemplateRootsRowChangeEventHandler)Delegate.Combine(this.TemplateRootsRowDeleted, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateRootsRowDeleted = (UserWorkingProfileDS.TemplateRootsRowChangeEventHandler)Delegate.Remove(this.TemplateRootsRowDeleted, value);
				}
			}

			// Token: 0x06000AA2 RID: 2722 RVA: 0x000C5404 File Offset: 0x000C3804
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddTemplateRootsRow(UserWorkingProfileDS.TemplateRootsRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x06000AA3 RID: 2723 RVA: 0x000C5424 File Offset: 0x000C3824
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public UserWorkingProfileDS.TemplateRootsRow AddTemplateRootsRow(string TemplateName, int ListIndex)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				UserWorkingProfileDS.TemplateRootsRow templateRootsRow = (UserWorkingProfileDS.TemplateRootsRow)base.NewRow();
				object[] itemArray = new object[]
				{
					TemplateName,
					ListIndex
				};
				templateRootsRow.ItemArray = itemArray;
				base.Rows.Add(templateRootsRow);
				return templateRootsRow;
			}

			// Token: 0x06000AA4 RID: 2724 RVA: 0x000C5480 File Offset: 0x000C3880
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

			// Token: 0x06000AA5 RID: 2725 RVA: 0x000C54B0 File Offset: 0x000C38B0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				UserWorkingProfileDS.TemplateRootsDataTable templateRootsDataTable = (UserWorkingProfileDS.TemplateRootsDataTable)base.Clone();
				templateRootsDataTable.InitVars();
				return templateRootsDataTable;
			}

			// Token: 0x06000AA6 RID: 2726 RVA: 0x000C54E8 File Offset: 0x000C38E8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new UserWorkingProfileDS.TemplateRootsDataTable();
			}

			// Token: 0x06000AA7 RID: 2727 RVA: 0x000C5510 File Offset: 0x000C3910
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnTemplateName = base.Columns["TemplateName"];
				this.columnListIndex = base.Columns["ListIndex"];
			}

			// Token: 0x06000AA8 RID: 2728 RVA: 0x000C5550 File Offset: 0x000C3950
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnTemplateName = new DataColumn("TemplateName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTemplateName);
				this.columnListIndex = new DataColumn("ListIndex", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnListIndex);
				this.columnTemplateName.DefaultValue = "";
			}

			// Token: 0x06000AA9 RID: 2729 RVA: 0x000C55DC File Offset: 0x000C39DC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public UserWorkingProfileDS.TemplateRootsRow NewTemplateRootsRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (UserWorkingProfileDS.TemplateRootsRow)base.NewRow();
			}

			// Token: 0x06000AAA RID: 2730 RVA: 0x000C560C File Offset: 0x000C3A0C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new UserWorkingProfileDS.TemplateRootsRow(builder);
			}

			// Token: 0x06000AAB RID: 2731 RVA: 0x000C5638 File Offset: 0x000C3A38
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(UserWorkingProfileDS.TemplateRootsRow);
			}

			// Token: 0x06000AAC RID: 2732 RVA: 0x000C5668 File Offset: 0x000C3A68
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this.TemplateRootsRowChanged != null)
				{
					this.TemplateRootsRowChanged(this, new UserWorkingProfileDS.TemplateRootsRowChangeEvent((UserWorkingProfileDS.TemplateRootsRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000AAD RID: 2733 RVA: 0x000C56C4 File Offset: 0x000C3AC4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this.TemplateRootsRowChanging != null)
				{
					this.TemplateRootsRowChanging(this, new UserWorkingProfileDS.TemplateRootsRowChangeEvent((UserWorkingProfileDS.TemplateRootsRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000AAE RID: 2734 RVA: 0x000C5720 File Offset: 0x000C3B20
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this.TemplateRootsRowDeleted != null)
				{
					this.TemplateRootsRowDeleted(this, new UserWorkingProfileDS.TemplateRootsRowChangeEvent((UserWorkingProfileDS.TemplateRootsRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000AAF RID: 2735 RVA: 0x000C577C File Offset: 0x000C3B7C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this.TemplateRootsRowDeleting != null)
				{
					this.TemplateRootsRowDeleting(this, new UserWorkingProfileDS.TemplateRootsRowChangeEvent((UserWorkingProfileDS.TemplateRootsRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000AB0 RID: 2736 RVA: 0x000C57D8 File Offset: 0x000C3BD8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveTemplateRootsRow(UserWorkingProfileDS.TemplateRootsRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x06000AB1 RID: 2737 RVA: 0x000C57F8 File Offset: 0x000C3BF8
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
				UserWorkingProfileDS userWorkingProfileDS = new UserWorkingProfileDS();
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
				xmlSchemaAttribute.FixedValue = userWorkingProfileDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "TemplateRootsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = userWorkingProfileDS.GetSchemaSerializable();
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

			// Token: 0x0400070B RID: 1803
			private DataColumn columnTemplateName;

			// Token: 0x0400070C RID: 1804
			private DataColumn columnListIndex;
		}

		// Token: 0x020000E3 RID: 227
		[XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[Serializable]
		public class TemplateItemDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000AB2 RID: 2738 RVA: 0x000C5A88 File Offset: 0x000C3E88
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateItemDataTable() : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				base.TableName = "TemplateItem";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000AB3 RID: 2739 RVA: 0x000C5AC8 File Offset: 0x000C3EC8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TemplateItemDataTable(DataTable table) : base()
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

			// Token: 0x06000AB4 RID: 2740 RVA: 0x000C5BAC File Offset: 0x000C3FAC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected TemplateItemDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.InitVars();
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x000C5BD4 File Offset: 0x000C3FD4
			[DebuggerNonUserCode]
			public DataColumn ItemNameColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnItemName;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x000C5C00 File Offset: 0x000C4000
			[DebuggerNonUserCode]
			public DataColumn ListIndexColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnListIndex;
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x000C5C2C File Offset: 0x000C402C
			[DebuggerNonUserCode]
			public DataColumn IsDefalutTemplateColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnIsDefalutTemplate;
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x000C5C58 File Offset: 0x000C4058
			[DebuggerNonUserCode]
			public DataColumn RootTemplateNameColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnRootTemplateName;
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x000C5C84 File Offset: 0x000C4084
			[DebuggerNonUserCode]
			public DataColumn HotKeyColumn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return this.columnHotKey;
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06000ABA RID: 2746 RVA: 0x000C5CB0 File Offset: 0x000C40B0
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

			// Token: 0x17000181 RID: 385
			[DebuggerNonUserCode]
			public UserWorkingProfileDS.TemplateItemRow this[int index]
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					return (UserWorkingProfileDS.TemplateItemRow)base.Rows[index];
				}
			}

			// Token: 0x14000033 RID: 51
			// (add) Token: 0x06000ABC RID: 2748 RVA: 0x000C5D14 File Offset: 0x000C4114
			// (remove) Token: 0x06000ABD RID: 2749 RVA: 0x000C5D3C File Offset: 0x000C413C
			public event UserWorkingProfileDS.TemplateItemRowChangeEventHandler TemplateItemRowChanging
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateItemRowChanging = (UserWorkingProfileDS.TemplateItemRowChangeEventHandler)Delegate.Combine(this.TemplateItemRowChanging, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateItemRowChanging = (UserWorkingProfileDS.TemplateItemRowChangeEventHandler)Delegate.Remove(this.TemplateItemRowChanging, value);
				}
			}

			// Token: 0x14000034 RID: 52
			// (add) Token: 0x06000ABE RID: 2750 RVA: 0x000C5D64 File Offset: 0x000C4164
			// (remove) Token: 0x06000ABF RID: 2751 RVA: 0x000C5D8C File Offset: 0x000C418C
			public event UserWorkingProfileDS.TemplateItemRowChangeEventHandler TemplateItemRowChanged
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateItemRowChanged = (UserWorkingProfileDS.TemplateItemRowChangeEventHandler)Delegate.Combine(this.TemplateItemRowChanged, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateItemRowChanged = (UserWorkingProfileDS.TemplateItemRowChangeEventHandler)Delegate.Remove(this.TemplateItemRowChanged, value);
				}
			}

			// Token: 0x14000035 RID: 53
			// (add) Token: 0x06000AC0 RID: 2752 RVA: 0x000C5DB4 File Offset: 0x000C41B4
			// (remove) Token: 0x06000AC1 RID: 2753 RVA: 0x000C5DDC File Offset: 0x000C41DC
			public event UserWorkingProfileDS.TemplateItemRowChangeEventHandler TemplateItemRowDeleting
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateItemRowDeleting = (UserWorkingProfileDS.TemplateItemRowChangeEventHandler)Delegate.Combine(this.TemplateItemRowDeleting, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateItemRowDeleting = (UserWorkingProfileDS.TemplateItemRowChangeEventHandler)Delegate.Remove(this.TemplateItemRowDeleting, value);
				}
			}

			// Token: 0x14000036 RID: 54
			// (add) Token: 0x06000AC2 RID: 2754 RVA: 0x000C5E04 File Offset: 0x000C4204
			// (remove) Token: 0x06000AC3 RID: 2755 RVA: 0x000C5E2C File Offset: 0x000C422C
			public event UserWorkingProfileDS.TemplateItemRowChangeEventHandler TemplateItemRowDeleted
			{
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				add
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateItemRowDeleted = (UserWorkingProfileDS.TemplateItemRowChangeEventHandler)Delegate.Combine(this.TemplateItemRowDeleted, value);
				}
				[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
				remove
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					this.TemplateItemRowDeleted = (UserWorkingProfileDS.TemplateItemRowChangeEventHandler)Delegate.Remove(this.TemplateItemRowDeleted, value);
				}
			}

			// Token: 0x06000AC4 RID: 2756 RVA: 0x000C5E54 File Offset: 0x000C4254
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddTemplateItemRow(UserWorkingProfileDS.TemplateItemRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Add(row);
			}

			// Token: 0x06000AC5 RID: 2757 RVA: 0x000C5E74 File Offset: 0x000C4274
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public UserWorkingProfileDS.TemplateItemRow AddTemplateItemRow(string ItemName, int ListIndex, bool IsDefalutTemplate, string RootTemplateName, int HotKey)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				UserWorkingProfileDS.TemplateItemRow templateItemRow = (UserWorkingProfileDS.TemplateItemRow)base.NewRow();
				object[] itemArray = new object[]
				{
					ItemName,
					ListIndex,
					IsDefalutTemplate,
					RootTemplateName,
					HotKey
				};
				templateItemRow.ItemArray = itemArray;
				base.Rows.Add(templateItemRow);
				return templateItemRow;
			}

			// Token: 0x06000AC6 RID: 2758 RVA: 0x000C5EE8 File Offset: 0x000C42E8
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

			// Token: 0x06000AC7 RID: 2759 RVA: 0x000C5F18 File Offset: 0x000C4318
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override DataTable Clone()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				UserWorkingProfileDS.TemplateItemDataTable templateItemDataTable = (UserWorkingProfileDS.TemplateItemDataTable)base.Clone();
				templateItemDataTable.InitVars();
				return templateItemDataTable;
			}

			// Token: 0x06000AC8 RID: 2760 RVA: 0x000C5F50 File Offset: 0x000C4350
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataTable CreateInstance()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new UserWorkingProfileDS.TemplateItemDataTable();
			}

			// Token: 0x06000AC9 RID: 2761 RVA: 0x000C5F78 File Offset: 0x000C4378
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void InitVars()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnItemName = base.Columns["ItemName"];
				this.columnListIndex = base.Columns["ListIndex"];
				this.columnIsDefalutTemplate = base.Columns["IsDefalutTemplate"];
				this.columnRootTemplateName = base.Columns["RootTemplateName"];
				this.columnHotKey = base.Columns["HotKey"];
			}

			// Token: 0x06000ACA RID: 2762 RVA: 0x000C6004 File Offset: 0x000C4404
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void InitClass()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				this.columnItemName = new DataColumn("ItemName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemName);
				this.columnListIndex = new DataColumn("ListIndex", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnListIndex);
				this.columnIsDefalutTemplate = new DataColumn("IsDefalutTemplate", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnIsDefalutTemplate);
				this.columnRootTemplateName = new DataColumn("RootTemplateName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRootTemplateName);
				this.columnHotKey = new DataColumn("HotKey", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnHotKey);
				this.columnItemName.DefaultValue = "";
				this.columnIsDefalutTemplate.DefaultValue = false;
				this.columnRootTemplateName.DefaultValue = "";
			}

			// Token: 0x06000ACB RID: 2763 RVA: 0x000C613C File Offset: 0x000C453C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public UserWorkingProfileDS.TemplateItemRow NewTemplateItemRow()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return (UserWorkingProfileDS.TemplateItemRow)base.NewRow();
			}

			// Token: 0x06000ACC RID: 2764 RVA: 0x000C616C File Offset: 0x000C456C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return new UserWorkingProfileDS.TemplateItemRow(builder);
			}

			// Token: 0x06000ACD RID: 2765 RVA: 0x000C6198 File Offset: 0x000C4598
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Type GetRowType()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return typeof(UserWorkingProfileDS.TemplateItemRow);
			}

			// Token: 0x06000ACE RID: 2766 RVA: 0x000C61C8 File Offset: 0x000C45C8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanged(e);
				if (this.TemplateItemRowChanged != null)
				{
					this.TemplateItemRowChanged(this, new UserWorkingProfileDS.TemplateItemRowChangeEvent((UserWorkingProfileDS.TemplateItemRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000ACF RID: 2767 RVA: 0x000C6224 File Offset: 0x000C4624
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowChanging(e);
				if (this.TemplateItemRowChanging != null)
				{
					this.TemplateItemRowChanging(this, new UserWorkingProfileDS.TemplateItemRowChangeEvent((UserWorkingProfileDS.TemplateItemRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000AD0 RID: 2768 RVA: 0x000C6280 File Offset: 0x000C4680
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleted(e);
				if (this.TemplateItemRowDeleted != null)
				{
					this.TemplateItemRowDeleted(this, new UserWorkingProfileDS.TemplateItemRowChangeEvent((UserWorkingProfileDS.TemplateItemRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000AD1 RID: 2769 RVA: 0x000C62DC File Offset: 0x000C46DC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.OnRowDeleting(e);
				if (this.TemplateItemRowDeleting != null)
				{
					this.TemplateItemRowDeleting(this, new UserWorkingProfileDS.TemplateItemRowChangeEvent((UserWorkingProfileDS.TemplateItemRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x000C6338 File Offset: 0x000C4738
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemoveTemplateItemRow(UserWorkingProfileDS.TemplateItemRow row)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base.Rows.Remove(row);
			}

			// Token: 0x06000AD3 RID: 2771 RVA: 0x000C6358 File Offset: 0x000C4758
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
				UserWorkingProfileDS userWorkingProfileDS = new UserWorkingProfileDS();
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
				xmlSchemaAttribute.FixedValue = userWorkingProfileDS.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "TemplateItemDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = userWorkingProfileDS.GetSchemaSerializable();
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

			// Token: 0x04000711 RID: 1809
			private DataColumn columnItemName;

			// Token: 0x04000712 RID: 1810
			private DataColumn columnListIndex;

			// Token: 0x04000713 RID: 1811
			private DataColumn columnIsDefalutTemplate;

			// Token: 0x04000714 RID: 1812
			private DataColumn columnRootTemplateName;

			// Token: 0x04000715 RID: 1813
			private DataColumn columnHotKey;
		}

		// Token: 0x020000E4 RID: 228
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class TemplateRootsRow : DataRow
		{
			// Token: 0x06000AD4 RID: 2772 RVA: 0x000C65E8 File Offset: 0x000C49E8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TemplateRootsRow(DataRowBuilder rb) : base(rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.tableTemplateRoots = (UserWorkingProfileDS.TemplateRootsDataTable)base.Table;
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000C6618 File Offset: 0x000C4A18
			// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x000C6670 File Offset: 0x000C4A70
			[DebuggerNonUserCode]
			public string TemplateName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsTemplateNameNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableTemplateRoots.TemplateNameColumn];
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
					base[this.tableTemplateRoots.TemplateNameColumn] = value;
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000C6694 File Offset: 0x000C4A94
			// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x000C66F0 File Offset: 0x000C4AF0
			[DebuggerNonUserCode]
			public int ListIndex
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					int result;
					try
					{
						result = (int)base[this.tableTemplateRoots.ListIndexColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ListIndex' in table 'TemplateRoots' is DBNull.", innerException);
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
					base[this.tableTemplateRoots.ListIndexColumn] = value;
				}
			}

			// Token: 0x06000AD9 RID: 2777 RVA: 0x000C671C File Offset: 0x000C4B1C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsTemplateNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateRoots.TemplateNameColumn);
			}

			// Token: 0x06000ADA RID: 2778 RVA: 0x000C6750 File Offset: 0x000C4B50
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetTemplateNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateRoots.TemplateNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000ADB RID: 2779 RVA: 0x000C6778 File Offset: 0x000C4B78
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsListIndexNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateRoots.ListIndexColumn);
			}

			// Token: 0x06000ADC RID: 2780 RVA: 0x000C67AC File Offset: 0x000C4BAC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetListIndexNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateRoots.ListIndexColumn] = Convert.DBNull;
			}

			// Token: 0x0400071A RID: 1818
			private UserWorkingProfileDS.TemplateRootsDataTable tableTemplateRoots;
		}

		// Token: 0x020000E5 RID: 229
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class TemplateItemRow : DataRow
		{
			// Token: 0x06000ADD RID: 2781 RVA: 0x000C67D4 File Offset: 0x000C4BD4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TemplateItemRow(DataRowBuilder rb) : base(rb)
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.tableTemplateItem = (UserWorkingProfileDS.TemplateItemDataTable)base.Table;
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000C6804 File Offset: 0x000C4C04
			// (set) Token: 0x06000ADF RID: 2783 RVA: 0x000C685C File Offset: 0x000C4C5C
			[DebuggerNonUserCode]
			public string ItemName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsItemNameNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableTemplateItem.ItemNameColumn];
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
					base[this.tableTemplateItem.ItemNameColumn] = value;
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000C6880 File Offset: 0x000C4C80
			// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000C68DC File Offset: 0x000C4CDC
			[DebuggerNonUserCode]
			public int ListIndex
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					int result;
					try
					{
						result = (int)base[this.tableTemplateItem.ListIndexColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ListIndex' in table 'TemplateItem' is DBNull.", innerException);
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
					base[this.tableTemplateItem.ListIndexColumn] = value;
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x000C6908 File Offset: 0x000C4D08
			// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x000C6964 File Offset: 0x000C4D64
			[DebuggerNonUserCode]
			public bool IsDefalutTemplate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					bool result;
					try
					{
						result = (bool)base[this.tableTemplateItem.IsDefalutTemplateColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'IsDefalutTemplate' in table 'TemplateItem' is DBNull.", innerException);
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
					base[this.tableTemplateItem.IsDefalutTemplateColumn] = value;
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000C6990 File Offset: 0x000C4D90
			// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x000C69E8 File Offset: 0x000C4DE8
			[DebuggerNonUserCode]
			public string RootTemplateName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					string result;
					if (this.IsRootTemplateNameNull())
					{
						result = string.Empty;
					}
					else
					{
						result = (string)base[this.tableTemplateItem.RootTemplateNameColumn];
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
					base[this.tableTemplateItem.RootTemplateNameColumn] = value;
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x000C6A0C File Offset: 0x000C4E0C
			// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x000C6A68 File Offset: 0x000C4E68
			[DebuggerNonUserCode]
			public int HotKey
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					while (false)
					{
						//object arg_0A_0 = null[0];
					}
					int result;
					try
					{
						result = (int)base[this.tableTemplateItem.HotKeyColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'HotKey' in table 'TemplateItem' is DBNull.", innerException);
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
					base[this.tableTemplateItem.HotKeyColumn] = value;
				}
			}

			// Token: 0x06000AE8 RID: 2792 RVA: 0x000C6A94 File Offset: 0x000C4E94
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsItemNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateItem.ItemNameColumn);
			}

			// Token: 0x06000AE9 RID: 2793 RVA: 0x000C6AC8 File Offset: 0x000C4EC8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetItemNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateItem.ItemNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000AEA RID: 2794 RVA: 0x000C6AF0 File Offset: 0x000C4EF0
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsListIndexNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateItem.ListIndexColumn);
			}

			// Token: 0x06000AEB RID: 2795 RVA: 0x000C6B24 File Offset: 0x000C4F24
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetListIndexNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateItem.ListIndexColumn] = Convert.DBNull;
			}

			// Token: 0x06000AEC RID: 2796 RVA: 0x000C6B4C File Offset: 0x000C4F4C
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsIsDefalutTemplateNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateItem.IsDefalutTemplateColumn);
			}

			// Token: 0x06000AED RID: 2797 RVA: 0x000C6B80 File Offset: 0x000C4F80
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetIsDefalutTemplateNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateItem.IsDefalutTemplateColumn] = Convert.DBNull;
			}

			// Token: 0x06000AEE RID: 2798 RVA: 0x000C6BA8 File Offset: 0x000C4FA8
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsRootTemplateNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateItem.RootTemplateNameColumn);
			}

			// Token: 0x06000AEF RID: 2799 RVA: 0x000C6BDC File Offset: 0x000C4FDC
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetRootTemplateNameNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateItem.RootTemplateNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000AF0 RID: 2800 RVA: 0x000C6C04 File Offset: 0x000C5004
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsHotKeyNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				return base.IsNull(this.tableTemplateItem.HotKeyColumn);
			}

			// Token: 0x06000AF1 RID: 2801 RVA: 0x000C6C38 File Offset: 0x000C5038
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetHotKeyNull()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				base[this.tableTemplateItem.HotKeyColumn] = Convert.DBNull;
			}

			// Token: 0x0400071B RID: 1819
			private UserWorkingProfileDS.TemplateItemDataTable tableTemplateItem;
		}

		// Token: 0x020000E6 RID: 230
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class TemplateRootsRowChangeEvent : EventArgs
		{
			// Token: 0x06000AF2 RID: 2802 RVA: 0x000C6C60 File Offset: 0x000C5060
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateRootsRowChangeEvent(UserWorkingProfileDS.TemplateRootsRow row, DataRowAction action) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000C6C8C File Offset: 0x000C508C
			[DebuggerNonUserCode]
			public UserWorkingProfileDS.TemplateRootsRow Row
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

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000C6CB8 File Offset: 0x000C50B8
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

			// Token: 0x0400071C RID: 1820
			private UserWorkingProfileDS.TemplateRootsRow eventRow;

			// Token: 0x0400071D RID: 1821
			private DataRowAction eventAction;
		}

		// Token: 0x020000E7 RID: 231
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class TemplateItemRowChangeEvent : EventArgs
		{
			// Token: 0x06000AF5 RID: 2805 RVA: 0x000C6CE4 File Offset: 0x000C50E4
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TemplateItemRowChangeEvent(UserWorkingProfileDS.TemplateItemRow row, DataRowAction action) : base()
			{
				while (false)
				{
					//object arg_0A_0 = null[0];
				}
				QG1JNMDDCVMQeEY2Tq.hPhdpr4o5CbKJ();
				
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x000C6D10 File Offset: 0x000C5110
			[DebuggerNonUserCode]
			public UserWorkingProfileDS.TemplateItemRow Row
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

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x000C6D3C File Offset: 0x000C513C
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

			// Token: 0x0400071E RID: 1822
			private UserWorkingProfileDS.TemplateItemRow eventRow;

			// Token: 0x0400071F RID: 1823
			private DataRowAction eventAction;
		}
	}
}
