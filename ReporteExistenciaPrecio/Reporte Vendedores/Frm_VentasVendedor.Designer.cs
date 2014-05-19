namespace ReporteExistenciaPrecio.Reporte_Vendedores
{
    partial class Frm_VentasVendedor
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
            this.tabControlVendores = new System.Windows.Forms.TabControl();
            this.tabPageFiltros = new System.Windows.Forms.TabPage();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbVendedores = new System.Windows.Forms.GroupBox();
            this.gridVendedores = new DevExpress.XtraGrid.GridControl();
            this.vendedoresGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVendedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeleccionado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbPeriodo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabPageResultados = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gridReporteVendedores = new DevExpress.XtraGrid.GridControl();
            this.reporteVendedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvReporteVendedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVendedor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVentaTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadesVendidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUltimoCostoUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hiloConsulta = new System.ComponentModel.BackgroundWorker();
            this.tabControlVendores.SuspendLayout();
            this.tabPageFiltros.SuspendLayout();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendedores)).BeginInit();
            this.gbPeriodo.SuspendLayout();
            this.tabPageResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReporteVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteVendedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReporteVendedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVendores
            // 
            this.tabControlVendores.Controls.Add(this.tabPageFiltros);
            this.tabControlVendores.Controls.Add(this.tabPageResultados);
            this.tabControlVendores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVendores.Location = new System.Drawing.Point(0, 55);
            this.tabControlVendores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlVendores.Name = "tabControlVendores";
            this.tabControlVendores.SelectedIndex = 0;
            this.tabControlVendores.Size = new System.Drawing.Size(784, 507);
            this.tabControlVendores.TabIndex = 0;
            // 
            // tabPageFiltros
            // 
            this.tabPageFiltros.Controls.Add(this.panelLoading);
            this.tabPageFiltros.Controls.Add(this.gbVendedores);
            this.tabPageFiltros.Controls.Add(this.gbPeriodo);
            this.tabPageFiltros.Controls.Add(this.btnConsultar);
            this.tabPageFiltros.Location = new System.Drawing.Point(4, 25);
            this.tabPageFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageFiltros.Name = "tabPageFiltros";
            this.tabPageFiltros.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageFiltros.Size = new System.Drawing.Size(776, 478);
            this.tabPageFiltros.TabIndex = 0;
            this.tabPageFiltros.Text = "Filtros";
            this.tabPageFiltros.UseVisualStyleBackColor = true;
            // 
            // panelLoading
            // 
            this.panelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLoading.BackColor = System.Drawing.Color.DimGray;
            this.panelLoading.Controls.Add(this.label4);
            this.panelLoading.Controls.Add(this.pictureBox1);
            this.panelLoading.Location = new System.Drawing.Point(274, 143);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(228, 192);
            this.panelLoading.TabIndex = 1;
            this.panelLoading.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cargando datos...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ReporteExistenciaPrecio.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbVendedores
            // 
            this.gbVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVendedores.Controls.Add(this.gridVendedores);
            this.gbVendedores.Location = new System.Drawing.Point(8, 86);
            this.gbVendedores.Name = "gbVendedores";
            this.gbVendedores.Size = new System.Drawing.Size(760, 348);
            this.gbVendedores.TabIndex = 5;
            this.gbVendedores.TabStop = false;
            this.gbVendedores.Text = "Vendedores";
            // 
            // gridVendedores
            // 
            this.gridVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVendedores.DataSource = this.vendedoresGridBindingSource;
            this.gridVendedores.Location = new System.Drawing.Point(6, 22);
            this.gridVendedores.MainView = this.gvVendedores;
            this.gridVendedores.Name = "gridVendedores";
            this.gridVendedores.Size = new System.Drawing.Size(748, 320);
            this.gridVendedores.TabIndex = 0;
            this.gridVendedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVendedores});
            // 
            // vendedoresGridBindingSource
            // 
            this.vendedoresGridBindingSource.DataSource = typeof(ReporteExistenciaPrecio.Modelos.Reporte_Vendedores.VendedoresGrid);
            // 
            // gvVendedores
            // 
            this.gvVendedores.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVendedores.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVendedores.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvVendedores.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvVendedores.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvVendedores.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvVendedores.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvVendedores.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvVendedores.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVendedores.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvVendedores.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvVendedores.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvVendedores.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvVendedores.Appearance.Empty.Options.UseBackColor = true;
            this.gvVendedores.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvVendedores.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvVendedores.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVendedores.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVendedores.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvVendedores.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvVendedores.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvVendedores.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvVendedores.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvVendedores.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvVendedores.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvVendedores.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvVendedores.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvVendedores.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvVendedores.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvVendedores.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvVendedores.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvVendedores.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvVendedores.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvVendedores.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvVendedores.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVendedores.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVendedores.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvVendedores.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvVendedores.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvVendedores.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVendedores.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVendedores.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvVendedores.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvVendedores.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvVendedores.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVendedores.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVendedores.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvVendedores.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvVendedores.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvVendedores.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvVendedores.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvVendedores.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvVendedores.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVendedores.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvVendedores.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvVendedores.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvVendedores.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvVendedores.Appearance.GroupRow.Options.UseFont = true;
            this.gvVendedores.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvVendedores.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvVendedores.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvVendedores.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvVendedores.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvVendedores.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvVendedores.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvVendedores.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvVendedores.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvVendedores.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvVendedores.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvVendedores.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvVendedores.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvVendedores.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvVendedores.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.OddRow.Options.UseBackColor = true;
            this.gvVendedores.Appearance.OddRow.Options.UseForeColor = true;
            this.gvVendedores.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvVendedores.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvVendedores.Appearance.Preview.Options.UseBackColor = true;
            this.gvVendedores.Appearance.Preview.Options.UseForeColor = true;
            this.gvVendedores.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvVendedores.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvVendedores.Appearance.Row.Options.UseBackColor = true;
            this.gvVendedores.Appearance.Row.Options.UseForeColor = true;
            this.gvVendedores.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvVendedores.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvVendedores.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvVendedores.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvVendedores.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvVendedores.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvVendedores.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvVendedores.Appearance.VertLine.Options.UseBackColor = true;
            this.gvVendedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeleccionado,
            this.colVendedor});
            this.gvVendedores.GridControl = this.gridVendedores;
            this.gvVendedores.Name = "gvVendedores";
            this.gvVendedores.OptionsView.EnableAppearanceEvenRow = true;
            this.gvVendedores.OptionsView.EnableAppearanceOddRow = true;
            this.gvVendedores.OptionsView.ShowGroupPanel = false;
            // 
            // colSeleccionado
            // 
            this.colSeleccionado.Caption = " ";
            this.colSeleccionado.FieldName = "Seleccionado";
            this.colSeleccionado.Name = "colSeleccionado";
            this.colSeleccionado.Visible = true;
            this.colSeleccionado.VisibleIndex = 0;
            this.colSeleccionado.Width = 55;
            // 
            // colVendedor
            // 
            this.colVendedor.FieldName = "Vendedor";
            this.colVendedor.Name = "colVendedor";
            this.colVendedor.OptionsColumn.AllowEdit = false;
            this.colVendedor.Visible = true;
            this.colVendedor.VisibleIndex = 1;
            this.colVendedor.Width = 580;
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPeriodo.Controls.Add(this.label3);
            this.gbPeriodo.Controls.Add(this.dtpFinal);
            this.gbPeriodo.Controls.Add(this.label2);
            this.gbPeriodo.Controls.Add(this.dtpInicial);
            this.gbPeriodo.Location = new System.Drawing.Point(8, 7);
            this.gbPeriodo.Name = "gbPeriodo";
            this.gbPeriodo.Size = new System.Drawing.Size(760, 73);
            this.gbPeriodo.TabIndex = 4;
            this.gbPeriodo.TabStop = false;
            this.gbPeriodo.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Final:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFinal.CustomFormat = "dd/MMMM/yyyy";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(417, 35);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 23);
            this.dtpFinal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicial:";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpInicial.CustomFormat = "dd/MMMM/yyyy";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(143, 33);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(200, 23);
            this.dtpInicial.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(693, 440);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 30);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tabPageResultados
            // 
            this.tabPageResultados.Controls.Add(this.btnImprimir);
            this.tabPageResultados.Controls.Add(this.gridReporteVendedores);
            this.tabPageResultados.Location = new System.Drawing.Point(4, 25);
            this.tabPageResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageResultados.Name = "tabPageResultados";
            this.tabPageResultados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageResultados.Size = new System.Drawing.Size(776, 478);
            this.tabPageResultados.TabIndex = 1;
            this.tabPageResultados.Text = "Resultados";
            this.tabPageResultados.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(693, 440);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gridReporteVendedores
            // 
            this.gridReporteVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReporteVendedores.DataSource = this.reporteVendedoresBindingSource;
            this.gridReporteVendedores.Location = new System.Drawing.Point(6, 7);
            this.gridReporteVendedores.MainView = this.gvReporteVendedores;
            this.gridReporteVendedores.Name = "gridReporteVendedores";
            this.gridReporteVendedores.Size = new System.Drawing.Size(762, 427);
            this.gridReporteVendedores.TabIndex = 0;
            this.gridReporteVendedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReporteVendedores});
            // 
            // reporteVendedoresBindingSource
            // 
            this.reporteVendedoresBindingSource.DataSource = typeof(ReporteExistenciaPrecio.Modelos.Reporte_Vendedores.ReporteVendedores);
            // 
            // gvReporteVendedores
            // 
            this.gvReporteVendedores.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvReporteVendedores.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporteVendedores.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvReporteVendedores.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvReporteVendedores.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvReporteVendedores.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvReporteVendedores.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporteVendedores.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvReporteVendedores.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvReporteVendedores.Appearance.Empty.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvReporteVendedores.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporteVendedores.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvReporteVendedores.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvReporteVendedores.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvReporteVendedores.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvReporteVendedores.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvReporteVendedores.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvReporteVendedores.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvReporteVendedores.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvReporteVendedores.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporteVendedores.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvReporteVendedores.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporteVendedores.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporteVendedores.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvReporteVendedores.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporteVendedores.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporteVendedores.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvReporteVendedores.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvReporteVendedores.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporteVendedores.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporteVendedores.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvReporteVendedores.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvReporteVendedores.Appearance.GroupRow.Options.UseFont = true;
            this.gvReporteVendedores.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvReporteVendedores.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporteVendedores.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporteVendedores.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvReporteVendedores.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvReporteVendedores.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvReporteVendedores.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvReporteVendedores.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvReporteVendedores.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.OddRow.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.OddRow.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvReporteVendedores.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvReporteVendedores.Appearance.Preview.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.Preview.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvReporteVendedores.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvReporteVendedores.Appearance.Row.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.Row.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvReporteVendedores.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvReporteVendedores.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvReporteVendedores.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvReporteVendedores.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvReporteVendedores.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvReporteVendedores.Appearance.VertLine.Options.UseBackColor = true;
            this.gvReporteVendedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVendedor1,
            this.colArticulo,
            this.colVentaTotal,
            this.colUnidadesVendidas,
            this.colUltimoCostoUnitario,
            this.colCostoTotal,
            this.colUtilidad});
            this.gvReporteVendedores.GridControl = this.gridReporteVendedores;
            this.gvReporteVendedores.GroupCount = 1;
            this.gvReporteVendedores.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VentaTotal", null, "Venta Total: {0:c}")});
            this.gvReporteVendedores.Name = "gvReporteVendedores";
            this.gvReporteVendedores.OptionsBehavior.Editable = false;
            this.gvReporteVendedores.OptionsView.EnableAppearanceEvenRow = true;
            this.gvReporteVendedores.OptionsView.EnableAppearanceOddRow = true;
            this.gvReporteVendedores.OptionsView.ShowGroupPanel = false;
            this.gvReporteVendedores.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colVendedor1, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvReporteVendedores.EndGrouping += new System.EventHandler(this.gvReporteVendedores_EndGrouping);
            // 
            // colVendedor1
            // 
            this.colVendedor1.FieldName = "Vendedor";
            this.colVendedor1.Name = "colVendedor1";
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 0;
            // 
            // colVentaTotal
            // 
            this.colVentaTotal.DisplayFormat.FormatString = "c";
            this.colVentaTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVentaTotal.FieldName = "VentaTotal";
            this.colVentaTotal.Name = "colVentaTotal";
            this.colVentaTotal.Visible = true;
            this.colVentaTotal.VisibleIndex = 2;
            // 
            // colUnidadesVendidas
            // 
            this.colUnidadesVendidas.DisplayFormat.FormatString = "n";
            this.colUnidadesVendidas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnidadesVendidas.FieldName = "UnidadesVendidas";
            this.colUnidadesVendidas.Name = "colUnidadesVendidas";
            this.colUnidadesVendidas.Visible = true;
            this.colUnidadesVendidas.VisibleIndex = 1;
            // 
            // colUltimoCostoUnitario
            // 
            this.colUltimoCostoUnitario.Caption = "Ultimo costo unitario";
            this.colUltimoCostoUnitario.DisplayFormat.FormatString = "c";
            this.colUltimoCostoUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUltimoCostoUnitario.FieldName = "UltimoCostoUnitario";
            this.colUltimoCostoUnitario.Name = "colUltimoCostoUnitario";
            this.colUltimoCostoUnitario.ToolTip = "Ultimo Costo Unitario";
            this.colUltimoCostoUnitario.Visible = true;
            this.colUltimoCostoUnitario.VisibleIndex = 3;
            // 
            // colCostoTotal
            // 
            this.colCostoTotal.DisplayFormat.FormatString = "c";
            this.colCostoTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCostoTotal.FieldName = "CostoTotal";
            this.colCostoTotal.Name = "colCostoTotal";
            this.colCostoTotal.OptionsColumn.ReadOnly = true;
            this.colCostoTotal.Visible = true;
            this.colCostoTotal.VisibleIndex = 4;
            // 
            // colUtilidad
            // 
            this.colUtilidad.DisplayFormat.FormatString = "c";
            this.colUtilidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUtilidad.FieldName = "Utilidad";
            this.colUtilidad.Name = "colUtilidad";
            this.colUtilidad.OptionsColumn.ReadOnly = true;
            this.colUtilidad.Visible = true;
            this.colUtilidad.VisibleIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas por vendedor";
            // 
            // hiloConsulta
            // 
            this.hiloConsulta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.hiloConsulta_DoWork);
            this.hiloConsulta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.hiloConsulta_RunWorkerCompleted);
            // 
            // Frm_VentasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControlVendores);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_VentasVendedor";
            this.Text = "Reporte de ventas por vendedor";
            this.Shown += new System.EventHandler(this.Frm_VentasVendedor_Shown);
            this.tabControlVendores.ResumeLayout(false);
            this.tabPageFiltros.ResumeLayout(false);
            this.panelLoading.ResumeLayout(false);
            this.panelLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbVendedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedoresGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendedores)).EndInit();
            this.gbPeriodo.ResumeLayout(false);
            this.gbPeriodo.PerformLayout();
            this.tabPageResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridReporteVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteVendedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReporteVendedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVendores;
        private System.Windows.Forms.TabPage tabPageFiltros;
        private System.Windows.Forms.TabPage tabPageResultados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridVendedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVendedores;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.BindingSource vendedoresGridBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccionado;
        private DevExpress.XtraGrid.Columns.GridColumn colVendedor;
        private System.Windows.Forms.Button btnImprimir;
        private DevExpress.XtraGrid.GridControl gridReporteVendedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReporteVendedores;
        private System.Windows.Forms.BindingSource reporteVendedoresBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colVendedor1;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colVentaTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadesVendidas;
        private DevExpress.XtraGrid.Columns.GridColumn colUltimoCostoUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colCostoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilidad;
        private System.ComponentModel.BackgroundWorker hiloConsulta;
        private System.Windows.Forms.GroupBox gbVendedores;
        private System.Windows.Forms.GroupBox gbPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}