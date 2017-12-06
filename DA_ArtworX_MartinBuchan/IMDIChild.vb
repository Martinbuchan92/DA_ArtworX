''' <summary>
''' Programmatic interface for an MDI child form
''' </summary>
''' <remarks></remarks>
Public Interface IMDIChild
    Function ProcessAdd() As Boolean
    Function ProcessDelete() As Boolean
    Function ProcessEdit() As Boolean
    Function ProcessFind() As Boolean
    Function ProcessUpdate() As Boolean
    Function ProcessCancel() As Boolean
    Function MoveFirst() As Boolean
    Function MovePrevious() As Boolean
    Function MoveNext() As Boolean
    Function MoveLast() As Boolean
End Interface
