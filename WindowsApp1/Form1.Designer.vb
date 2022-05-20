<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim UcenikID_Label As System.Windows.Forms.Label
        Dim ImeLabel As System.Windows.Forms.Label
        Dim PrezimeLabel As System.Windows.Forms.Label
        Dim RazredLabel As System.Windows.Forms.Label
        Dim ProsjekLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New WindowsApp1.Database1DataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New WindowsApp1.Database1DataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtUcenik = New System.Windows.Forms.TextBox()
        Me.txtIme = New System.Windows.Forms.TextBox()
        Me.txtPrezime = New System.Windows.Forms.TextBox()
        Me.txtRazred = New System.Windows.Forms.TextBox()
        Me.txtProsjek = New System.Windows.Forms.TextBox()
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonUnos = New System.Windows.Forms.Button()
        Me.ButtonBrisanje = New System.Windows.Forms.Button()
        Me.ButtonIzmjena = New System.Windows.Forms.Button()
        UcenikID_Label = New System.Windows.Forms.Label()
        ImeLabel = New System.Windows.Forms.Label()
        PrezimeLabel = New System.Windows.Forms.Label()
        RazredLabel = New System.Windows.Forms.Label()
        ProsjekLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.Database1DataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(753, 27)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UcenikID_Label
        '
        UcenikID_Label.AutoSize = True
        UcenikID_Label.Location = New System.Drawing.Point(46, 56)
        UcenikID_Label.Name = "UcenikID_Label"
        UcenikID_Label.Size = New System.Drawing.Size(71, 16)
        UcenikID_Label.TabIndex = 1
        UcenikID_Label.Text = "Ucenik ID :"
        '
        'txtUcenik
        '
        Me.txtUcenik.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "UcenikID ", True))
        Me.txtUcenik.Location = New System.Drawing.Point(123, 53)
        Me.txtUcenik.Name = "txtUcenik"
        Me.txtUcenik.Size = New System.Drawing.Size(100, 22)
        Me.txtUcenik.TabIndex = 2
        '
        'ImeLabel
        '
        ImeLabel.AutoSize = True
        ImeLabel.Location = New System.Drawing.Point(85, 98)
        ImeLabel.Name = "ImeLabel"
        ImeLabel.Size = New System.Drawing.Size(32, 16)
        ImeLabel.TabIndex = 3
        ImeLabel.Text = "Ime:"
        '
        'txtIme
        '
        Me.txtIme.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Ime", True))
        Me.txtIme.Location = New System.Drawing.Point(123, 95)
        Me.txtIme.Name = "txtIme"
        Me.txtIme.Size = New System.Drawing.Size(100, 22)
        Me.txtIme.TabIndex = 4
        '
        'PrezimeLabel
        '
        PrezimeLabel.AutoSize = True
        PrezimeLabel.Location = New System.Drawing.Point(58, 148)
        PrezimeLabel.Name = "PrezimeLabel"
        PrezimeLabel.Size = New System.Drawing.Size(59, 16)
        PrezimeLabel.TabIndex = 5
        PrezimeLabel.Text = "Prezime:"
        '
        'txtPrezime
        '
        Me.txtPrezime.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Prezime", True))
        Me.txtPrezime.Location = New System.Drawing.Point(123, 145)
        Me.txtPrezime.Name = "txtPrezime"
        Me.txtPrezime.Size = New System.Drawing.Size(100, 22)
        Me.txtPrezime.TabIndex = 6
        '
        'RazredLabel
        '
        RazredLabel.AutoSize = True
        RazredLabel.Location = New System.Drawing.Point(58, 191)
        RazredLabel.Name = "RazredLabel"
        RazredLabel.Size = New System.Drawing.Size(54, 16)
        RazredLabel.TabIndex = 7
        RazredLabel.Text = "Razred:"
        '
        'txtRazred
        '
        Me.txtRazred.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Razred", True))
        Me.txtRazred.Location = New System.Drawing.Point(123, 191)
        Me.txtRazred.Name = "txtRazred"
        Me.txtRazred.Size = New System.Drawing.Size(100, 22)
        Me.txtRazred.TabIndex = 8
        '
        'ProsjekLabel
        '
        ProsjekLabel.AutoSize = True
        ProsjekLabel.Location = New System.Drawing.Point(61, 247)
        ProsjekLabel.Name = "ProsjekLabel"
        ProsjekLabel.Size = New System.Drawing.Size(56, 16)
        ProsjekLabel.TabIndex = 9
        ProsjekLabel.Text = "Prosjek:"
        '
        'txtProsjek
        '
        Me.txtProsjek.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Prosjek", True))
        Me.txtProsjek.Location = New System.Drawing.Point(123, 244)
        Me.txtProsjek.Name = "txtProsjek"
        Me.txtProsjek.Size = New System.Drawing.Size(100, 22)
        Me.txtProsjek.TabIndex = 10
        '
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AutoGenerateColumns = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView.Location = New System.Drawing.Point(61, 342)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.RowHeadersWidth = 51
        Me.CustomersDataGridView.RowTemplate.Height = 24
        Me.CustomersDataGridView.Size = New System.Drawing.Size(678, 220)
        Me.CustomersDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UcenikID "
        Me.DataGridViewTextBoxColumn1.HeaderText = "UcenikID "
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ime"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Prezime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Prezime"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Razred"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Razred"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Prosjek"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Prosjek"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'buttonUnos
        '
        Me.buttonUnos.Location = New System.Drawing.Point(567, 74)
        Me.buttonUnos.Name = "buttonUnos"
        Me.buttonUnos.Size = New System.Drawing.Size(149, 40)
        Me.buttonUnos.TabIndex = 12
        Me.buttonUnos.Text = "Unos"
        Me.buttonUnos.UseVisualStyleBackColor = True
        '
        'ButtonBrisanje
        '
        Me.ButtonBrisanje.Location = New System.Drawing.Point(567, 209)
        Me.ButtonBrisanje.Name = "ButtonBrisanje"
        Me.ButtonBrisanje.Size = New System.Drawing.Size(149, 40)
        Me.ButtonBrisanje.TabIndex = 13
        Me.ButtonBrisanje.Text = "Brisanje"
        Me.ButtonBrisanje.UseVisualStyleBackColor = True
        '
        'ButtonIzmjena
        '
        Me.ButtonIzmjena.Location = New System.Drawing.Point(567, 148)
        Me.ButtonIzmjena.Name = "ButtonIzmjena"
        Me.ButtonIzmjena.Size = New System.Drawing.Size(149, 38)
        Me.ButtonIzmjena.TabIndex = 14
        Me.ButtonIzmjena.Text = "Izmjena"
        Me.ButtonIzmjena.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 583)
        Me.Controls.Add(Me.ButtonIzmjena)
        Me.Controls.Add(Me.ButtonBrisanje)
        Me.Controls.Add(Me.buttonUnos)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.Controls.Add(ProsjekLabel)
        Me.Controls.Add(Me.txtProsjek)
        Me.Controls.Add(RazredLabel)
        Me.Controls.Add(Me.txtRazred)
        Me.Controls.Add(PrezimeLabel)
        Me.Controls.Add(Me.txtPrezime)
        Me.Controls.Add(ImeLabel)
        Me.Controls.Add(Me.txtIme)
        Me.Controls.Add(UcenikID_Label)
        Me.Controls.Add(Me.txtUcenik)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As Database1DataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtUcenik As TextBox
    Friend WithEvents txtIme As TextBox
    Friend WithEvents txtPrezime As TextBox
    Friend WithEvents txtRazred As TextBox
    Friend WithEvents txtProsjek As TextBox
    Friend WithEvents CustomersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents buttonUnos As Button
    Friend WithEvents ButtonBrisanje As Button
    Friend WithEvents ButtonIzmjena As Button
End Class
