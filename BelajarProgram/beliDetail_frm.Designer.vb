<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class beliDetail_frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSatuan = New System.Windows.Forms.Label()
        Me.lblHrg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataSet1 = New BelajarProgram.DataSet1()
        Me.TbJenisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbJenisTableAdapter = New BelajarProgram.DataSet1TableAdapters.tbJenisTableAdapter()
        Me.MsbrgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MsbrgTableAdapter = New BelajarProgram.DataSet1TableAdapters.msbrgTableAdapter()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbJenisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MsbrgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Barang"
        '
        'lblSatuan
        '
        Me.lblSatuan.AutoSize = True
        Me.lblSatuan.Location = New System.Drawing.Point(227, 12)
        Me.lblSatuan.Name = "lblSatuan"
        Me.lblSatuan.Size = New System.Drawing.Size(41, 13)
        Me.lblSatuan.TabIndex = 2
        Me.lblSatuan.Text = "Satuan"
        '
        'lblHrg
        '
        Me.lblHrg.AutoSize = True
        Me.lblHrg.Location = New System.Drawing.Point(11, 65)
        Me.lblHrg.Name = "lblHrg"
        Me.lblHrg.Size = New System.Drawing.Size(36, 13)
        Me.lblHrg.TabIndex = 3
        Me.lblHrg.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Qty Beli"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.MsbrgBindingSource
        Me.ComboBox2.DisplayMember = "namabrg"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(100, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.ValueMember = "idbrg"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(67, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbJenisBindingSource
        '
        Me.TbJenisBindingSource.DataMember = "tbJenis"
        Me.TbJenisBindingSource.DataSource = Me.DataSet1
        '
        'TbJenisTableAdapter
        '
        Me.TbJenisTableAdapter.ClearBeforeFill = True
        '
        'MsbrgBindingSource
        '
        Me.MsbrgBindingSource.DataMember = "msbrg"
        Me.MsbrgBindingSource.DataSource = Me.DataSet1
        '
        'MsbrgTableAdapter
        '
        Me.MsbrgTableAdapter.ClearBeforeFill = True
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(8, 37)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(68, 13)
        Me.lblJenis.TabIndex = 10
        Me.lblJenis.Text = "Jenis Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Notes"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(100, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 20)
        Me.TextBox2.TabIndex = 12
        '
        'beliDetail_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 205)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHrg)
        Me.Controls.Add(Me.lblSatuan)
        Me.Controls.Add(Me.Label2)
        Me.Name = "beliDetail_frm"
        Me.Text = "Detail Beli"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbJenisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MsbrgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSatuan As Label
    Friend WithEvents lblHrg As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TbJenisBindingSource As BindingSource
    Friend WithEvents TbJenisTableAdapter As DataSet1TableAdapters.tbJenisTableAdapter
    Friend WithEvents MsbrgBindingSource As BindingSource
    Friend WithEvents MsbrgTableAdapter As DataSet1TableAdapters.msbrgTableAdapter
    Friend WithEvents lblJenis As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
