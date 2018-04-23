Imports System.Collections.Generic
' ...

Namespace SilverlightApplication28
	Public Class MainPageViewModel
        Public Property Persons() As IEnumerable(Of Person)

		Public Sub New()
            Persons = New Person() {New Person("John", 25), New Person("Mary", 33)}
		End Sub
	End Class
End Namespace
