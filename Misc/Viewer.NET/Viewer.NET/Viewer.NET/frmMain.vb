Imports System.IO
Imports System.Collections.Generic


Public Class frmMain

    Dim sListColumns As List(Of String) = New List(Of String)
    'Dim sDataFiltered() As String
    Dim sListData As List(Of String)
    Dim sListValues As New List(Of String)
    Dim sListDataFilter As List(Of String)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtFileData.Text = "trimmed_rats_JUNE12.csv"
        cmdReadData.PerformClick()

    End Sub

    Private Sub cmdReadData_Click(sender As Object, e As EventArgs) Handles cmdReadData.Click
        ReadCSV(Me.txtFileData.Text, sListColumns)
        Me.cboColumnName.Items.Clear()
        For iIdx = 1 To sListColumns.Count
            Me.cboColumnName.Items.Add(sListColumns(iIdx - 1))
        Next

    End Sub

    Private Sub cboColumnName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboColumnName.SelectedIndexChanged
        Dim sListTemp As New List(Of String)
        Dim sColumnsForStats() As String = {}
        Dim dStats(,) As Double = {}

        sListValues.Clear()
        GetColumnValues(Me.cboColumnName.Text, sListValues)
        Me.lblValues.Text = "Column Value: " & sListValues.Count

        sListData = New List(Of String)
        sListDataFilter = New List(Of String)
        lstSummaryView.Clear()
        lstSummaryView.Columns.Add(Me.cboColumnName.Text, 80, HorizontalAlignment.Left)
        lstSummaryView.Columns.Add("Count", 70, HorizontalAlignment.Left)
        lstSummaryView.Columns.Add("Average", 70, HorizontalAlignment.Left)
        lstSummaryView.Columns.Add("Median", 70, HorizontalAlignment.Left)
        lstSummaryView.Columns.Add("Stdev", 70, HorizontalAlignment.Left)
        lstSummaryView.Columns.Add("Min", 60, HorizontalAlignment.Left)
        lstSummaryView.Columns.Add("Max", 60, HorizontalAlignment.Left)


        Me.cboColumnValue.Items.Clear()
        For Each sValue In sListValues
            cboColumnValue.Items.Add(sValue)
            GetFilteredData(Me.cboColumnName.Text, sValue, sListData)
            GetStatisticsData(sListData, {"SCORE"}, dStats)
            If Me.chkTable.Checked Then
                sListTemp = New List(Of String)
                sListTemp.Add(sValue)
            End If
            Dim sOutput As String = ""
            sOutput += sValue
            For iIdx = 1 To dStats.GetUpperBound(1) + 1
                If Me.chkTable.Checked Then
                    sListTemp.Add(Format(dStats(0, iIdx - 1), "0.####"))
                End If
                sOutput += "," & Format(dStats(0, iIdx - 1), "0.####")
            Next

            If Me.chkTable.Checked Then
                Dim lstViewItem As ListViewItem = New ListViewItem(sListTemp.ToArray)
                lstSummaryView.Items.Add(lstViewItem)
                sListDataFilter.Add(sOutput)
            End If
        Next



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboColumnValue.SelectedIndexChanged
        Try
            sListData = New List(Of String)

            GetFilteredData(Me.cboColumnName.Text, Me.cboColumnValue.Text, sListData)

            lstDataView.Columns.Clear()
            lstDataView.Clear()
            For Each sColName In sListColumns
                lstDataView.Columns.Add(sColName, 100, HorizontalAlignment.Left)
            Next
            For Each sRowData In sListData
                Dim sTmp() As String = sRowData.Split(",")
                Dim lstViewItem As ListViewItem = New ListViewItem(sTmp)
                lstDataView.Items.Add(lstViewItem)
                lstViewItem.UseItemStyleForSubItems = False
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdWriteData_Click(sender As Object, e As EventArgs) Handles cmdWriteDataListView.Click
        Try
            'For Each sValue As String In sListValues
            '    GetFilteredData(Me.cboColumnName.Text, sValue, sListData)
            'Next
            If Me.chkTable.Checked Then

                Using LVStream As New IO.StreamWriter(String.Format("Summary_{0}.CSV", Me.cboColumnName.Text))
                    Dim sTemp As String = ""
                    For Each colName As ColumnHeader In Me.lstSummaryView.Columns

                        sTemp &= colName.Text & ","
                    Next
                    sTemp = sTemp.Remove(sTemp.Length - 1, 1)
                    LVStream.WriteLine(sTemp)
                    For Each LVi As ListViewItem In Me.lstSummaryView.Items
                        Dim LVRow As String = ""
                        For Each LVCell As ListViewItem.ListViewSubItem _
                                In LVi.SubItems

                            LVRow &= LVCell.Text & ","
                        Next
                        LVRow = LVRow.Remove(LVRow.Length - 1, 1)
                        LVStream.WriteLine(LVRow)

                    Next
                End Using
            Else
                Using LVStream As New IO.StreamWriter(String.Format("Summary_{0}.CSV", Me.cboColumnName.Text))
                    Dim sTemp As String = ""
                    'For Each colName As ColumnHeader In Me.lstSummaryView.Columns

                    '    sTemp &= colName.Text & ","
                    'Next
                    'sTemp = sTemp.Remove(sTemp.Length - 1, 1)
                    'LVStream.WriteLine(sTemp)
                    'For Each LVi As ListViewItem In Me.lstSummaryView.Items
                    For Each sOutput In sListDataFilter
                        Dim LVRow As String = ""
                        'For Each LVCell As ListViewItem.ListViewSubItem _
                        '        In LVi.SubItems

                        '    LVRow &= LVCell.Text & ","
                        'Next
                        'LVRow = LVRow.Remove(LVRow.Length - 1, 1)
                        LVStream.WriteLine(sOutput)
                    Next
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdConvertCSVtoJSON_Click(sender As Object, e As EventArgs) Handles cmdConvertCSVtoJSON.Click
        ConvertCSVtoJSON(Me.txtFileData.Text)
    End Sub
End Class

Module Functions

    Dim sData() As String
    Dim sColumn() As String

    Public Sub ConvertCSVtoJSON(ByVal sFileCSV As String)
        '        var csv = New List < String[]>(); // Or, List<YourClass>
        'var lines = System.IO.File.ReadAllLines(@"C:\file.txt");
        'foreach(String line In lines)
        '        csv.Add(line.Split(',')); // or, populate YourClass          
        'String json = New 


        Try
            Dim sData = System.IO.File.ReadAllLines(sFileCSV)
            Dim sListRows = New List(Of String())

            For Each sRow As String In sData
                sListRows.Add(sRow.Split(","))
            Next

            'Dim properties = sData(0).Split(",")

            'Dim listObjResult = New List(Of Dictionary(Of String, String))()

            'For i = 1 To sData.Count - 1
            '    Dim objResult = New Dictionary(Of String, String)()
            '    For j = 0 To properties.Length - 1
            '        objResult.Add(properties(j), sListRows(i)(j))
            '    Next
            '    listObjResult.Add(objResult)
            'Next


            Dim sJson = New System.Web.Script.Serialization.JavaScriptSerializer().Serialize(sListRows)

            'Using LVStream As New IO.StreamWriter(sFileCSV.Replace(".csv", ".json"))

            '    For Each sRow As String In sJson
            '        LVStream.WriteLine(sRow)
            '    Next

            'End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function CalcMedian1D(ByVal d1DArray() As Double) As Double
        'Created. v1.3.0
        Dim d2DArrayList As New List(Of Double)

        For iIdx1 = 0 To UBound(d1DArray)
            'For iIdx2 = 0 To UBound(d2DArray, 2)
            d2DArrayList.Add(d1DArray(iIdx1))
            'Next
        Next

        d2DArrayList.Sort()

        If d2DArrayList.Count Mod 2 <> 0 Then
            Return d2DArrayList(d2DArrayList.Count / 2)
        Else
            Return d2DArrayList((d2DArrayList.Count - 1) / 2)
        End If
    End Function

    Public Function CalcStdev(ByVal dArray() As Double) As Double


        Dim squares As New List(Of Double)
        Dim squareAvg As Double
        Dim iCount As Integer = 0
        Dim iIndex As Integer = 0
        'Dim dTempArray() As Double

        On Error GoTo TstErr

        Dim mean As Double = dArray.Average

        For iIdx = 0 To UBound(dArray) 'For Each value As Double In dTempArray
            squares.Add(Math.Pow(dArray(iIdx) - mean, 2)) 'squares.Add(Math.Pow(value - mean, 2))
        Next
        squareAvg = squares.Sum
        squareAvg = squares.Average()

        Return Math.Sqrt(squareAvg) ' / dMean 'Divide dMean per matlab code
TstErr:
        Return -1
    End Function

    Public Sub GetStatisticsData(ByVal sFilteredData As List(Of String), ByVal sColumnName As String(), ByRef dStats As Double(,))
        Try
            Dim iIndex(sColumnName.Length - 1) As Integer
            Dim dListData As List(Of Double)() ' = New List(Of Double)(5) '(Of Double)
            ReDim dStats(sColumnName.Length - 1, 5)
            ReDim dListData(sColumnName.Length - 1)

            For iIdx = 1 To sColumnName.Length
                For iIdxCol = 1 To sColumn.Count
                    If sColumnName(iIdx - 1) = sColumn(iIdxCol - 1) Then
                        iIndex(iIdx - 1) = iIdxCol
                        Exit For
                    End If
                Next

                If iIndex(iIdx - 1) = -1 Then
                    Throw New Exception("Column not found")
                End If
                dListData(iIdx - 1) = New List(Of Double)
            Next 'Column Index grab

            For Each sRow As String In sFilteredData
                Dim sTmp() As String = sRow.Split(",")
                For iIdxCol = 1 To sColumnName.Length
                    dListData(iIdxCol - 1).Add(Val(sTmp(iIndex(iIdxCol - 1) - 1)))
                Next
            Next 'Grab data

            For iIdxCol = 1 To sColumnName.Length
                dStats(iIdxCol - 1, 0) = dListData(iIdxCol - 1).Count
                dStats(iIdxCol - 1, 1) = dListData(iIdxCol - 1).Average
                dStats(iIdxCol - 1, 2) = CalcMedian1D(dListData(iIdxCol - 1).ToArray)
                dStats(iIdxCol - 1, 3) = CalcStdev(dListData(iIdxCol - 1).ToArray)
                dStats(iIdxCol - 1, 4) = dListData(iIdxCol - 1).Min()
                dStats(iIdxCol - 1, 5) = dListData(iIdxCol - 1).Max()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetFilteredData(ByVal sColumnName As String, ByVal sColumnValue As String, ByRef sListData As List(Of String))
        Try
            Dim iIndex As Integer = -1
            sListData.Clear()

            For iIdx = 1 To sColumn.Count
                If sColumnName = sColumn(iIdx - 1) Then
                    iIndex = iIdx
                    Exit For
                End If
            Next

            If iIndex = -1 Then
                Throw New Exception("Column not found")
            End If

            For Each sDataRow In sData
                Dim sTmp() As String = sDataRow.Split(",")
                If sTmp(iIndex - 1) = sColumnValue Then
                    sListData.Add(sDataRow) 'sListData.Add(sTmp(iIndex - 1))
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub GetColumnValues(ByVal sColumnName As String, ByRef sListData As List(Of String))
        Dim iIdx = 0
        Dim sTemp As String = ""
        Try
            Dim iIndex As Integer = -1

            sListData.Clear()

            For iIdx = 1 To sColumn.Count
                If sColumnName = sColumn(iIdx - 1) Then
                    iIndex = iIdx
                    Exit For
                End If
            Next

            If iIndex = -1 Then
                Throw New Exception("Column not found")
            End If

            For iIdx = 1 To sData.Length
                sTemp = sData(iIdx - 1)
                Dim sTmp() As String = sData(iIdx - 1).Split(",")
                If Not sListData.Contains(sTmp(iIndex - 1)) Then
                    sListData.Add(sTmp(iIndex - 1))
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message + sTemp)
        End Try
    End Sub

    Public Sub ReadCSV(ByVal sFile As String, ByRef sListColumns As List(Of String))
        Try
            Dim sTmp() As String
            Dim sTemp As String
            sListColumns.Clear()
            sData = File.ReadAllLines(sFile)
            ReDim sData(sData.Length - 2)

            For Each Line As String In File.ReadLines(sFile)
                sTmp = Line.Split(",")
                ReDim sColumn(sTmp.Length)

                For iIdxTmp = 1 To sTmp.Length
                    sColumn(iIdxTmp - 1) = sTmp(iIdxTmp - 1)
                    sListColumns.Add(sColumn(iIdxTmp - 1))
                Next

                Exit For
            Next

            Dim iIdx As Integer = 0
            For Each Line As String In File.ReadLines(sFile).Skip(1)
                sData(iIdx) = Line
                sTemp = Line
                iIdx += 1
            Next
            'For Each (sDataLine As String In System.IO.File.ReadLines(sDataFile).Skip(1)) 
            'MessageBox.Show(sTemp)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Module
