namespace ReporteExistenciaPrecio
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbcReporte = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.gridGrupos = new DevExpress.XtraGrid.GridControl();
            this.filtroGruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvGrupos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAlmacenes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.gridResultados = new DevExpress.XtraGrid.GridControl();
            this.reporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvResultados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioMayoreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioLista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hiloConsulta = new System.ComponentModel.BackgroundWorker();
            this.pnlTitulo.SuspendLayout();
            this.tbcReporte.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtroGruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(784, 53);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(214, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(357, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reporte de Precios y Existencias";
            // 
            // tbcReporte
            // 
            this.tbcReporte.Controls.Add(this.tabPage1);
            this.tbcReporte.Controls.Add(this.tabPage2);
            this.tbcReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcReporte.Location = new System.Drawing.Point(0, 53);
            this.tbcReporte.Name = "tbcReporte";
            this.tbcReporte.SelectedIndex = 0;
            this.tbcReporte.Size = new System.Drawing.Size(784, 509);
            this.tbcReporte.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbLoading);
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoading.Image = global::ReporteExistenciaPrecio.Properties.Resources.loading;
            this.pbLoading.Location = new System.Drawing.Point(152, 6);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(473, 334);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 2;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(693, 442);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 30);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblLoading);
            this.groupBox2.Controls.Add(this.gridGrupos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupos de Artículos";
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.BackColor = System.Drawing.Color.Black;
            this.lblLoading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(144, 231);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(473, 34);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Cargando datos...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoading.Visible = false;
            // 
            // gridGrupos
            // 
            this.gridGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGrupos.DataSource = this.filtroGruposBindingSource;
            this.gridGrupos.Location = new System.Drawing.Point(131, 38);
            this.gridGrupos.MainView = this.gvGrupos;
            this.gridGrupos.Name = "gridGrupos";
            this.gridGrupos.Size = new System.Drawing.Size(502, 280);
            this.gridGrupos.TabIndex = 1;
            this.gridGrupos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGrupos});
            // 
            // filtroGruposBindingSource
            // 
            this.filtroGruposBindingSource.DataSource = typeof(ReporteExistenciaPrecio.Modelos.FiltroGrupos);
            // 
            // gvGrupos
            // 
            this.gvGrupos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvGrupos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvGrupos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvGrupos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvGrupos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvGrupos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvGrupos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvGrupos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvGrupos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvGrupos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvGrupos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvGrupos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvGrupos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvGrupos.Appearance.Empty.Options.UseBackColor = true;
            this.gvGrupos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvGrupos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvGrupos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvGrupos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvGrupos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvGrupos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvGrupos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvGrupos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvGrupos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvGrupos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvGrupos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvGrupos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvGrupos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvGrupos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvGrupos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvGrupos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvGrupos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvGrupos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvGrupos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvGrupos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvGrupos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvGrupos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvGrupos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvGrupos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvGrupos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvGrupos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvGrupos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvGrupos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvGrupos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvGrupos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvGrupos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvGrupos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvGrupos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvGrupos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvGrupos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvGrupos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvGrupos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvGrupos.Appearance.GroupRow.Options.UseFont = true;
            this.gvGrupos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvGrupos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvGrupos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvGrupos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvGrupos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvGrupos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvGrupos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvGrupos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvGrupos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvGrupos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvGrupos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvGrupos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvGrupos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvGrupos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvGrupos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvGrupos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvGrupos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvGrupos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvGrupos.Appearance.Preview.Options.UseBackColor = true;
            this.gvGrupos.Appearance.Preview.Options.UseForeColor = true;
            this.gvGrupos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvGrupos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.Row.Options.UseBackColor = true;
            this.gvGrupos.Appearance.Row.Options.UseForeColor = true;
            this.gvGrupos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvGrupos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvGrupos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvGrupos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvGrupos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvGrupos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvGrupos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvGrupos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvGrupos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeleccion,
            this.colGrupo});
            this.gvGrupos.GridControl = this.gridGrupos;
            this.gvGrupos.Name = "gvGrupos";
            this.gvGrupos.OptionsCustomization.AllowGroup = false;
            this.gvGrupos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvGrupos.OptionsView.EnableAppearanceOddRow = true;
            this.gvGrupos.OptionsView.ShowGroupPanel = false;
            // 
            // colSeleccion
            // 
            this.colSeleccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colSeleccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeleccion.Caption = "-";
            this.colSeleccion.FieldName = "Seleccion";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.Visible = true;
            this.colSeleccion.VisibleIndex = 0;
            // 
            // colGrupo
            // 
            this.colGrupo.FieldName = "Grupo";
            this.colGrupo.Name = "colGrupo";
            this.colGrupo.OptionsColumn.AllowEdit = false;
            this.colGrupo.Visible = true;
            this.colGrupo.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione los grupos de artículos a mostrar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbAlmacenes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacenes";
            // 
            // cbAlmacenes
            // 
            this.cbAlmacenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlmacenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlmacenes.FormattingEnabled = true;
            this.cbAlmacenes.Location = new System.Drawing.Point(131, 44);
            this.cbAlmacenes.Name = "cbAlmacenes";
            this.cbAlmacenes.Size = new System.Drawing.Size(502, 24);
            this.cbAlmacenes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el almacen:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnImprimir);
            this.tabPage2.Controls.Add(this.pnlResultados);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(693, 442);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pnlResultados
            // 
            this.pnlResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResultados.Controls.Add(this.gridResultados);
            this.pnlResultados.Location = new System.Drawing.Point(8, 6);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(762, 430);
            this.pnlResultados.TabIndex = 1;
            // 
            // gridResultados
            // 
            this.gridResultados.DataSource = this.reporteBindingSource;
            this.gridResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResultados.Location = new System.Drawing.Point(0, 0);
            this.gridResultados.MainView = this.gvResultados;
            this.gridResultados.Name = "gridResultados";
            this.gridResultados.Size = new System.Drawing.Size(762, 430);
            this.gridResultados.TabIndex = 0;
            this.gridResultados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResultados});
            // 
            // reporteBindingSource
            // 
            this.reporteBindingSource.DataSource = typeof(ReporteExistenciaPrecio.Modelos.Reporte);
            // 
            // gvResultados
            // 
            this.gvResultados.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvResultados.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvResultados.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvResultados.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvResultados.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvResultados.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvResultados.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvResultados.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvResultados.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvResultados.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvResultados.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvResultados.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvResultados.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvResultados.Appearance.Empty.Options.UseBackColor = true;
            this.gvResultados.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvResultados.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvResultados.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvResultados.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvResultados.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvResultados.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvResultados.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvResultados.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvResultados.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvResultados.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvResultados.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvResultados.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvResultados.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvResultados.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvResultados.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvResultados.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvResultados.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvResultados.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvResultados.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvResultados.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvResultados.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvResultados.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvResultados.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvResultados.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvResultados.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvResultados.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvResultados.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvResultados.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvResultados.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvResultados.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvResultados.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvResultados.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvResultados.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvResultados.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvResultados.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvResultados.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvResultados.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvResultados.Appearance.GroupRow.Options.UseFont = true;
            this.gvResultados.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvResultados.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvResultados.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvResultados.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvResultados.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvResultados.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvResultados.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvResultados.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvResultados.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvResultados.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvResultados.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvResultados.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvResultados.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvResultados.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvResultados.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.OddRow.Options.UseBackColor = true;
            this.gvResultados.Appearance.OddRow.Options.UseForeColor = true;
            this.gvResultados.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvResultados.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvResultados.Appearance.Preview.Options.UseBackColor = true;
            this.gvResultados.Appearance.Preview.Options.UseForeColor = true;
            this.gvResultados.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvResultados.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.Row.Options.UseBackColor = true;
            this.gvResultados.Appearance.Row.Options.UseForeColor = true;
            this.gvResultados.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvResultados.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvResultados.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvResultados.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvResultados.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvResultados.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvResultados.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvResultados.Appearance.VertLine.Options.UseBackColor = true;
            this.gvResultados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colArticulo,
            this.colExistencia,
            this.colPrecioFilial,
            this.colPrecioMayoreo,
            this.colPrecioLista});
            this.gvResultados.GridControl = this.gridResultados;
            this.gvResultados.Name = "gvResultados";
            this.gvResultados.OptionsBehavior.Editable = false;
            this.gvResultados.OptionsCustomization.AllowGroup = false;
            this.gvResultados.OptionsView.EnableAppearanceEvenRow = true;
            this.gvResultados.OptionsView.EnableAppearanceOddRow = true;
            this.gvResultados.OptionsView.ShowGroupPanel = false;
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 0;
            // 
            // colExistencia
            // 
            this.colExistencia.DisplayFormat.FormatString = "n";
            this.colExistencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExistencia.FieldName = "Existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.Visible = true;
            this.colExistencia.VisibleIndex = 1;
            // 
            // colPrecioFilial
            // 
            this.colPrecioFilial.DisplayFormat.FormatString = "C";
            this.colPrecioFilial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioFilial.FieldName = "PrecioFilial";
            this.colPrecioFilial.Name = "colPrecioFilial";
            this.colPrecioFilial.Visible = true;
            this.colPrecioFilial.VisibleIndex = 2;
            // 
            // colPrecioMayoreo
            // 
            this.colPrecioMayoreo.DisplayFormat.FormatString = "C";
            this.colPrecioMayoreo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioMayoreo.FieldName = "PrecioMayoreo";
            this.colPrecioMayoreo.Name = "colPrecioMayoreo";
            this.colPrecioMayoreo.Visible = true;
            this.colPrecioMayoreo.VisibleIndex = 3;
            // 
            // colPrecioLista
            // 
            this.colPrecioLista.DisplayFormat.FormatString = "C";
            this.colPrecioLista.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioLista.FieldName = "PrecioLista";
            this.colPrecioLista.Name = "colPrecioLista";
            this.colPrecioLista.Visible = true;
            this.colPrecioLista.VisibleIndex = 4;
            // 
            // hiloConsulta
            // 
            this.hiloConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.hiloConsulta_DoWork);
            this.hiloConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.hiloConsulta_RunWorkerCompleted);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tbcReporte);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Principal";
            this.Text = "Reporte de precios y existencias";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.tbcReporte.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtroGruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGrupos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tbcReporte;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridGrupos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGrupos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlmacenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private DevExpress.XtraGrid.GridControl gridResultados;
        private DevExpress.XtraGrid.Views.Grid.GridView gvResultados;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.BindingSource filtroGruposBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccion;
        private System.Windows.Forms.BindingSource reporteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioMayoreo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioLista;
        private System.ComponentModel.BackgroundWorker hiloConsulta;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lblLoading;
    }
}