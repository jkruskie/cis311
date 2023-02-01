Imports System.IO

'------------------------------------------------------------
'-                File Name : Assignment3.vb                - 
'-                Part of Project: DiseaseTracker           -
'------------------------------------------------------------
'-                Written By: Justin T. Kruskie             -
'-                Written On: January 28, 2023              -
'------------------------------------------------------------
'- File Purpose:                                            -
'-                                                          -
'- This file contains the main program for the Disease      -
'- Tracker program. The program will read in a file of      -
'- disease records and generate a report based on the       -
'- records.                                                 -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- The purpose of this program is to handle the disease     -
'- tracking and reporting the diseases that are being       -
'- reported.                                                -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- (None)                                                   -
'------------------------------------------------------------

Module Assignment3
    '---------------------------------------------------------------------------------------
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '---------------------------------------------------------------------------------------
    Const HEALTHCENTERNAME As String = "Mad Man's Disease Reporting Center"
    Const HISTOGRAMSCALE As Integer = 50


    Sub Main()
        '------------------------------------------------------------
        '-            Subprogram Name: Main                         -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 28, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is the main program for the Disease      -
        '- Tracker program. The program will read in a file of      -
        '- disease records and generate a report based on the       -
        '- records.                                                 -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- strFileName - The file name of the disease records       -
        '- strReportFileName - The file name of the report to       -
        '-  be saved                                                -
        '------------------------------------------------------------

        ' Set console properties
        ' Title
        Console.Title = "Assignment 3 Disease Reporter 4000"
        ' Background color blue
        Console.BackgroundColor = ConsoleColor.Blue
        ' Text color yellow
        Console.ForegroundColor = ConsoleColor.Yellow
        ' Font 
        Console.OutputEncoding = System.Text.Encoding.UTF8

        ' Clear the console for the changes to take place
        Console.Clear()

        ' File name for the disease records
        Dim strFileName As String

        ' Ask user to enter a file name
        Console.Write("Enter a file name: ")
        strFileName = Console.ReadLine()

        ' Check if the file exists
        If File.Exists(strFileName) Then
            ' File exists
            ' Create a new list of DiseaseRecords from the return of
            ' the IngestRecordFile function
            Dim lstDiseaseRecords As List(Of DiseaseRecord) = IngestRecordFile(strFileName)
            ' Console log report generation completed
            Console.WriteLine("Report File Generation Completed...")
            ' Ask user for file name and directory to save the report
            Console.Write("Enter a file name and directory to save the report: ")
            ' Get the file name and directory from the user
            Dim strReportFileName As String = Console.ReadLine()
            GenerateReport(strReportFileName, lstDiseaseRecords)

            ' Ask user if they want to view the report
            Console.Write("View report? (Y/N): ")
            ' Listen for the user to press a key
            Dim chrUserInput As Char = Console.ReadKey().KeyChar
            ' Check if the user pressed Y
            If chrUserInput = "Y" Or chrUserInput = "y" Then
                ' User pressed Y
                ' Generate the report and display it
                ViewReport(strReportFileName)
            Else
                ' Close app sub
                CloseApp()
            End If
        Else
            ' Clear the screen
            Console.Clear()
            ' File does not exist
            Console.WriteLine("File does not exist")
            ' Close app sub
            CloseApp()
            End
        End If

    End Sub

    Private Sub ViewReport(strReportFileName As String)
        '------------------------------------------------------------
        '-            Subprogram Name: ViewReport                   -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 28, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine will open the report file and display    -
        '- the report to the user.                                  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strReportFileName - The file name of the report to       -
        '-  be saved                                                -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- strReport - The report to be displayed                   -
        '------------------------------------------------------------

        ' Try to open the file
        Try
            ' Open the file
            Using sr As New StreamReader(strReportFileName)
                ' Read the file
                Dim strReport As String = sr.ReadToEnd()
                ' Clear the console
                Console.Clear()
                ' Console log the report
                Console.WriteLine(strReport)
                ' Ask user to any key to close
                Console.WriteLine("Press any key to close")
                ' Listen for the user to press any key
                Console.ReadKey()
            End Using
        Catch ex As Exception
            ' Error opening file
            Console.WriteLine("Error opening file")
            ' Close app sub
            CloseApp()
        End Try
    End Sub

    Private Sub GenerateReport(ByRef strFileName As String, lstDiseaseRecords As List(Of DiseaseRecord))
        '------------------------------------------------------------
        '-            Subprogram Name: GenerateReport               -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 28, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine will generate a report based on the      -
        '- disease records.                                         -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strFileName - The file name of the report to be saved    -
        '- lstDiseaseRecords - The list of disease records          -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- dateOldestDate - The oldest date in the list of          -
        '-  disease records                                         -
        '- dateNewestDate - The newest date in the list of          -
        '-  disease records                                         -
        '- strDateRange - The date range of the disease records     -
        '- intUniqueDiseases - The number of unique diseases        -
        '- lstDiseaseCount - The count of diseases                  -
        '- lstDiseaseName - The name of the diseases                -
        '- maxCount - The max number of occurrences of a disease    -
        '- maxCountCeiling - The max number of occurrences of a     -
        '-  disease rounded up to the nearest 10                   -
        '- scaleIncrement - The increment of the scale              -
        '- scalePadding - The padding of the scale                  -
        '- scaleFormat - The format of the scale                    -
        '- scaleList - The list of the scale                        -
        '------------------------------------------------------------

        Try
            Using sw As New StreamWriter(strFileName)
                ' Write the header of the report
                sw.WriteLine(HEALTHCENTERNAME)

                ' Get the oldest date from the list of DiseaseRecords using LINQ
                Dim dateOldestDate As Date = lstDiseaseRecords.Min(Function(x) x.dateVisitDate)
                ' Get the newest date from the list of DiseaseRecords using LINQ
                Dim dateNewestDate As Date = lstDiseaseRecords.Max(Function(x) x.dateVisitDate)
                ' Create a string for the date range
                ' "Disease Report for the period mm-dd-yyyy - mm-dd-yyyy"
                Dim strDateRange As New System.Text.StringBuilder
                strDateRange.Append("Disease Report for the period ")
                strDateRange.Append(dateOldestDate.ToShortDateString)
                strDateRange.Append(" - ")
                strDateRange.Append(dateNewestDate.ToShortDateString)

                ' Write the date range of the report to the file
                sw.WriteLine(strDateRange)

                ' Write the total number of visitors to the file
                sw.WriteLine("Total number of visitors: " & lstDiseaseRecords.Count)

                ' Get the number of unique diseases using LINQ
                Dim intUniqueDiseases As Integer = lstDiseaseRecords.Select(Function(x) x.strDiseaseClassification).Distinct.Count
                ' Write the number of unique diseases to the file
                sw.WriteLine("Number of unique diseases: " & intUniqueDiseases)

                ' Create a relative histogram of the diseases in ascending order
                ' Get the number of each disease using LINQ and sort in ascending order
                Dim lstDiseaseCount As List(Of Integer) = lstDiseaseRecords.
                    GroupBy(Function(x) x.strDiseaseClassification).
                    Select(Function(x) x.Count).
                    OrderBy(Function(x) x).ToList
                ' Get the name of each disease using LINQ and sort in the same order as the count list
                Dim lstDiseaseName As List(Of String) = lstDiseaseRecords.
                    GroupBy(Function(x) x.strDiseaseClassification).
                    Select(Function(x) x.Key).
                    OrderBy(Function(x) lstDiseaseRecords.
                    GroupBy(Function(y) y.strDiseaseClassification).
                    Where(Function(z) z.Key = x).Select(Function(z) z.Count).
                    FirstOrDefault).ToList

                ' Get the maximum number of occurrences
                Dim maxCount As Integer = lstDiseaseCount.Max()

                ' Write the formatted histogram of the diseases to the file
                For i As Integer = 0 To lstDiseaseCount.Count - 1
                    ' Write the disease name to the file
                    sw.Write(lstDiseaseName(i).PadRight(25))
                    ' Write the number of times the disease occurred to the file
                    sw.Write(lstDiseaseCount(i).ToString().PadLeft(5))
                    ' Write the relative histogram to the file
                    sw.WriteLine(" " & New String("*"c, CInt(lstDiseaseCount(i) / maxCount * HISTOGRAMSCALE)))
                Next



                sw.WriteLine()
                Dim maxCountCeiling As Integer = CInt(Math.Ceiling(maxCount / 10.0)) * 10
                Dim scaleIncrement As Integer = 10
                Dim scalePadding As Integer = 50 \ (maxCountCeiling \ scaleIncrement)
                If scalePadding < 0 Then
                    scalePadding = 0
                End If

                Dim scaleFormat As String = "".PadLeft(scalePadding - 5, " "c) & "" & "".PadLeft(scalePadding - 5, " "c)

                Dim scaleList As List(Of Integer) = New List(Of Integer)()
                For i As Integer = 0 To maxCountCeiling Step scaleIncrement
                    scaleList.Add(i)
                Next

                sw.WriteLine("Scale:".PadRight(30) & String.Join(scaleFormat, scaleList.Select(Function(i) i.ToString().PadLeft(2))))
            End Using

        Catch ex As Exception
            ' Some issue happen while writing the file
            Console.WriteLine("Error writing file")
            ' Close app sub
            CloseApp()

        End Try
    End Sub

    Private Sub CloseApp()
        '------------------------------------------------------------
        '-            Subprogram Name: CloseApp                     -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 28, 2023              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                       -
        '-                                                          -
        '- This subprogram closes the application.                   -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (none)                                                    -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):               -
        '- (none)                                                    -
        '------------------------------------------------------------

        ' Clear the screen
        Console.Clear()
        ' Ask user to any key to close
        Console.WriteLine("Press any key to close")
        ' Listen for the user to press any key
        Console.ReadKey()
    End Sub

    Private Function IngestRecordFile(ByRef strFileName As String) As List(Of DiseaseRecord)
        '------------------------------------------------------------
        '-            Function Name: IngestRecordFile               -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: January 28, 2023              -
        '------------------------------------------------------------
        '- Function Purpose:                                         -
        '-                                                          -
        '- This function reads the file and creates a list of       -
        '- DiseaseRecords.                                          -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- strFileName - The name of the file to read               -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):               -
        '- lstDiseaseRecords - The list of DiseaseRecords           -
        '- strLine - The current line of the file                   -
        '- strLineArray - The array of strings from the current     -
        '-                line of the file                          -
        '- objDiseaseRecord - The current DiseaseRecord             -
        '------------------------------------------------------------
        '- Returns:                                                 -
        '- List(Of DiseaseRecord) - The list of DiseaseRecords      -
        '------------------------------------------------------------

        ' Create a new list of DiseaseRecords
        Dim lstDiseaseRecords As New List(Of DiseaseRecord)
        ' Loop through each line of the file
        For Each strLine As String In File.ReadLines(strFileName)
            ' Split the line into an array of strings
            Dim strLineArray() As String = strLine.Split(vbTab)
            ' Create a new DiseaseRecord
            Dim objDiseaseRecord As New DiseaseRecord
            ' Set the properties of the DiseaseRecord
            objDiseaseRecord.strPatientId = strLineArray(0)
            objDiseaseRecord.strPatientFirstName = strLineArray(1)
            objDiseaseRecord.strPatientLastName = strLineArray(2)
            objDiseaseRecord.dateVisitDate = strLineArray(3)
            objDiseaseRecord.strDiseaseClassification = strLineArray(4)
            ' Add the DiseaseRecord to the list
            lstDiseaseRecords.Add(objDiseaseRecord)
        Next
        ' Return the list of DiseaseRecords
        Return lstDiseaseRecords
    End Function
End Module
