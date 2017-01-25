
// This file has been generated by the GUI designer. Do not modify.
namespace WinuxDB
{
	public partial class wCreateTable
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action actCreate;

		private global::Gtk.Action actAddColumn;

		private global::Gtk.Action actDelete;

		private global::Gtk.VBox vboxMain;

		private global::Gtk.Toolbar toolbar1;

		private global::Gtk.Table table1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView txtvDescription;

		private global::Gtk.HBox hboxDependence;

		private global::Gtk.ComboBox cmbTblDependence;

		private global::Gtk.ComboBox cmbClmDependence;

		private global::Gtk.Label lblDependence;

		private global::Gtk.Label lblDescription;

		private global::Gtk.Label lblTableName;

		private global::Gtk.Label lblTableTitle;

		private global::Gtk.Entry txtTableName;

		private global::Gtk.Entry txtTableTitle;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Toolbar toolbar2;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gtk.TreeView tblColumns;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget WinuxDB.wCreateTable
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.actCreate = new global::Gtk.Action("actCreate", global::Mono.Unix.Catalog.GetString("Create"), "", "gtk-apply");
			this.actCreate.ShortLabel = global::Mono.Unix.Catalog.GetString("Create");
			w1.Add(this.actCreate, null);
			this.actAddColumn = new global::Gtk.Action("actAddColumn", null, null, "gtk-add");
			w1.Add(this.actAddColumn, null);
			this.actDelete = new global::Gtk.Action("actDelete", null, null, "gtk-delete");
			w1.Add(this.actDelete, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "WinuxDB.wCreateTable";
			this.Title = global::Mono.Unix.Catalog.GetString("Create Table");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Modal = true;
			// Container child WinuxDB.wCreateTable.Gtk.Container+ContainerChild
			this.vboxMain = new global::Gtk.VBox();
			this.vboxMain.Name = "vboxMain";
			// Container child vboxMain.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar1\'><toolitem name=\'actCreate\' action=\'actCreate\'/></too" +
					"lbar></ui>");
			this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
			this.toolbar1.Name = "toolbar1";
			this.toolbar1.ShowArrow = false;
			this.vboxMain.Add(this.toolbar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.toolbar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vboxMain.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(10));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.HeightRequest = 100;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.txtvDescription = new global::Gtk.TextView();
			this.txtvDescription.CanFocus = true;
			this.txtvDescription.Name = "txtvDescription";
			this.GtkScrolledWindow.Add(this.txtvDescription);
			this.table1.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hboxDependence = new global::Gtk.HBox();
			this.hboxDependence.Name = "hboxDependence";
			this.hboxDependence.Spacing = 10;
			// Container child hboxDependence.Gtk.Box+BoxChild
			this.cmbTblDependence = global::Gtk.ComboBox.NewText();
			this.cmbTblDependence.Name = "cmbTblDependence";
			this.hboxDependence.Add(this.cmbTblDependence);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxDependence[this.cmbTblDependence]));
			w5.Position = 0;
			// Container child hboxDependence.Gtk.Box+BoxChild
			this.cmbClmDependence = global::Gtk.ComboBox.NewText();
			this.cmbClmDependence.Name = "cmbClmDependence";
			this.hboxDependence.Add(this.cmbClmDependence);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxDependence[this.cmbClmDependence]));
			w6.Position = 1;
			this.table1.Add(this.hboxDependence);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.hboxDependence]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblDependence = new global::Gtk.Label();
			this.lblDependence.Name = "lblDependence";
			this.lblDependence.LabelProp = global::Mono.Unix.Catalog.GetString("Dependence");
			this.table1.Add(this.lblDependence);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.lblDependence]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblDescription = new global::Gtk.Label();
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.LabelProp = global::Mono.Unix.Catalog.GetString("Description");
			this.table1.Add(this.lblDescription);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.lblDescription]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblTableName = new global::Gtk.Label();
			this.lblTableName.Name = "lblTableName";
			this.lblTableName.LabelProp = global::Mono.Unix.Catalog.GetString("Table Name");
			this.table1.Add(this.lblTableName);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.lblTableName]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lblTableTitle = new global::Gtk.Label();
			this.lblTableTitle.Name = "lblTableTitle";
			this.lblTableTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Table Title");
			this.table1.Add(this.lblTableTitle);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.lblTableTitle]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtTableName = new global::Gtk.Entry();
			this.txtTableName.CanFocus = true;
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.IsEditable = true;
			this.txtTableName.InvisibleChar = '●';
			this.table1.Add(this.txtTableName);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.txtTableName]));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.txtTableTitle = new global::Gtk.Entry();
			this.txtTableTitle.CanFocus = true;
			this.txtTableTitle.Name = "txtTableTitle";
			this.txtTableTitle.IsEditable = true;
			this.txtTableTitle.InvisibleChar = '●';
			this.table1.Add(this.txtTableTitle);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.txtTableTitle]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vboxMain.Add(this.table1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.table1]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vboxMain.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vboxMain.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.hseparator1]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vboxMain.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString("<ui><toolbar name=\'toolbar2\'><toolitem name=\'actAddColumn\' action=\'actAddColumn\'/" +
					"><toolitem name=\'actDelete\' action=\'actDelete\'/></toolbar></ui>");
			this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar2")));
			this.toolbar2.Name = "toolbar2";
			this.toolbar2.ShowArrow = false;
			this.vboxMain.Add(this.toolbar2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.toolbar2]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vboxMain.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.tblColumns = new global::Gtk.TreeView();
			this.tblColumns.CanFocus = true;
			this.tblColumns.Name = "tblColumns";
			this.tblColumns.EnableSearch = false;
			this.GtkScrolledWindow1.Add(this.tblColumns);
			this.vboxMain.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.GtkScrolledWindow1]));
			w18.Position = 4;
			this.Add(this.vboxMain);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 468;
			this.DefaultHeight = 543;
			this.Show();
			this.actCreate.Activated += new global::System.EventHandler(this.OnActCreateActivated);
			this.actAddColumn.Activated += new global::System.EventHandler(this.OnActAddColumnActivated);
			this.actDelete.Activated += new global::System.EventHandler(this.OnActDeleteActivated);
			this.tblColumns.KeyPressEvent += new global::Gtk.KeyPressEventHandler(this.OnTblColumnsKeyPressEvent);
		}
	}
}
