<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.picWorld = New System.Windows.Forms.PictureBox()
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(204, 319)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(78, 319)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(100, 28)
        Me.btnShow.TabIndex = 11
        Me.btnShow.Text = "Show World"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'picWorld
        '
        Me.picWorld.Cursor = System.Windows.Forms.Cursors.Default
        Me.picWorld.Image = CType(resources.GetObject("picWorld.Image"), System.Drawing.Image)
        Me.picWorld.Location = New System.Drawing.Point(78, 53)
        Me.picWorld.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picWorld.Name = "picWorld"
        Me.picWorld.Size = New System.Drawing.Size(226, 212)
        Me.picWorld.TabIndex = 10
        Me.picWorld.TabStop = False
        Me.picWorld.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 384)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.picWorld)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "The World"
        CType(Me.picWorld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Public WithEvents picWorld As System.Windows.Forms.PictureBox

End Class
