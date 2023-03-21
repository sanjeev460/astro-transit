Imports astrodiamondDll
Public Class frmPlanetsinRasi



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
            Fill_Ephemeris_default(New Date(NumericUpDown1.Value, 1, 1), New Date(NumericUpDown1.Value, 12, 31))
        End Sub
        Public logo_Stringarray() As String = {"♈", "♉", "♊", "♋", "♌", "♍", "♎", "♏", "♐", "♑", "♒", "♓"}
        Public Sub Fill_Ephemeris_default(startdate As Date, enddate As Date)

            Dim dt As New DataTable

        Dim calobj As New astrocal
            Dim chartlong As Double = -78.489444444444445
            Dim chartlat As Double = 17.407777777777778
            Dim charttz As Single = 5.5
            Dim chartmethod = astrocal.TypeOfMethod.kp
            Dim chartayan = astrocal.TypeOfAyan.Kpnew
            Dim charttype = astrocal.TypeofChart.horary
            Dim nodetype = False
        Dim af As New astrofn

        'Chart INITCAL
        calobj.initcalc(chartmethod, chartayan, charttype, nodetype)  '' false is for nodetype =  Mean Rahu and Mean ketu,  True gives True rahu/ketu

        'dtpDMY.Value = Date.Now

        'DtpDMY_To.Value = Date.Now.AddDays(30)

        '  Dim af As New AstroDll2017.astrofn
        dt.Columns.Add("ChartDate")

        ' For index As Integer = 1 To af.planet_Name.Count - 1
        dt.Columns.Add("Rasino")
        dt.Columns.Add("Rasi")
        dt.Columns.Add("PlanetName")
        dt.Columns.Add("IsRetro")
        dt.Columns.Add("Decdeg")
        dt.Columns.Add("s-sl-ssl")
        dt.Columns.Add("continous")
        ' dgdEphemeris.Columns(index).DefaultCellStyle.Format = "N4"

        'Next
        '  dt_Tip = dt.Clone

        Dim chartStdate As Date = startdate
            Dim chartTodate As Date = enddate




            Dim datediff As Integer = (chartTodate - chartStdate).Days



            ''Chart INITCAL
            calobj.initcalc(chartmethod, chartayan, charttype, nodetype)  '' false is for nodetype =  Mean Rahu and Mean ketu,  True gives True rahu/ketu

            For index As Integer = 0 To datediff
                Dim chartdate As Date = chartStdate.AddDays(index)

                Dim charttime As Date = New DateTime(chartdate.Year, chartdate.Month, chartdate.Day, dtpHMS.Value.Hour, dtpHMS.Value.Minute, dtpHMS.Value.Second)
                Dim chartist As Double = af.Date2IST(charttime)

                'Dim current As New astrodiamondDll.astrocal


                'Planetcaliculations
                calobj.planetcal(chartdate.Day, chartdate.Month, chartdate.Year, chartist, charttz, chartlong, chartlat) ' -78.48389, 17.40778)


            For Pindex As Integer = 1 To 9
                    Dim planetval = calobj.planetvalue(Pindex)
                    Dim pvalmod30 As Integer = calobj.degOfLong(planetval) Mod 30

                    If pvalmod30 = 0 Then

                        Dim isplanetretro = calobj.planetretro(Pindex)
                        Dim r As String = IIf(isplanetretro, "R", "")
                    Dim drow As DataRow = dt.NewRow
                    drow("ChartDate") = chartdate.ToString("dd MMM")
                    drow("PlanetName") = af.planet_Name(Pindex)
                    drow("IsRetro") = r

                    ' dgdEphemeris.Rows(index).Cells(Pindex).ToolTipText = af.starlord(planetval).ToString + "-" + af.sublord(planetval).ToString + "-" + af.subsublord(planetval).ToString
                    'dgdEphemeris.Rows(index).Cells(Pindex).Value = af.rasi(calobj.planetvalue(Pindex)).ToLowerInvariant() + " " + pvalmod30.ToString + "°" + calobj.minOfLong(calobj.planetvalue(Pindex)).ToString + "'" + r
                    '  drow(Pindex) = logo_Stringarray(Array.IndexOf(af.sign, af.rasi(calobj.planetvalue(Pindex)).ToUpper) - 1) + " " + pvalmod30.ToString + "°" + calobj.minOfLong(calobj.planetvalue(Pindex)).ToString + "'" + r
                    drow("Rasino") = af.rasinumber(calobj.planetvalue(Pindex))
                    drow("Rasi") = logo_Stringarray(af.rasinumber(calobj.planetvalue(Pindex)) - 1)

                        drow("Decdeg") = logo_Stringarray(af.rasinumber(calobj.planetvalue(Pindex)) - 1) + " " + pvalmod30.ToString + "°" + calobj.minOfLong(calobj.planetvalue(Pindex)).ToString + "'" + r

                    'drow_Tip(_index) = planetval.ToString + "," + af.starlord(planetval).ToString + "-" + af.sublord(planetval).ToString + "-" + af.subsublord(planetval).ToString + "," + r + "," + Pindex.ToString
                    drow("s-sl-ssl") = af.starlord(planetval).ToString + "-" + af.sublord(planetval).ToString + "-" + af.subsublord(planetval).ToString

                    Dim prevchartdate = chartdate.AddDays(-1)
                    Dim con = dt.Rows.Count
                    If (con > 0) Then
                        Dim qry = "PlanetName ='" + af.planet_Name(Pindex) + "' and  chartdate = '" + prevchartdate.ToString("dd MMM") + "' and Rasino =" + af.rasinumber(calobj.planetvalue(Pindex)).ToString()

                        con = dt.Select(qry).Length
                    End If


                    drow("continous") = con



                    '_index = _index + 2
                    dt.Rows.Add(drow)

                    End If
                Next

            '  If dt.Rows.Count = 5 Then Exit For

        Next
        dgdEphemeris.DataSource = dt

        fillLstbox(dt.Copy)

    End Sub

    Private Sub fillLstbox(dt As DataTable)
        Dim dv = dt.DefaultView
        Dim lstboxary = {lb1, lb1, lb2, lb3, lb4, lb5, lb6, lb7, lb8, lb9, lb10, lb11, lb12}
        For rasino As Integer = 1 To 12
            dv.RowFilter = "Rasino=" + rasino.ToString() + " and continous=0"
            dv.Sort = "Rasino,PlanetName asc"
            Dim lbdt = dv.ToTable

            Dim lb = lstboxary(rasino)
            lb.Items.Clear()

            lb.Items.Add(logo_Stringarray(rasino - 1))
            For Each rasidrow In lbdt.Rows
                Dim txt = " " + rasidrow("PlanetName") + " " + rasidrow("ChartDate") + IIf(rasidrow("IsRetro") = "", "", " (" + rasidrow("IsRetro") + ")")
                lb.Items.Add(txt)
            Next


        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
            dtpHMS.Value = New Date(2020, 1, 1, 5, 0, 0)
        End Sub

    Private Sub lb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb1.SelectedIndexChanged

    End Sub

    Private Sub lb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb2.SelectedIndexChanged

    End Sub

    Private Sub lb3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb3.SelectedIndexChanged

    End Sub

    Private Sub lb4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb4.SelectedIndexChanged

    End Sub

    Private Sub lb5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb5.SelectedIndexChanged

    End Sub

    Private Sub lb6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb6.SelectedIndexChanged

    End Sub

    Private Sub lb7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb7.SelectedIndexChanged

    End Sub

    Private Sub lb9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb9.SelectedIndexChanged

    End Sub

    Private Sub lb8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb8.SelectedIndexChanged

    End Sub

    Private Sub lb10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb10.SelectedIndexChanged

    End Sub

    Private Sub lb11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb11.SelectedIndexChanged

    End Sub
End Class
