
// This file has been generated by the GUI designer. Do not modify.

public partial class wndMain
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action Action;

	private global::Gtk.Action actRefreshTable;

	private global::Gtk.Action actFile;

	private global::Gtk.Action actActions;

	private global::Gtk.Action CreateTableAction;

	private global::Gtk.Action actCreateColumn;

	private global::Gtk.Action actEditTable;

	private global::Gtk.Action actEditColumn;

	private global::Gtk.Action actCreateDatabase;

	private global::Gtk.Action actCreateSqlite3;

	private global::Gtk.VBox vboxMain;

	private global::Gtk.MenuBar mBar;

	private global::Gtk.Toolbar ToolBar;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TreeView tblMain;

	private global::Gtk.Statusbar StatusBar;

	private global::Gtk.ComboBox cmb1;

	private global::Gtk.ProgressBar pb;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget wndMain
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.Action = new global::Gtk.Action("Action", global::Mono.Unix.Catalog.GetString("Файл"), null, null);
		this.Action.ShortLabel = global::Mono.Unix.Catalog.GetString("Файл");
		w1.Add(this.Action, null);
		this.actRefreshTable = new global::Gtk.Action("actRefreshTable", null, global::Mono.Unix.Catalog.GetString("Refresh"), "gtk-refresh");
		this.actRefreshTable.ShortLabel = "";
		w1.Add(this.actRefreshTable, null);
		this.actFile = new global::Gtk.Action("actFile", global::Mono.Unix.Catalog.GetString("File"), null, "gtk-file");
		this.actFile.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.actFile, null);
		this.actActions = new global::Gtk.Action("actActions", global::Mono.Unix.Catalog.GetString("Actions"), null, null);
		this.actActions.ShortLabel = global::Mono.Unix.Catalog.GetString("Actions");
		w1.Add(this.actActions, null);
		this.CreateTableAction = new global::Gtk.Action("CreateTableAction", global::Mono.Unix.Catalog.GetString("Create table"), null, null);
		this.CreateTableAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Create table");
		w1.Add(this.CreateTableAction, null);
		this.actCreateColumn = new global::Gtk.Action("actCreateColumn", global::Mono.Unix.Catalog.GetString("Create column"), null, null);
		this.actCreateColumn.ShortLabel = global::Mono.Unix.Catalog.GetString("Create column");
		w1.Add(this.actCreateColumn, null);
		this.actEditTable = new global::Gtk.Action("actEditTable", global::Mono.Unix.Catalog.GetString("Edit table"), null, null);
		this.actEditTable.ShortLabel = global::Mono.Unix.Catalog.GetString("Edit table");
		w1.Add(this.actEditTable, null);
		this.actEditColumn = new global::Gtk.Action("actEditColumn", global::Mono.Unix.Catalog.GetString("Edit column"), null, null);
		this.actEditColumn.ShortLabel = global::Mono.Unix.Catalog.GetString("Edit column");
		w1.Add(this.actEditColumn, null);
		this.actCreateDatabase = new global::Gtk.Action("actCreateDatabase", global::Mono.Unix.Catalog.GetString("Create Database"), null, null);
		this.actCreateDatabase.ShortLabel = global::Mono.Unix.Catalog.GetString("Create Database");
		w1.Add(this.actCreateDatabase, null);
		this.actCreateSqlite3 = new global::Gtk.Action("actCreateSqlite3", global::Mono.Unix.Catalog.GetString("Sqlite3"), null, null);
		this.actCreateSqlite3.ShortLabel = global::Mono.Unix.Catalog.GetString("Sqlite3");
		w1.Add(this.actCreateSqlite3, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "wndMain";
		this.Title = global::Mono.Unix.Catalog.GetString("WinuxDB");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child wndMain.Gtk.Container+ContainerChild
		this.vboxMain = new global::Gtk.VBox();
		this.vboxMain.Name = "vboxMain";
		this.vboxMain.BorderWidth = ((uint)(3));
		// Container child vboxMain.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><menubar name='mBar'><menu name='actFile' action='actFile'><menu name='actCreateDatabase' action='actCreateDatabase'><menuitem name='actCreateSqlite3' action='actCreateSqlite3'/></menu></menu><menu name='actActions' action='actActions'><menuitem name='CreateTableAction' action='CreateTableAction'/><menuitem name='actEditTable' action='actEditTable'/><menuitem name='actCreateColumn' action='actCreateColumn'/><menuitem name='actEditColumn' action='actEditColumn'/></menu></menubar></ui>");
		this.mBar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/mBar")));
		this.mBar.Name = "mBar";
		this.vboxMain.Add(this.mBar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.mBar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vboxMain.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><toolbar name=\'ToolBar\'><toolitem name=\'actRefreshTable\' action=\'actRefreshTa" +
				"ble\'/></toolbar></ui>");
		this.ToolBar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/ToolBar")));
		this.ToolBar.Name = "ToolBar";
		this.ToolBar.ShowArrow = false;
		this.ToolBar.ToolbarStyle = ((global::Gtk.ToolbarStyle)(0));
		this.ToolBar.IconSize = ((global::Gtk.IconSize)(3));
		this.vboxMain.Add(this.ToolBar);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.ToolBar]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vboxMain.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.tblMain = new global::Gtk.TreeView();
		this.tblMain.CanFocus = true;
		this.tblMain.Name = "tblMain";
		this.GtkScrolledWindow.Add(this.tblMain);
		this.vboxMain.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.GtkScrolledWindow]));
		w5.Position = 2;
		// Container child vboxMain.Gtk.Box+BoxChild
		this.StatusBar = new global::Gtk.Statusbar();
		this.StatusBar.Name = "StatusBar";
		this.StatusBar.Homogeneous = true;
		this.StatusBar.Spacing = 5;
		this.StatusBar.BorderWidth = ((uint)(5));
		this.StatusBar.HasResizeGrip = false;
		// Container child StatusBar.Gtk.Box+BoxChild
		this.pb = new global::Gtk.ProgressBar();
		this.pb.Name = "pb";
		this.StatusBar.Add(this.pb);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.StatusBar[this.pb]));
		w7.Position = 2;
		this.vboxMain.Add(this.StatusBar);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vboxMain[this.StatusBar]));
		w8.Position = 3;
		w8.Expand = false;
		w8.Fill = false;
		this.Add(this.vboxMain);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 893;
		this.DefaultHeight = 496;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.actRefreshTable.Activated += new global::System.EventHandler(this.OnActRefreshTableActivated);
		this.CreateTableAction.Activated += new global::System.EventHandler(this.OnActCreateTableActivated);
	}
}
