Private Sub ManufacturerCount()
    
    'This function counts number of items per manufacturer.
    ' Entire column E is named 'manu'
    ' Since it is a lop we do not need to use
    ' Range("A3" & FinalRow).FillDown
    
    FinalRow = Cells(Rows.Count, 2).End(xlUp).Row
         
          Range("A3").Formula = "=COUNTIF(manu,E3)"
          Range("A3" & FinalRow).FillDown
          Range("A3:A" & FinalRow).Value = Range("A3:A" & FinalRow).Value
    
End Sub

Private Sub DownloadedDate()

    FinalRow = Cells(Rows.Count, 12).End(xlUp).Row  ' Find the last row

    'Loop to fill function to extract the date and convert into values
         Range("L3").Formula = "=CONCATENATE(MID(J3,5,6),"","" , RIGHT(J3,4))"
         Range("L3" & FinalRow).FillDown
         Range("L3:L" & FinalRow).Value = Range("L3:L" & FinalRow).Value

End Sub
    
Private Sub CountPerDate()
    
    'This function counts number of items per date.
    'Entire column L is named 'dldate'
    
    FinalRow = Cells(Rows.Count, 2).End(xlUp).Row
           
         Range("M3").Formula = "=COUNTIF(dldate,L3)"
         Range("M3" & FinalRow).FillDown
         Range("M3:M" & FinalRow).Value = Range("M3:M" & FinalRow).Value
      
End Sub
Private Sub GetLetter()
    
    FinalRow = Cells(Rows.Count, 2).End(xlUp).Row
         
         Range("N3").Formula = "=LEFT(E3, 1)"
         Range("N3" & FinalRow).FillDown
         Range("N3:N" & FinalRow).Value = Range("N3:N" & FinalRow).Value
         
   
End Sub

Private Sub LetterGroupAssign()
    'Figure out what the last row is
    FinalRow = Cells(Rows.Count, 14).End(xlUp).Row
    'Below is the loop function to assign letter group to technician:
    For I = 3 To FinalRow
        Select Case Cells(I, 14)
        Case 1, 3, "H", "O", "M", "Y", "C"
            Cells(I, 15).Value = "Cindy McComb"
        Case "N", "U", "K"
            Cells(I, 15).Value = "Gwen"
        Case "X", "G", "F", "W", "D", "L", "Z"
            Cells(I, 15).Value = "Matt"
        Case "Q", "V", "S", "I", "R", "E"
            Cells(I, 15).Value = "Leo"
        Case "P", "J", "T", "A", "B"
            Cells(I, 15).Value = "Lina"
        Case Else
            
    End Select
        
    Next I
    
End Sub

Public Sub Assign_Letter_Groups()

    ManufacturerCount
    DownloadedDate
    CountPerDate
    GetLetter
    LetterGroupAssign

End Sub

