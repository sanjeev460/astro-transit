Imports astrodiamondDll

Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Fill_Ephemeris_default(New Date(NumericUpDown1.Value, 1, 1), New Date(NumericUpDown1.Value, 12, 31))
    End Sub
    Public logo_Stringarray() As String = {"♈", "♉", "♊", "♋", "♌", "♍", "♎", "♏", "♐", "♑", "♒", "♓"}
    Public Sub Fill_Ephemeris_default(startdate As Date, enddate As Date)

        Dim dt As New DataTable
        Dim dt_Tip As New DataTable
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
        dt.Columns.Add("Date")

        ' For index As Integer = 1 To af.planet_Name.Count - 1
        'dt.Columns.Add("")
        dt.Columns.Add("Rasi")
        dt.Columns.Add("PlanetName")
        dt.Columns.Add("Decdeg")
        dt.Columns.Add("s-sl-ssl")
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


            Dim drow_Tip As DataRow = dt_Tip.NewRow



            Dim _index = 1
            For Pindex As Integer = 1 To 9
                Dim planetval = calobj.planetvalue(Pindex)
                Dim pvalmod30 As Integer = calobj.degOfLong(planetval) Mod 30

                If pvalmod30 = 0 Then

                    Dim isplanetretro = calobj.planetretro(Pindex)
                    Dim r As String = IIf(isplanetretro, "R", "")

                    Dim drow As DataRow = dt.NewRow
                    drow("Date") = chartdate.ToString("dd-MMM-yyyy")

                    drow("PlanetName") = af.planet_NameFull(Pindex)

                    ' dgdEphemeris.Rows(index).Cells(Pindex).ToolTipText = af.starlord(planetval).ToString + "-" + af.sublord(planetval).ToString + "-" + af.subsublord(planetval).ToString



                    'dgdEphemeris.Rows(index).Cells(Pindex).Value = af.rasi(calobj.planetvalue(Pindex)).ToLowerInvariant() + " " + pvalmod30.ToString + "°" + calobj.minOfLong(calobj.planetvalue(Pindex)).ToString + "'" + r
                    '  drow(Pindex) = logo_Stringarray(Array.IndexOf(af.sign, af.rasi(calobj.planetvalue(Pindex)).ToUpper) - 1) + " " + pvalmod30.ToString + "°" + calobj.minOfLong(calobj.planetvalue(Pindex)).ToString + "'" + r
                    drow("Rasi") = logo_Stringarray(af.rasinumber(calobj.planetvalue(Pindex)) - 1)

                    drow("Decdeg") = logo_Stringarray(af.rasinumber(calobj.planetvalue(Pindex)) - 1) + " " + pvalmod30.ToString + "°" + calobj.minOfLong(calobj.planetvalue(Pindex)).ToString + "'" + r

                    'drow_Tip(_index) = planetval.ToString + "," + af.starlord(planetval).ToString + "-" + af.sublord(planetval).ToString + "-" + af.subsublord(planetval).ToString + "," + r + "," + Pindex.ToString
                    drow_Tip("s-sl-ssl") = planetval.ToString + "," + af.starlord(planetval).ToString + "-" + af.sublord(planetval).ToString + "-" + af.subsublord(planetval).ToString + "," + r + "," + Pindex.ToString

                    '_index = _index + 2
                    dt.Rows.Add(drow)

                End If
            Next

            '  If dt.Rows.Count = 5 Then Exit For
            dt_Tip.Rows.Add(drow_Tip)
            Next
        dgdEphemeris.DataSource = dt

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtpHMS.Value = New Date(2020, 1, 1, 5, 0, 0)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(1050, 658)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
End Class
