Imports Solmicro.Expertis.Application.ERP.CommonClasses
Imports Solmicro.Expertis.Business.BusinessEnum
Imports Janus.Windows
Imports Solmicro.Expertis.Business.CRM

Public Class MntoProveedores
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        'Me.jngBancos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBanco", "Banco", "IDBanco", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescBanco", "DescBanco")}))})
        'Me.jngDirecciones.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescAlmacen", "DescAlmacen")}))})
        Me.jngArtLinea.ParentData = Me.jngArticulos
        Dim StrIDS(1) As String
        StrIDS(0) = "IDProveedor"
        StrIDS(1) = "IDArticulo"
        Me.jngArtLinea.LinkFields = StrIDS
        Me.jngArtLinea.ParentLinkFields = StrIDS
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then

            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Public WithEvents lblfwiTipoProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIdMercado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIdPais As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFax As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiFax As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTelefono As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiTelefono As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiProvincia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiRazonSocial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCifProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiCifProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiPoblacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiCodigoPostal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDescProveedor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiDireccion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIdZona As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaAlta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaAlta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiEMail As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiEMail As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwiIDTipoClasif As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiRazonSocial As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFwiWeb As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiWeb As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents LblfwiIDioma As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblIDEmpresa As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtIDEmpresa As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents TabProveedores As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents lblfwiTipoFacturacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiAgrupFactura As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiAgrupAlbaran As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiDto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIdBancoPropio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiDiaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIdFPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIdCPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIDTipoIVA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIDMoneda As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCCFianza As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCCAnticipo As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCCRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ullCCRetencion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advCCRetencion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ullCCAnticipo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advCCAnticipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ullCCFianza As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advCCFianza As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ChkEmpresaGrupo As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblFwiModoTransporte As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIDCEnvio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIDFEnvio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiAlmacenProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwIPorcentajeTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwIPorcentajeTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents jngBancos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngArticulos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngFamilia As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngDirecciones As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents jngVacaciones As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents Frame3 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiGrupoFactura As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fwiGrupoArticulo As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblfwiIdGrupoProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TabPagePicArticulos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents PicCabecera As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents Splitter1 As System.Windows.Forms.Splitter
    Public WithEvents lblIDIdioma As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TabPagePicDatosEconomicos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicDirecciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicBancos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicEnvio As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicObservaciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicVacaciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicFamilias As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicGrupoProv As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicCalidad As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicCContables As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FrmObservaciones As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiTexto As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents Frame7 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents jngObservaciones As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents PnlMsgVacaciones As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents TxtMsgVacaciones As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FraEnvio As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraAlmacen As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FraPorcentaje As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiCertificadoCalidad As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fwiImprimirEspecificacion As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fwiHomologable As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents fwiCalidadConcertada As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents lblFwiFechaValidez As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiAuditor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiReferencial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaValidez As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiNCertificado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiNCertificado As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiFechaHomologacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaHomologacion As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents jngArtLinea As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents txtIDProveedor As Solmicro.Expertis.Engine.UI.CounterTextBox
    Public WithEvents lblProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvAlmacenProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDReferencial As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDGrupoProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDIdioma As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDTipoProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDMercado As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDPais As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDZona As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvIDTipoClasif As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ulDescBancoPropio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescDiaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescFPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescCPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescTipoIVA As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescModoTransporte As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescCEnvio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescFEnvio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescAlmacenProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescAuditor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescReferencial As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescGrupoProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescIdioma As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescTipoProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescMercado As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescZona As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescTipoClasif As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents cbxAgrupAlbaran As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxTipoFacturacion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxAgrupFactura As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDBancoPropio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDDiaPago As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDFPago As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDCPago As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDTipoIVA As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDMoneda As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxEmpresa As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDModoTransporte As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDCEnvio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDFEnvio As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDAuditor As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents TxtRefCliente As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FrmCondicionesPago As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents PnlAgrupCContables As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents FrmAgrupaciones As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents FrmCuentas As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ullCCEfectos As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advCCEfectos As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCCEfectos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCCProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ullCCProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advCCProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents CmbTipoDocIdent As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents LblTipoDocIdent As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TxtNIFRepresen As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents LblNIFRepresen As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCodigoPostal As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents TxtPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents Graphic1 As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents Graphic As Janus.Windows.UI.CommandBars.UICommand
    Public WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents FrmFacturacion As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblTipoRetencion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxTipoRetencion As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiRetencionIRPF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxSerieAbonos As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents cbxIDTipoAsiento As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblfwiIDTipoAsiento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiRetencionIRPF As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiRegEspecial As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwiSerieAbonos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwiSerieCargos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxSerieCargos As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents Frame5 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ulDescCalificacionCC As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents ulDescCalificacion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblfwiResultadoCC As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiResultado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiCalificacionCC As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiCalificacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiResultadoCC As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents AdvIDCalificacionCC As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiFechaUltimaCalificacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaUltimaCalificacion As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents fwiResultado As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents AdvIDCalificacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblMovil As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtMovil As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTelefono2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtTelefono2 As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents FraDeclaraciones As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents chkIVACaja As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents ChkActivo As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents AdvIDCNAE As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCNAE As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulbladvCCFraPdte As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advCCFraPdte As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCCFraPdte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabPagePagos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents chbpiso As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblpiso As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbluz As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblluz As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbfianza As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblfianza As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbTotalGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbTotalAlquiler As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalAlquiler As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbvarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblvarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbgas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblgas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbagua As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblagua As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbretencion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblretencion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbiva As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lbliva As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbrenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblrenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbTotalPagar As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalPagar As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblRefCliente As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxAgrupAlbaran_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxAgrupFactura_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoFacturacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDCPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDFPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDDiaPago_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDBancoPropio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDMoneda_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDTipoIVA_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoRetencion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxSerieAbonos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxSerieCargos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEmpresa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDModoTransporte_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDCEnvio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDFEnvio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngBancos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngBancos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage")
        Dim jngArticulos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngArticulos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage")
        Dim jngArticulos_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage")
        Dim jngArtLinea_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngDirecciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngDirecciones_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage")
        Dim jngDirecciones_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column18.ButtonImage")
        Dim jngFamilia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngFamilia_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage")
        Dim jngFamilia_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column4.ButtonImage")
        Dim jngVacaciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngObservaciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDAuditor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbTipoDocIdent_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoProveedores))
        Me.TabProveedores = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPagePicDatosEconomicos = New Janus.Windows.UI.Tab.UITabPage
        Me.PnlAgrupCContables = New Solmicro.Expertis.Engine.UI.Panel
        Me.FrmAgrupaciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiAgrupAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiAgrupFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTipoFacturacion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxAgrupAlbaran = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxAgrupFactura = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxTipoFacturacion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FrmCuentas = New Solmicro.Expertis.Engine.UI.Frame
        Me.ullCCEfectos = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advCCEfectos = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCCEfectos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCCProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.ullCCProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advCCProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FrmCondicionesPago = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiDto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiIdFPago = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDCPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescCPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblfwiIdCPago = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDFPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescFPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxIDDiaPago = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescDiaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblfwiDiaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDBancoPropio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescBancoPropio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblfwiIdBancoPropio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiIDTipoIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiDto = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDMoneda = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblfwiIDMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDTipoIVA = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescTipoIVA = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.FraDeclaraciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkIVACaja = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.FrmFacturacion = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTipoRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoRetencion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiRetencionIRPF = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxSerieAbonos = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.cbxIDTipoAsiento = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiIDTipoAsiento = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRetencionIRPF = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiRegEspecial = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiSerieAbonos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiSerieCargos = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxSerieCargos = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.TabPagePicCContables = New Janus.Windows.UI.Tab.UITabPage
        Me.ulbladvCCFraPdte = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advCCFraPdte = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCCFraPdte = New Solmicro.Expertis.Engine.UI.Label
        Me.ChkEmpresaGrupo = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.cbxEmpresa = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ullCCFianza = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advCCFianza = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ullCCAnticipo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advCCAnticipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ullCCRetencion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advCCRetencion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCCRetencion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCCAnticipo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCCFianza = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPagePicEnvio = New Janus.Windows.UI.Tab.UITabPage
        Me.FraPorcentaje = New Solmicro.Expertis.Engine.UI.Frame
        Me.FwIPorcentajeTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblFwIPorcentajeTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.FraAlmacen = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiAlmacenProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescAlmacenProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvAlmacenProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraEnvio = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFwiModoTransporte = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescModoTransporte = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxIDModoTransporte = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiIDCEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescCEnvio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxIDCEnvio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiIDFEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescFEnvio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxIDFEnvio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.TabPagePicBancos = New Janus.Windows.UI.Tab.UITabPage
        Me.jngBancos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicArticulos = New Janus.Windows.UI.Tab.UITabPage
        Me.jngArticulos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.jngArtLinea = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicDirecciones = New Janus.Windows.UI.Tab.UITabPage
        Me.jngDirecciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicFamilias = New Janus.Windows.UI.Tab.UITabPage
        Me.jngFamilia = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicVacaciones = New Janus.Windows.UI.Tab.UITabPage
        Me.jngVacaciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlMsgVacaciones = New Solmicro.Expertis.Engine.UI.Panel
        Me.TxtMsgVacaciones = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabPagePicObservaciones = New Janus.Windows.UI.Tab.UITabPage
        Me.FrmObservaciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Frame7 = New Solmicro.Expertis.Engine.UI.Frame
        Me.jngObservaciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPagePicCalidad = New Janus.Windows.UI.Tab.UITabPage
        Me.Frame5 = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulDescCalificacionCC = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescCalificacion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblfwiResultadoCC = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiResultado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiCalificacionCC = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiCalificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiResultadoCC = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.AdvIDCalificacionCC = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFechaUltimaCalificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaUltimaCalificacion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiResultado = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.AdvIDCalificacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Frame3 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiNCertificado = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNCertificado = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiFechaHomologacion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaHomologacion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFwiFechaValidez = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiAuditor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiReferencial = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaValidez = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ulDescAuditor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxIDAuditor = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.ulDescReferencial = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDReferencial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fwiCertificadoCalidad = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiImprimirEspecificacion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiHomologable = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiCalidadConcertada = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.TabPagePicGrupoProv = New Janus.Windows.UI.Tab.UITabPage
        Me.fwiGrupoFactura = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.fwiGrupoArticulo = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblfwiIdGrupoProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescGrupoProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDGrupoProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPagePagos = New Janus.Windows.UI.Tab.UITabPage
        Me.ntbTotalPagar = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPagar = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbTotalGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbTotalAlquiler = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalAlquiler = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbvarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblvarios = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbgas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblgas = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbagua = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblagua = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbretencion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblretencion = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbiva = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lbliva = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbrenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblrenta = New Solmicro.Expertis.Engine.UI.Label
        Me.chbpiso = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblpiso = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbluz = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblluz = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbfianza = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfianza = New Solmicro.Expertis.Engine.UI.Label
        Me.PicCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.AdvIDCNAE = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCNAE = New Solmicro.Expertis.Engine.UI.Label
        Me.ChkActivo = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblMovil = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMovil = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTelefono2 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTelefono2 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TxtPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.fwiCodigoPostal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.CmbTipoDocIdent = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoDocIdent = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtNIFRepresen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblNIFRepresen = New Solmicro.Expertis.Engine.UI.Label
        Me.TxtRefCliente = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblRefCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDEmpresa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ulDescIdioma = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDIdioma = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblfwiIDioma = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiWeb = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiWeb = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiRazonSocial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiFechaAlta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.ulDescTipoProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDTipoProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdMercado = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescMercado = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDMercado = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdPais = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDPais = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFax = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFax = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiTelefono = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTelefono = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiRazonSocial = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiCifProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCifProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiCodigoPostal = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDescProveedor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDProveedor = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.lblfwiDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiIdZona = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescZona = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDZona = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFechaAlta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiEMail = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiEMail = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiIDTipoClasif = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescTipoClasif = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDTipoClasif = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiTipoProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDIdioma = New Solmicro.Expertis.Engine.UI.Label
        Me.Graphic = New Janus.Windows.UI.CommandBars.UICommand("Graphic")
        Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.Graphic1 = New Janus.Windows.UI.CommandBars.UICommand("Graphic")
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.TabProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabProveedores.SuspendLayout()
        Me.TabPagePicDatosEconomicos.SuspendLayout()
        Me.PnlAgrupCContables.suspendlayout()
        Me.FrmAgrupaciones.SuspendLayout()
        CType(Me.cbxAgrupAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxAgrupFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrmCuentas.SuspendLayout()
        Me.FrmCondicionesPago.SuspendLayout()
        CType(Me.cbxIDCPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDFPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDDiaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDBancoPropio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDTipoIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage1.SuspendLayout()
        Me.FraDeclaraciones.SuspendLayout()
        Me.FrmFacturacion.SuspendLayout()
        CType(Me.cbxTipoRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSerieAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDTipoAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxSerieCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicCContables.SuspendLayout()
        CType(Me.cbxEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicEnvio.SuspendLayout()
        Me.FraPorcentaje.SuspendLayout()
        Me.FraAlmacen.SuspendLayout()
        Me.FraEnvio.SuspendLayout()
        CType(Me.cbxIDModoTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDCEnvio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDFEnvio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicBancos.SuspendLayout()
        CType(Me.jngBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicArticulos.SuspendLayout()
        CType(Me.jngArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jngArtLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicDirecciones.SuspendLayout()
        CType(Me.jngDirecciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicFamilias.SuspendLayout()
        CType(Me.jngFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicVacaciones.SuspendLayout()
        CType(Me.jngVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMsgVacaciones.suspendlayout()
        Me.TabPagePicObservaciones.SuspendLayout()
        Me.FrmObservaciones.SuspendLayout()
        Me.Frame7.SuspendLayout()
        CType(Me.jngObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicCalidad.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.cbxIDAuditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicGrupoProv.SuspendLayout()
        Me.TabPagePagos.SuspendLayout()
        Me.PicCabecera.suspendlayout()
        CType(Me.CmbTipoDocIdent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Separator4, Me.Graphic1})
        Me.ToolBar.Size = New System.Drawing.Size(723, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Graphic})
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabProveedores)
        Me.MainPanel.Controls.Add(Me.PicCabecera)
        Me.MainPanel.Controls.Add(Me.lblIDIdioma)
        Me.MainPanel.Size = New System.Drawing.Size(715, 542)
        '
        'TabProveedores
        '
        Me.TabProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabProveedores.Location = New System.Drawing.Point(0, 252)
        Me.TabProveedores.Name = "TabProveedores"
        Me.TabProveedores.Size = New System.Drawing.Size(715, 290)
        Me.TabProveedores.TabIndex = 19
        Me.TabProveedores.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPagePicDatosEconomicos, Me.UiTabPage1, Me.TabPagePicCContables, Me.TabPagePicEnvio, Me.TabPagePicBancos, Me.TabPagePicArticulos, Me.TabPagePicDirecciones, Me.TabPagePicFamilias, Me.TabPagePicVacaciones, Me.TabPagePicObservaciones, Me.TabPagePicCalidad, Me.TabPagePicGrupoProv, Me.TabPagePagos})
        Me.TabProveedores.Text = "Cabecera Grupo "
        Me.TabProveedores.UseThemes = True
        '
        'TabPagePicDatosEconomicos
        '
        Me.TabPagePicDatosEconomicos.Controls.Add(Me.PnlAgrupCContables)
        Me.TabPagePicDatosEconomicos.Controls.Add(Me.FrmCondicionesPago)
        Me.TabPagePicDatosEconomicos.Key = "DatosEconomicos"
        Me.TabPagePicDatosEconomicos.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicDatosEconomicos.Name = "TabPagePicDatosEconomicos"
        Me.TabPagePicDatosEconomicos.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicDatosEconomicos.TabStop = True
        Me.TabPagePicDatosEconomicos.Text = "Datos Económicos"
        '
        'PnlAgrupCContables
        '
        Me.PnlAgrupCContables.Controls.Add(Me.FrmAgrupaciones)
        Me.PnlAgrupCContables.Controls.Add(Me.FrmCuentas)
        Me.PnlAgrupCContables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAgrupCContables.Location = New System.Drawing.Point(0, 117)
        Me.PnlAgrupCContables.Name = "PnlAgrupCContables"
        Me.PnlAgrupCContables.Size = New System.Drawing.Size(713, 151)
        Me.PnlAgrupCContables.TabIndex = 118
        '
        'FrmAgrupaciones
        '
        Me.FrmAgrupaciones.Controls.Add(Me.lblfwiAgrupAlbaran)
        Me.FrmAgrupaciones.Controls.Add(Me.lblfwiAgrupFactura)
        Me.FrmAgrupaciones.Controls.Add(Me.lblfwiTipoFacturacion)
        Me.FrmAgrupaciones.Controls.Add(Me.cbxAgrupAlbaran)
        Me.FrmAgrupaciones.Controls.Add(Me.cbxAgrupFactura)
        Me.FrmAgrupaciones.Controls.Add(Me.cbxTipoFacturacion)
        Me.FrmAgrupaciones.Location = New System.Drawing.Point(0, 0)
        Me.FrmAgrupaciones.Name = "FrmAgrupaciones"
        Me.FrmAgrupaciones.Size = New System.Drawing.Size(279, 93)
        Me.FrmAgrupaciones.TabIndex = 116
        Me.FrmAgrupaciones.TabStop = False
        Me.FrmAgrupaciones.Text = "Agrupaciones"
        '
        'lblfwiAgrupAlbaran
        '
        Me.lblfwiAgrupAlbaran.Location = New System.Drawing.Point(7, 21)
        Me.lblfwiAgrupAlbaran.Name = "lblfwiAgrupAlbaran"
        Me.lblfwiAgrupAlbaran.Size = New System.Drawing.Size(140, 13)
        Me.lblfwiAgrupAlbaran.TabIndex = 94
        Me.lblfwiAgrupAlbaran.Tag = "IdRec=6477;"
        Me.lblfwiAgrupAlbaran.Text = "Agrupar Albarán por ..."
        '
        'lblfwiAgrupFactura
        '
        Me.lblfwiAgrupFactura.Location = New System.Drawing.Point(7, 46)
        Me.lblfwiAgrupFactura.Name = "lblfwiAgrupFactura"
        Me.lblfwiAgrupFactura.Size = New System.Drawing.Size(137, 13)
        Me.lblfwiAgrupFactura.TabIndex = 92
        Me.lblfwiAgrupFactura.Tag = "IdRec=6478;"
        Me.lblfwiAgrupFactura.Text = "Agrupar Factura por ..."
        '
        'lblfwiTipoFacturacion
        '
        Me.lblfwiTipoFacturacion.Location = New System.Drawing.Point(7, 71)
        Me.lblfwiTipoFacturacion.Name = "lblfwiTipoFacturacion"
        Me.lblfwiTipoFacturacion.Size = New System.Drawing.Size(99, 13)
        Me.lblfwiTipoFacturacion.TabIndex = 0
        Me.lblfwiTipoFacturacion.Text = "Tipo Facturación"
        '
        'cbxAgrupAlbaran
        '
        Me.TryDataBinding(cbxAgrupAlbaran, New System.Windows.Forms.Binding("Value", Me, "AgrupAlbaran", True))
        cbxAgrupAlbaran_DesignTimeLayout.LayoutString = resources.GetString("cbxAgrupAlbaran_DesignTimeLayout.LayoutString")
        Me.cbxAgrupAlbaran.DesignTimeLayout = cbxAgrupAlbaran_DesignTimeLayout
        Me.cbxAgrupAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAgrupAlbaran.DisplayMember = "Value"
        Me.cbxAgrupAlbaran.Location = New System.Drawing.Point(151, 17)
        Me.cbxAgrupAlbaran.Name = "cbxAgrupAlbaran"
        Me.cbxAgrupAlbaran.PrimaryDataFields = "AgrupAlbaran"
        Me.cbxAgrupAlbaran.SecondaryDataFields = "Value"
        Me.cbxAgrupAlbaran.SelectedIndex = -1
        Me.cbxAgrupAlbaran.SelectedItem = Nothing
        Me.cbxAgrupAlbaran.Size = New System.Drawing.Size(112, 21)
        Me.cbxAgrupAlbaran.TabIndex = 31
        '
        'cbxAgrupFactura
        '
        Me.TryDataBinding(cbxAgrupFactura, New System.Windows.Forms.Binding("Value", Me, "AgrupFactura", True))
        cbxAgrupFactura_DesignTimeLayout.LayoutString = resources.GetString("cbxAgrupFactura_DesignTimeLayout.LayoutString")
        Me.cbxAgrupFactura.DesignTimeLayout = cbxAgrupFactura_DesignTimeLayout
        Me.cbxAgrupFactura.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAgrupFactura.DisplayMember = "Value"
        Me.cbxAgrupFactura.Location = New System.Drawing.Point(151, 42)
        Me.cbxAgrupFactura.Name = "cbxAgrupFactura"
        Me.cbxAgrupFactura.PrimaryDataFields = "AgrupFactura"
        Me.cbxAgrupFactura.SecondaryDataFields = "Value"
        Me.cbxAgrupFactura.SelectedIndex = -1
        Me.cbxAgrupFactura.SelectedItem = Nothing
        Me.cbxAgrupFactura.Size = New System.Drawing.Size(112, 21)
        Me.cbxAgrupFactura.TabIndex = 32
        '
        'cbxTipoFacturacion
        '
        Me.TryDataBinding(cbxTipoFacturacion, New System.Windows.Forms.Binding("Value", Me, "TipoFacturacion", True))
        cbxTipoFacturacion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoFacturacion_DesignTimeLayout.LayoutString")
        Me.cbxTipoFacturacion.DesignTimeLayout = cbxTipoFacturacion_DesignTimeLayout
        Me.cbxTipoFacturacion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoFacturacion.DisplayMember = "Value"
        Me.cbxTipoFacturacion.Location = New System.Drawing.Point(151, 67)
        Me.cbxTipoFacturacion.Name = "cbxTipoFacturacion"
        Me.cbxTipoFacturacion.PrimaryDataFields = "TipoFacturacion"
        Me.cbxTipoFacturacion.SecondaryDataFields = "Value"
        Me.cbxTipoFacturacion.SelectedIndex = -1
        Me.cbxTipoFacturacion.SelectedItem = Nothing
        Me.cbxTipoFacturacion.Size = New System.Drawing.Size(112, 21)
        Me.cbxTipoFacturacion.TabIndex = 33
        '
        'FrmCuentas
        '
        Me.FrmCuentas.Controls.Add(Me.ullCCEfectos)
        Me.FrmCuentas.Controls.Add(Me.advCCEfectos)
        Me.FrmCuentas.Controls.Add(Me.lblCCEfectos)
        Me.FrmCuentas.Controls.Add(Me.lblCCProveedor)
        Me.FrmCuentas.Controls.Add(Me.ullCCProveedor)
        Me.FrmCuentas.Controls.Add(Me.advCCProveedor)
        Me.FrmCuentas.Location = New System.Drawing.Point(281, 0)
        Me.FrmCuentas.Name = "FrmCuentas"
        Me.FrmCuentas.Size = New System.Drawing.Size(429, 93)
        Me.FrmCuentas.TabIndex = 117
        Me.FrmCuentas.TabStop = False
        Me.FrmCuentas.Text = "Cuentas Contables"
        '
        'ullCCEfectos
        '
        Me.ullCCEfectos.Location = New System.Drawing.Point(247, 52)
        Me.ullCCEfectos.Name = "ullCCEfectos"
        Me.ullCCEfectos.Size = New System.Drawing.Size(175, 21)
        Me.ullCCEfectos.TabIndex = 126
        '
        'advCCEfectos
        '
        Me.TryDataBinding(advCCEfectos, New System.Windows.Forms.Binding("Text", Me, "CCEfectos", True))
        Me.advCCEfectos.DisabledBackColor = System.Drawing.Color.White
        Me.advCCEfectos.EntityName = "PlanContable"
        Me.advCCEfectos.Location = New System.Drawing.Point(112, 54)
        Me.advCCEfectos.Name = "advCCEfectos"
        Me.advCCEfectos.PrimaryDataFields = "CCEfectos"
        Me.advCCEfectos.SecondaryDataFields = "IDCContable"
        Me.advCCEfectos.Size = New System.Drawing.Size(128, 23)
        Me.advCCEfectos.TabIndex = 122
        '
        'lblCCEfectos
        '
        Me.lblCCEfectos.Location = New System.Drawing.Point(8, 59)
        Me.lblCCEfectos.Name = "lblCCEfectos"
        Me.lblCCEfectos.Size = New System.Drawing.Size(74, 13)
        Me.lblCCEfectos.TabIndex = 125
        Me.lblCCEfectos.Tag = "IdRec=5377;"
        Me.lblCCEfectos.Text = "CC. Efectos"
        '
        'lblCCProveedor
        '
        Me.lblCCProveedor.Location = New System.Drawing.Point(8, 33)
        Me.lblCCProveedor.Name = "lblCCProveedor"
        Me.lblCCProveedor.Size = New System.Drawing.Size(92, 13)
        Me.lblCCProveedor.TabIndex = 123
        Me.lblCCProveedor.Tag = "IdRec=5377;"
        Me.lblCCProveedor.Text = "CC. Proveedor"
        '
        'ullCCProveedor
        '
        Me.ullCCProveedor.Location = New System.Drawing.Point(247, 29)
        Me.ullCCProveedor.Name = "ullCCProveedor"
        Me.ullCCProveedor.Size = New System.Drawing.Size(176, 21)
        Me.ullCCProveedor.TabIndex = 124
        '
        'advCCProveedor
        '
        Me.TryDataBinding(advCCProveedor, New System.Windows.Forms.Binding("Text", Me, "CCProveedor", True))
        Me.advCCProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advCCProveedor.EntityName = "PlanContable"
        Me.advCCProveedor.Location = New System.Drawing.Point(112, 28)
        Me.advCCProveedor.Name = "advCCProveedor"
        Me.advCCProveedor.PrimaryDataFields = "CCProveedor"
        Me.advCCProveedor.SecondaryDataFields = "IDCContable"
        Me.advCCProveedor.Size = New System.Drawing.Size(128, 23)
        Me.advCCProveedor.TabIndex = 121
        '
        'FrmCondicionesPago
        '
        Me.FrmCondicionesPago.Controls.Add(Me.fwiDto)
        Me.FrmCondicionesPago.Controls.Add(Me.lblfwiIdFPago)
        Me.FrmCondicionesPago.Controls.Add(Me.cbxIDCPago)
        Me.FrmCondicionesPago.Controls.Add(Me.ulDescCPago)
        Me.FrmCondicionesPago.Controls.Add(Me.lblfwiIdCPago)
        Me.FrmCondicionesPago.Controls.Add(Me.cbxIDFPago)
        Me.FrmCondicionesPago.Controls.Add(Me.ulDescFPago)
        Me.FrmCondicionesPago.Controls.Add(Me.cbxIDDiaPago)
        Me.FrmCondicionesPago.Controls.Add(Me.ulDescDiaPago)
        Me.FrmCondicionesPago.Controls.Add(Me.lblfwiDiaPago)
        Me.FrmCondicionesPago.Controls.Add(Me.cbxIDBancoPropio)
        Me.FrmCondicionesPago.Controls.Add(Me.ulDescBancoPropio)
        Me.FrmCondicionesPago.Controls.Add(Me.lblfwiIdBancoPropio)
        Me.FrmCondicionesPago.Controls.Add(Me.lblfwiIDTipoIVA)
        Me.FrmCondicionesPago.Controls.Add(Me.lblfwiDto)
        Me.FrmCondicionesPago.Controls.Add(Me.cbxIDMoneda)
        Me.FrmCondicionesPago.Controls.Add(Me.ulDescMoneda)
        Me.FrmCondicionesPago.Controls.Add(Me.lblfwiIDMoneda)
        Me.FrmCondicionesPago.Controls.Add(Me.cbxIDTipoIVA)
        Me.FrmCondicionesPago.Controls.Add(Me.ulDescTipoIVA)
        Me.FrmCondicionesPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmCondicionesPago.Location = New System.Drawing.Point(0, 0)
        Me.FrmCondicionesPago.Name = "FrmCondicionesPago"
        Me.FrmCondicionesPago.Size = New System.Drawing.Size(713, 117)
        Me.FrmCondicionesPago.TabIndex = 114
        Me.FrmCondicionesPago.TabStop = False
        Me.FrmCondicionesPago.Text = "Datos Económicos"
        '
        'fwiDto
        '
        Me.TryDataBinding(fwiDto, New System.Windows.Forms.Binding("Value", Me, "DtoComercial", True))
        Me.fwiDto.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDto.Location = New System.Drawing.Point(465, 69)
        Me.fwiDto.Name = "fwiDto"
        Me.fwiDto.Size = New System.Drawing.Size(53, 21)
        Me.fwiDto.TabIndex = 24
        '
        'lblfwiIdFPago
        '
        Me.lblfwiIdFPago.Location = New System.Drawing.Point(15, 21)
        Me.lblfwiIdFPago.Name = "lblfwiIdFPago"
        Me.lblfwiIdFPago.Size = New System.Drawing.Size(75, 13)
        Me.lblfwiIdFPago.TabIndex = 102
        Me.lblfwiIdFPago.Tag = "IdRec=4397;"
        Me.lblfwiIdFPago.Text = "Forma Pago"
        '
        'cbxIDCPago
        '
        Me.TryDataBinding(cbxIDCPago, New System.Windows.Forms.Binding("Value", Me, "IDCondicionPago", True))
        cbxIDCPago_DesignTimeLayout.LayoutString = resources.GetString("cbxIDCPago_DesignTimeLayout.LayoutString")
        Me.cbxIDCPago.DesignTimeLayout = cbxIDCPago_DesignTimeLayout
        Me.cbxIDCPago.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDCPago.DisplayMember = "IDCondicionPago"
        Me.cbxIDCPago.EntityName = "CondicionPago"
        Me.cbxIDCPago.Location = New System.Drawing.Point(98, 41)
        Me.cbxIDCPago.Name = "cbxIDCPago"
        Me.cbxIDCPago.PrimaryDataFields = "IDCondicionPago"
        Me.cbxIDCPago.SecondaryDataFields = "IDCondicionPago"
        Me.cbxIDCPago.SelectedIndex = -1
        Me.cbxIDCPago.SelectedItem = Nothing
        Me.cbxIDCPago.Size = New System.Drawing.Size(53, 21)
        Me.cbxIDCPago.TabIndex = 21
        Me.cbxIDCPago.ValueMember = "IDCondicionPago"
        Me.cbxIDCPago.ViewName = "tbMaestroCondicionPago"
        '
        'ulDescCPago
        '
        Me.TryDataBinding(ulDescCPago, New System.Windows.Forms.Binding("Text", Me.cbxIDCPago, "DescCondicionPago", True))
        Me.ulDescCPago.Location = New System.Drawing.Point(158, 41)
        Me.ulDescCPago.Name = "ulDescCPago"
        Me.ulDescCPago.Size = New System.Drawing.Size(212, 21)
        Me.ulDescCPago.TabIndex = 105
        '
        'lblfwiIdCPago
        '
        Me.lblfwiIdCPago.Location = New System.Drawing.Point(15, 45)
        Me.lblfwiIdCPago.Name = "lblfwiIdCPago"
        Me.lblfwiIdCPago.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiIdCPago.TabIndex = 104
        Me.lblfwiIdCPago.Tag = "IdRec=4396;"
        Me.lblfwiIdCPago.Text = "Condic. Pago"
        '
        'cbxIDFPago
        '
        Me.TryDataBinding(cbxIDFPago, New System.Windows.Forms.Binding("Value", Me, "IDFormaPago", True))
        cbxIDFPago_DesignTimeLayout.LayoutString = resources.GetString("cbxIDFPago_DesignTimeLayout.LayoutString")
        Me.cbxIDFPago.DesignTimeLayout = cbxIDFPago_DesignTimeLayout
        Me.cbxIDFPago.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDFPago.DisplayMember = "IDFormaPago"
        Me.cbxIDFPago.EntityName = "FormaPago"
        Me.cbxIDFPago.Location = New System.Drawing.Point(98, 17)
        Me.cbxIDFPago.Name = "cbxIDFPago"
        Me.cbxIDFPago.PrimaryDataFields = "IDFormaPago"
        Me.cbxIDFPago.SecondaryDataFields = "IDFormaPago"
        Me.cbxIDFPago.SelectedIndex = -1
        Me.cbxIDFPago.SelectedItem = Nothing
        Me.cbxIDFPago.Size = New System.Drawing.Size(53, 21)
        Me.cbxIDFPago.TabIndex = 19
        Me.cbxIDFPago.ValueMember = "IDFormaPago"
        Me.cbxIDFPago.ViewName = "tbMaestroFormaPago"
        '
        'ulDescFPago
        '
        Me.TryDataBinding(ulDescFPago, New System.Windows.Forms.Binding("Text", Me.cbxIDFPago, "DescFormaPago", True))
        Me.ulDescFPago.Location = New System.Drawing.Point(158, 17)
        Me.ulDescFPago.Name = "ulDescFPago"
        Me.ulDescFPago.Size = New System.Drawing.Size(212, 21)
        Me.ulDescFPago.TabIndex = 103
        '
        'cbxIDDiaPago
        '
        Me.TryDataBinding(cbxIDDiaPago, New System.Windows.Forms.Binding("Value", Me, "IDDiaPago", True))
        cbxIDDiaPago_DesignTimeLayout.LayoutString = resources.GetString("cbxIDDiaPago_DesignTimeLayout.LayoutString")
        Me.cbxIDDiaPago.DesignTimeLayout = cbxIDDiaPago_DesignTimeLayout
        Me.cbxIDDiaPago.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDDiaPago.DisplayMember = "IDDiaPago"
        Me.cbxIDDiaPago.EntityName = "DiaPago"
        Me.cbxIDDiaPago.Location = New System.Drawing.Point(98, 65)
        Me.cbxIDDiaPago.Name = "cbxIDDiaPago"
        Me.cbxIDDiaPago.PrimaryDataFields = "IDDiaPago"
        Me.cbxIDDiaPago.SecondaryDataFields = "IDDiaPago"
        Me.cbxIDDiaPago.SelectedIndex = -1
        Me.cbxIDDiaPago.SelectedItem = Nothing
        Me.cbxIDDiaPago.Size = New System.Drawing.Size(53, 21)
        Me.cbxIDDiaPago.TabIndex = 23
        Me.cbxIDDiaPago.ValueMember = "IDDiaPago"
        Me.cbxIDDiaPago.ViewName = "tbMaestroDiaPago"
        '
        'ulDescDiaPago
        '
        Me.TryDataBinding(ulDescDiaPago, New System.Windows.Forms.Binding("Text", Me.cbxIDDiaPago, "DescDiaPago", True))
        Me.ulDescDiaPago.Location = New System.Drawing.Point(158, 65)
        Me.ulDescDiaPago.Name = "ulDescDiaPago"
        Me.ulDescDiaPago.Size = New System.Drawing.Size(212, 21)
        Me.ulDescDiaPago.TabIndex = 100
        '
        'lblfwiDiaPago
        '
        Me.lblfwiDiaPago.Location = New System.Drawing.Point(15, 69)
        Me.lblfwiDiaPago.Name = "lblfwiDiaPago"
        Me.lblfwiDiaPago.Size = New System.Drawing.Size(58, 13)
        Me.lblfwiDiaPago.TabIndex = 99
        Me.lblfwiDiaPago.Tag = "IdRec=4681;"
        Me.lblfwiDiaPago.Text = "Día Pago"
        '
        'cbxIDBancoPropio
        '
        Me.TryDataBinding(cbxIDBancoPropio, New System.Windows.Forms.Binding("Value", Me, "IDBancoPropio", True))
        cbxIDBancoPropio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDBancoPropio_DesignTimeLayout.LayoutString")
        Me.cbxIDBancoPropio.DesignTimeLayout = cbxIDBancoPropio_DesignTimeLayout
        Me.cbxIDBancoPropio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDBancoPropio.DisplayMember = "IDBancoPropio"
        Me.cbxIDBancoPropio.EntityName = "BancoPropio"
        Me.cbxIDBancoPropio.Location = New System.Drawing.Point(98, 89)
        Me.cbxIDBancoPropio.Name = "cbxIDBancoPropio"
        Me.cbxIDBancoPropio.PrimaryDataFields = "IDBancoPropio"
        Me.cbxIDBancoPropio.SecondaryDataFields = "IDBancoPropio"
        Me.cbxIDBancoPropio.SelectedIndex = -1
        Me.cbxIDBancoPropio.SelectedItem = Nothing
        Me.cbxIDBancoPropio.Size = New System.Drawing.Size(53, 21)
        Me.cbxIDBancoPropio.TabIndex = 25
        Me.cbxIDBancoPropio.ValueMember = "IDBancoPropio"
        Me.cbxIDBancoPropio.ViewName = "tbMaestroBancoPropio"
        '
        'ulDescBancoPropio
        '
        Me.TryDataBinding(ulDescBancoPropio, New System.Windows.Forms.Binding("Text", Me.cbxIDBancoPropio, "DescBancoPropio", True))
        Me.ulDescBancoPropio.Location = New System.Drawing.Point(158, 89)
        Me.ulDescBancoPropio.Name = "ulDescBancoPropio"
        Me.ulDescBancoPropio.Size = New System.Drawing.Size(212, 21)
        Me.ulDescBancoPropio.TabIndex = 98
        '
        'lblfwiIdBancoPropio
        '
        Me.lblfwiIdBancoPropio.Location = New System.Drawing.Point(15, 93)
        Me.lblfwiIdBancoPropio.Name = "lblfwiIdBancoPropio"
        Me.lblfwiIdBancoPropio.Size = New System.Drawing.Size(82, 13)
        Me.lblfwiIdBancoPropio.TabIndex = 97
        Me.lblfwiIdBancoPropio.Tag = "IdRec=4602;"
        Me.lblfwiIdBancoPropio.Text = "Banco Propio"
        '
        'lblfwiIDTipoIVA
        '
        Me.lblfwiIDTipoIVA.Location = New System.Drawing.Point(387, 25)
        Me.lblfwiIDTipoIVA.Name = "lblfwiIDTipoIVA"
        Me.lblfwiIDTipoIVA.Size = New System.Drawing.Size(66, 13)
        Me.lblfwiIDTipoIVA.TabIndex = 110
        Me.lblfwiIDTipoIVA.Tag = "IdRec=4586;"
        Me.lblfwiIDTipoIVA.Text = "Tipo I.V.A."
        '
        'lblfwiDto
        '
        Me.lblfwiDto.Location = New System.Drawing.Point(387, 73)
        Me.lblfwiDto.Name = "lblfwiDto"
        Me.lblfwiDto.Size = New System.Drawing.Size(93, 13)
        Me.lblfwiDto.TabIndex = 96
        Me.lblfwiDto.Tag = ""
        Me.lblfwiDto.Text = "Dto. Comercial"
        '
        'cbxIDMoneda
        '
        Me.TryDataBinding(cbxIDMoneda, New System.Windows.Forms.Binding("Value", Me, "IDMoneda", True))
        cbxIDMoneda_DesignTimeLayout.LayoutString = resources.GetString("cbxIDMoneda_DesignTimeLayout.LayoutString")
        Me.cbxIDMoneda.DesignTimeLayout = cbxIDMoneda_DesignTimeLayout
        Me.cbxIDMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDMoneda.DisplayMember = "IDMoneda"
        Me.cbxIDMoneda.EntityName = "Moneda"
        Me.cbxIDMoneda.Location = New System.Drawing.Point(465, 45)
        Me.cbxIDMoneda.Name = "cbxIDMoneda"
        Me.cbxIDMoneda.PrimaryDataFields = "IDMoneda"
        Me.cbxIDMoneda.SecondaryDataFields = "IDMoneda"
        Me.cbxIDMoneda.SelectedIndex = -1
        Me.cbxIDMoneda.SelectedItem = Nothing
        Me.cbxIDMoneda.Size = New System.Drawing.Size(53, 21)
        Me.cbxIDMoneda.TabIndex = 22
        Me.cbxIDMoneda.ValueMember = "IDMoneda"
        Me.cbxIDMoneda.ViewName = "tbMaestroMoneda"
        '
        'ulDescMoneda
        '
        Me.TryDataBinding(ulDescMoneda, New System.Windows.Forms.Binding("Text", Me.cbxIDMoneda, "DescMoneda", True))
        Me.ulDescMoneda.Location = New System.Drawing.Point(526, 45)
        Me.ulDescMoneda.Name = "ulDescMoneda"
        Me.ulDescMoneda.Size = New System.Drawing.Size(181, 21)
        Me.ulDescMoneda.TabIndex = 113
        '
        'lblfwiIDMoneda
        '
        Me.lblfwiIDMoneda.Location = New System.Drawing.Point(387, 49)
        Me.lblfwiIDMoneda.Name = "lblfwiIDMoneda"
        Me.lblfwiIDMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblfwiIDMoneda.TabIndex = 112
        Me.lblfwiIDMoneda.Tag = "IdRec=4398;"
        Me.lblfwiIDMoneda.Text = "Moneda"
        '
        'cbxIDTipoIVA
        '
        Me.TryDataBinding(cbxIDTipoIVA, New System.Windows.Forms.Binding("Value", Me, "IDTipoIva", True))
        cbxIDTipoIVA_DesignTimeLayout.LayoutString = resources.GetString("cbxIDTipoIVA_DesignTimeLayout.LayoutString")
        Me.cbxIDTipoIVA.DesignTimeLayout = cbxIDTipoIVA_DesignTimeLayout
        Me.cbxIDTipoIVA.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDTipoIVA.DisplayMember = "IDTipoIva"
        Me.cbxIDTipoIVA.EntityName = "TipoIva"
        Me.cbxIDTipoIVA.Location = New System.Drawing.Point(465, 21)
        Me.cbxIDTipoIVA.Name = "cbxIDTipoIVA"
        Me.cbxIDTipoIVA.PrimaryDataFields = "IDTipoIva"
        Me.cbxIDTipoIVA.SecondaryDataFields = "IDTipoIva"
        Me.cbxIDTipoIVA.SelectedIndex = -1
        Me.cbxIDTipoIVA.SelectedItem = Nothing
        Me.cbxIDTipoIVA.Size = New System.Drawing.Size(53, 21)
        Me.cbxIDTipoIVA.TabIndex = 20
        Me.cbxIDTipoIVA.ValueMember = "IDTipoIva"
        Me.cbxIDTipoIVA.ViewName = "tbMaestroTipoIva"
        '
        'ulDescTipoIVA
        '
        Me.TryDataBinding(ulDescTipoIVA, New System.Windows.Forms.Binding("Text", Me.cbxIDTipoIVA, "DescTipoIva", True))
        Me.ulDescTipoIVA.Location = New System.Drawing.Point(526, 21)
        Me.ulDescTipoIVA.Name = "ulDescTipoIVA"
        Me.ulDescTipoIVA.Size = New System.Drawing.Size(181, 21)
        Me.ulDescTipoIVA.TabIndex = 111
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.FraDeclaraciones)
        Me.UiTabPage1.Controls.Add(Me.FrmFacturacion)
        Me.UiTabPage1.Key = "Facturacion"
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(713, 268)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Facturación"
        '
        'FraDeclaraciones
        '
        Me.FraDeclaraciones.Controls.Add(Me.chkIVACaja)
        Me.FraDeclaraciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDeclaraciones.Location = New System.Drawing.Point(0, 176)
        Me.FraDeclaraciones.Name = "FraDeclaraciones"
        Me.FraDeclaraciones.Size = New System.Drawing.Size(713, 44)
        Me.FraDeclaraciones.TabIndex = 117
        Me.FraDeclaraciones.TabStop = False
        Me.FraDeclaraciones.Text = "Declaraciones"
        '
        'chkIVACaja
        '
        Me.chkIVACaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(chkIVACaja, New System.Windows.Forms.Binding("BindableValue", Me, "IVACaja", True))
        Me.chkIVACaja.Location = New System.Drawing.Point(11, 21)
        Me.chkIVACaja.Name = "chkIVACaja"
        Me.chkIVACaja.Size = New System.Drawing.Size(77, 20)
        Me.chkIVACaja.TabIndex = 31
        Me.chkIVACaja.Text = "IVA Caja"
        '
        'FrmFacturacion
        '
        Me.FrmFacturacion.Controls.Add(Me.lblTipoRetencion)
        Me.FrmFacturacion.Controls.Add(Me.cbxTipoRetencion)
        Me.FrmFacturacion.Controls.Add(Me.lblfwiRetencionIRPF)
        Me.FrmFacturacion.Controls.Add(Me.cbxSerieAbonos)
        Me.FrmFacturacion.Controls.Add(Me.cbxIDTipoAsiento)
        Me.FrmFacturacion.Controls.Add(Me.lblfwiIDTipoAsiento)
        Me.FrmFacturacion.Controls.Add(Me.fwiRetencionIRPF)
        Me.FrmFacturacion.Controls.Add(Me.fwiRegEspecial)
        Me.FrmFacturacion.Controls.Add(Me.Label5)
        Me.FrmFacturacion.Controls.Add(Me.lblFwiSerieAbonos)
        Me.FrmFacturacion.Controls.Add(Me.lblFwiSerieCargos)
        Me.FrmFacturacion.Controls.Add(Me.cbxSerieCargos)
        Me.FrmFacturacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmFacturacion.Location = New System.Drawing.Point(0, 0)
        Me.FrmFacturacion.Name = "FrmFacturacion"
        Me.FrmFacturacion.Size = New System.Drawing.Size(713, 176)
        Me.FrmFacturacion.TabIndex = 116
        Me.FrmFacturacion.TabStop = False
        Me.FrmFacturacion.Text = "Datos Facturación"
        '
        'lblTipoRetencion
        '
        Me.lblTipoRetencion.Location = New System.Drawing.Point(7, 73)
        Me.lblTipoRetencion.Name = "lblTipoRetencion"
        Me.lblTipoRetencion.Size = New System.Drawing.Size(133, 13)
        Me.lblTipoRetencion.TabIndex = 108
        Me.lblTipoRetencion.Tag = ""
        Me.lblTipoRetencion.Text = "Tipo Retención I.R.P.F."
        '
        'cbxTipoRetencion
        '
        Me.TryDataBinding(cbxTipoRetencion, New System.Windows.Forms.Binding("Value", Me, "TipoRetencionIRPF", True))
        cbxTipoRetencion_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoRetencion_DesignTimeLayout.LayoutString")
        Me.cbxTipoRetencion.DesignTimeLayout = cbxTipoRetencion_DesignTimeLayout
        Me.cbxTipoRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoRetencion.DisplayMember = "Text"
        Me.cbxTipoRetencion.Location = New System.Drawing.Point(145, 69)
        Me.cbxTipoRetencion.Name = "cbxTipoRetencion"
        Me.cbxTipoRetencion.SelectedIndex = -1
        Me.cbxTipoRetencion.SelectedItem = Nothing
        Me.cbxTipoRetencion.Size = New System.Drawing.Size(197, 21)
        Me.cbxTipoRetencion.TabIndex = 28
        Me.cbxTipoRetencion.ValueMember = "Value"
        '
        'lblfwiRetencionIRPF
        '
        Me.lblfwiRetencionIRPF.Location = New System.Drawing.Point(7, 100)
        Me.lblfwiRetencionIRPF.Name = "lblfwiRetencionIRPF"
        Me.lblfwiRetencionIRPF.Size = New System.Drawing.Size(72, 13)
        Me.lblfwiRetencionIRPF.TabIndex = 101
        Me.lblfwiRetencionIRPF.Tag = "IdRec=5069;"
        Me.lblfwiRetencionIRPF.Text = "IRPF Actual"
        '
        'cbxSerieAbonos
        '
        Me.TryDataBinding(cbxSerieAbonos, New System.Windows.Forms.Binding("Value", Me, "IDContadorAbono", True))
        cbxSerieAbonos_DesignTimeLayout.LayoutString = resources.GetString("cbxSerieAbonos_DesignTimeLayout.LayoutString")
        Me.cbxSerieAbonos.DesignTimeLayout = cbxSerieAbonos_DesignTimeLayout
        Me.cbxSerieAbonos.DisabledBackColor = System.Drawing.Color.White
        Me.cbxSerieAbonos.DisplayMember = "IDContador"
        Me.cbxSerieAbonos.EntityName = "Contador"
        Me.cbxSerieAbonos.Location = New System.Drawing.Point(145, 45)
        Me.cbxSerieAbonos.Name = "cbxSerieAbonos"
        Me.cbxSerieAbonos.PrimaryDataFields = "IDContadorAbono"
        Me.cbxSerieAbonos.SecondaryDataFields = "IDContador"
        Me.cbxSerieAbonos.SelectedIndex = -1
        Me.cbxSerieAbonos.SelectedItem = Nothing
        Me.cbxSerieAbonos.Size = New System.Drawing.Size(197, 21)
        Me.cbxSerieAbonos.TabIndex = 27
        Me.cbxSerieAbonos.ValueMember = "IDContador"
        Me.cbxSerieAbonos.ViewName = "vContadoresSeriesAbonoCargo"
        '
        'cbxIDTipoAsiento
        '
        Me.TryDataBinding(cbxIDTipoAsiento, New System.Windows.Forms.Binding("Value", Me, "IDTipoAsiento", True))
        cbxIDTipoAsiento_DesignTimeLayout.LayoutString = resources.GetString("cbxIDTipoAsiento_DesignTimeLayout.LayoutString")
        Me.cbxIDTipoAsiento.DesignTimeLayout = cbxIDTipoAsiento_DesignTimeLayout
        Me.cbxIDTipoAsiento.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDTipoAsiento.DisplayMember = "Value"
        Me.cbxIDTipoAsiento.Location = New System.Drawing.Point(145, 150)
        Me.cbxIDTipoAsiento.Name = "cbxIDTipoAsiento"
        Me.cbxIDTipoAsiento.PrimaryDataFields = "IDTipoAsiento"
        Me.cbxIDTipoAsiento.SecondaryDataFields = "Value"
        Me.cbxIDTipoAsiento.SelectedIndex = -1
        Me.cbxIDTipoAsiento.SelectedItem = Nothing
        Me.cbxIDTipoAsiento.Size = New System.Drawing.Size(310, 21)
        Me.cbxIDTipoAsiento.TabIndex = 31
        '
        'lblfwiIDTipoAsiento
        '
        Me.lblfwiIDTipoAsiento.Location = New System.Drawing.Point(7, 154)
        Me.lblfwiIDTipoAsiento.Name = "lblfwiIDTipoAsiento"
        Me.lblfwiIDTipoAsiento.Size = New System.Drawing.Size(77, 13)
        Me.lblfwiIDTipoAsiento.TabIndex = 106
        Me.lblfwiIDTipoAsiento.Tag = "IdRec=5376;"
        Me.lblfwiIDTipoAsiento.Text = "Tipo Asiento"
        '
        'fwiRetencionIRPF
        '
        Me.TryDataBinding(fwiRetencionIRPF, New System.Windows.Forms.Binding("Value", Me, "RetencionIRPF", True))
        Me.fwiRetencionIRPF.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRetencionIRPF.Location = New System.Drawing.Point(144, 96)
        Me.fwiRetencionIRPF.Name = "fwiRetencionIRPF"
        Me.fwiRetencionIRPF.Size = New System.Drawing.Size(56, 21)
        Me.fwiRetencionIRPF.TabIndex = 29
        '
        'fwiRegEspecial
        '
        Me.fwiRegEspecial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(fwiRegEspecial, New System.Windows.Forms.Binding("BindableValue", Me, "RegimenEspecial", True))
        Me.fwiRegEspecial.Location = New System.Drawing.Point(7, 123)
        Me.fwiRegEspecial.Name = "fwiRegEspecial"
        Me.fwiRegEspecial.Size = New System.Drawing.Size(152, 20)
        Me.fwiRegEspecial.TabIndex = 30
        Me.fwiRegEspecial.Text = "Régimen Especial"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(206, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Tag = "IdRec=4445;"
        Me.Label5.Text = "%"
        '
        'lblFwiSerieAbonos
        '
        Me.lblFwiSerieAbonos.Location = New System.Drawing.Point(7, 49)
        Me.lblFwiSerieAbonos.Name = "lblFwiSerieAbonos"
        Me.lblFwiSerieAbonos.Size = New System.Drawing.Size(83, 13)
        Me.lblFwiSerieAbonos.TabIndex = 90
        Me.lblFwiSerieAbonos.Tag = "IdRec=8346;"
        Me.lblFwiSerieAbonos.Text = "Serie Abonos"
        '
        'lblFwiSerieCargos
        '
        Me.lblFwiSerieCargos.Location = New System.Drawing.Point(7, 24)
        Me.lblFwiSerieCargos.Name = "lblFwiSerieCargos"
        Me.lblFwiSerieCargos.Size = New System.Drawing.Size(82, 13)
        Me.lblFwiSerieCargos.TabIndex = 89
        Me.lblFwiSerieCargos.Tag = "IdRec=8345;"
        Me.lblFwiSerieCargos.Text = "Serie Cargos"
        '
        'cbxSerieCargos
        '
        Me.TryDataBinding(cbxSerieCargos, New System.Windows.Forms.Binding("Value", Me, "IDContadorCargo", True))
        cbxSerieCargos_DesignTimeLayout.LayoutString = resources.GetString("cbxSerieCargos_DesignTimeLayout.LayoutString")
        Me.cbxSerieCargos.DesignTimeLayout = cbxSerieCargos_DesignTimeLayout
        Me.cbxSerieCargos.DisabledBackColor = System.Drawing.Color.White
        Me.cbxSerieCargos.DisplayMember = "IDContador"
        Me.cbxSerieCargos.EntityName = "Contador"
        Me.cbxSerieCargos.Location = New System.Drawing.Point(145, 20)
        Me.cbxSerieCargos.Name = "cbxSerieCargos"
        Me.cbxSerieCargos.PrimaryDataFields = "IDContadorCargo"
        Me.cbxSerieCargos.SecondaryDataFields = "IDContador"
        Me.cbxSerieCargos.SelectedIndex = -1
        Me.cbxSerieCargos.SelectedItem = Nothing
        Me.cbxSerieCargos.Size = New System.Drawing.Size(197, 21)
        Me.cbxSerieCargos.TabIndex = 26
        Me.cbxSerieCargos.ValueMember = "IDContador"
        Me.cbxSerieCargos.ViewName = "vContadoresSeriesAbonoCargo"
        '
        'TabPagePicCContables
        '
        Me.TabPagePicCContables.Controls.Add(Me.ulbladvCCFraPdte)
        Me.TabPagePicCContables.Controls.Add(Me.advCCFraPdte)
        Me.TabPagePicCContables.Controls.Add(Me.lblCCFraPdte)
        Me.TabPagePicCContables.Controls.Add(Me.ChkEmpresaGrupo)
        Me.TabPagePicCContables.Controls.Add(Me.cbxEmpresa)
        Me.TabPagePicCContables.Controls.Add(Me.ullCCFianza)
        Me.TabPagePicCContables.Controls.Add(Me.advCCFianza)
        Me.TabPagePicCContables.Controls.Add(Me.ullCCAnticipo)
        Me.TabPagePicCContables.Controls.Add(Me.advCCAnticipo)
        Me.TabPagePicCContables.Controls.Add(Me.ullCCRetencion)
        Me.TabPagePicCContables.Controls.Add(Me.advCCRetencion)
        Me.TabPagePicCContables.Controls.Add(Me.lblCCRetencion)
        Me.TabPagePicCContables.Controls.Add(Me.lblCCAnticipo)
        Me.TabPagePicCContables.Controls.Add(Me.lblCCFianza)
        Me.TabPagePicCContables.Key = "CuentasContables"
        Me.TabPagePicCContables.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicCContables.Name = "TabPagePicCContables"
        Me.TabPagePicCContables.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicCContables.TabStop = True
        Me.TabPagePicCContables.Text = "Otras Cuentas"
        '
        'ulbladvCCFraPdte
        '
        Me.TryDataBinding(ulbladvCCFraPdte, New System.Windows.Forms.Binding("Text", Me.advCCFraPdte, "DescCContable", True))
        Me.ulbladvCCFraPdte.Location = New System.Drawing.Point(263, 119)
        Me.ulbladvCCFraPdte.Name = "ulbladvCCFraPdte"
        Me.ulbladvCCFraPdte.Size = New System.Drawing.Size(360, 21)
        Me.ulbladvCCFraPdte.TabIndex = 129
        '
        'advCCFraPdte
        '
        Me.TryDataBinding(advCCFraPdte, New System.Windows.Forms.Binding("Text", Me, "CCProveedorPdte", True))
        Me.advCCFraPdte.DisabledBackColor = System.Drawing.Color.White
        Me.advCCFraPdte.EntityName = "PlanContable"
        Me.advCCFraPdte.Location = New System.Drawing.Point(128, 119)
        Me.advCCFraPdte.Name = "advCCFraPdte"
        Me.advCCFraPdte.PrimaryDataFields = "CCProveedorPdte"
        Me.advCCFraPdte.SecondaryDataFields = "IDCContable"
        Me.advCCFraPdte.Size = New System.Drawing.Size(128, 23)
        Me.advCCFraPdte.TabIndex = 127
        '
        'lblCCFraPdte
        '
        Me.lblCCFraPdte.Location = New System.Drawing.Point(40, 124)
        Me.lblCCFraPdte.Name = "lblCCFraPdte"
        Me.lblCCFraPdte.Size = New System.Drawing.Size(88, 13)
        Me.lblCCFraPdte.TabIndex = 128
        Me.lblCCFraPdte.Tag = "IdRec=5377;"
        Me.lblCCFraPdte.Text = "CC. Fra. Pdte."
        '
        'ChkEmpresaGrupo
        '
        Me.ChkEmpresaGrupo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(ChkEmpresaGrupo, New System.Windows.Forms.Binding("BindableValue", Me, "EmpresaGrupo", True))
        Me.ChkEmpresaGrupo.Location = New System.Drawing.Point(16, 6)
        Me.ChkEmpresaGrupo.Name = "ChkEmpresaGrupo"
        Me.ChkEmpresaGrupo.Size = New System.Drawing.Size(144, 24)
        Me.ChkEmpresaGrupo.TabIndex = 34
        Me.ChkEmpresaGrupo.Text = "Empresa del Grupo"
        '
        'cbxEmpresa
        '
        Me.TryDataBinding(cbxEmpresa, New System.Windows.Forms.Binding("Value", Me, "BaseDatos", True))
        cbxEmpresa_DesignTimeLayout.LayoutString = resources.GetString("cbxEmpresa_DesignTimeLayout.LayoutString")
        Me.cbxEmpresa.DesignTimeLayout = cbxEmpresa_DesignTimeLayout
        Me.cbxEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEmpresa.DisplayMember = "BaseDatos"
        Me.cbxEmpresa.Enabled = False
        Me.cbxEmpresa.Location = New System.Drawing.Point(176, 8)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.PrimaryDataFields = "BaseDatos"
        Me.cbxEmpresa.SelectedIndex = -1
        Me.cbxEmpresa.SelectedItem = Nothing
        Me.cbxEmpresa.Size = New System.Drawing.Size(104, 21)
        Me.cbxEmpresa.TabIndex = 35
        Me.cbxEmpresa.ValueMember = "IDBaseDatos"
        '
        'ullCCFianza
        '
        Me.TryDataBinding(ullCCFianza, New System.Windows.Forms.Binding("Text", Me.advCCFianza, "DescCContable", True))
        Me.ullCCFianza.Location = New System.Drawing.Point(263, 93)
        Me.ullCCFianza.Name = "ullCCFianza"
        Me.ullCCFianza.Size = New System.Drawing.Size(360, 21)
        Me.ullCCFianza.TabIndex = 126
        '
        'advCCFianza
        '
        Me.TryDataBinding(advCCFianza, New System.Windows.Forms.Binding("Text", Me, "CCFianza", True))
        Me.advCCFianza.DisabledBackColor = System.Drawing.Color.White
        Me.advCCFianza.EntityName = "PlanContable"
        Me.advCCFianza.Location = New System.Drawing.Point(128, 93)
        Me.advCCFianza.Name = "advCCFianza"
        Me.advCCFianza.PrimaryDataFields = "CCFianza"
        Me.advCCFianza.SecondaryDataFields = "IDCContable"
        Me.advCCFianza.Size = New System.Drawing.Size(128, 23)
        Me.advCCFianza.TabIndex = 40
        '
        'ullCCAnticipo
        '
        Me.TryDataBinding(ullCCAnticipo, New System.Windows.Forms.Binding("Text", Me.advCCAnticipo, "DescCContable", True))
        Me.ullCCAnticipo.Location = New System.Drawing.Point(263, 67)
        Me.ullCCAnticipo.Name = "ullCCAnticipo"
        Me.ullCCAnticipo.Size = New System.Drawing.Size(360, 21)
        Me.ullCCAnticipo.TabIndex = 124
        '
        'advCCAnticipo
        '
        Me.TryDataBinding(advCCAnticipo, New System.Windows.Forms.Binding("Text", Me, "CCAnticipo", True))
        Me.advCCAnticipo.DisabledBackColor = System.Drawing.Color.White
        Me.advCCAnticipo.EntityName = "PlanContable"
        Me.advCCAnticipo.Location = New System.Drawing.Point(128, 67)
        Me.advCCAnticipo.Name = "advCCAnticipo"
        Me.advCCAnticipo.PrimaryDataFields = "CCAnticipo"
        Me.advCCAnticipo.SecondaryDataFields = "IDCContable"
        Me.advCCAnticipo.Size = New System.Drawing.Size(128, 23)
        Me.advCCAnticipo.TabIndex = 39
        '
        'ullCCRetencion
        '
        Me.TryDataBinding(ullCCRetencion, New System.Windows.Forms.Binding("Text", Me.advCCRetencion, "DescCContable", True))
        Me.ullCCRetencion.Location = New System.Drawing.Point(263, 41)
        Me.ullCCRetencion.Name = "ullCCRetencion"
        Me.ullCCRetencion.Size = New System.Drawing.Size(360, 21)
        Me.ullCCRetencion.TabIndex = 122
        '
        'advCCRetencion
        '
        Me.TryDataBinding(advCCRetencion, New System.Windows.Forms.Binding("Text", Me, "CCRetencion", True))
        Me.advCCRetencion.DisabledBackColor = System.Drawing.Color.White
        Me.advCCRetencion.EntityName = "PlanContable"
        Me.advCCRetencion.Location = New System.Drawing.Point(128, 41)
        Me.advCCRetencion.Name = "advCCRetencion"
        Me.advCCRetencion.PrimaryDataFields = "CCRetencion"
        Me.advCCRetencion.SecondaryDataFields = "IDCContable"
        Me.advCCRetencion.Size = New System.Drawing.Size(128, 23)
        Me.advCCRetencion.TabIndex = 38
        '
        'lblCCRetencion
        '
        Me.lblCCRetencion.Location = New System.Drawing.Point(40, 46)
        Me.lblCCRetencion.Name = "lblCCRetencion"
        Me.lblCCRetencion.Size = New System.Drawing.Size(89, 13)
        Me.lblCCRetencion.TabIndex = 117
        Me.lblCCRetencion.Tag = "IdRec=5377;"
        Me.lblCCRetencion.Text = "CC. Retención"
        '
        'lblCCAnticipo
        '
        Me.lblCCAnticipo.Location = New System.Drawing.Point(40, 72)
        Me.lblCCAnticipo.Name = "lblCCAnticipo"
        Me.lblCCAnticipo.Size = New System.Drawing.Size(78, 13)
        Me.lblCCAnticipo.TabIndex = 116
        Me.lblCCAnticipo.Tag = "IdRec=5377;"
        Me.lblCCAnticipo.Text = "CC. Anticipo"
        '
        'lblCCFianza
        '
        Me.lblCCFianza.Location = New System.Drawing.Point(40, 98)
        Me.lblCCFianza.Name = "lblCCFianza"
        Me.lblCCFianza.Size = New System.Drawing.Size(69, 13)
        Me.lblCCFianza.TabIndex = 115
        Me.lblCCFianza.Tag = "IdRec=5377;"
        Me.lblCCFianza.Text = "CC. Fianza"
        '
        'TabPagePicEnvio
        '
        Me.TabPagePicEnvio.Controls.Add(Me.FraPorcentaje)
        Me.TabPagePicEnvio.Controls.Add(Me.FraAlmacen)
        Me.TabPagePicEnvio.Controls.Add(Me.FraEnvio)
        Me.TabPagePicEnvio.Key = "Envio"
        Me.TabPagePicEnvio.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicEnvio.Name = "TabPagePicEnvio"
        Me.TabPagePicEnvio.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicEnvio.TabStop = True
        Me.TabPagePicEnvio.Text = "Envío"
        '
        'FraPorcentaje
        '
        Me.FraPorcentaje.Controls.Add(Me.FwIPorcentajeTotal)
        Me.FraPorcentaje.Controls.Add(Me.lblFwIPorcentajeTotal)
        Me.FraPorcentaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraPorcentaje.Location = New System.Drawing.Point(0, 147)
        Me.FraPorcentaje.Name = "FraPorcentaje"
        Me.FraPorcentaje.Size = New System.Drawing.Size(713, 48)
        Me.FraPorcentaje.TabIndex = 75
        Me.FraPorcentaje.TabStop = False
        Me.FraPorcentaje.Text = "Porcentaje"
        '
        'FwIPorcentajeTotal
        '
        Me.TryDataBinding(FwIPorcentajeTotal, New System.Windows.Forms.Binding("Value", Me, "PorcentajeTolCierre", True))
        Me.FwIPorcentajeTotal.DisabledBackColor = System.Drawing.Color.White
        Me.FwIPorcentajeTotal.Location = New System.Drawing.Point(134, 19)
        Me.FwIPorcentajeTotal.Name = "FwIPorcentajeTotal"
        Me.FwIPorcentajeTotal.Size = New System.Drawing.Size(88, 21)
        Me.FwIPorcentajeTotal.TabIndex = 75
        '
        'lblFwIPorcentajeTotal
        '
        Me.lblFwIPorcentajeTotal.Location = New System.Drawing.Point(16, 22)
        Me.lblFwIPorcentajeTotal.Name = "lblFwIPorcentajeTotal"
        Me.lblFwIPorcentajeTotal.Size = New System.Drawing.Size(130, 13)
        Me.lblFwIPorcentajeTotal.TabIndex = 0
        Me.lblFwIPorcentajeTotal.Text = "Porcentaje Tolerancia"
        '
        'FraAlmacen
        '
        Me.FraAlmacen.Controls.Add(Me.lblfwiAlmacenProveedor)
        Me.FraAlmacen.Controls.Add(Me.ulDescAlmacenProveedor)
        Me.FraAlmacen.Controls.Add(Me.AdvAlmacenProveedor)
        Me.FraAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraAlmacen.Location = New System.Drawing.Point(0, 94)
        Me.FraAlmacen.Name = "FraAlmacen"
        Me.FraAlmacen.Size = New System.Drawing.Size(713, 53)
        Me.FraAlmacen.TabIndex = 63
        Me.FraAlmacen.TabStop = False
        Me.FraAlmacen.Text = "Almacén"
        '
        'lblfwiAlmacenProveedor
        '
        Me.lblfwiAlmacenProveedor.Location = New System.Drawing.Point(16, 26)
        Me.lblfwiAlmacenProveedor.Name = "lblfwiAlmacenProveedor"
        Me.lblfwiAlmacenProveedor.Size = New System.Drawing.Size(119, 13)
        Me.lblfwiAlmacenProveedor.TabIndex = 0
        Me.lblfwiAlmacenProveedor.Text = "Almacén Proveedor"
        '
        'ulDescAlmacenProveedor
        '
        Me.TryDataBinding(ulDescAlmacenProveedor, New System.Windows.Forms.Binding("Text", Me.AdvAlmacenProveedor, "DescAlmacen", True))
        Me.ulDescAlmacenProveedor.Location = New System.Drawing.Point(246, 21)
        Me.ulDescAlmacenProveedor.Name = "ulDescAlmacenProveedor"
        Me.ulDescAlmacenProveedor.Size = New System.Drawing.Size(299, 21)
        Me.ulDescAlmacenProveedor.TabIndex = 1
        '
        'AdvAlmacenProveedor
        '
        Me.TryDataBinding(AdvAlmacenProveedor, New System.Windows.Forms.Binding("Text", Me, "IDAlmacenProveedor", True))
        Me.AdvAlmacenProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacenProveedor.EntityName = "Almacen"
        Me.AdvAlmacenProveedor.Location = New System.Drawing.Point(134, 21)
        Me.AdvAlmacenProveedor.Name = "AdvAlmacenProveedor"
        Me.AdvAlmacenProveedor.PrimaryDataFields = "IDAlmacenProveedor"
        Me.AdvAlmacenProveedor.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacenProveedor.Size = New System.Drawing.Size(106, 23)
        Me.AdvAlmacenProveedor.TabIndex = 37
        Me.AdvAlmacenProveedor.ViewName = "tbMaestroAlmacen"
        '
        'FraEnvio
        '
        Me.FraEnvio.Controls.Add(Me.lblFwiModoTransporte)
        Me.FraEnvio.Controls.Add(Me.ulDescModoTransporte)
        Me.FraEnvio.Controls.Add(Me.cbxIDModoTransporte)
        Me.FraEnvio.Controls.Add(Me.lblfwiIDCEnvio)
        Me.FraEnvio.Controls.Add(Me.ulDescCEnvio)
        Me.FraEnvio.Controls.Add(Me.cbxIDCEnvio)
        Me.FraEnvio.Controls.Add(Me.lblfwiIDFEnvio)
        Me.FraEnvio.Controls.Add(Me.ulDescFEnvio)
        Me.FraEnvio.Controls.Add(Me.cbxIDFEnvio)
        Me.FraEnvio.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraEnvio.Location = New System.Drawing.Point(0, 0)
        Me.FraEnvio.Name = "FraEnvio"
        Me.FraEnvio.Size = New System.Drawing.Size(713, 94)
        Me.FraEnvio.TabIndex = 62
        Me.FraEnvio.TabStop = False
        Me.FraEnvio.Text = "Envío"
        '
        'lblFwiModoTransporte
        '
        Me.lblFwiModoTransporte.Location = New System.Drawing.Point(16, 69)
        Me.lblFwiModoTransporte.Name = "lblFwiModoTransporte"
        Me.lblFwiModoTransporte.Size = New System.Drawing.Size(102, 13)
        Me.lblFwiModoTransporte.TabIndex = 0
        Me.lblFwiModoTransporte.Text = "Modo Transporte"
        '
        'ulDescModoTransporte
        '
        Me.TryDataBinding(ulDescModoTransporte, New System.Windows.Forms.Binding("Text", Me.cbxIDModoTransporte, "DescModoTransporte", True))
        Me.ulDescModoTransporte.Location = New System.Drawing.Point(218, 65)
        Me.ulDescModoTransporte.Name = "ulDescModoTransporte"
        Me.ulDescModoTransporte.Size = New System.Drawing.Size(324, 21)
        Me.ulDescModoTransporte.TabIndex = 1
        '
        'cbxIDModoTransporte
        '
        Me.TryDataBinding(cbxIDModoTransporte, New System.Windows.Forms.Binding("Value", Me, "IDModoTransporte", True))
        cbxIDModoTransporte_DesignTimeLayout.LayoutString = resources.GetString("cbxIDModoTransporte_DesignTimeLayout.LayoutString")
        Me.cbxIDModoTransporte.DesignTimeLayout = cbxIDModoTransporte_DesignTimeLayout
        Me.cbxIDModoTransporte.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDModoTransporte.DisplayMember = "IDModoTransporte"
        Me.cbxIDModoTransporte.EntityName = "ModoTrasporte"
        Me.cbxIDModoTransporte.Location = New System.Drawing.Point(134, 65)
        Me.cbxIDModoTransporte.Name = "cbxIDModoTransporte"
        Me.cbxIDModoTransporte.PrimaryDataFields = "IDModoTransporte"
        Me.cbxIDModoTransporte.SecondaryDataFields = "IDModoTransporte"
        Me.cbxIDModoTransporte.SelectedIndex = -1
        Me.cbxIDModoTransporte.SelectedItem = Nothing
        Me.cbxIDModoTransporte.Size = New System.Drawing.Size(82, 21)
        Me.cbxIDModoTransporte.TabIndex = 36
        Me.cbxIDModoTransporte.ValueMember = "IDModoTransporte"
        Me.cbxIDModoTransporte.ViewName = "tbMaestroModoTrasporte"
        '
        'lblfwiIDCEnvio
        '
        Me.lblfwiIDCEnvio.Location = New System.Drawing.Point(16, 44)
        Me.lblfwiIDCEnvio.Name = "lblfwiIDCEnvio"
        Me.lblfwiIDCEnvio.Size = New System.Drawing.Size(111, 13)
        Me.lblfwiIDCEnvio.TabIndex = 37
        Me.lblfwiIDCEnvio.Tag = "IdRec=5375;"
        Me.lblfwiIDCEnvio.Text = "Condiciones Envío"
        '
        'ulDescCEnvio
        '
        Me.TryDataBinding(ulDescCEnvio, New System.Windows.Forms.Binding("Text", Me.cbxIDCEnvio, "DescCondicionEnvio", True))
        Me.ulDescCEnvio.Location = New System.Drawing.Point(218, 40)
        Me.ulDescCEnvio.Name = "ulDescCEnvio"
        Me.ulDescCEnvio.Size = New System.Drawing.Size(324, 21)
        Me.ulDescCEnvio.TabIndex = 38
        '
        'cbxIDCEnvio
        '
        Me.TryDataBinding(cbxIDCEnvio, New System.Windows.Forms.Binding("Value", Me, "IDCondicionEnvio", True))
        cbxIDCEnvio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDCEnvio_DesignTimeLayout.LayoutString")
        Me.cbxIDCEnvio.DesignTimeLayout = cbxIDCEnvio_DesignTimeLayout
        Me.cbxIDCEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDCEnvio.DisplayMember = "IDCondicionEnvio"
        Me.cbxIDCEnvio.EntityName = "CondicionEnvio"
        Me.cbxIDCEnvio.Location = New System.Drawing.Point(134, 40)
        Me.cbxIDCEnvio.Name = "cbxIDCEnvio"
        Me.cbxIDCEnvio.PrimaryDataFields = "IDCondicionEnvio"
        Me.cbxIDCEnvio.SecondaryDataFields = "IDCondicionEnvio"
        Me.cbxIDCEnvio.SelectedIndex = -1
        Me.cbxIDCEnvio.SelectedItem = Nothing
        Me.cbxIDCEnvio.Size = New System.Drawing.Size(82, 21)
        Me.cbxIDCEnvio.TabIndex = 35
        Me.cbxIDCEnvio.ValueMember = "IDCondicionEnvio"
        Me.cbxIDCEnvio.ViewName = "tbMaestroCondicionEnvio"
        '
        'lblfwiIDFEnvio
        '
        Me.lblfwiIDFEnvio.Location = New System.Drawing.Point(16, 19)
        Me.lblfwiIDFEnvio.Name = "lblfwiIDFEnvio"
        Me.lblfwiIDFEnvio.Size = New System.Drawing.Size(78, 13)
        Me.lblfwiIDFEnvio.TabIndex = 39
        Me.lblfwiIDFEnvio.Tag = ""
        Me.lblfwiIDFEnvio.Text = "Forma Envío"
        '
        'ulDescFEnvio
        '
        Me.TryDataBinding(ulDescFEnvio, New System.Windows.Forms.Binding("Text", Me.cbxIDFEnvio, "DescFormaEnvio", True))
        Me.ulDescFEnvio.Location = New System.Drawing.Point(218, 15)
        Me.ulDescFEnvio.Name = "ulDescFEnvio"
        Me.ulDescFEnvio.Size = New System.Drawing.Size(324, 21)
        Me.ulDescFEnvio.TabIndex = 40
        '
        'cbxIDFEnvio
        '
        Me.TryDataBinding(cbxIDFEnvio, New System.Windows.Forms.Binding("Value", Me, "IDFormaEnvio", True))
        cbxIDFEnvio_DesignTimeLayout.LayoutString = resources.GetString("cbxIDFEnvio_DesignTimeLayout.LayoutString")
        Me.cbxIDFEnvio.DesignTimeLayout = cbxIDFEnvio_DesignTimeLayout
        Me.cbxIDFEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDFEnvio.DisplayMember = "IDFormaEnvio"
        Me.cbxIDFEnvio.EntityName = "FormaEnvio"
        Me.cbxIDFEnvio.Location = New System.Drawing.Point(134, 15)
        Me.cbxIDFEnvio.Name = "cbxIDFEnvio"
        Me.cbxIDFEnvio.PrimaryDataFields = "IDFormaEnvio"
        Me.cbxIDFEnvio.SecondaryDataFields = "IDFormaEnvio"
        Me.cbxIDFEnvio.SelectedIndex = -1
        Me.cbxIDFEnvio.SelectedItem = Nothing
        Me.cbxIDFEnvio.Size = New System.Drawing.Size(82, 21)
        Me.cbxIDFEnvio.TabIndex = 34
        Me.cbxIDFEnvio.ValueMember = "IDFormaEnvio"
        Me.cbxIDFEnvio.ViewName = "tbMaestroFormaEnvio"
        '
        'TabPagePicBancos
        '
        Me.TabPagePicBancos.Controls.Add(Me.jngBancos)
        Me.TabPagePicBancos.Key = "Bancos"
        Me.TabPagePicBancos.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicBancos.Name = "TabPagePicBancos"
        Me.TabPagePicBancos.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicBancos.TabStop = True
        Me.TabPagePicBancos.Text = "Bancos"
        '
        'jngBancos
        '
        Me.jngBancos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDBanco", "Banco", "IDBanco", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescBanco", "DescBanco")}))})
        jngBancos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngBancos_DesignTimeLayout_Reference_0.Instance"), Object)
        jngBancos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngBancos_DesignTimeLayout_Reference_0})
        jngBancos_DesignTimeLayout.LayoutString = resources.GetString("jngBancos_DesignTimeLayout.LayoutString")
        Me.jngBancos.DesignTimeLayout = jngBancos_DesignTimeLayout
        Me.jngBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngBancos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngBancos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngBancos.EntityName = "ProveedorBanco"
        Me.jngBancos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngBancos.FrozenColumns = 3
        Me.jngBancos.Location = New System.Drawing.Point(0, 0)
        Me.jngBancos.Name = "jngBancos"
        Me.jngBancos.PrimaryDataFields = "IDProveedor"
        Me.jngBancos.SecondaryDataFields = "IDProveedor"
        Me.jngBancos.Size = New System.Drawing.Size(713, 268)
        Me.jngBancos.TabIndex = 38
        Me.jngBancos.Tag = "IdRec=5071:4357:4607:4697:4606:4608:4609:4614:4411:4415:4612:4698:4699:;"
        Me.jngBancos.ViewName = "vfrmMntoProveedorBanco"
        '
        'TabPagePicArticulos
        '
        Me.TabPagePicArticulos.Controls.Add(Me.jngArticulos)
        Me.TabPagePicArticulos.Controls.Add(Me.Splitter1)
        Me.TabPagePicArticulos.Controls.Add(Me.jngArtLinea)
        Me.TabPagePicArticulos.Key = "Articulos"
        Me.TabPagePicArticulos.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicArticulos.Name = "TabPagePicArticulos"
        Me.TabPagePicArticulos.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicArticulos.TabStop = True
        Me.TabPagePicArticulos.Text = "Artículos"
        '
        'jngArticulos
        '
        Me.jngArticulos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("UDValoracion", "UDValoracion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdCompra", "IDUdCompra")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDCompra", "UDMedida", "IDUDMedida")})
        jngArticulos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngArticulos_DesignTimeLayout_Reference_0.Instance"), Object)
        jngArticulos_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("jngArticulos_DesignTimeLayout_Reference_1.Instance"), Object)
        jngArticulos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngArticulos_DesignTimeLayout_Reference_0, jngArticulos_DesignTimeLayout_Reference_1})
        jngArticulos_DesignTimeLayout.LayoutString = resources.GetString("jngArticulos_DesignTimeLayout.LayoutString")
        Me.jngArticulos.DesignTimeLayout = jngArticulos_DesignTimeLayout
        Me.jngArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngArticulos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngArticulos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngArticulos.EntityName = "ArticuloProveedor"
        Me.jngArticulos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngArticulos.FrozenColumns = 2
        Me.jngArticulos.Location = New System.Drawing.Point(0, 0)
        Me.jngArticulos.Name = "jngArticulos"
        Me.jngArticulos.PrimaryDataFields = "IDProveedor"
        Me.jngArticulos.SecondaryDataFields = "IDProveedor"
        Me.jngArticulos.Size = New System.Drawing.Size(384, 268)
        Me.jngArticulos.TabIndex = 39
        Me.jngArticulos.Tag = "IdRec=4357:4377:4379:4378:4572:4384:4573:4386:4387:4388:4489:;"
        Me.jngArticulos.ViewName = "vfrmMntoProveedorArticulo"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(384, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 268)
        Me.Splitter1.TabIndex = 41
        Me.Splitter1.TabStop = False
        '
        'jngArtLinea
        '
        jngArtLinea_DesignTimeLayout.LayoutString = resources.GetString("jngArtLinea_DesignTimeLayout.LayoutString")
        Me.jngArtLinea.DesignTimeLayout = jngArtLinea_DesignTimeLayout
        Me.jngArtLinea.Dock = System.Windows.Forms.DockStyle.Right
        Me.jngArtLinea.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngArtLinea.EntityName = "ArticuloProveedorLinea"
        Me.jngArtLinea.FrozenColumns = 1
        Me.jngArtLinea.Location = New System.Drawing.Point(389, 0)
        Me.jngArtLinea.Name = "jngArtLinea"
        Me.jngArtLinea.PrimaryDataFields = ""
        Me.jngArtLinea.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.jngArtLinea.RequeryManually = True
        Me.jngArtLinea.SecondaryDataFields = ""
        Me.jngArtLinea.Size = New System.Drawing.Size(324, 268)
        Me.jngArtLinea.TabIndex = 42
        Me.jngArtLinea.Tag = "IdRec=4357:4377:4688:4385:5439:5440:5441:;"
        Me.jngArtLinea.ViewName = "tbArticuloProveedorLinea"
        '
        'TabPagePicDirecciones
        '
        Me.TabPagePicDirecciones.Controls.Add(Me.jngDirecciones)
        Me.TabPagePicDirecciones.Key = "Direcciones"
        Me.TabPagePicDirecciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicDirecciones.Name = "TabPagePicDirecciones"
        Me.TabPagePicDirecciones.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicDirecciones.TabStop = True
        Me.TabPagePicDirecciones.Text = "Direcciones"
        '
        'jngDirecciones
        '
        Me.jngDirecciones.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDPais", "Pais", "IDPais", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescPais", "DescPais")}), ""), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescAlmacen", "DescAlmacen")}))})
        jngDirecciones_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngDirecciones_DesignTimeLayout_Reference_0.Instance"), Object)
        jngDirecciones_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("jngDirecciones_DesignTimeLayout_Reference_1.Instance"), Object)
        jngDirecciones_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngDirecciones_DesignTimeLayout_Reference_0, jngDirecciones_DesignTimeLayout_Reference_1})
        jngDirecciones_DesignTimeLayout.LayoutString = resources.GetString("jngDirecciones_DesignTimeLayout.LayoutString")
        Me.jngDirecciones.DesignTimeLayout = jngDirecciones_DesignTimeLayout
        Me.jngDirecciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngDirecciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngDirecciones.EntityName = "ProveedorDireccion"
        Me.jngDirecciones.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngDirecciones.Location = New System.Drawing.Point(0, 0)
        Me.jngDirecciones.Name = "jngDirecciones"
        Me.jngDirecciones.PrimaryDataFields = "IDProveedor"
        Me.jngDirecciones.SecondaryDataFields = "IDProveedor"
        Me.jngDirecciones.Size = New System.Drawing.Size(713, 268)
        Me.jngDirecciones.TabIndex = 89
        Me.jngDirecciones.ViewName = "vfrmMntoProveedorDireccion"
        '
        'TabPagePicFamilias
        '
        Me.TabPagePicFamilias.Controls.Add(Me.jngFamilia)
        Me.TabPagePicFamilias.Key = "Familias"
        Me.TabPagePicFamilias.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicFamilias.Name = "TabPagePicFamilias"
        Me.TabPagePicFamilias.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicFamilias.TabStop = True
        Me.TabPagePicFamilias.Text = "Dto. Familias"
        '
        'jngFamilia
        '
        Me.jngFamilia.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipo", "TipoArticulo", "IDTipo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescTipo", "DescTipo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFamilia", "Familia", "IDFamilia", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescFamilia", "DescFamilia")}))})
        jngFamilia_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngFamilia_DesignTimeLayout_Reference_0.Instance"), Object)
        jngFamilia_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("jngFamilia_DesignTimeLayout_Reference_1.Instance"), Object)
        jngFamilia_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngFamilia_DesignTimeLayout_Reference_0, jngFamilia_DesignTimeLayout_Reference_1})
        jngFamilia_DesignTimeLayout.LayoutString = resources.GetString("jngFamilia_DesignTimeLayout.LayoutString")
        Me.jngFamilia.DesignTimeLayout = jngFamilia_DesignTimeLayout
        Me.jngFamilia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngFamilia.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngFamilia.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngFamilia.EntityName = "ProveedorDescuentoFamilia"
        Me.jngFamilia.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngFamilia.Location = New System.Drawing.Point(0, 0)
        Me.jngFamilia.Name = "jngFamilia"
        Me.jngFamilia.PrimaryDataFields = "IDProveedor"
        Me.jngFamilia.SecondaryDataFields = "IDProveedor"
        Me.jngFamilia.Size = New System.Drawing.Size(713, 268)
        Me.jngFamilia.TabIndex = 41
        Me.jngFamilia.ViewName = "VMntoProveedorFamiliaDescuento"
        '
        'TabPagePicVacaciones
        '
        Me.TabPagePicVacaciones.Controls.Add(Me.jngVacaciones)
        Me.TabPagePicVacaciones.Controls.Add(Me.PnlMsgVacaciones)
        Me.TabPagePicVacaciones.Key = "Vacaciones"
        Me.TabPagePicVacaciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicVacaciones.Name = "TabPagePicVacaciones"
        Me.TabPagePicVacaciones.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicVacaciones.TabStop = True
        Me.TabPagePicVacaciones.Text = "Vacaciones"
        '
        'jngVacaciones
        '
        jngVacaciones_DesignTimeLayout.LayoutString = resources.GetString("jngVacaciones_DesignTimeLayout.LayoutString")
        Me.jngVacaciones.DesignTimeLayout = jngVacaciones_DesignTimeLayout
        Me.jngVacaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngVacaciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngVacaciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngVacaciones.EntityName = "ProveedorVacaciones"
        Me.jngVacaciones.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jngVacaciones.Location = New System.Drawing.Point(0, 0)
        Me.jngVacaciones.Name = "jngVacaciones"
        Me.jngVacaciones.PrimaryDataFields = "IDProveedor"
        Me.jngVacaciones.SecondaryDataFields = "IDProveedor"
        Me.jngVacaciones.Size = New System.Drawing.Size(713, 236)
        Me.jngVacaciones.TabIndex = 42
        Me.jngVacaciones.Tag = "IdRec=7389:4352:4632:4641:7397:7398:7392:;"
        Me.jngVacaciones.ViewName = "VFrmMntoProveedorVacaciones"
        '
        'PnlMsgVacaciones
        '
        Me.PnlMsgVacaciones.Controls.Add(Me.TxtMsgVacaciones)
        Me.PnlMsgVacaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlMsgVacaciones.Location = New System.Drawing.Point(0, 236)
        Me.PnlMsgVacaciones.Name = "PnlMsgVacaciones"
        Me.PnlMsgVacaciones.Size = New System.Drawing.Size(713, 32)
        Me.PnlMsgVacaciones.TabIndex = 44
        '
        'TxtMsgVacaciones
        '
        Me.TxtMsgVacaciones.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TxtMsgVacaciones.DisabledBackColor = System.Drawing.Color.White
        Me.TxtMsgVacaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMsgVacaciones.ForeColor = System.Drawing.Color.Red
        Me.TxtMsgVacaciones.Location = New System.Drawing.Point(0, 0)
        Me.TxtMsgVacaciones.Multiline = True
        Me.TxtMsgVacaciones.Name = "TxtMsgVacaciones"
        Me.TxtMsgVacaciones.Size = New System.Drawing.Size(713, 32)
        Me.TxtMsgVacaciones.TabIndex = 0
        Me.TxtMsgVacaciones.Text = "*** Si se ponen fechas alternativas es importante establecer un año coherente, es" & _
            " decir se deberá tener en cuenta si la fecha alternativa va a ser en el mismo añ" & _
            "o, el año anterior o el siguiente"
        '
        'TabPagePicObservaciones
        '
        Me.TabPagePicObservaciones.Controls.Add(Me.FrmObservaciones)
        Me.TabPagePicObservaciones.Controls.Add(Me.Frame7)
        Me.TabPagePicObservaciones.Key = "Observaciones"
        Me.TabPagePicObservaciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicObservaciones.Name = "TabPagePicObservaciones"
        Me.TabPagePicObservaciones.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicObservaciones.TabStop = True
        Me.TabPagePicObservaciones.Text = "Observaciones"
        '
        'FrmObservaciones
        '
        Me.FrmObservaciones.Controls.Add(Me.fwiTexto)
        Me.FrmObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmObservaciones.Location = New System.Drawing.Point(0, 128)
        Me.FrmObservaciones.Name = "FrmObservaciones"
        Me.FrmObservaciones.Size = New System.Drawing.Size(713, 140)
        Me.FrmObservaciones.TabIndex = 76
        Me.FrmObservaciones.TabStop = False
        Me.FrmObservaciones.Text = "Observaciones"
        '
        'fwiTexto
        '
        Me.TryDataBinding(fwiTexto, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.fwiTexto.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fwiTexto.Location = New System.Drawing.Point(3, 17)
        Me.fwiTexto.Multiline = True
        Me.fwiTexto.Name = "fwiTexto"
        Me.fwiTexto.Size = New System.Drawing.Size(707, 120)
        Me.fwiTexto.TabIndex = 77
        '
        'Frame7
        '
        Me.Frame7.Controls.Add(Me.jngObservaciones)
        Me.Frame7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame7.Location = New System.Drawing.Point(0, 0)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Size = New System.Drawing.Size(713, 128)
        Me.Frame7.TabIndex = 77
        Me.Frame7.TabStop = False
        Me.Frame7.Text = "Observaciones - Entidades"
        '
        'jngObservaciones
        '
        Me.jngObservaciones.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDObservacion", "Observacion", "IDObservacion", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescObservacion", "DescObservacion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Entidad", "Entidad")}))})
        jngObservaciones_DesignTimeLayout.LayoutString = resources.GetString("jngObservaciones_DesignTimeLayout.LayoutString")
        Me.jngObservaciones.DesignTimeLayout = jngObservaciones_DesignTimeLayout
        Me.jngObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngObservaciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngObservaciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngObservaciones.EntityName = "ProveedorObservacion"
        Me.jngObservaciones.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngObservaciones.Location = New System.Drawing.Point(3, 17)
        Me.jngObservaciones.Name = "jngObservaciones"
        Me.jngObservaciones.PrimaryDataFields = "IDProveedor"
        Me.jngObservaciones.SecondaryDataFields = "IDProveedor"
        Me.jngObservaciones.Size = New System.Drawing.Size(707, 108)
        Me.jngObservaciones.TabIndex = 70
        Me.jngObservaciones.Tag = "IdRec=8307:4431:7414:4571:4433:0:;"
        Me.jngObservaciones.ViewName = "vfrmProveedorObservacion"
        '
        'TabPagePicCalidad
        '
        Me.TabPagePicCalidad.Controls.Add(Me.Frame5)
        Me.TabPagePicCalidad.Controls.Add(Me.Frame3)
        Me.TabPagePicCalidad.Key = "Calidad"
        Me.TabPagePicCalidad.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicCalidad.Name = "TabPagePicCalidad"
        Me.TabPagePicCalidad.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicCalidad.TabStop = True
        Me.TabPagePicCalidad.Text = "Calidad"
        '
        'Frame5
        '
        Me.Frame5.Controls.Add(Me.ulDescCalificacionCC)
        Me.Frame5.Controls.Add(Me.ulDescCalificacion)
        Me.Frame5.Controls.Add(Me.lblfwiResultadoCC)
        Me.Frame5.Controls.Add(Me.lblfwiResultado)
        Me.Frame5.Controls.Add(Me.lblfwiCalificacionCC)
        Me.Frame5.Controls.Add(Me.lblfwiCalificacion)
        Me.Frame5.Controls.Add(Me.fwiResultadoCC)
        Me.Frame5.Controls.Add(Me.AdvIDCalificacionCC)
        Me.Frame5.Controls.Add(Me.lblfwiFechaUltimaCalificacion)
        Me.Frame5.Controls.Add(Me.fwiFechaUltimaCalificacion)
        Me.Frame5.Controls.Add(Me.fwiResultado)
        Me.Frame5.Controls.Add(Me.AdvIDCalificacion)
        Me.Frame5.Location = New System.Drawing.Point(0, 123)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Size = New System.Drawing.Size(710, 91)
        Me.Frame5.TabIndex = 68
        Me.Frame5.TabStop = False
        '
        'ulDescCalificacionCC
        '
        Me.ulDescCalificacionCC.Location = New System.Drawing.Point(224, 39)
        Me.ulDescCalificacionCC.Name = "ulDescCalificacionCC"
        Me.ulDescCalificacionCC.Size = New System.Drawing.Size(208, 21)
        Me.ulDescCalificacionCC.TabIndex = 60
        '
        'ulDescCalificacion
        '
        Me.ulDescCalificacion.Location = New System.Drawing.Point(224, 13)
        Me.ulDescCalificacion.Name = "ulDescCalificacion"
        Me.ulDescCalificacion.Size = New System.Drawing.Size(208, 21)
        Me.ulDescCalificacion.TabIndex = 59
        '
        'lblfwiResultadoCC
        '
        Me.lblfwiResultadoCC.Location = New System.Drawing.Point(232, 65)
        Me.lblfwiResultadoCC.Name = "lblfwiResultadoCC"
        Me.lblfwiResultadoCC.Size = New System.Drawing.Size(97, 13)
        Me.lblfwiResultadoCC.TabIndex = 58
        Me.lblfwiResultadoCC.Text = "Resultado C. C."
        '
        'lblfwiResultado
        '
        Me.lblfwiResultado.Location = New System.Drawing.Point(8, 66)
        Me.lblfwiResultado.Name = "lblfwiResultado"
        Me.lblfwiResultado.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiResultado.TabIndex = 57
        Me.lblfwiResultado.Text = "Resultado"
        '
        'lblfwiCalificacionCC
        '
        Me.lblfwiCalificacionCC.Location = New System.Drawing.Point(8, 41)
        Me.lblfwiCalificacionCC.Name = "lblfwiCalificacionCC"
        Me.lblfwiCalificacionCC.Size = New System.Drawing.Size(106, 13)
        Me.lblfwiCalificacionCC.TabIndex = 56
        Me.lblfwiCalificacionCC.Text = "Calificación C. C."
        '
        'lblfwiCalificacion
        '
        Me.lblfwiCalificacion.Location = New System.Drawing.Point(8, 16)
        Me.lblfwiCalificacion.Name = "lblfwiCalificacion"
        Me.lblfwiCalificacion.Size = New System.Drawing.Size(72, 13)
        Me.lblfwiCalificacion.TabIndex = 55
        Me.lblfwiCalificacion.Text = "Calificación"
        '
        'fwiResultadoCC
        '
        Me.TryDataBinding(fwiResultadoCC, New System.Windows.Forms.Binding("Value", Me, "ResultadoCC", True))
        Me.fwiResultadoCC.DisabledBackColor = System.Drawing.Color.White
        Me.fwiResultadoCC.Enabled = False
        Me.fwiResultadoCC.Location = New System.Drawing.Point(344, 65)
        Me.fwiResultadoCC.Name = "fwiResultadoCC"
        Me.fwiResultadoCC.Size = New System.Drawing.Size(100, 21)
        Me.fwiResultadoCC.TabIndex = 93
        '
        'AdvIDCalificacionCC
        '
        Me.TryDataBinding(AdvIDCalificacionCC, New System.Windows.Forms.Binding("Text", Me, "IDCalificacionCC", True))
        Me.AdvIDCalificacionCC.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCalificacionCC.EntityName = "Calificacion"
        Me.AdvIDCalificacionCC.Location = New System.Drawing.Point(118, 39)
        Me.AdvIDCalificacionCC.Name = "AdvIDCalificacionCC"
        Me.AdvIDCalificacionCC.PrimaryDataFields = "IDCalificacionCC"
        Me.AdvIDCalificacionCC.SecondaryDataFields = "IDCalificacion"
        Me.AdvIDCalificacionCC.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDCalificacionCC.TabIndex = 91
        Me.AdvIDCalificacionCC.ViewName = "tbMaestroCalificacion"
        '
        'lblfwiFechaUltimaCalificacion
        '
        Me.lblfwiFechaUltimaCalificacion.Location = New System.Drawing.Point(457, 16)
        Me.lblfwiFechaUltimaCalificacion.Name = "lblfwiFechaUltimaCalificacion"
        Me.lblfwiFechaUltimaCalificacion.Size = New System.Drawing.Size(113, 13)
        Me.lblfwiFechaUltimaCalificacion.TabIndex = 54
        Me.lblfwiFechaUltimaCalificacion.Text = "Fecha Ultima Calif."
        '
        'fwiFechaUltimaCalificacion
        '
        Me.TryDataBinding(fwiFechaUltimaCalificacion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaUltimaCalificacion", True))
        Me.fwiFechaUltimaCalificacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaUltimaCalificacion.Location = New System.Drawing.Point(580, 13)
        Me.fwiFechaUltimaCalificacion.Name = "fwiFechaUltimaCalificacion"
        Me.fwiFechaUltimaCalificacion.Size = New System.Drawing.Size(116, 21)
        Me.fwiFechaUltimaCalificacion.TabIndex = 90
        '
        'fwiResultado
        '
        Me.TryDataBinding(fwiResultado, New System.Windows.Forms.Binding("Value", Me, "Resultado", True))
        Me.fwiResultado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiResultado.Enabled = False
        Me.fwiResultado.Location = New System.Drawing.Point(118, 65)
        Me.fwiResultado.Name = "fwiResultado"
        Me.fwiResultado.Size = New System.Drawing.Size(100, 21)
        Me.fwiResultado.TabIndex = 92
        '
        'AdvIDCalificacion
        '
        Me.TryDataBinding(AdvIDCalificacion, New System.Windows.Forms.Binding("Text", Me, "IDCalificacion", True))
        Me.AdvIDCalificacion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCalificacion.EntityName = "Calificacion"
        Me.AdvIDCalificacion.Location = New System.Drawing.Point(118, 13)
        Me.AdvIDCalificacion.Name = "AdvIDCalificacion"
        Me.AdvIDCalificacion.PrimaryDataFields = "IDCalificacion"
        Me.AdvIDCalificacion.SecondaryDataFields = "IDCalificacion"
        Me.AdvIDCalificacion.Size = New System.Drawing.Size(100, 23)
        Me.AdvIDCalificacion.TabIndex = 89
        Me.AdvIDCalificacion.ViewName = "tbMaestroCalificacion"
        '
        'Frame3
        '
        Me.Frame3.Controls.Add(Me.lblfwiNCertificado)
        Me.Frame3.Controls.Add(Me.fwiNCertificado)
        Me.Frame3.Controls.Add(Me.lblfwiFechaHomologacion)
        Me.Frame3.Controls.Add(Me.fwiFechaHomologacion)
        Me.Frame3.Controls.Add(Me.lblFwiFechaValidez)
        Me.Frame3.Controls.Add(Me.lblfwiAuditor)
        Me.Frame3.Controls.Add(Me.lblfwiReferencial)
        Me.Frame3.Controls.Add(Me.fwiFechaValidez)
        Me.Frame3.Controls.Add(Me.ulDescAuditor)
        Me.Frame3.Controls.Add(Me.cbxIDAuditor)
        Me.Frame3.Controls.Add(Me.ulDescReferencial)
        Me.Frame3.Controls.Add(Me.AdvIDReferencial)
        Me.Frame3.Controls.Add(Me.fwiCertificadoCalidad)
        Me.Frame3.Controls.Add(Me.fwiImprimirEspecificacion)
        Me.Frame3.Controls.Add(Me.fwiHomologable)
        Me.Frame3.Controls.Add(Me.fwiCalidadConcertada)
        Me.Frame3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame3.Location = New System.Drawing.Point(0, 0)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Size = New System.Drawing.Size(713, 124)
        Me.Frame3.TabIndex = 65
        Me.Frame3.TabStop = False
        '
        'lblfwiNCertificado
        '
        Me.lblfwiNCertificado.Location = New System.Drawing.Point(8, 96)
        Me.lblfwiNCertificado.Name = "lblfwiNCertificado"
        Me.lblfwiNCertificado.Size = New System.Drawing.Size(87, 13)
        Me.lblfwiNCertificado.TabIndex = 94
        Me.lblfwiNCertificado.Text = "Nº Certificado"
        '
        'fwiNCertificado
        '
        Me.TryDataBinding(fwiNCertificado, New System.Windows.Forms.Binding("Text", Me, "NCertificado", True))
        Me.fwiNCertificado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNCertificado.Location = New System.Drawing.Point(104, 96)
        Me.fwiNCertificado.Name = "fwiNCertificado"
        Me.fwiNCertificado.Size = New System.Drawing.Size(296, 21)
        Me.fwiNCertificado.TabIndex = 87
        '
        'lblfwiFechaHomologacion
        '
        Me.lblfwiFechaHomologacion.Location = New System.Drawing.Point(436, 96)
        Me.lblfwiFechaHomologacion.Name = "lblfwiFechaHomologacion"
        Me.lblfwiFechaHomologacion.Size = New System.Drawing.Size(142, 13)
        Me.lblfwiFechaHomologacion.TabIndex = 95
        Me.lblfwiFechaHomologacion.Text = "Fecha de Homologación"
        '
        'fwiFechaHomologacion
        '
        Me.TryDataBinding(fwiFechaHomologacion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaHomologacion", True))
        Me.fwiFechaHomologacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaHomologacion.Location = New System.Drawing.Point(580, 96)
        Me.fwiFechaHomologacion.Name = "fwiFechaHomologacion"
        Me.fwiFechaHomologacion.Size = New System.Drawing.Size(116, 21)
        Me.fwiFechaHomologacion.TabIndex = 88
        '
        'lblFwiFechaValidez
        '
        Me.lblFwiFechaValidez.Location = New System.Drawing.Point(192, 66)
        Me.lblFwiFechaValidez.Name = "lblFwiFechaValidez"
        Me.lblFwiFechaValidez.Size = New System.Drawing.Size(84, 13)
        Me.lblFwiFechaValidez.TabIndex = 91
        Me.lblFwiFechaValidez.Text = "Fecha Validez"
        '
        'lblfwiAuditor
        '
        Me.lblfwiAuditor.Location = New System.Drawing.Point(192, 41)
        Me.lblfwiAuditor.Name = "lblfwiAuditor"
        Me.lblfwiAuditor.Size = New System.Drawing.Size(48, 13)
        Me.lblfwiAuditor.TabIndex = 90
        Me.lblfwiAuditor.Text = "Auditor"
        '
        'lblfwiReferencial
        '
        Me.lblfwiReferencial.Location = New System.Drawing.Point(192, 16)
        Me.lblfwiReferencial.Name = "lblfwiReferencial"
        Me.lblfwiReferencial.Size = New System.Drawing.Size(71, 13)
        Me.lblfwiReferencial.TabIndex = 89
        Me.lblfwiReferencial.Text = "Referencial"
        '
        'fwiFechaValidez
        '
        Me.TryDataBinding(fwiFechaValidez, New System.Windows.Forms.Binding("BindableValue", Me, "FechaValidezHomologacion", True))
        Me.fwiFechaValidez.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaValidez.Location = New System.Drawing.Point(288, 66)
        Me.fwiFechaValidez.Name = "fwiFechaValidez"
        Me.fwiFechaValidez.Size = New System.Drawing.Size(107, 21)
        Me.fwiFechaValidez.TabIndex = 86
        '
        'ulDescAuditor
        '
        Me.TryDataBinding(ulDescAuditor, New System.Windows.Forms.Binding("Text", Me.cbxIDAuditor, "DescAuditor", True))
        Me.ulDescAuditor.Location = New System.Drawing.Point(400, 41)
        Me.ulDescAuditor.Name = "ulDescAuditor"
        Me.ulDescAuditor.Size = New System.Drawing.Size(296, 21)
        Me.ulDescAuditor.TabIndex = 87
        '
        'cbxIDAuditor
        '
        Me.TryDataBinding(cbxIDAuditor, New System.Windows.Forms.Binding("Value", Me, "IDAuditor", True))
        cbxIDAuditor_DesignTimeLayout.LayoutString = resources.GetString("cbxIDAuditor_DesignTimeLayout.LayoutString")
        Me.cbxIDAuditor.DesignTimeLayout = cbxIDAuditor_DesignTimeLayout
        Me.cbxIDAuditor.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDAuditor.DisplayMember = "IDAuditor"
        Me.cbxIDAuditor.EntityName = "Auditor"
        Me.cbxIDAuditor.Location = New System.Drawing.Point(288, 41)
        Me.cbxIDAuditor.Name = "cbxIDAuditor"
        Me.cbxIDAuditor.PrimaryDataFields = "IDAuditor"
        Me.cbxIDAuditor.SecondaryDataFields = "IDAuditor"
        Me.cbxIDAuditor.SelectedIndex = -1
        Me.cbxIDAuditor.SelectedItem = Nothing
        Me.cbxIDAuditor.Size = New System.Drawing.Size(107, 21)
        Me.cbxIDAuditor.TabIndex = 85
        Me.cbxIDAuditor.ValueMember = "IDAuditor"
        Me.cbxIDAuditor.ViewName = "tbMaestroAuditor"
        '
        'ulDescReferencial
        '
        Me.TryDataBinding(ulDescReferencial, New System.Windows.Forms.Binding("Text", Me.AdvIDReferencial, "DescReferencial", True))
        Me.ulDescReferencial.Location = New System.Drawing.Point(400, 16)
        Me.ulDescReferencial.Name = "ulDescReferencial"
        Me.ulDescReferencial.Size = New System.Drawing.Size(296, 17)
        Me.ulDescReferencial.TabIndex = 88
        '
        'AdvIDReferencial
        '
        Me.TryDataBinding(AdvIDReferencial, New System.Windows.Forms.Binding("Text", Me, "IDReferencial", True))
        Me.AdvIDReferencial.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDReferencial.EntityName = "Referencial"
        Me.AdvIDReferencial.Location = New System.Drawing.Point(288, 16)
        Me.AdvIDReferencial.Name = "AdvIDReferencial"
        Me.AdvIDReferencial.PrimaryDataFields = "IDReferencial"
        Me.AdvIDReferencial.SecondaryDataFields = "IDReferencial"
        Me.AdvIDReferencial.Size = New System.Drawing.Size(107, 23)
        Me.AdvIDReferencial.TabIndex = 84
        Me.AdvIDReferencial.ViewName = "tbMaestroReferencial"
        '
        'fwiCertificadoCalidad
        '
        Me.TryDataBinding(fwiCertificadoCalidad, New System.Windows.Forms.Binding("BindableValue", Me, "CertificadoCalidad", True))
        Me.fwiCertificadoCalidad.Location = New System.Drawing.Point(8, 49)
        Me.fwiCertificadoCalidad.Name = "fwiCertificadoCalidad"
        Me.fwiCertificadoCalidad.Size = New System.Drawing.Size(130, 20)
        Me.fwiCertificadoCalidad.TabIndex = 82
        Me.fwiCertificadoCalidad.Text = "Cfdo. Calidad"
        '
        'fwiImprimirEspecificacion
        '
        Me.TryDataBinding(fwiImprimirEspecificacion, New System.Windows.Forms.Binding("BindableValue", Me, "ImprimirEspecificacion", True))
        Me.fwiImprimirEspecificacion.Location = New System.Drawing.Point(8, 64)
        Me.fwiImprimirEspecificacion.Name = "fwiImprimirEspecificacion"
        Me.fwiImprimirEspecificacion.Size = New System.Drawing.Size(160, 25)
        Me.fwiImprimirEspecificacion.TabIndex = 83
        Me.fwiImprimirEspecificacion.Text = "Imprimir Especificación"
        '
        'fwiHomologable
        '
        Me.TryDataBinding(fwiHomologable, New System.Windows.Forms.Binding("BindableValue", Me, "Homologable", True))
        Me.fwiHomologable.Location = New System.Drawing.Point(8, 13)
        Me.fwiHomologable.Name = "fwiHomologable"
        Me.fwiHomologable.Size = New System.Drawing.Size(130, 19)
        Me.fwiHomologable.TabIndex = 80
        Me.fwiHomologable.Text = "Homologable"
        '
        'fwiCalidadConcertada
        '
        Me.TryDataBinding(fwiCalidadConcertada, New System.Windows.Forms.Binding("BindableValue", Me, "CalidadConcertada", True))
        Me.fwiCalidadConcertada.Location = New System.Drawing.Point(8, 31)
        Me.fwiCalidadConcertada.Name = "fwiCalidadConcertada"
        Me.fwiCalidadConcertada.Size = New System.Drawing.Size(130, 20)
        Me.fwiCalidadConcertada.TabIndex = 81
        Me.fwiCalidadConcertada.Text = "Calidad Concertada"
        '
        'TabPagePicGrupoProv
        '
        Me.TabPagePicGrupoProv.Controls.Add(Me.fwiGrupoFactura)
        Me.TabPagePicGrupoProv.Controls.Add(Me.fwiGrupoArticulo)
        Me.TabPagePicGrupoProv.Controls.Add(Me.lblfwiIdGrupoProveedor)
        Me.TabPagePicGrupoProv.Controls.Add(Me.ulDescGrupoProveedor)
        Me.TabPagePicGrupoProv.Controls.Add(Me.AdvIDGrupoProveedor)
        Me.TabPagePicGrupoProv.Key = "Grupo"
        Me.TabPagePicGrupoProv.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicGrupoProv.Name = "TabPagePicGrupoProv"
        Me.TabPagePicGrupoProv.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePicGrupoProv.TabStop = True
        Me.TabPagePicGrupoProv.Text = "Grupo"
        '
        'fwiGrupoFactura
        '
        Me.fwiGrupoFactura.Checked = True
        Me.fwiGrupoFactura.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TryDataBinding(fwiGrupoFactura, New System.Windows.Forms.Binding("BindableValue", Me, "GrupoFactura", True))
        Me.fwiGrupoFactura.Location = New System.Drawing.Point(120, 56)
        Me.fwiGrupoFactura.Name = "fwiGrupoFactura"
        Me.fwiGrupoFactura.Size = New System.Drawing.Size(125, 21)
        Me.fwiGrupoFactura.TabIndex = 79
        Me.fwiGrupoFactura.Text = "Grupo Factura"
        Me.fwiGrupoFactura.Visible = False
        '
        'fwiGrupoArticulo
        '
        Me.TryDataBinding(fwiGrupoArticulo, New System.Windows.Forms.Binding("BindableValue", Me, "GrupoArticulo", True))
        Me.fwiGrupoArticulo.Location = New System.Drawing.Point(384, 56)
        Me.fwiGrupoArticulo.Name = "fwiGrupoArticulo"
        Me.fwiGrupoArticulo.Size = New System.Drawing.Size(125, 22)
        Me.fwiGrupoArticulo.TabIndex = 78
        Me.fwiGrupoArticulo.Text = "Grupo Artículo"
        Me.fwiGrupoArticulo.Visible = False
        '
        'lblfwiIdGrupoProveedor
        '
        Me.lblfwiIdGrupoProveedor.Location = New System.Drawing.Point(19, 21)
        Me.lblfwiIdGrupoProveedor.Name = "lblfwiIdGrupoProveedor"
        Me.lblfwiIdGrupoProveedor.Size = New System.Drawing.Size(105, 13)
        Me.lblfwiIdGrupoProveedor.TabIndex = 80
        Me.lblfwiIdGrupoProveedor.Text = "Grupo Proveedor"
        '
        'ulDescGrupoProveedor
        '
        Me.TryDataBinding(ulDescGrupoProveedor, New System.Windows.Forms.Binding("Text", Me.AdvIDGrupoProveedor, "DescProveedor", True))
        Me.ulDescGrupoProveedor.Location = New System.Drawing.Point(259, 16)
        Me.ulDescGrupoProveedor.Name = "ulDescGrupoProveedor"
        Me.ulDescGrupoProveedor.Size = New System.Drawing.Size(360, 21)
        Me.ulDescGrupoProveedor.TabIndex = 81
        '
        'AdvIDGrupoProveedor
        '
        Me.TryDataBinding(AdvIDGrupoProveedor, New System.Windows.Forms.Binding("Text", Me, "IDGrupoProveedor", True))
        Me.AdvIDGrupoProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDGrupoProveedor.EntityName = "Proveedor"
        Me.AdvIDGrupoProveedor.Location = New System.Drawing.Point(128, 16)
        Me.AdvIDGrupoProveedor.Name = "AdvIDGrupoProveedor"
        Me.AdvIDGrupoProveedor.PrimaryDataFields = "IDGrupoProveedor"
        Me.AdvIDGrupoProveedor.SecondaryDataFields = "IDProveedor"
        Me.AdvIDGrupoProveedor.Size = New System.Drawing.Size(128, 23)
        Me.AdvIDGrupoProveedor.TabIndex = 77
        Me.AdvIDGrupoProveedor.ViewName = "tbMaestroProveedor"
        '
        'TabPagePagos
        '
        Me.TabPagePagos.Controls.Add(Me.ntbTotalPagar)
        Me.TabPagePagos.Controls.Add(Me.lblTotalPagar)
        Me.TabPagePagos.Controls.Add(Me.ntbTotalGastos)
        Me.TabPagePagos.Controls.Add(Me.lblTotalGastos)
        Me.TabPagePagos.Controls.Add(Me.ntbTotalAlquiler)
        Me.TabPagePagos.Controls.Add(Me.lblTotalAlquiler)
        Me.TabPagePagos.Controls.Add(Me.ntbvarios)
        Me.TabPagePagos.Controls.Add(Me.lblvarios)
        Me.TabPagePagos.Controls.Add(Me.ntbgas)
        Me.TabPagePagos.Controls.Add(Me.lblgas)
        Me.TabPagePagos.Controls.Add(Me.ntbagua)
        Me.TabPagePagos.Controls.Add(Me.lblagua)
        Me.TabPagePagos.Controls.Add(Me.ntbretencion)
        Me.TabPagePagos.Controls.Add(Me.lblretencion)
        Me.TabPagePagos.Controls.Add(Me.ntbiva)
        Me.TabPagePagos.Controls.Add(Me.lbliva)
        Me.TabPagePagos.Controls.Add(Me.ntbrenta)
        Me.TabPagePagos.Controls.Add(Me.lblrenta)
        Me.TabPagePagos.Controls.Add(Me.chbpiso)
        Me.TabPagePagos.Controls.Add(Me.lblpiso)
        Me.TabPagePagos.Controls.Add(Me.ntbluz)
        Me.TabPagePagos.Controls.Add(Me.lblluz)
        Me.TabPagePagos.Controls.Add(Me.ntbfianza)
        Me.TabPagePagos.Controls.Add(Me.lblfianza)
        Me.TabPagePagos.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePagos.Name = "TabPagePagos"
        Me.TabPagePagos.Size = New System.Drawing.Size(713, 268)
        Me.TabPagePagos.TabStop = True
        Me.TabPagePagos.Text = "Pagos"
        '
        'ntbTotalPagar
        '
        Me.TryDataBinding(ntbTotalPagar, New System.Windows.Forms.Binding("Value", Me, "TotalPagar", True))
        Me.ntbTotalPagar.DisabledBackColor = System.Drawing.Color.White
        Me.ntbTotalPagar.Location = New System.Drawing.Point(574, 140)
        Me.ntbTotalPagar.Name = "ntbTotalPagar"
        Me.ntbTotalPagar.Size = New System.Drawing.Size(121, 21)
        Me.ntbTotalPagar.TabIndex = 22
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.Location = New System.Drawing.Point(501, 144)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(67, 13)
        Me.lblTotalPagar.TabIndex = 23
        Me.lblTotalPagar.Text = "TotalPagar"
        '
        'ntbTotalGastos
        '
        Me.TryDataBinding(ntbTotalGastos, New System.Windows.Forms.Binding("Value", Me, "TotalGastos", True))
        Me.ntbTotalGastos.DisabledBackColor = System.Drawing.Color.White
        Me.ntbTotalGastos.Location = New System.Drawing.Point(347, 140)
        Me.ntbTotalGastos.Name = "ntbTotalGastos"
        Me.ntbTotalGastos.Size = New System.Drawing.Size(121, 21)
        Me.ntbTotalGastos.TabIndex = 20
        '
        'lblTotalGastos
        '
        Me.lblTotalGastos.Location = New System.Drawing.Point(269, 144)
        Me.lblTotalGastos.Name = "lblTotalGastos"
        Me.lblTotalGastos.Size = New System.Drawing.Size(73, 13)
        Me.lblTotalGastos.TabIndex = 21
        Me.lblTotalGastos.Text = "TotalGastos"
        '
        'ntbTotalAlquiler
        '
        Me.TryDataBinding(ntbTotalAlquiler, New System.Windows.Forms.Binding("Value", Me, "TotalAlquiler", True))
        Me.ntbTotalAlquiler.DisabledBackColor = System.Drawing.Color.White
        Me.ntbTotalAlquiler.Location = New System.Drawing.Point(111, 140)
        Me.ntbTotalAlquiler.Name = "ntbTotalAlquiler"
        Me.ntbTotalAlquiler.Size = New System.Drawing.Size(121, 21)
        Me.ntbTotalAlquiler.TabIndex = 18
        '
        'lblTotalAlquiler
        '
        Me.lblTotalAlquiler.Location = New System.Drawing.Point(12, 144)
        Me.lblTotalAlquiler.Name = "lblTotalAlquiler"
        Me.lblTotalAlquiler.Size = New System.Drawing.Size(77, 13)
        Me.lblTotalAlquiler.TabIndex = 19
        Me.lblTotalAlquiler.Text = "TotalAlquiler"
        '
        'ntbvarios
        '
        Me.TryDataBinding(ntbvarios, New System.Windows.Forms.Binding("Value", Me, "varios", True))
        Me.ntbvarios.DisabledBackColor = System.Drawing.Color.White
        Me.ntbvarios.Location = New System.Drawing.Point(348, 102)
        Me.ntbvarios.Name = "ntbvarios"
        Me.ntbvarios.Size = New System.Drawing.Size(121, 21)
        Me.ntbvarios.TabIndex = 16
        '
        'lblvarios
        '
        Me.lblvarios.Location = New System.Drawing.Point(268, 106)
        Me.lblvarios.Name = "lblvarios"
        Me.lblvarios.Size = New System.Drawing.Size(42, 13)
        Me.lblvarios.TabIndex = 17
        Me.lblvarios.Text = "varios"
        '
        'ntbgas
        '
        Me.TryDataBinding(ntbgas, New System.Windows.Forms.Binding("Value", Me, "gas", True))
        Me.ntbgas.DisabledBackColor = System.Drawing.Color.White
        Me.ntbgas.Location = New System.Drawing.Point(348, 75)
        Me.ntbgas.Name = "ntbgas"
        Me.ntbgas.Size = New System.Drawing.Size(121, 21)
        Me.ntbgas.TabIndex = 14
        '
        'lblgas
        '
        Me.lblgas.Location = New System.Drawing.Point(268, 79)
        Me.lblgas.Name = "lblgas"
        Me.lblgas.Size = New System.Drawing.Size(27, 13)
        Me.lblgas.TabIndex = 15
        Me.lblgas.Text = "gas"
        '
        'ntbagua
        '
        Me.TryDataBinding(ntbagua, New System.Windows.Forms.Binding("Value", Me, "agua", True))
        Me.ntbagua.DisabledBackColor = System.Drawing.Color.White
        Me.ntbagua.Location = New System.Drawing.Point(348, 48)
        Me.ntbagua.Name = "ntbagua"
        Me.ntbagua.Size = New System.Drawing.Size(121, 21)
        Me.ntbagua.TabIndex = 12
        '
        'lblagua
        '
        Me.lblagua.Location = New System.Drawing.Point(268, 52)
        Me.lblagua.Name = "lblagua"
        Me.lblagua.Size = New System.Drawing.Size(35, 13)
        Me.lblagua.TabIndex = 13
        Me.lblagua.Text = "agua"
        '
        'ntbretencion
        '
        Me.TryDataBinding(ntbretencion, New System.Windows.Forms.Binding("Value", Me, "retencion", True))
        Me.ntbretencion.DisabledBackColor = System.Drawing.Color.White
        Me.ntbretencion.Location = New System.Drawing.Point(111, 102)
        Me.ntbretencion.Name = "ntbretencion"
        Me.ntbretencion.Size = New System.Drawing.Size(121, 21)
        Me.ntbretencion.TabIndex = 10
        '
        'lblretencion
        '
        Me.lblretencion.Location = New System.Drawing.Point(12, 106)
        Me.lblretencion.Name = "lblretencion"
        Me.lblretencion.Size = New System.Drawing.Size(60, 13)
        Me.lblretencion.TabIndex = 11
        Me.lblretencion.Text = "retencion"
        '
        'ntbiva
        '
        Me.TryDataBinding(ntbiva, New System.Windows.Forms.Binding("Value", Me, "iva", True))
        Me.ntbiva.DisabledBackColor = System.Drawing.Color.White
        Me.ntbiva.Location = New System.Drawing.Point(111, 75)
        Me.ntbiva.Name = "ntbiva"
        Me.ntbiva.Size = New System.Drawing.Size(121, 21)
        Me.ntbiva.TabIndex = 8
        '
        'lbliva
        '
        Me.lbliva.Location = New System.Drawing.Point(12, 79)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(24, 13)
        Me.lbliva.TabIndex = 9
        Me.lbliva.Text = "iva"
        '
        'ntbrenta
        '
        Me.TryDataBinding(ntbrenta, New System.Windows.Forms.Binding("Value", Me, "renta", True))
        Me.ntbrenta.DisabledBackColor = System.Drawing.Color.White
        Me.ntbrenta.Location = New System.Drawing.Point(111, 48)
        Me.ntbrenta.Name = "ntbrenta"
        Me.ntbrenta.Size = New System.Drawing.Size(121, 21)
        Me.ntbrenta.TabIndex = 6
        '
        'lblrenta
        '
        Me.lblrenta.Location = New System.Drawing.Point(12, 52)
        Me.lblrenta.Name = "lblrenta"
        Me.lblrenta.Size = New System.Drawing.Size(37, 13)
        Me.lblrenta.TabIndex = 7
        Me.lblrenta.Text = "renta"
        '
        'chbpiso
        '
        Me.TryDataBinding(chbpiso, New System.Windows.Forms.Binding("BindableValue", Me, "piso", True))
        Me.chbpiso.Location = New System.Drawing.Point(574, 25)
        Me.chbpiso.Name = "chbpiso"
        Me.chbpiso.Size = New System.Drawing.Size(15, 15)
        Me.chbpiso.TabIndex = 4
        '
        'lblpiso
        '
        Me.lblpiso.Location = New System.Drawing.Point(501, 25)
        Me.lblpiso.Name = "lblpiso"
        Me.lblpiso.Size = New System.Drawing.Size(30, 13)
        Me.lblpiso.TabIndex = 5
        Me.lblpiso.Text = "piso"
        '
        'ntbluz
        '
        Me.TryDataBinding(ntbluz, New System.Windows.Forms.Binding("Value", Me, "luz", True))
        Me.ntbluz.DisabledBackColor = System.Drawing.Color.White
        Me.ntbluz.Location = New System.Drawing.Point(348, 21)
        Me.ntbluz.Name = "ntbluz"
        Me.ntbluz.Size = New System.Drawing.Size(121, 21)
        Me.ntbluz.TabIndex = 2
        '
        'lblluz
        '
        Me.lblluz.Location = New System.Drawing.Point(268, 25)
        Me.lblluz.Name = "lblluz"
        Me.lblluz.Size = New System.Drawing.Size(23, 13)
        Me.lblluz.TabIndex = 3
        Me.lblluz.Text = "luz"
        '
        'ntbfianza
        '
        Me.TryDataBinding(ntbfianza, New System.Windows.Forms.Binding("Value", Me, "fianza", True))
        Me.ntbfianza.DisabledBackColor = System.Drawing.Color.White
        Me.ntbfianza.Location = New System.Drawing.Point(111, 21)
        Me.ntbfianza.Name = "ntbfianza"
        Me.ntbfianza.Size = New System.Drawing.Size(121, 21)
        Me.ntbfianza.TabIndex = 0
        '
        'lblfianza
        '
        Me.lblfianza.Location = New System.Drawing.Point(12, 25)
        Me.lblfianza.Name = "lblfianza"
        Me.lblfianza.Size = New System.Drawing.Size(41, 13)
        Me.lblfianza.TabIndex = 1
        Me.lblfianza.Text = "fianza"
        '
        'PicCabecera
        '
        Me.PicCabecera.Controls.Add(Me.AdvIDCNAE)
        Me.PicCabecera.Controls.Add(Me.lblCNAE)
        Me.PicCabecera.Controls.Add(Me.ChkActivo)
        Me.PicCabecera.Controls.Add(Me.lblMovil)
        Me.PicCabecera.Controls.Add(Me.txtMovil)
        Me.PicCabecera.Controls.Add(Me.lblTelefono2)
        Me.PicCabecera.Controls.Add(Me.txtTelefono2)
        Me.PicCabecera.Controls.Add(Me.TxtPoblacion)
        Me.PicCabecera.Controls.Add(Me.fwiCodigoPostal)
        Me.PicCabecera.Controls.Add(Me.CmbTipoDocIdent)
        Me.PicCabecera.Controls.Add(Me.LblTipoDocIdent)
        Me.PicCabecera.Controls.Add(Me.TxtNIFRepresen)
        Me.PicCabecera.Controls.Add(Me.LblNIFRepresen)
        Me.PicCabecera.Controls.Add(Me.TxtRefCliente)
        Me.PicCabecera.Controls.Add(Me.LblRefCliente)
        Me.PicCabecera.Controls.Add(Me.lblIDEmpresa)
        Me.PicCabecera.Controls.Add(Me.txtIDEmpresa)
        Me.PicCabecera.Controls.Add(Me.ulDescIdioma)
        Me.PicCabecera.Controls.Add(Me.AdvIDIdioma)
        Me.PicCabecera.Controls.Add(Me.LblfwiIDioma)
        Me.PicCabecera.Controls.Add(Me.lblFwiWeb)
        Me.PicCabecera.Controls.Add(Me.FwiWeb)
        Me.PicCabecera.Controls.Add(Me.fwiRazonSocial)
        Me.PicCabecera.Controls.Add(Me.fwiFechaAlta)
        Me.PicCabecera.Controls.Add(Me.ulDescTipoProveedor)
        Me.PicCabecera.Controls.Add(Me.AdvIDTipoProveedor)
        Me.PicCabecera.Controls.Add(Me.lblfwiIdMercado)
        Me.PicCabecera.Controls.Add(Me.ulDescMercado)
        Me.PicCabecera.Controls.Add(Me.AdvIDMercado)
        Me.PicCabecera.Controls.Add(Me.lblfwiIdPais)
        Me.PicCabecera.Controls.Add(Me.AdvIDPais)
        Me.PicCabecera.Controls.Add(Me.lblfwiFax)
        Me.PicCabecera.Controls.Add(Me.fwiFax)
        Me.PicCabecera.Controls.Add(Me.lblfwiTelefono)
        Me.PicCabecera.Controls.Add(Me.fwiTelefono)
        Me.PicCabecera.Controls.Add(Me.lblfwiProvincia)
        Me.PicCabecera.Controls.Add(Me.fwiProvincia)
        Me.PicCabecera.Controls.Add(Me.lblfwiRazonSocial)
        Me.PicCabecera.Controls.Add(Me.lblfwiCifProveedor)
        Me.PicCabecera.Controls.Add(Me.fwiCifProveedor)
        Me.PicCabecera.Controls.Add(Me.lblfwiPoblacion)
        Me.PicCabecera.Controls.Add(Me.lblfwiCodigoPostal)
        Me.PicCabecera.Controls.Add(Me.fwiDescProveedor)
        Me.PicCabecera.Controls.Add(Me.lblProveedor)
        Me.PicCabecera.Controls.Add(Me.txtIDProveedor)
        Me.PicCabecera.Controls.Add(Me.lblfwiDireccion)
        Me.PicCabecera.Controls.Add(Me.fwiDireccion)
        Me.PicCabecera.Controls.Add(Me.lblfwiIdZona)
        Me.PicCabecera.Controls.Add(Me.ulDescZona)
        Me.PicCabecera.Controls.Add(Me.AdvIDZona)
        Me.PicCabecera.Controls.Add(Me.lblfwiFechaAlta)
        Me.PicCabecera.Controls.Add(Me.lblfwiEMail)
        Me.PicCabecera.Controls.Add(Me.fwiEMail)
        Me.PicCabecera.Controls.Add(Me.lblFwiIDTipoClasif)
        Me.PicCabecera.Controls.Add(Me.ulDescTipoClasif)
        Me.PicCabecera.Controls.Add(Me.AdvIDTipoClasif)
        Me.PicCabecera.Controls.Add(Me.lblfwiTipoProveedor)
        Me.PicCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PicCabecera.Name = "PicCabecera"
        Me.PicCabecera.Size = New System.Drawing.Size(715, 252)
        Me.PicCabecera.TabIndex = 1
        '
        'AdvIDCNAE
        '
        Me.TryDataBinding(AdvIDCNAE, New System.Windows.Forms.Binding("Text", Me, "IDCNAE", True))
        Me.AdvIDCNAE.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCNAE.EntityName = "CNAE"
        Me.AdvIDCNAE.Location = New System.Drawing.Point(613, 147)
        Me.AdvIDCNAE.Name = "AdvIDCNAE"
        Me.AdvIDCNAE.PrimaryDataFields = "IDCNAE"
        Me.AdvIDCNAE.SecondaryDataFields = "IDCNAE"
        Me.AdvIDCNAE.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDCNAE.TabIndex = 58
        '
        'lblCNAE
        '
        Me.lblCNAE.Location = New System.Drawing.Point(559, 152)
        Me.lblCNAE.Name = "lblCNAE"
        Me.lblCNAE.Size = New System.Drawing.Size(55, 13)
        Me.lblCNAE.TabIndex = 60
        Me.lblCNAE.Text = "C.N.A.E."
        '
        'ChkActivo
        '
        Me.ChkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TryDataBinding(ChkActivo, New System.Windows.Forms.Binding("BindableValue", Me, "Activo", True))
        Me.ChkActivo.Location = New System.Drawing.Point(559, 25)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(68, 23)
        Me.ChkActivo.TabIndex = 4
        Me.ChkActivo.Text = "Activo"
        '
        'lblMovil
        '
        Me.lblMovil.Location = New System.Drawing.Point(171, 154)
        Me.lblMovil.Name = "lblMovil"
        Me.lblMovil.Size = New System.Drawing.Size(36, 13)
        Me.lblMovil.TabIndex = 57
        Me.lblMovil.Tag = ""
        Me.lblMovil.Text = "Móvil"
        '
        'txtMovil
        '
        Me.TryDataBinding(txtMovil, New System.Windows.Forms.Binding("Text", Me, "Movil", True))
        Me.txtMovil.DisabledBackColor = System.Drawing.Color.White
        Me.txtMovil.Location = New System.Drawing.Point(203, 150)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(93, 21)
        Me.txtMovil.TabIndex = 15
        '
        'lblTelefono2
        '
        Me.lblTelefono2.Location = New System.Drawing.Point(7, 154)
        Me.lblTelefono2.Name = "lblTelefono2"
        Me.lblTelefono2.Size = New System.Drawing.Size(66, 13)
        Me.lblTelefono2.TabIndex = 55
        Me.lblTelefono2.Tag = ""
        Me.lblTelefono2.Text = "Teléfono 2"
        '
        'txtTelefono2
        '
        Me.TryDataBinding(txtTelefono2, New System.Windows.Forms.Binding("Text", Me, "Telefono2", True))
        Me.txtTelefono2.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono2.Location = New System.Drawing.Point(85, 150)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(86, 21)
        Me.txtTelefono2.TabIndex = 14
        '
        'TxtPoblacion
        '
        Me.TxtPoblacion.ButtonImageIndex = 1
        Me.TxtPoblacion.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TryDataBinding(TxtPoblacion, New System.Windows.Forms.Binding("Text", Me, "Poblacion", True))
        Me.TxtPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.TxtPoblacion.ImageList = Me.ImageList1
        Me.TxtPoblacion.Location = New System.Drawing.Point(85, 99)
        Me.TxtPoblacion.Name = "TxtPoblacion"
        Me.TxtPoblacion.Size = New System.Drawing.Size(211, 24)
        Me.TxtPoblacion.TabIndex = 9
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "find_again.ico")
        '
        'fwiCodigoPostal
        '
        Me.TryDataBinding(fwiCodigoPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostal", True))
        Me.fwiCodigoPostal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCodigoPostal.Location = New System.Drawing.Point(612, 51)
        Me.fwiCodigoPostal.Name = "fwiCodigoPostal"
        Me.fwiCodigoPostal.Size = New System.Drawing.Size(97, 21)
        Me.fwiCodigoPostal.TabIndex = 7
        '
        'CmbTipoDocIdent
        '
        Me.CmbTipoDocIdent.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(CmbTipoDocIdent, New System.Windows.Forms.Binding("Value", Me, "TipoDocIdentidad", True))
        CmbTipoDocIdent_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoDocIdent_DesignTimeLayout.LayoutString")
        Me.CmbTipoDocIdent.DesignTimeLayout = CmbTipoDocIdent_DesignTimeLayout
        Me.CmbTipoDocIdent.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoDocIdent.DisplayMember = "Text"
        Me.CmbTipoDocIdent.Location = New System.Drawing.Point(85, 51)
        Me.CmbTipoDocIdent.Name = "CmbTipoDocIdent"
        Me.CmbTipoDocIdent.SelectedIndex = -1
        Me.CmbTipoDocIdent.SelectedItem = Nothing
        Me.CmbTipoDocIdent.Size = New System.Drawing.Size(160, 21)
        Me.CmbTipoDocIdent.TabIndex = 4
        Me.CmbTipoDocIdent.ValueMember = "Value"
        '
        'LblTipoDocIdent
        '
        Me.LblTipoDocIdent.Location = New System.Drawing.Point(7, 55)
        Me.LblTipoDocIdent.Name = "LblTipoDocIdent"
        Me.LblTipoDocIdent.Size = New System.Drawing.Size(81, 13)
        Me.LblTipoDocIdent.TabIndex = 53
        Me.LblTipoDocIdent.Text = "Tipo Doc. Id."
        '
        'TxtNIFRepresen
        '
        Me.TryDataBinding(TxtNIFRepresen, New System.Windows.Forms.Binding("Text", Me, "NIFRepresentanteLegal", True))
        Me.TxtNIFRepresen.DisabledBackColor = System.Drawing.Color.White
        Me.TxtNIFRepresen.Location = New System.Drawing.Point(587, 225)
        Me.TxtNIFRepresen.Name = "TxtNIFRepresen"
        Me.TxtNIFRepresen.Size = New System.Drawing.Size(125, 21)
        Me.TxtNIFRepresen.TabIndex = 24
        '
        'LblNIFRepresen
        '
        Me.LblNIFRepresen.Location = New System.Drawing.Point(462, 229)
        Me.LblNIFRepresen.Name = "LblNIFRepresen"
        Me.LblNIFRepresen.Size = New System.Drawing.Size(122, 13)
        Me.LblNIFRepresen.TabIndex = 51
        Me.LblNIFRepresen.Text = "NIF Represen. Legal"
        '
        'TxtRefCliente
        '
        Me.TryDataBinding(TxtRefCliente, New System.Windows.Forms.Binding("Text", Me, "ReferenciaCliente", True))
        Me.TxtRefCliente.DisabledBackColor = System.Drawing.Color.White
        Me.TxtRefCliente.Location = New System.Drawing.Point(85, 226)
        Me.TxtRefCliente.MaxLength = 25
        Me.TxtRefCliente.Name = "TxtRefCliente"
        Me.TxtRefCliente.Size = New System.Drawing.Size(211, 21)
        Me.TxtRefCliente.TabIndex = 22
        '
        'LblRefCliente
        '
        Me.LblRefCliente.Location = New System.Drawing.Point(7, 230)
        Me.LblRefCliente.Name = "LblRefCliente"
        Me.LblRefCliente.Size = New System.Drawing.Size(73, 13)
        Me.LblRefCliente.TabIndex = 49
        Me.LblRefCliente.Text = "Ref. Cliente"
        Me.LblRefCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIDEmpresa
        '
        Me.lblIDEmpresa.Location = New System.Drawing.Point(302, 229)
        Me.lblIDEmpresa.Name = "lblIDEmpresa"
        Me.lblIDEmpresa.Size = New System.Drawing.Size(57, 13)
        Me.lblIDEmpresa.TabIndex = 46
        Me.lblIDEmpresa.Tag = "IdRec=55249;"
        Me.lblIDEmpresa.Text = "Empresa"
        '
        'txtIDEmpresa
        '
        Me.TryDataBinding(txtIDEmpresa, New System.Windows.Forms.Binding("Text", Me, "IDEmpresa", True))
        Me.txtIDEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDEmpresa.Enabled = False
        Me.txtIDEmpresa.Location = New System.Drawing.Point(364, 225)
        Me.txtIDEmpresa.MaxLength = 25
        Me.txtIDEmpresa.Name = "txtIDEmpresa"
        Me.txtIDEmpresa.Size = New System.Drawing.Size(96, 21)
        Me.txtIDEmpresa.TabIndex = 23
        '
        'ulDescIdioma
        '
        Me.TryDataBinding(ulDescIdioma, New System.Windows.Forms.Binding("Text", Me.AdvIDIdioma, "DescIdioma", True))
        Me.ulDescIdioma.Location = New System.Drawing.Point(424, 149)
        Me.ulDescIdioma.Name = "ulDescIdioma"
        Me.ulDescIdioma.Size = New System.Drawing.Size(120, 21)
        Me.ulDescIdioma.TabIndex = 43
        '
        'AdvIDIdioma
        '
        Me.TryDataBinding(AdvIDIdioma, New System.Windows.Forms.Binding("Text", Me, "IDIdioma", True))
        Me.AdvIDIdioma.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDIdioma.EntityName = "Idioma"
        Me.AdvIDIdioma.Location = New System.Drawing.Point(364, 147)
        Me.AdvIDIdioma.Name = "AdvIDIdioma"
        Me.AdvIDIdioma.PrimaryDataFields = "IDIdioma"
        Me.AdvIDIdioma.SecondaryDataFields = "IDIdioma"
        Me.AdvIDIdioma.Size = New System.Drawing.Size(56, 23)
        Me.AdvIDIdioma.TabIndex = 17
        Me.AdvIDIdioma.ViewName = "tbMaestroIdioma"
        '
        'LblfwiIDioma
        '
        Me.LblfwiIDioma.Location = New System.Drawing.Point(302, 152)
        Me.LblfwiIDioma.Name = "LblfwiIDioma"
        Me.LblfwiIDioma.Size = New System.Drawing.Size(47, 13)
        Me.LblfwiIDioma.TabIndex = 44
        Me.LblfwiIDioma.Text = "Idioma"
        '
        'lblFwiWeb
        '
        Me.lblFwiWeb.Location = New System.Drawing.Point(559, 99)
        Me.lblFwiWeb.Name = "lblFwiWeb"
        Me.lblFwiWeb.Size = New System.Drawing.Size(31, 13)
        Me.lblFwiWeb.TabIndex = 41
        Me.lblFwiWeb.Text = "Web"
        '
        'FwiWeb
        '
        Me.TryDataBinding(FwiWeb, New System.Windows.Forms.Binding("Text", Me, "Web", True))
        Me.FwiWeb.DisabledBackColor = System.Drawing.Color.White
        Me.FwiWeb.Location = New System.Drawing.Point(613, 99)
        Me.FwiWeb.Name = "FwiWeb"
        Me.FwiWeb.Size = New System.Drawing.Size(96, 21)
        Me.FwiWeb.TabIndex = 11
        '
        'fwiRazonSocial
        '
        Me.TryDataBinding(fwiRazonSocial, New System.Windows.Forms.Binding("Text", Me, "RazonSocial", True))
        Me.fwiRazonSocial.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRazonSocial.Location = New System.Drawing.Point(85, 27)
        Me.fwiRazonSocial.Name = "fwiRazonSocial"
        Me.fwiRazonSocial.Size = New System.Drawing.Size(468, 21)
        Me.fwiRazonSocial.TabIndex = 3
        '
        'fwiFechaAlta
        '
        Me.TryDataBinding(fwiFechaAlta, New System.Windows.Forms.Binding("BindableValue", Me, "FechaAlta", True))
        Me.fwiFechaAlta.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaAlta.Location = New System.Drawing.Point(612, 3)
        Me.fwiFechaAlta.Name = "fwiFechaAlta"
        Me.fwiFechaAlta.Size = New System.Drawing.Size(96, 21)
        Me.fwiFechaAlta.TabIndex = 2
        '
        'ulDescTipoProveedor
        '
        Me.TryDataBinding(ulDescTipoProveedor, New System.Windows.Forms.Binding("Text", Me.AdvIDTipoProveedor, "DescTipoProveedor", True))
        Me.ulDescTipoProveedor.Location = New System.Drawing.Point(422, 200)
        Me.ulDescTipoProveedor.Name = "ulDescTipoProveedor"
        Me.ulDescTipoProveedor.Size = New System.Drawing.Size(287, 21)
        Me.ulDescTipoProveedor.TabIndex = 1
        '
        'AdvIDTipoProveedor
        '
        Me.TryDataBinding(AdvIDTipoProveedor, New System.Windows.Forms.Binding("Text", Me, "IDTipoProveedor", True))
        Me.AdvIDTipoProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoProveedor.EntityName = "TipoProveedor"
        Me.AdvIDTipoProveedor.Location = New System.Drawing.Point(364, 199)
        Me.AdvIDTipoProveedor.Name = "AdvIDTipoProveedor"
        Me.AdvIDTipoProveedor.PrimaryDataFields = "IDTipoProveedor"
        Me.AdvIDTipoProveedor.SecondaryDataFields = "IDTipoProveedor"
        Me.AdvIDTipoProveedor.Size = New System.Drawing.Size(56, 23)
        Me.AdvIDTipoProveedor.TabIndex = 21
        Me.AdvIDTipoProveedor.ViewName = "tbMaestroTipoProveedor"
        '
        'lblfwiIdMercado
        '
        Me.lblfwiIdMercado.Location = New System.Drawing.Point(302, 178)
        Me.lblfwiIdMercado.Name = "lblfwiIdMercado"
        Me.lblfwiIdMercado.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiIdMercado.TabIndex = 18
        Me.lblfwiIdMercado.Tag = "IdRec=4671;"
        Me.lblfwiIdMercado.Text = "Mercado"
        '
        'ulDescMercado
        '
        Me.TryDataBinding(ulDescMercado, New System.Windows.Forms.Binding("Text", Me.AdvIDMercado, "DescMercado", True))
        Me.ulDescMercado.Location = New System.Drawing.Point(422, 174)
        Me.ulDescMercado.Name = "ulDescMercado"
        Me.ulDescMercado.Size = New System.Drawing.Size(286, 21)
        Me.ulDescMercado.TabIndex = 19
        '
        'AdvIDMercado
        '
        Me.TryDataBinding(AdvIDMercado, New System.Windows.Forms.Binding("Text", Me, "IDMercado", True))
        Me.AdvIDMercado.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDMercado.EntityName = "Mercado"
        Me.AdvIDMercado.Location = New System.Drawing.Point(364, 173)
        Me.AdvIDMercado.Name = "AdvIDMercado"
        Me.AdvIDMercado.PrimaryDataFields = "IDMercado"
        Me.AdvIDMercado.SecondaryDataFields = "IDMercado"
        Me.AdvIDMercado.Size = New System.Drawing.Size(56, 23)
        Me.AdvIDMercado.TabIndex = 19
        Me.AdvIDMercado.ViewName = "tbMaestroMercado"
        '
        'lblfwiIdPais
        '
        Me.lblfwiIdPais.Location = New System.Drawing.Point(437, 55)
        Me.lblfwiIdPais.Name = "lblfwiIdPais"
        Me.lblfwiIdPais.Size = New System.Drawing.Size(30, 13)
        Me.lblfwiIdPais.TabIndex = 20
        Me.lblfwiIdPais.Tag = "IdRec=4627;"
        Me.lblfwiIdPais.Text = "País"
        '
        'AdvIDPais
        '
        Me.TryDataBinding(AdvIDPais, New System.Windows.Forms.Binding("Text", Me, "IDPais", True))
        Me.AdvIDPais.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDPais.EntityName = "Pais"
        Me.AdvIDPais.Location = New System.Drawing.Point(471, 50)
        Me.AdvIDPais.Name = "AdvIDPais"
        Me.AdvIDPais.PrimaryDataFields = "IDPais"
        Me.AdvIDPais.SecondaryDataFields = "IDPais"
        Me.AdvIDPais.Size = New System.Drawing.Size(82, 23)
        Me.AdvIDPais.TabIndex = 6
        Me.AdvIDPais.ViewName = "tbMaestroPais"
        '
        'lblfwiFax
        '
        Me.lblfwiFax.Location = New System.Drawing.Point(171, 130)
        Me.lblfwiFax.Name = "lblfwiFax"
        Me.lblfwiFax.Size = New System.Drawing.Size(26, 13)
        Me.lblfwiFax.TabIndex = 22
        Me.lblfwiFax.Tag = "IdRec=4415;"
        Me.lblfwiFax.Text = "Fax"
        '
        'fwiFax
        '
        Me.TryDataBinding(fwiFax, New System.Windows.Forms.Binding("Text", Me, "Fax", True))
        Me.fwiFax.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFax.Location = New System.Drawing.Point(203, 126)
        Me.fwiFax.Name = "fwiFax"
        Me.fwiFax.Size = New System.Drawing.Size(93, 21)
        Me.fwiFax.TabIndex = 13
        '
        'lblfwiTelefono
        '
        Me.lblfwiTelefono.Location = New System.Drawing.Point(7, 130)
        Me.lblfwiTelefono.Name = "lblfwiTelefono"
        Me.lblfwiTelefono.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiTelefono.TabIndex = 23
        Me.lblfwiTelefono.Tag = "IdRec=4411;"
        Me.lblfwiTelefono.Text = "Teléfono"
        '
        'fwiTelefono
        '
        Me.TryDataBinding(fwiTelefono, New System.Windows.Forms.Binding("Text", Me, "Telefono", True))
        Me.fwiTelefono.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTelefono.Location = New System.Drawing.Point(85, 126)
        Me.fwiTelefono.Name = "fwiTelefono"
        Me.fwiTelefono.Size = New System.Drawing.Size(86, 21)
        Me.fwiTelefono.TabIndex = 12
        '
        'lblfwiProvincia
        '
        Me.lblfwiProvincia.Location = New System.Drawing.Point(302, 104)
        Me.lblfwiProvincia.Name = "lblfwiProvincia"
        Me.lblfwiProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblfwiProvincia.TabIndex = 24
        Me.lblfwiProvincia.Tag = "IdRec=4412;"
        Me.lblfwiProvincia.Text = "Provincia"
        '
        'fwiProvincia
        '
        Me.TryDataBinding(fwiProvincia, New System.Windows.Forms.Binding("Text", Me, "Provincia", True))
        Me.fwiProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiProvincia.Location = New System.Drawing.Point(364, 99)
        Me.fwiProvincia.Name = "fwiProvincia"
        Me.fwiProvincia.Size = New System.Drawing.Size(146, 21)
        Me.fwiProvincia.TabIndex = 10
        '
        'lblfwiRazonSocial
        '
        Me.lblfwiRazonSocial.Location = New System.Drawing.Point(7, 31)
        Me.lblfwiRazonSocial.Name = "lblfwiRazonSocial"
        Me.lblfwiRazonSocial.Size = New System.Drawing.Size(80, 13)
        Me.lblfwiRazonSocial.TabIndex = 25
        Me.lblfwiRazonSocial.Tag = "IdRec=4426;"
        Me.lblfwiRazonSocial.Text = "Razón Social"
        '
        'lblfwiCifProveedor
        '
        Me.lblfwiCifProveedor.Location = New System.Drawing.Point(251, 55)
        Me.lblfwiCifProveedor.Name = "lblfwiCifProveedor"
        Me.lblfwiCifProveedor.Size = New System.Drawing.Size(72, 13)
        Me.lblfwiCifProveedor.TabIndex = 26
        Me.lblfwiCifProveedor.Tag = "IdRec=4425;"
        Me.lblfwiCifProveedor.Text = "Documento"
        '
        'fwiCifProveedor
        '
        Me.TryDataBinding(fwiCifProveedor, New System.Windows.Forms.Binding("Text", Me, "CifProveedor", True))
        Me.fwiCifProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCifProveedor.Location = New System.Drawing.Point(324, 51)
        Me.fwiCifProveedor.Name = "fwiCifProveedor"
        Me.fwiCifProveedor.Size = New System.Drawing.Size(100, 21)
        Me.fwiCifProveedor.TabIndex = 5
        '
        'lblfwiPoblacion
        '
        Me.lblfwiPoblacion.Location = New System.Drawing.Point(7, 104)
        Me.lblfwiPoblacion.Name = "lblfwiPoblacion"
        Me.lblfwiPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiPoblacion.TabIndex = 27
        Me.lblfwiPoblacion.Tag = "IdRec=4413;"
        Me.lblfwiPoblacion.Text = "Población"
        '
        'lblfwiCodigoPostal
        '
        Me.lblfwiCodigoPostal.Location = New System.Drawing.Point(559, 55)
        Me.lblfwiCodigoPostal.Name = "lblfwiCodigoPostal"
        Me.lblfwiCodigoPostal.Size = New System.Drawing.Size(29, 13)
        Me.lblfwiCodigoPostal.TabIndex = 28
        Me.lblfwiCodigoPostal.Tag = "IdRec=4414;"
        Me.lblfwiCodigoPostal.Text = "C.P."
        '
        'fwiDescProveedor
        '
        Me.TryDataBinding(fwiDescProveedor, New System.Windows.Forms.Binding("Text", Me, "DescProveedor", True))
        Me.fwiDescProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescProveedor.Location = New System.Drawing.Point(208, 3)
        Me.fwiDescProveedor.Name = "fwiDescProveedor"
        Me.fwiDescProveedor.Size = New System.Drawing.Size(345, 21)
        Me.fwiDescProveedor.TabIndex = 1
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(7, 8)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblProveedor.TabIndex = 29
        Me.lblProveedor.Tag = "IdRec=4352;"
        Me.lblProveedor.Text = "Proveedor"
        '
        'txtIDProveedor
        '
        Me.TryDataBinding(txtIDProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.txtIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDProveedor.Enabled = False
        Me.txtIDProveedor.Location = New System.Drawing.Point(85, 2)
        Me.txtIDProveedor.Name = "txtIDProveedor"
        Me.txtIDProveedor.Size = New System.Drawing.Size(116, 23)
        Me.txtIDProveedor.TabIndex = 0
        '
        'lblfwiDireccion
        '
        Me.lblfwiDireccion.Location = New System.Drawing.Point(7, 79)
        Me.lblfwiDireccion.Name = "lblfwiDireccion"
        Me.lblfwiDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiDireccion.TabIndex = 30
        Me.lblfwiDireccion.Tag = "IdRec=4410;"
        Me.lblfwiDireccion.Text = "Dirección"
        '
        'fwiDireccion
        '
        Me.TryDataBinding(fwiDireccion, New System.Windows.Forms.Binding("Text", Me, "Direccion", True))
        Me.fwiDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDireccion.Location = New System.Drawing.Point(85, 75)
        Me.fwiDireccion.Name = "fwiDireccion"
        Me.fwiDireccion.Size = New System.Drawing.Size(624, 21)
        Me.fwiDireccion.TabIndex = 8
        '
        'lblfwiIdZona
        '
        Me.lblfwiIdZona.Location = New System.Drawing.Point(7, 179)
        Me.lblfwiIdZona.Name = "lblfwiIdZona"
        Me.lblfwiIdZona.Size = New System.Drawing.Size(36, 13)
        Me.lblfwiIdZona.TabIndex = 31
        Me.lblfwiIdZona.Tag = "IdRec=4707;"
        Me.lblfwiIdZona.Text = "Zona"
        '
        'ulDescZona
        '
        Me.TryDataBinding(ulDescZona, New System.Windows.Forms.Binding("Text", Me.AdvIDZona, "DescZona", True))
        Me.ulDescZona.Location = New System.Drawing.Point(154, 176)
        Me.ulDescZona.Name = "ulDescZona"
        Me.ulDescZona.Size = New System.Drawing.Size(142, 21)
        Me.ulDescZona.TabIndex = 32
        '
        'AdvIDZona
        '
        Me.TryDataBinding(AdvIDZona, New System.Windows.Forms.Binding("Text", Me, "IDZona", True))
        Me.AdvIDZona.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDZona.EntityName = "Zona"
        Me.AdvIDZona.Location = New System.Drawing.Point(85, 174)
        Me.AdvIDZona.Name = "AdvIDZona"
        Me.AdvIDZona.PrimaryDataFields = "IDZona"
        Me.AdvIDZona.SecondaryDataFields = "IDZona"
        Me.AdvIDZona.Size = New System.Drawing.Size(67, 23)
        Me.AdvIDZona.TabIndex = 18
        Me.AdvIDZona.ViewName = "tbMaestroZona"
        '
        'lblfwiFechaAlta
        '
        Me.lblfwiFechaAlta.Location = New System.Drawing.Point(559, 7)
        Me.lblfwiFechaAlta.Name = "lblfwiFechaAlta"
        Me.lblfwiFechaAlta.Size = New System.Drawing.Size(66, 13)
        Me.lblfwiFechaAlta.TabIndex = 33
        Me.lblfwiFechaAlta.Tag = "IdRec=4457;"
        Me.lblfwiFechaAlta.Text = "Fecha Alta"
        '
        'lblfwiEMail
        '
        Me.lblfwiEMail.Location = New System.Drawing.Point(302, 127)
        Me.lblfwiEMail.Name = "lblfwiEMail"
        Me.lblfwiEMail.Size = New System.Drawing.Size(41, 13)
        Me.lblfwiEMail.TabIndex = 34
        Me.lblfwiEMail.Tag = "IdRec=4416;"
        Me.lblfwiEMail.Text = "E-Mail"
        '
        'fwiEMail
        '
        Me.TryDataBinding(fwiEMail, New System.Windows.Forms.Binding("Text", Me, "EMail", True))
        Me.fwiEMail.DisabledBackColor = System.Drawing.Color.White
        Me.fwiEMail.Location = New System.Drawing.Point(364, 123)
        Me.fwiEMail.Name = "fwiEMail"
        Me.fwiEMail.Size = New System.Drawing.Size(345, 21)
        Me.fwiEMail.TabIndex = 16
        '
        'lblFwiIDTipoClasif
        '
        Me.lblFwiIDTipoClasif.Location = New System.Drawing.Point(7, 205)
        Me.lblFwiIDTipoClasif.Name = "lblFwiIDTipoClasif"
        Me.lblFwiIDTipoClasif.Size = New System.Drawing.Size(70, 13)
        Me.lblFwiIDTipoClasif.TabIndex = 36
        Me.lblFwiIDTipoClasif.Text = "Tipo Clasif."
        '
        'ulDescTipoClasif
        '
        Me.TryDataBinding(ulDescTipoClasif, New System.Windows.Forms.Binding("Text", Me.AdvIDTipoClasif, "DescTipoClasif", True))
        Me.ulDescTipoClasif.Location = New System.Drawing.Point(154, 201)
        Me.ulDescTipoClasif.Name = "ulDescTipoClasif"
        Me.ulDescTipoClasif.Size = New System.Drawing.Size(142, 21)
        Me.ulDescTipoClasif.TabIndex = 37
        '
        'AdvIDTipoClasif
        '
        Me.TryDataBinding(AdvIDTipoClasif, New System.Windows.Forms.Binding("Text", Me, "IDTipoClasif", True))
        Me.AdvIDTipoClasif.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoClasif.EntityName = "TipoClasif"
        Me.AdvIDTipoClasif.Location = New System.Drawing.Point(85, 200)
        Me.AdvIDTipoClasif.Name = "AdvIDTipoClasif"
        Me.AdvIDTipoClasif.PrimaryDataFields = "IDTipoClasif"
        Me.AdvIDTipoClasif.SecondaryDataFields = "IDTipoClasif"
        Me.AdvIDTipoClasif.Size = New System.Drawing.Size(67, 23)
        Me.AdvIDTipoClasif.TabIndex = 20
        Me.AdvIDTipoClasif.ViewName = "tbMaestroTipoClasif"
        '
        'lblfwiTipoProveedor
        '
        Me.lblfwiTipoProveedor.Location = New System.Drawing.Point(302, 203)
        Me.lblfwiTipoProveedor.Name = "lblfwiTipoProveedor"
        Me.lblfwiTipoProveedor.Size = New System.Drawing.Size(64, 13)
        Me.lblfwiTipoProveedor.TabIndex = 0
        Me.lblfwiTipoProveedor.Text = "Tipo Prov."
        '
        'lblIDIdioma
        '
        Me.lblIDIdioma.Location = New System.Drawing.Point(299, 124)
        Me.lblIDIdioma.Name = "lblIDIdioma"
        Me.lblIDIdioma.Size = New System.Drawing.Size(61, 13)
        Me.lblIDIdioma.TabIndex = 2
        Me.lblIDIdioma.Text = "IDIdioma"
        '
        'Graphic
        '
        Me.Graphic.Icon = CType(resources.GetObject("Graphic.Icon"), System.Drawing.Icon)
        Me.Graphic.Key = "Graphic"
        Me.Graphic.Name = "Graphic"
        '
        'Separator4
        '
        Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator4.Key = "Separator"
        Me.Separator4.Name = "Separator4"
        '
        'Graphic1
        '
        Me.Graphic1.Key = "Graphic"
        Me.Graphic1.Name = "Graphic1"
        '
        'MntoProveedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(723, 615)
        Me.CreateTransaction = True
        Me.EntityName = "Proveedor"
        Me.Name = "MntoProveedores"
        Me.NavigationFields = "IDProveedor"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.txtIDProveedor})
        Me.ViewName = "frmMntoProveedores"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.TabProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabProveedores.ResumeLayout(False)
        Me.TabPagePicDatosEconomicos.ResumeLayout(False)
        Me.PnlAgrupCContables.ResumeLayout(False)
        Me.FrmAgrupaciones.ResumeLayout(False)
        Me.FrmAgrupaciones.PerformLayout()
        CType(Me.cbxAgrupAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxAgrupFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrmCuentas.ResumeLayout(False)
        Me.FrmCuentas.PerformLayout()
        Me.FrmCondicionesPago.ResumeLayout(False)
        Me.FrmCondicionesPago.PerformLayout()
        CType(Me.cbxIDCPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDFPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDDiaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDBancoPropio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDTipoIVA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage1.ResumeLayout(False)
        Me.FraDeclaraciones.ResumeLayout(False)
        Me.FrmFacturacion.ResumeLayout(False)
        Me.FrmFacturacion.PerformLayout()
        CType(Me.cbxTipoRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSerieAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDTipoAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxSerieCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicCContables.ResumeLayout(False)
        Me.TabPagePicCContables.PerformLayout()
        CType(Me.cbxEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicEnvio.ResumeLayout(False)
        Me.FraPorcentaje.ResumeLayout(False)
        Me.FraPorcentaje.PerformLayout()
        Me.FraAlmacen.ResumeLayout(False)
        Me.FraAlmacen.PerformLayout()
        Me.FraEnvio.ResumeLayout(False)
        Me.FraEnvio.PerformLayout()
        CType(Me.cbxIDModoTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDCEnvio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDFEnvio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicBancos.ResumeLayout(False)
        CType(Me.jngBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicArticulos.ResumeLayout(False)
        CType(Me.jngArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jngArtLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicDirecciones.ResumeLayout(False)
        CType(Me.jngDirecciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicFamilias.ResumeLayout(False)
        CType(Me.jngFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicVacaciones.ResumeLayout(False)
        CType(Me.jngVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMsgVacaciones.ResumeLayout(False)
        Me.PnlMsgVacaciones.PerformLayout()
        Me.TabPagePicObservaciones.ResumeLayout(False)
        Me.FrmObservaciones.ResumeLayout(False)
        Me.FrmObservaciones.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        CType(Me.jngObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicCalidad.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.cbxIDAuditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicGrupoProv.ResumeLayout(False)
        Me.TabPagePicGrupoProv.PerformLayout()
        Me.TabPagePagos.ResumeLayout(False)
        Me.TabPagePagos.PerformLayout()
        Me.PicCabecera.ResumeLayout(False)
        Me.PicCabecera.PerformLayout()
        CType(Me.CmbTipoDocIdent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected mstrIdEjercicio As String
    Protected mintDigitosAux As Integer
    Protected mblnModificado As Boolean
    Protected mblnGestionAlquileres As Boolean
    Protected WithEvents AdvPoblacion As New Engine.UI.AdvancedSearch

#Region " Load "

    Protected Overridable Sub MntoProveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadToolbarActions()
            LoadGridActions()
            LoadDataBases()
        End If
    End Sub

    Protected Overridable Sub LoadToolbarActions()
        Me.FormActions.Add("Personas de Contacto", AddressOf AccionPersonaContacto, ExpertisApp.GetIcon("xRepresentantes.ico"))
        'If mblnGestionAlquileres Then
        Me.AddSeparator()
        Me.FormActions.Add("Información Adicional", AddressOf AccionCargarInformacion, ExpertisApp.GetIcon("column-chart.ico"))
        'End If
    End Sub

    Protected Overridable Sub LoadGridActions()
        jngDirecciones.Actions.Add("Agregar dirección", AddressOf GetDatosDireccion)
        'TODO HISTREV
        jngArticulos.Actions.Add("Ver Artículo", AddressOf AccionAbrirArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        jngArticulos.AddSeparator()
        jngArticulos.Actions.Add("Ver/Modificar Histórico Precios", AddressOf AbrirHistoricoPrecios, ExpertisApp.GetIcon("index_new.ico"))
        jngArtLinea.Actions.Add("Ver/Modificar Histórico Precios", AddressOf AbrirHistoricoPreciosLinea, ExpertisApp.GetIcon("index_new.ico"))
    End Sub

    Protected Overridable Sub LoadERPData()
        Dim E As New EjercicioContable

        mstrIdEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, cnMinDate)

        If Len(mstrIdEjercicio) > 0 Then
            Dim dtEjercicio As DataTable = E.SelOnPrimaryKey(mstrIdEjercicio)
            If Not IsNothing(dtEjercicio) AndAlso dtEjercicio.Rows.Count > 0 Then
                mintDigitosAux = Nz(dtEjercicio.Rows(0)("DigitosAuxiliar"), 0)
                advCCProveedor.MaxLength = mintDigitosAux
                advCCEfectos.MaxLength = mintDigitosAux
                advCCRetencion.MaxLength = mintDigitosAux
                advCCAnticipo.MaxLength = mintDigitosAux
                advCCFianza.MaxLength = mintDigitosAux
                advCCFraPdte.MaxLength = mintDigitosAux
            End If
        End If

        Dim p As New Parametro
        mblnGestionAlquileres = p.AplicacionGestionAlquiler
        If p.ExpertisSAAS() Then
            TabPagePicCalidad.TabVisible = False
            TabPagePicCContables.TabVisible = False
            TabPagePicEnvio.TabVisible = False
            If Not p.Contabilidad Then FrmCuentas.Visible = False
        End If

        ' Cargamos el combo de entidades en el grid de Observaciones
        Dim oProvObservacion As New ProveedorObservacion
        Dim dt As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf ProveedorObservacion.ObtenerEntidades, New Object)
        'jngObservaciones.Columns("Entidad").DropDown.SetDataBinding(dt, String.Empty)
        Dim col As GridEX.GridEXColumn = jngObservaciones.Columns("Entidad")
        col.ValueList.PopulateValueList(dt.DefaultView, "Entidad", "Entidad")

        Dim f As New Filter
        f.Add(New StringFilterItem("Entidad", "FacturaCompraCabecera"))
        cbxSerieCargos.Filter = f
        cbxSerieAbonos.Filter = f

        Me.AdvPoblacion.EntityName = "Poblacion"
    End Sub

    Protected Overridable Sub LoadEnums()
        cbxIDTipoAsiento.DataSource = New EnumData("enumTipoAsiento")
        cbxAgrupAlbaran.DataSource = New EnumData("enummpAgrupAlbaran")
        cbxAgrupFactura.DataSource = New EnumData("enummpAgrupFactura")
        cbxTipoFacturacion.DataSource = New EnumData("enummcTipoFacturacion")
        cbxTipoRetencion.DataSource = EnumData.EnumView("TipoRetencionIRPF")
        EnumData.PopulateValueList("enumClaveGasto", jngBancos.Columns("ClaveGastos"))

        Me.CmbTipoDocIdent.DataSource = EnumData.EnumView("enumTipoDocIdent")
    End Sub

    Protected Overridable Sub LoadDataBases()
        Dim DtDatos As DataTable = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Proveedor.ObtenerXDataBase, New Object)
        cbxEmpresa.DropDownList.SetDataBinding(DtDatos, String.Empty)
    End Sub

#End Region

#Region " Toolbar Actions "

    Protected Overridable Sub AccionPersonaContacto()
        Dim frm As New frmPersonaContacto
        frm.AbrirPersonaContacto(txtIDProveedor.Text, Me)
    End Sub

    Protected Overridable Sub AccionCargarInformacion()
        If Length(txtIDProveedor.Text) > 0 Then
            Dim Frm As New FrmInformacionAlquiler
            If Frm.ShowDialog() = DialogResult.OK Then
                Dim HtParams As New Hashtable
                HtParams.Add("IDProveedor", txtIDProveedor.Text)
                ExpertisApp.OpenForm(Frm.Programa, , HtParams)
            End If
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Protected Overridable Sub GetDatosDireccion()

        With jngDirecciones
            .Row = Grid.newTopRowPosition
            .SetValue("RazonSocial", fwiRazonSocial.Text)
            .GetRow.Cells("RazonSocial").DataChanged = True

            .SetValue("Envio", True)
            .SetValue("Factura", True)
            .SetValue("Giro", True)

            .SetValue("Direccion", fwiDireccion.Text)
            .SetValue(("CodPostal"), fwiCodigoPostal.Text)
            .SetValue(("Poblacion"), TxtPoblacion.Text)
            .SetValue(("Provincia"), fwiProvincia.Text)
            .SetValue(("IdPais"), AdvIDPais.Text)
            .SetValue(("DescPais"), lblfwiIdPais.Text)
            .SetValue(("Telefono"), fwiTelefono.Text)
            .SetValue(("Fax"), fwiFax.Text)
            .SetValue(("Email"), fwiEMail.Text)

            If .RowCount = 0 Then
                .SetValue("PredeterminadaEnvio", True)
                .SetValue("PredeterminadaFactura", True)
                .SetValue("PredeterminadaGiro", True)
            End If

            .Columns("IDAlmacen").Visible = True
            .Columns("DescAlmacen").Visible = True
        End With
    End Sub

    Protected Overridable Sub AccionAbrirArticulo()
        If Length(Me.jngArticulos.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New FilterItem("IDArticulo", FilterOperator.Equal, Me.jngArticulos.GetValue("IDArticulo")))
        End If
    End Sub

    'TODO HISTREV
    Protected Overridable Sub AbrirHistoricoPrecios()
        Dim FrmHist As New FrmHistoricoPreciosClieProv
        FrmHist.Opcion = FrmHistoricoPreciosClieProv.Opt.PreciosProveedores
        FrmHist.Entity = New HistoricoPreciosProveedor
        FrmHist.IDEntity = Me.CurrentRow("IDProveedor")
        FrmHist.DescIdentity = Me.CurrentRow("DescProveedor")
        FrmHist.IDArticulo = jngArticulos.GetValue("IDArticulo")
        FrmHist.DescArticulo = jngArticulos.GetValue("DescArticulo")
        FrmHist.Precio = jngArticulos.GetValue("Precio")
        FrmHist.Dto1 = jngArticulos.GetValue("Dto1")
        FrmHist.Dto2 = jngArticulos.GetValue("Dto2")
        FrmHist.Dto3 = jngArticulos.GetValue("Dto3")
        FrmHist.ShowDialog()
    End Sub

    Protected Overridable Sub AbrirHistoricoPreciosLinea()
        Dim FrmHist As New FrmHistoricoPreciosClieProv
        FrmHist.Opcion = FrmHistoricoPreciosClieProv.Opt.PreciosProveedoresLineas
        FrmHist.Entity = New HistoricoPreciosProveedorQDesde
        FrmHist.IDEntity = Me.CurrentRow("IDProveedor")
        FrmHist.DescIdentity = Me.CurrentRow("DescProveedor")
        FrmHist.IDArticulo = jngArtLinea.GetValue("IDArticulo")
        FrmHist.DescArticulo = jngArticulos.GetValue("DescArticulo")
        FrmHist.Cantidad = jngArtLinea.GetValue("QDesde")
        FrmHist.Precio = jngArtLinea.GetValue("Precio")
        FrmHist.Dto1 = jngArtLinea.GetValue("Dto1")
        FrmHist.Dto2 = jngArtLinea.GetValue("Dto2")
        FrmHist.Dto3 = jngArtLinea.GetValue("Dto3")
        FrmHist.ShowDialog()
    End Sub

#End Region

    Protected Overridable Sub MntoProveedores_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        TabProveedores_Click(TabProveedores, New EventArgs)
        If e.Action = DataProviderActions.NewRecord Then
            jngDirecciones.AllowAddNew = GridEX.InheritableBoolean.False
            jngDirecciones.AllowEdit = GridEX.InheritableBoolean.False
            jngDirecciones.AllowDelete = GridEX.InheritableBoolean.False
        Else
            jngDirecciones.AllowAddNew = GridEX.InheritableBoolean.True
            jngDirecciones.AllowEdit = GridEX.InheritableBoolean.True
            jngDirecciones.AllowDelete = GridEX.InheritableBoolean.True
        End If
    End Sub

    Protected Overridable Sub MntoProveedores_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordUpdating
        'Verificar que haya una dirección y al menos una, predeterminada, por tipo de dirección
        If Me.RecordsState <> RecordsState.[New] Then
            Dim dtDirecciones As DataTable = jngDirecciones.DataSource
            If dtDirecciones Is Nothing Then
                ExpertisApp.GenerateMessage("Debe haber al menos una dirección predeterminada por cada tipo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            Dim dv As DataView = dtDirecciones.DefaultView
            dv.RowStateFilter = DataViewRowState.CurrentRows
            If dv Is Nothing OrElse dv.Count = 0 Then
                ExpertisApp.GenerateMessage("Debe haber al menos una dirección predeterminada por cada tipo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            Else
                Dim tienePredetEnvio As Boolean
                Dim tienePredetFactura As Boolean
                Dim tienePredetGiro As Boolean
                For Each drv As DataRowView In dv
                    If Not drv.Row.IsNull("PredeterminadaEnvio") AndAlso drv("PredeterminadaEnvio") Then
                        tienePredetEnvio = True
                    End If
                    If Not drv.Row.IsNull("PredeterminadaFactura") AndAlso drv("PredeterminadaFactura") Then
                        tienePredetFactura = True
                    End If
                    If Not drv.Row.IsNull("PredeterminadaGiro") AndAlso drv("PredeterminadaGiro") Then
                        tienePredetGiro = True
                    End If
                Next
                If Not tienePredetEnvio Then
                    ExpertisApp.GenerateMessage("Debe haber una dirección predeterminada de envío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                ElseIf Not tienePredetFactura Then
                    ExpertisApp.GenerateMessage("Debe haber una dirección predeterminada de factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                ElseIf Not tienePredetGiro Then
                    ExpertisApp.GenerateMessage("Debe haber una dirección predeterminada de giro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If
            If e.Cancel Then Exit Sub
            If Length(Me.CurrentRow("IDEmpresa")) > 0 And mblnModificado Then
                If ExpertisApp.GenerateMessage("Se han realizado cambios en la Dirección / Formas de Contacto de la Ficha del Proveedor. ¿Desea actualizar estos datos en la Ficha de la Empresa Relacionada.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim ActualizarDatos As New Empresa.infoActualizarDatos
                    ActualizarDatos.IDProveedor = Me.CurrentRow("IDProveedor")
                    ActualizarDatos.dt = Me.CurrentData
                    ActualizarDatos.EntidadActualizadora = Empresa.enumEntidadActualizadora.Proveedor
                    ExpertisApp.ExecuteTask(Of Empresa.infoActualizarDatos)(AddressOf Empresa.ActualizarDatosRelacionados, ActualizarDatos)
                End If
                mblnModificado = False
            End If
        End If

        If Not e.Cancel Then
            Dim CC As New AltaPlanContable
            If Length(advCCProveedor.Text) > 0 Then
                e.Cancel = Not CC.ValidaCuentaContable(advCCProveedor.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value)
            End If
            If Not e.Cancel AndAlso Length(advCCEfectos.Text) > 0 Then
                e.Cancel = Not CC.ValidaCuentaContable(advCCEfectos.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value)
            End If
            If Not e.Cancel AndAlso Length(advCCRetencion.Text) > 0 Then
                e.Cancel = Not CC.ValidaCuentaContable(advCCRetencion.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value)
            End If
            If Not e.Cancel AndAlso Length(advCCAnticipo.Text) > 0 Then
                e.Cancel = Not CC.ValidaCuentaContable(advCCAnticipo.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value)
            End If
            If Not e.Cancel AndAlso Length(advCCFianza.Text) > 0 Then
                e.Cancel = Not CC.ValidaCuentaContable(advCCFianza.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value)
            End If
            If Not e.Cancel AndAlso Length(advCCFraPdte.Text) > 0 Then
                e.Cancel = Not CC.ValidaCuentaContable(advCCFraPdte.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value)
            End If
        End If
    End Sub

    Protected Overridable Sub MntoProveedores_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated
        TabProveedores_Click(TabProveedores, New EventArgs)
    End Sub

    'protected overridable sub MntoProveedores_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles MyBase.BusinessCalled
    '    If Not IsNothing(e.Data) AndAlso e.Data.ContainsKey("CifCorrecto") Then
    '        fwiCifProveedor.Text = e.Data("CifCorrecto")
    '    End If
    'End Sub

#Region " Direcciones "
    Protected Overridable Sub jngDirecciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngDirecciones.SelectionChanged
        If Not jngDirecciones.GetValue("Envio") Is System.DBNull.Value AndAlso _
            jngDirecciones.GetValue("Envio") = True Then
            ActivaDesactivaButtonsDireccion(True)
        Else
            ActivaDesactivaButtonsDireccion(False)
        End If
    End Sub
    Protected Overridable Sub jngDirecciones_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngDirecciones.EditingCell
        Try
            Select Case e.Column.Key
                Case "Envio"
                    If e.Value Is System.DBNull.Value OrElse e.Value = False Then
                        ActivaDesactivaButtonsDireccion(True)
                    End If

                Case "PredeterminadaEnvio"
                    If jngDirecciones.GetValue("Envio") Is System.DBNull.Value OrElse _
                        jngDirecciones.GetValue("Envio") = False Then
                        e.Cancel = True
                    End If

                Case "PredeterminadaFactura"
                    If jngDirecciones.GetValue("Factura") Is System.DBNull.Value OrElse _
                        jngDirecciones.GetValue("Factura") = False Then
                        e.Cancel = True
                    End If

                Case "PredeterminadaGiro"
                    If jngDirecciones.GetValue("Giro") Is System.DBNull.Value OrElse _
                        jngDirecciones.GetValue("Giro") = False Then
                        e.Cancel = True
                    End If

                Case "IDAlmacen"
                    If jngDirecciones.GetValue("Envio") Is System.DBNull.Value OrElse _
                        jngDirecciones.GetValue("Envio") = False Then
                        e.Cancel = True
                    End If
                    If e.Cancel Then
                        e.Column.ButtonStyle = GridEX.ButtonStyle.NoButton
                    Else
                        e.Column.ButtonStyle = GridEX.ButtonStyle.Image
                    End If

                Case "IDCAE"
                    If jngDirecciones.GetValue("Envio") Is System.DBNull.Value OrElse _
                        jngDirecciones.GetValue("Envio") = False Then
                        e.Cancel = True
                    End If

            End Select
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'protected overridable sub jngDirecciones_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngDirecciones.UpdatingCell
    '    If e.Column.Key = "Envio" Then
    '        ActivaDesactivaButtonsDireccion(e.Value)
    '    End If
    'End Sub
    Protected Overridable Sub ActivaDesactivaButtonsDireccion(ByVal esEnvio As Boolean)
        'Dirección Envio
        jngDirecciones.Columns("IDAlmacen").Visible = esEnvio
        jngDirecciones.Columns("DescAlmacen").Visible = esEnvio
    End Sub
    Protected Overridable Sub jngDirecciones_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngDirecciones.GotFocus
        If Me.RecordsState = Engine.UI.RecordsState.New AndAlso Length(Me.CurrentRow("IDContador")) > 0 Then Me.UpdateData()
    End Sub

#End Region

#Region " Familias "
    Protected Overridable Sub jngFamilia_AdvSearchSelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchSelectionChangedEventArgs) Handles jngFamilia.AdvSearchSelectionChanged
        If e.Key = "IDTipo" Then
            jngFamilia.Value("IDFamilia") = System.DBNull.Value
            jngFamilia.Value("DescFamilia") = System.DBNull.Value
        End If
    End Sub

    Protected Overridable Sub jngFamilia_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngFamilia.AdvSearchSetPredefinedFilter
        If e.Key = "IDFamilia" And Length(jngFamilia.Value("IDTipo")) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, jngFamilia.Value("IDTipo"))
        End If
    End Sub

#End Region

#Region " Articulos "
    Protected Overridable Sub jngArtLinea_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngArtLinea.EditingCell

        With jngArtLinea
            Select Case e.Column.Index
                Case .Columns("Qdesde").Index
                    If .Row <> Grid.newTopRowPosition And Length(.Value("Qdesde")) > 0 Then
                        e.Cancel = True
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub jngArticulos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngArticulos.SelectionChanged
        Dim strIDArticulo As String = String.Empty
        With jngArticulos
            If .Row = Grid.newTopRowPosition Then
                jngArtLinea.AllowAddNew = GridEX.InheritableBoolean.False
            Else
                If Length(.GetValue("IdArticulo")) > 0 Then
                    strIDArticulo = .GetValue("IdArticulo")
                    jngArtLinea.AllowAddNew = GridEX.InheritableBoolean.True
                Else
                    jngArtLinea.AllowAddNew = GridEX.InheritableBoolean.False
                End If
            End If
            If Not jngArticulos.DataSource Is Nothing AndAlso Length(Me.jngArticulos.GetValue("IDArticulo")) Then
                Dim FilLinea As New Filter
                FilLinea.Add("IDProveedor", FilterOperator.Equal, Me.CurrentRow("IDProveedor"))
                FilLinea.Add("IDArticulo", FilterOperator.Equal, jngArticulos.GetValue("IDArticulo"))
                jngArtLinea.ReQuery(FilLinea)
            Else : jngArtLinea.DataSource = Nothing
            End If
            If jngArtLinea.AllowAddNew = GridEX.InheritableBoolean.True Then
                jngArtLinea.Columns("IdArticulo").DefaultValue = .GetValue("IdArticulo")
                jngArtLinea.Columns("Dto1").DefaultValue = .GetValue("Dto1")
                jngArtLinea.Columns("Dto2").DefaultValue = .GetValue("Dto2")
                jngArtLinea.Columns("Dto3").DefaultValue = .GetValue("Dto3")
            End If
        End With
    End Sub

    Protected Overridable Sub jngArticulos_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngArticulos.EditingCell
        With jngArticulos
            If e.Column.Index = .Columns("IdArticulo").Index Then
                If .Row = Grid.newTopRowPosition Or Length(.Value("IdArticulo")) = 0 Then
                    .Columns("IdArticulo").EditType = Janus.Windows.GridEX.EditType.TextBox
                    .Columns("IdArticulo").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                Else
                    e.Cancel = True
                    .Columns("IdArticulo").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                End If
            End If

            If e.Column.Index = .Columns("Principal").Index Then
                If Length(.Value("IDArticulo")) = 0 Then e.Cancel = True
            End If
        End With
    End Sub

    Protected Overridable Sub jngArticulos_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngArticulos.GotFocus
        With jngArticulos
            .Columns("IDProveedor").DefaultValue = Me.CurrentRow("IDProveedor")
            .Columns("Principal").DefaultValue = False
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0
            If Me.RecordsState = Engine.UI.RecordsState.New AndAlso Length(Me.CurrentRow("IDContador")) > 0 Then Me.UpdateData()
        End With
    End Sub

    Protected Overridable Sub jngArtLinea_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngArtLinea.GotFocus
        jngArtLinea.Columns("IDProveedor").DefaultValue = Me.CurrentRow("IDProveedor")
        jngArtLinea.Columns("IDArticulo").DefaultValue = jngArticulos.Value("IDArticulo")
    End Sub
#End Region

#Region " Bancos "
    Protected Overridable Sub jngBancos_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngBancos.EditingCell
        With jngBancos
            Select Case e.Column.Index
                Case .Columns("IDBanco").Index
                    If .Row = Grid.newTopRowPosition Or Length(.Value("IDBanco")) = 0 Then
                        .Columns("IDBanco").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    Else
                        e.Cancel = True
                        .Columns("IDBanco").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End If
            End Select
        End With
    End Sub

    Protected Overridable Sub jngBancos_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngBancos.GotFocus
        jngBancos.Columns("Predeterminado").DefaultValue = False
        If Me.RecordsState = Engine.UI.RecordsState.New AndAlso Length(Me.CurrentRow("IDContador")) > 0 Then Me.UpdateData()
    End Sub
#End Region

#Region " Cuentas Contables "

    Protected Overridable Sub advCC_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advCCFraPdte.SetPredefinedFilter, advCCFianza.SetPredefinedFilter, advCCAnticipo.SetPredefinedFilter, advCCRetencion.SetPredefinedFilter, advCCEfectos.SetPredefinedFilter, advCCProveedor.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, mstrIdEjercicio))
    End Sub

    Protected Overridable Sub advCCProveedor_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCProveedor.DoubleClick
        'Al hacer doble click se genera una cuenta contable, de la concatenación de los dígitos de
        'prefijo, proveedor y un número de 0's determinado por el número de dígitos que debe tener
        'una CC
        If Length(advCCProveedor.Text) = 0 Then
            If ChkEmpresaGrupo.Checked Then
                advCCProveedor.Text = GeneraCContable(txtIDProveedor.Text, mstrIdEjercicio, enumTipoCodigo.ProveedorGrupo)
            Else
                advCCProveedor.Text = GeneraCContable(txtIDProveedor.Text, mstrIdEjercicio, enumTipoCodigo.Proveedor)
            End If

        End If
    End Sub

    Protected Overridable Sub advCCEfectos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles advCCEfectos.DoubleClick
        If Length(advCCEfectos.Text) = 0 Then
            advCCEfectos.Text = GeneraCContable(txtIDProveedor.Text, mstrIdEjercicio, enumTipoCodigo.EfectosProveedor)
        End If
    End Sub

    Protected Overridable Sub advCCProveedor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCProveedor.Leave
        advCCProveedor.Text = PuntoPorCero(advCCProveedor.Text, mintDigitosAux, mstrIdEjercicio)
        If Length(advCCProveedor.Text) > 0 Then
            If New CommonClasses.AltaPlanContable().ValidaCuentaContable(advCCProveedor.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value) Then
                ullCCProveedor.Text = DescripcionCContable(mstrIdEjercicio, advCCProveedor.Text)
            End If
        End If
    End Sub

    Protected Overridable Sub advCCAnticipo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCAnticipo.Leave
        advCCAnticipo.Text = PuntoPorCero(advCCAnticipo.Text, mintDigitosAux, mstrIdEjercicio)
        If Length(advCCAnticipo.Text) > 0 Then
            If New CommonClasses.AltaPlanContable().ValidaCuentaContable(advCCAnticipo.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value) Then
                ullCCAnticipo.Text = DescripcionCContable(mstrIdEjercicio, advCCAnticipo.Text)
            End If
        End If
    End Sub

    Protected Overridable Sub advCCEfectos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCEfectos.Leave
        advCCEfectos.Text = PuntoPorCero(advCCEfectos.Text, mintDigitosAux, mstrIdEjercicio)
        If Length(advCCEfectos.Text) > 0 Then
            If New CommonClasses.AltaPlanContable().ValidaCuentaContable(advCCEfectos.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value) Then
                ullCCEfectos.Text = DescripcionCContable(mstrIdEjercicio, advCCEfectos.Text)
            End If
        End If
    End Sub

    Protected Overridable Sub advCCFianza_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCFianza.Leave
        advCCFianza.Text = PuntoPorCero(advCCFianza.Text, mintDigitosAux, mstrIdEjercicio)
        If Length(advCCFianza.Text) > 0 Then
            If New CommonClasses.AltaPlanContable().ValidaCuentaContable(advCCFianza.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value) Then
                ullCCFianza.Text = DescripcionCContable(mstrIdEjercicio, advCCFianza.Text)
            End If
        End If
    End Sub

    Protected Overridable Sub advCCFraPdte_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCFraPdte.Leave
        advCCFraPdte.Text = PuntoPorCero(advCCFraPdte.Text, mintDigitosAux, mstrIdEjercicio)
        If Length(advCCFraPdte.Text) > 0 Then
            If New CommonClasses.AltaPlanContable().ValidaCuentaContable(advCCFraPdte.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value) Then
                ulbladvCCFraPdte.Text = DescripcionCContable(mstrIdEjercicio, advCCFraPdte.Text)
            End If
        End If
    End Sub

    Protected Overridable Sub advCCRetencion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCRetencion.Leave
        advCCRetencion.Text = PuntoPorCero(advCCRetencion.Text, mintDigitosAux, mstrIdEjercicio)
        If Length(advCCRetencion.Text) > 0 Then
            If New CommonClasses.AltaPlanContable().ValidaCuentaContable(advCCRetencion.Text, mstrIdEjercicio, fwiRazonSocial.Text, ChkEmpresaGrupo.Checked, cbxIDMoneda.Value) Then
                ullCCRetencion.Text = DescripcionCContable(mstrIdEjercicio, advCCRetencion.Text)
            End If
        End If
    End Sub

    Protected Overridable Sub advCCProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCProveedor.TextChanged
        If Length(advCCProveedor.Text) = 0 Then ullCCProveedor.Text = String.Empty
    End Sub

    Protected Overridable Sub advCCAnticipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCAnticipo.TextChanged
        If Length(advCCAnticipo.Text) = 0 Then ullCCAnticipo.Text = String.Empty
    End Sub

    Protected Overridable Sub advCCEfectos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCEfectos.TextChanged
        If Length(advCCEfectos.Text) = 0 Then ullCCEfectos.Text = String.Empty
    End Sub

    Protected Overridable Sub advCCFianza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCFianza.TextChanged
        If Length(advCCFianza.Text) = 0 Then ullCCFianza.Text = String.Empty
    End Sub

    Protected Overridable Sub advCCFraPdte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCFraPdte.TextChanged
        If Length(advCCFraPdte.Text) = 0 Then ulbladvCCFraPdte.Text = String.Empty
    End Sub

    Protected Overridable Sub advCCRetencion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advCCRetencion.TextChanged
        If Length(advCCRetencion.Text) = 0 Then ullCCRetencion.Text = String.Empty
    End Sub

    Protected Overridable Sub CuentasContables_NotInList(ByVal sender As Object, ByVal e As Engine.UI.NotInListEventArgs) Handles advCCProveedor.NotInList, advCCEfectos.NotInList, advCCAnticipo.NotInList, advCCFianza.NotInList, advCCRetencion.NotInList, advCCFraPdte.NotInList
        e.Cancel = False
    End Sub

#End Region

    Protected Overridable Sub TabProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabProveedores.Click
        Select Case TabProveedores.SelectedTab.Key
            Case "Grupo"
                'Dim blnVisible As Boolean = Length(AdvIDGrupoProveedor.Text) > 0
                'fwiGrupoArticulo.Visible = blnVisible
                'fwiGrupoFactura.Visible = blnVisible
            Case "Direcciones"
                If Me.RecordsState = RecordsState.[New] Then
                    jngDirecciones.AllowAddNew = GridEX.InheritableBoolean.False
                    jngDirecciones.AllowEdit = GridEX.InheritableBoolean.False
                    jngDirecciones.AllowDelete = GridEX.InheritableBoolean.False
                Else
                    jngDirecciones.AllowAddNew = GridEX.InheritableBoolean.True
                    jngDirecciones.AllowEdit = GridEX.InheritableBoolean.True
                    jngDirecciones.AllowDelete = GridEX.InheritableBoolean.True
                End If
            Case "DatosEconomicos"
                ullCCProveedor.Text = DescripcionCContable(mstrIdEjercicio, advCCProveedor.Text)
                ullCCEfectos.Text = DescripcionCContable(mstrIdEjercicio, advCCEfectos.Text)
            Case "CuentasContables"
                ullCCRetencion.Text = DescripcionCContable(mstrIdEjercicio, advCCRetencion.Text)
                ullCCAnticipo.Text = DescripcionCContable(mstrIdEjercicio, advCCAnticipo.Text)
                ullCCRetencion.Text = DescripcionCContable(mstrIdEjercicio, advCCRetencion.Text)
                ullCCFianza.Text = DescripcionCContable(mstrIdEjercicio, advCCFianza.Text)
        End Select
    End Sub

    Protected Overridable Sub OpenDoc(ByVal strFileName As String)
        If Length(strFileName) > 0 Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim PSDoc As New ProcessStartInfo
            PSDoc.WindowStyle = ProcessWindowStyle.Normal
            PSDoc.FileName = strFileName
            Process.Start(PSDoc)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Protected Overridable Sub FwiWeb_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FwiWeb.DoubleClick
        OpenDoc(FwiWeb.Text)
    End Sub

    'protected overridable sub AdvIDGrupoProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvIDGrupoProveedor.TextChanged
    '    Dim blnVisible As Boolean = Length(AdvIDGrupoProveedor.Text) > 0
    '    fwiGrupoArticulo.Visible = blnVisible
    '    fwiGrupoFactura.Visible = blnVisible
    '    If Not blnVisible Then
    '        fwiGrupoArticulo.Checked = blnVisible
    '        fwiGrupoFactura.Checked = blnVisible
    '    End If
    'End Sub

    Protected Overridable Sub fwiEMail_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiEMail.DoubleClick
        If Length(fwiEMail.Text) > 0 Then
            Dim eMail As String = "mailto:" & fwiEMail.Text
            OpenDoc(eMail)
        End If
    End Sub

    Protected Overridable Sub fwiDescProveedor_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiDescProveedor.LostFocus
        If Length(fwiRazonSocial.Text) = 0 Then fwiRazonSocial.Text = fwiDescProveedor.Text
    End Sub

    Protected Overridable Sub DatosComunesCRM_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FwiWeb.Validated, fwiRazonSocial.Validated, fwiFax.Validated, fwiTelefono.Validated, txtTelefono2.Validated, fwiProvincia.Validated, fwiCifProveedor.Validated, fwiDireccion.Validated, fwiEMail.Validated, AdvIDZona.Validated, fwiCodigoPostal.Validated
        mblnModificado = True
    End Sub

    Protected Overridable Sub ChkEmpresaGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEmpresaGrupo.CheckedChanged
        If ChkEmpresaGrupo.Checked Then
            cbxEmpresa.Enabled = True
        Else
            cbxEmpresa.Value = DBNull.Value
            cbxEmpresa.Enabled = False
        End If
    End Sub

#Region " Observaciones "

    Protected Overridable Sub jngObservaciones_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngObservaciones.DoubleClick
        Dim oP As Drawing.Point = jngObservaciones.PointToClient(Cursor.Position)
        Dim pos As Janus.Windows.GridEX.GridArea = jngObservaciones.HitTest(oP.X, oP.Y)
        If pos = Janus.Windows.GridEX.GridArea.Cell Or pos = Janus.Windows.GridEX.GridArea.NewRowCell Or pos = Janus.Windows.GridEX.GridArea.PreviewRow Then
            Dim frmTx As CommonClasses.FormularioTexto = New CommonClasses.FormularioTexto
            If Not IsDBNull(jngObservaciones.GetValue("DescObservacion")) Then frmTx.Texto = jngObservaciones.GetValue("DescObservacion")
            If frmTx.ShowDialog = DialogResult.OK Then jngObservaciones.SetValue("DescObservacion", frmTx.Texto)
        End If
    End Sub
    Protected Overridable Sub jngObservaciones_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngObservaciones.GotFocus
        If Me.RecordsState = Engine.UI.RecordsState.New AndAlso Length(Me.CurrentRow("IDContador")) > 0 Then Me.UpdateData()
    End Sub
    Protected Overridable Sub jngObservaciones_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngObservaciones.AdvSearchSetPredefinedFilter
        If Not jngObservaciones.GetValue("Entidad") Is Nothing AndAlso _
                jngObservaciones.GetValue("Entidad").ToString.Trim.Length > 0 Then
            e.Filter.Add(New StringFilterItem("Entidad", FilterOperator.Equal, jngObservaciones.GetValue("Entidad")))
        End If
    End Sub

    Protected Overridable Sub jngObservaciones_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngObservaciones.EditingCell
        If e.Column.Key.ToUpper = "DESCOBSERVACION" Then
            If Not jngObservaciones.GetValue("IdObservacion") Is Nothing AndAlso _
                jngObservaciones.GetValue("IdObservacion").ToString.Trim.Length > 0 Then
                e.Cancel = True
            End If
        End If
    End Sub
    Protected Overridable Sub jngObservaciones_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngObservaciones.UpdatingRecord
        AltaObservacion()
    End Sub

    Protected Overridable Sub jngObservaciones_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngObservaciones.AddingRecord
        AltaObservacion()
    End Sub

    Protected Overridable Sub AltaObservacion()
        With jngObservaciones
            If (.GetValue("IDObservacion") Is Nothing OrElse _
                .GetValue("IDObservacion").ToString.Trim.Length = 0) And _
                (Not .GetValue("DescObservacion") Is Nothing OrElse _
                .GetValue("DescObservacion").ToString.Trim.Length > 0) Then
                Dim res As DialogResult
                res = ExpertisApp.GenerateMessage("¿Desea dar de alta la observación introducida?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res = DialogResult.Yes Then
                    Dim oObservacion As New Observacion
                    Dim dt As DataTable = oObservacion.AddNewForm
                    dt.Rows(0)("IDObservacion") = ""
                    dt.Rows(0)("DescObservacion") = .GetValue("DescObservacion")
                    dt.Rows(0)("Entidad") = .GetValue("Entidad")
                    dt.Rows(0)("ImprimirSiempre") = False
                    dt = oObservacion.Update(dt)
                    .SetValue("IDObservacion", dt.Rows(0)("IDObservacion"))
                End If
            End If
        End With
    End Sub

    Protected Overridable Sub fwiTexto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiTexto.DoubleClick
        Dim frm As FormularioTexto = New FormularioTexto
        frm.Texto = fwiTexto.Text & String.Empty
        Dim res As DialogResult
        res = frm.ShowDialog()
        If res = DialogResult.OK Then
            If fwiTexto.Text & String.Empty <> frm.Texto Then
                fwiTexto.Text = frm.Texto
            End If
        End If
        frm.Dispose()
    End Sub

#End Region

    Protected Overridable Sub MntoProveedores_RecordCanceled(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordCanceled
        mblnModificado = False
    End Sub

    Protected Overridable Sub TxtPoblacion_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPoblacion.ButtonClick
        Me.AdvPoblacion.Open()
    End Sub

    Protected Overridable Sub AdvPoblacion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvPoblacion.SelectionChanged
        If Not e.Selected Is Nothing Then
            If Length(e.Selected.Rows(0)("IDPais")) > 0 Then AdvIDPais.Value = e.Selected.Rows(0)("IDPais")
            If Length(e.Selected.Rows(0)("CodPostal")) > 0 Then fwiCodigoPostal.Text = e.Selected.Rows(0)("CodPostal")
            If Length(e.Selected.Rows(0)("DescProvincia")) > 0 Then fwiProvincia.Text = e.Selected.Rows(0)("DescProvincia")
            Me.TxtPoblacion.Text = e.Selected.Rows(0)("DescPoblacion")
        End If
    End Sub

    Protected Overridable Sub AdvPoblacion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvPoblacion.SetPredefinedFilter
        If Length(AdvIDPais.Value) > 0 Then e.Filter.Add(New StringFilterItem("IDPais", AdvIDPais.Value))
        If Length(fwiCodigoPostal.Text) > 0 Then e.Filter.Add(New StringFilterItem("CodPostal", fwiCodigoPostal.Text))
    End Sub

    Protected Overridable Sub UICommandManager1_CommandClick(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiCommandManager1.CommandClick
        Select Case e.Command.Key
            Case "Graphic"
                LoadGraphic()
        End Select
    End Sub

    Protected Overridable Sub LoadGraphic()
        If Me.RecordsState = Engine.UI.RecordsState.Saved Then
            Dim GrpInfo As New GraphicInfo(EntityName)
            Dim IPRecord As New BusinessData(Me.CurrentRow)
            Dim StDatos As New Business.General.Graficos.StDatosOptions
            StDatos.Options = GrpInfo.FilterOptions
            StDatos.Entidad = EntityName
            StDatos.DrRecord = IPRecord
            GrpInfo.FilterOptions = ExpertisApp.ExecuteTask(Of Business.General.Graficos.StDatosOptions, Business.General.GraphicOptionsInfo)(AddressOf Business.General.Graficos.LoadKeys, StDatos)
            GrpInfo.FilterOptions.ProgramID = Me.ProgramInfo.ProgramID
            GrpInfo.TipoAreaGrafico = -1
            GrpInfo.FilterOptions.OptionsEnabled = True
            ExpertisApp.CloseForm("CIGRAPH")
            ExpertisApp.OpenForm("CIGRAPH", , GrpInfo)
        End If
    End Sub

    Protected Overridable Sub AdvIDPais_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDPais.SelectionChanged
        mblnModificado = True
    End Sub

    Protected Overridable Sub MntoProveedores_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RecordAdded
        Me.jngArtLinea.DataSource = Nothing
    End Sub

    'TODO HISTREV
    Protected Overridable Sub jngArticulos_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngArticulos.UpdatingCell
        Select Case e.Column.Key
            Case "Precio", "Dto1", "Dto2", "Dto3"
                If Not jngArticulos.GetRow.DataRow Is Nothing AndAlso CType(jngArticulos.GetRow.DataRow, DataRowView).Row.RowState <> DataRowState.Added Then
                    If jngArticulos.Row <> jngArticulos.newTopRowPosition Then
                        If ExpertisApp.GenerateMessage("Si desea mantener el precio que tenía registrado, deberá insertar la información del periodo de vigencia para dicho precio, ¿desea dar de alta el nuevo registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = Windows.Forms.DialogResult.Yes Then
                            Dim FrmHist As New FrmHistoricoPreciosClieProv
                            FrmHist.Opcion = FrmHistoricoPreciosClieProv.Opt.PreciosProveedores
                            FrmHist.Entity = New HistoricoPreciosProveedor
                            FrmHist.IDEntity = Me.CurrentRow("IDProveedor")
                            FrmHist.DescIdentity = Me.CurrentRow("DescProveedor")
                            FrmHist.IDArticulo = jngArticulos.GetValue("IDArticulo")
                            FrmHist.DescArticulo = jngArticulos.GetValue("DescArticulo")
                            Select Case e.Column.Key
                                Case "Precio"
                                    FrmHist.Precio = e.InitialValue
                                    FrmHist.Dto1 = jngArticulos.GetValue("Dto1")
                                    FrmHist.Dto2 = jngArticulos.GetValue("Dto2")
                                    FrmHist.Dto3 = jngArticulos.GetValue("Dto3")
                                Case "Dto1"
                                    FrmHist.Precio = jngArticulos.GetValue("Precio")
                                    FrmHist.Dto1 = e.InitialValue
                                    FrmHist.Dto2 = jngArticulos.GetValue("Dto2")
                                    FrmHist.Dto3 = jngArticulos.GetValue("Dto3")
                                Case "Dto2"
                                    FrmHist.Precio = jngArticulos.GetValue("Precio")
                                    FrmHist.Dto1 = jngArticulos.GetValue("Dto1")
                                    FrmHist.Dto2 = e.InitialValue
                                    FrmHist.Dto3 = jngArticulos.GetValue("Dto3")
                                Case "Dto3"
                                    FrmHist.Precio = jngArticulos.GetValue("Precio")
                                    FrmHist.Dto1 = jngArticulos.GetValue("Dto1")
                                    FrmHist.Dto2 = jngArticulos.GetValue("Dto2")
                                    FrmHist.Dto3 = e.InitialValue
                            End Select
                            FrmHist.ShowDialog()
                        End If
                    End If
                End If
        End Select
    End Sub

    Protected Overridable Sub jngArtLinea_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngArtLinea.UpdatingCell
        Select Case e.Column.Key
            Case "Precio", "Dto1", "Dto2", "Dto3"
                If jngArtLinea.Row <> jngArtLinea.newTopRowPosition Then
                    If ExpertisApp.GenerateMessage("Si desea mantener el precio que tenía registrado, deberá insertar la información del periodo de vigencia para dicho precio, ¿desea dar de alta el nuevo registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = Windows.Forms.DialogResult.Yes Then
                        Dim FrmHist As New FrmHistoricoPreciosClieProv
                        FrmHist.Opcion = FrmHistoricoPreciosClieProv.Opt.PreciosProveedoresLineas
                        FrmHist.Entity = New HistoricoPreciosProveedorQDesde
                        FrmHist.IDEntity = Me.CurrentRow("IDProveedor")
                        FrmHist.DescIdentity = Me.CurrentRow("DescProveedor")
                        FrmHist.IDArticulo = jngArtLinea.GetValue("IDArticulo")
                        FrmHist.DescArticulo = jngArticulos.GetValue("DescArticulo")
                        FrmHist.Cantidad = jngArtLinea.GetValue("QDesde")
                        Select Case e.Column.Key
                            Case "Precio"
                                FrmHist.Precio = e.InitialValue
                                FrmHist.Dto1 = jngArtLinea.GetValue("Dto1")
                                FrmHist.Dto2 = jngArtLinea.GetValue("Dto2")
                                FrmHist.Dto3 = jngArtLinea.GetValue("Dto3")
                            Case "Dto1"
                                FrmHist.Precio = jngArtLinea.GetValue("Precio")
                                FrmHist.Dto1 = e.InitialValue
                                FrmHist.Dto2 = jngArtLinea.GetValue("Dto2")
                                FrmHist.Dto3 = jngArtLinea.GetValue("Dto3")
                            Case "Dto2"
                                FrmHist.Precio = jngArtLinea.GetValue("Precio")
                                FrmHist.Dto1 = jngArtLinea.GetValue("Dto1")
                                FrmHist.Dto2 = e.InitialValue
                                FrmHist.Dto3 = jngArtLinea.GetValue("Dto3")
                            Case "Dto3"
                                FrmHist.Precio = jngArtLinea.GetValue("Precio")
                                FrmHist.Dto1 = jngArtLinea.GetValue("Dto1")
                                FrmHist.Dto2 = jngArtLinea.GetValue("Dto2")
                                FrmHist.Dto3 = e.InitialValue
                        End Select
                        FrmHist.ShowDialog()
                    End If
                End If
        End Select
    End Sub

    Protected Overridable Sub jngFamilia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngFamilia.GotFocus
        If Me.RecordsState = Engine.UI.RecordsState.New AndAlso Length(Me.CurrentRow("IDContador")) > 0 Then Me.UpdateData()
    End Sub

    Protected Overridable Sub jngVacaciones_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngVacaciones.GotFocus
        If Me.RecordsState = Engine.UI.RecordsState.New AndAlso Length(Me.CurrentRow("IDContador")) > 0 Then Me.UpdateData()
    End Sub

#Region "Pestaña Pagos"
    Private Sub CalcularAlquiler()
        ntbTotalAlquiler.Value = Nz(ntbrenta.Value, 0) + Nz(ntbiva.Value, 0) + Nz(ntbretencion.Value, 0)

    End Sub
    Private Sub CalcularGastos()
        ntbTotalGastos.Value = Nz(ntbluz.Value, 0) + Nz(ntbagua.Value, 0) + Nz(ntbgas.Value, 0) + Nz(ntbvarios.Value, 0)

    End Sub
    Private Sub CalcularTotal()
        ntbTotalPagar.Value = Nz(ntbTotalAlquiler.Value, 0) + Nz(ntbTotalGastos.Value, 0)
    End Sub

    Private Sub ntbrenta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ntbrenta.ValueChanged
        CalcularAlquiler()
        CalcularTotal()
    End Sub
    Private Sub ntbiva_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ntbiva.ValueChanged
        CalcularAlquiler()
        CalcularTotal()
    End Sub
    Private Sub ntbretencion_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ntbretencion.ValueChanged
        CalcularAlquiler()
        CalcularTotal()
    End Sub
    Private Sub ntbluz_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ntbluz.ValueChanged
        CalcularGastos()
        CalcularTotal()
    End Sub
    Private Sub ntbagua_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ntbagua.ValueChanged
        CalcularGastos()
        CalcularTotal()
    End Sub

    Private Sub ntbgas_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ntbgas.ValueChanged
        CalcularGastos()
        CalcularTotal()
    End Sub
    Private Sub ntbvarios_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ntbvarios.ValueChanged
        CalcularGastos()
        CalcularTotal()
    End Sub

#End Region


 
End Class