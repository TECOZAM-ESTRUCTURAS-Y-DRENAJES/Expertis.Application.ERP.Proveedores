
Public Class FrmInformacionAlquiler
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents OpPagosPendientes As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents OpFacturasCompra As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents OpAlbaranesCompra As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents OpPedidosCompra As Solmicro.Expertis.Engine.UI.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.OpPagosPendientes = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.OpFacturasCompra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.OpAlbaranesCompra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.OpPedidosCompra = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.OpPagosPendientes)
        Me.Frame1.Controls.Add(Me.OpFacturasCompra)
        Me.Frame1.Controls.Add(Me.OpAlbaranesCompra)
        Me.Frame1.Controls.Add(Me.OpPedidosCompra)
        Me.Frame1.Location = New System.Drawing.Point(5, -1)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(246, 137)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'OpPagosPendientes
        '
        Me.OpPagosPendientes.Location = New System.Drawing.Point(47, 104)
        Me.OpPagosPendientes.Name = "OpPagosPendientes"
        Me.OpPagosPendientes.Size = New System.Drawing.Size(160, 23)
        Me.OpPagosPendientes.TabIndex = 11
        Me.OpPagosPendientes.Text = "Pagos Pendientes"
        '
        'OpFacturasCompra
        '
        Me.OpFacturasCompra.Location = New System.Drawing.Point(47, 72)
        Me.OpFacturasCompra.Name = "OpFacturasCompra"
        Me.OpFacturasCompra.Size = New System.Drawing.Size(160, 23)
        Me.OpFacturasCompra.TabIndex = 10
        Me.OpFacturasCompra.Text = "Facturas de Compra"
        '
        'OpAlbaranesCompra
        '
        Me.OpAlbaranesCompra.Location = New System.Drawing.Point(47, 40)
        Me.OpAlbaranesCompra.Name = "OpAlbaranesCompra"
        Me.OpAlbaranesCompra.Size = New System.Drawing.Size(152, 23)
        Me.OpAlbaranesCompra.TabIndex = 9
        Me.OpAlbaranesCompra.Text = "Albaranes de Compra"
        '
        'OpPedidosCompra
        '
        Me.OpPedidosCompra.Location = New System.Drawing.Point(47, 8)
        Me.OpPedidosCompra.Name = "OpPedidosCompra"
        Me.OpPedidosCompra.Size = New System.Drawing.Size(136, 23)
        Me.OpPedidosCompra.TabIndex = 8
        Me.OpPedidosCompra.Text = "Pedidos de Compra"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdAceptar.Location = New System.Drawing.Point(12, 144)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(98, 27)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(138, 144)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(103, 27)
        Me.cmdCancelar.TabIndex = 8
        Me.cmdCancelar.Text = "Cancelar"
        '
        'FrmInformacionAlquiler
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(256, 175)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmInformacionAlquiler"
        Me.Text = "Información Adicional"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrPrograma As String
    Public ReadOnly Property Programa() As String
        Get
            Return mstrPrograma
        End Get
    End Property

#Region " Aceptar/Cancelar "

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        mstrPrograma = String.Empty
        If OpPedidosCompra.Checked Then
            mstrPrograma = "CPC"
        ElseIf OpAlbaranesCompra.Checked Then
            mstrPrograma = "EACD"
        ElseIf OpFacturasCompra.Checked Then
            mstrPrograma = "DFCD"
        ElseIf OpPagosPendientes.Checked Then
            mstrPrograma = "CIPAGO"
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region


End Class
