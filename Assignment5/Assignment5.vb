Module Assignment5
    '------------------------------------------------------------
    '-                File Name : Assignment5.vb                - 
    '-                Part of Project: Assignment5              -
    '------------------------------------------------------------
    '-                Written By: Justin T. Kruskie             -
    '-                Written On: February 14, 2023             -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the main program for the assignment 5 -
    '- project. This program will read in a file containing    -
    '- employee information and then output three reports.      -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '-                                                          -
    '- The purpose of this program is to handle the input and   -
    '- output of the employee information.                      -
    '- The program will read in a file containing employee      -
    '- information and then output three reports as specified   -
    '- in the assignment.                                       -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- (None)                                                   -
    '------------------------------------------------------------

    '---------------------------------------------------------------------------------------
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '--- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS --- GLOBAL CONSTANTS ---
    '---------------------------------------------------------------------------------------
    ' Header name
    Const CONST_HEADER As String = "Cybertech Manufacturing"
    ' Report names
    Const CONST_SALES_REPORT_ID As String = "Sales Report by ID"
    Const CONST_SALES_REPORT_NAME As String = "Sales Report by Name"
    Const CONST_SALES_VALUE_STAT As String = "Sales Value Statistics"


    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------
    Sub Main()
        '------------------------------------------------------------
        '-            Subprogram Name: Main                         -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 14, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is the main program for the assignment 5 -
        '- project. This program will read in a file containing    -
        '- employee information and then output three reports.      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- fileName - The name of the file to be read               -
        '- fileExists - Boolean to check if the file exists         -
        '- employees - List of employees                            -
        '- reader - Stream reader to read the file                  -
        '- line - The current line being read                       -
        '- lineParts - The parts of the line being read             -
        '- employee - The current employee being read               -
        '------------------------------------------------------------

        ' Filename to be read
        Dim fileName As String
        ' Boolean file exists check
        Dim fileExists As Boolean = False
        ' List of employees
        Dim employees As New List(Of Employee)
        ' Stream reader to read file
        Dim reader As IO.StreamReader

        ' Get file name and check if it exists
        While Not fileExists
            ' Prompt user for filename
            Console.Write("Enter filename: ")
            fileName = Console.ReadLine()

            ' Check if file exists
            If IO.File.Exists(fileName) Then
                fileExists = True
            End If
        End While

        ' Open the file
        reader = IO.File.OpenText(fileName)
        While Not reader.EndOfStream
            ' Read a line from the file
            Dim line As String = reader.ReadLine()
            ' Split the line by spaces
            Dim lineParts As String() = line.Split(" "c)
            ' Create a new employee
            Dim employee As New Employee(lineParts)
            ' Add the employee to the list
            employees.Add(employee)
        End While

        ' Close the file
        reader.Close()

        '------------------------------------------------------------------------
        ' First report
        '------------------------------------------------------------------------
        PrintSalesByIdReport(CONST_SALES_REPORT_ID, employees)

        '------------------------------------------------------------------------
        ' Divider line
        '------------------------------------------------------------------------
        PrintReportDivider()

        '------------------------------------------------------------------------
        ' Second report
        '------------------------------------------------------------------------
        PrintSalesByNameReport(CONST_SALES_REPORT_NAME, employees)

        '------------------------------------------------------------------------
        ' Divider line
        '------------------------------------------------------------------------
        PrintReportDivider()

        '------------------------------------------------------------------------
        ' Third report
        '------------------------------------------------------------------------
        PrintSalesAverage(CONST_SALES_VALUE_STAT, employees)

        '------------------------------------------------------------------------
        ' Divider line
        '------------------------------------------------------------------------
        PrintReportDivider()

        ' Promot user to enter key to quit
        Console.WriteLine("Press any key to quit...")
        Console.ReadKey()
    End Sub

    Private Sub PrintReportDivider()
        '------------------------------------------------------------
        '-            Subprogram Name: PrintReportDivider            -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 14, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine will print a divider line to the console -
        '- to separate the reports.                                 -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        Console.WriteLine()
        Console.WriteLine("------------------------------------------------------------------------------------------")
        Console.WriteLine()
    End Sub

    Private Sub PrintSalesByIdReport(reportName As String, employees As List(Of Employee))
        '------------------------------------------------------------
        '-            Subprogram Name: PrintSalesByIdReport         -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 14, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine will print the sales by ID report to the -
        '- console.                                                 -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- reportName - The name of the report                      -
        '- employees - The list of employees                        -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- headerWidth - The width of the header                    -
        '- sortedEmployees - The list of employees sorted by ID     -
        '------------------------------------------------------------

        ' Output the header centered in the console
        Dim headerWidth As Integer = CInt(Math.Floor(Console.WindowWidth / 2 + CONST_HEADER.Length / 2))
        Console.WriteLine("{0," & headerWidth & "}", CONST_HEADER)
        ' Output the sales type centered
        Console.WriteLine("{0," & (Console.WindowWidth / 2 + reportName.Length / 2) & "}", reportName)
        ' Output the column headers of the employee
        Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}{7,-10}", "Name", "ID", "Mon", "Tue", "Wed", "Thu", "Fri", "Total")
        ' Divider line of dashes
        Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}{7,-10}",
            New String("-"c, 20), New String("-"c, 10), New String("-"c, 10),
            New String("-"c, 10), New String("-"c, 10), New String("-"c, 10),
            New String("-"c, 10), New String("-"c, 10)
        )
        ' Get the employees sorted by their id
        Dim sortedEmployees = From employee In employees
                              Order By employee.intID
                              Select employee
        ' Loop through the employees
        For Each employee In sortedEmployees
            ' Output the employee's information
            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}{7,-10}",
                   employee.strFirstName & " " & employee.strLastName, employee.intID,
                   employee.sngMonSales.ToString("C"), employee.sngTueSales.ToString("C"),
                   employee.sngWedSales.ToString("C"), employee.sngThuSales.ToString("C"),
                   employee.sngFriSales.ToString("C"), employee.sngTotalSales.ToString("C"))
        Next
    End Sub


    Private Sub PrintSalesByNameReport(reportName As String, employees As List(Of Employee))
        '------------------------------------------------------------
        '-            Subprogram Name: PrintSalesByNameReport       -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 14, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine will print the sales by name report to   -
        '- the console.                                             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- reportName - The name of the report                      -
        '- employees - The list of employees                        -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- headerWidth - The width of the header                    -
        '- sortedEmployees - The list of employees sorted by name   -
        '------------------------------------------------------------

        ' Output the header centered in the console
        Dim headerWidth As Integer = CInt(Math.Floor(Console.WindowWidth / 2 + CONST_HEADER.Length / 2))
        Console.WriteLine("{0," & headerWidth & "}", CONST_HEADER)
        ' Output the sales type centered
        Console.WriteLine("{0," & (Console.WindowWidth / 2 + reportName.Length / 2) & "}", reportName)
        ' Output the column headers of the employee
        Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}{7,-10}", "Name", "ID", "Mon", "Tue", "Wed", "Thu", "Fri", "Total")
        ' Divider line of dashes
        Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}{7,-10}",
            New String("-"c, 20), New String("-"c, 10), New String("-"c, 10),
            New String("-"c, 10), New String("-"c, 10), New String("-"c, 10),
            New String("-"c, 10), New String("-"c, 10)
        )
        ' Get the employees sorted by their last name
        Dim sortedEmployees = From employee In employees
                              Order By employee.strLastName
                              Select employee
        ' Loop through the employees
        For Each employee In sortedEmployees
            ' Output the employee's information
            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}{7,-10}",
                   employee.strFirstName & " " & employee.strLastName, employee.intID,
                   employee.sngMonSales.ToString("C"), employee.sngTueSales.ToString("C"),
                   employee.sngWedSales.ToString("C"), employee.sngThuSales.ToString("C"),
                   employee.sngFriSales.ToString("C"), employee.sngTotalSales.ToString("C"))
        Next
    End Sub


    Private Sub PrintSalesAverage(reportName As String, employees As List(Of Employee))
        '------------------------------------------------------------
        '-            Subprogram Name: PrintSalesAverage            -
        '------------------------------------------------------------
        '-                Written By: Justin T. Kruskie             -
        '-                Written On: February 14, 2023             -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine will print the sales average report to   -
        '- the console.                                             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- reportName - The name of the report                      -
        '- employees - The list of employees                        -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- headerWidth - The width of the header                    -
        '- avgTotalSales - The average total sales                  -
        '- employeesBelowAverage - The number of employees below    -
        '-                         the average                      -
        '- employeeCount - The number of employees                  -
        '- employeesAboveAverage - The number of employees above    -
        '-                         the average                      -
        '------------------------------------------------------------

        ' LINQ documentation:
        ' Min - https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min?view=netframework-4.8
        ' Max - https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.max?view=netframework-4.8
        ' Average - https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=netframework-4.8

        ' Output the header centered in the console
        Dim headerWidth As Integer = CInt(Math.Floor(Console.WindowWidth / 2 + CONST_HEADER.Length / 2))
        Console.WriteLine("{0," & headerWidth & "}", CONST_HEADER)
        ' Output the sales type centered
        Console.WriteLine("{0," & (Console.WindowWidth / 2 + reportName.Length / 2) & "}", reportName)
        ' Column headers
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}", " ", "Mon", "Tue", "Wed", "Thu", "Fri", "Total")

        ' Output the low sales
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
            "Low", employees.Min(Function(x) x.sngMonSales).ToString("C"),
            employees.Min(Function(x) x.sngTueSales).ToString("C"),
            employees.Min(Function(x) x.sngWedSales).ToString("C"),
            employees.Min(Function(x) x.sngThuSales).ToString("C"),
            employees.Min(Function(x) x.sngFriSales).ToString("C"),
            employees.Min(Function(x) x.sngTotalSales).ToString("C")
        )

        ' Output the average sales
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
            "Ave", employees.Average(Function(x) x.sngMonSales).ToString("C"),
            employees.Average(Function(x) x.sngTueSales).ToString("C"),
            employees.Average(Function(x) x.sngWedSales).ToString("C"),
            employees.Average(Function(x) x.sngThuSales).ToString("C"),
            employees.Average(Function(x) x.sngFriSales).ToString("C"),
            employees.Average(Function(x) x.sngTotalSales).ToString("C")
        )

        ' Output the high sales
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
            "High", employees.Max(Function(x) x.sngMonSales).ToString("C"),
            employees.Max(Function(x) x.sngTueSales).ToString("C"),
            employees.Max(Function(x) x.sngWedSales).ToString("C"),
            employees.Max(Function(x) x.sngThuSales).ToString("C"),
            employees.Max(Function(x) x.sngFriSales).ToString("C"),
            employees.Max(Function(x) x.sngTotalSales).ToString("C")
        )
        ' Divider
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
            New String("-"c, 10), New String("-"c, 10), New String("-"c, 10),
            New String("-"c, 10), New String("-"c, 10), New String("-"c, 10),
            New String("-"c, 10)
        )

        ' Output the total sales
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}",
            "Total", employees.Sum(Function(x) x.sngMonSales).ToString("C"),
            employees.Sum(Function(x) x.sngTueSales).ToString("C"),
            employees.Sum(Function(x) x.sngWedSales).ToString("C"),
            employees.Sum(Function(x) x.sngThuSales).ToString("C"),
            employees.Sum(Function(x) x.sngFriSales).ToString("C"),
            employees.Sum(Function(x) x.sngTotalSales).ToString("C")
        )

        ' New line
        Console.WriteLine()

        ' Get the employees below the average
        Dim avgTotalSales = employees.Average(Function(e) e.sngTotalSales)
        Dim employeesBelowAverage = employees.Where(Function(e) e.sngTotalSales < avgTotalSales)
        Dim employeeCount = employeesBelowAverage.Count()
        ' Output the number of employees below the average
        Console.WriteLine("{0} employee{1} below the average.", employeeCount, If(employeeCount = 1, "", "s"))

        ' New line
        Console.WriteLine()

        ' Get the employees above the average
        Dim employeesAboveAverage = employees.Where(Function(e) e.sngTotalSales > avgTotalSales)
        employeeCount = employeesAboveAverage.Count()
        ' Output the number of employees above the average
        Console.WriteLine("{0} employee{1} above the average.", employeeCount, If(employeeCount = 1, "", "s"))

        ' Names of employees above average
        Console.WriteLine("Names of employees above average:")
        ' In alphabetical order
        ' You didn't specifify if it was first or last name, so I'm assuming last name
        ' like the other report
        For Each employee In employeesAboveAverage.OrderBy(Function(e) e.strLastName)
            Console.WriteLine(employee.strFirstName & " " & employee.strLastName)
        Next

    End Sub

End Module
