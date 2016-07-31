Imports Microsoft.VisualBasic
Imports System
Imports System.Security.Permissions
Imports Microsoft.Win32
' link de referenci https://msdn.microsoft.com/es-es/library/microsoft.win32.registrykey(v=vs.71).aspx
<Assembly: RegistryPermissionAttribute(
    SecurityAction.RequestMinimum, All:="HKEY_LOCAL_MACHINE")>

Public Class RegKey
    Shared Sub Main()

        ' Create a subkey named Test9999 under HKEY_CURRENT_USER.
        Dim Software As RegistryKey =
            Registry.LocalMachine.CreateSubKey("Software")

        ' Create two subkeys under HKEY_CURRENT_USER\Test9999.
        'test9999.CreateSubKey("TestName").Close()
        Dim BusqLey As RegistryKey = Software.CreateSubKey("BusqLey")

        ' Create data for the TestSettings subkey.
        BusqLey.SetValue("llave", "1238|2259|2778|2345|-ACEHMNOPPRTY")
        'testSettings.SetValue("Level", "Intermediate")
        'testSettings.SetValue("ID", 123)
        'testSettings.SetValue("Password", "Secret")
        'testSettings.Close()

        ' Print the information from the Test9999 subkey.
        'Console.WriteLine("There are {0} subkeys under Test9999.",
        'test9999.SubKeyCount.ToString())
        'For Each subKeyName As String In test9999.GetSubKeyNames()
        'Dim tempKey As RegistryKey =
        'test9999.OpenSubKey(subKeyName)
        'Console.WriteLine(vbCrLf & "There are {0} values for " &
        '"{1}.", tempKey.ValueCount.ToString(), tempKey.Name)
        'For Each valueName As String In tempKey.GetValueNames()
        'Console.WriteLine("{0,-8}: {1}", valueName,
        'tempKey.GetValue(valueName).ToString())
        'Next
        'Next

        ' Delete the non-secure password value.
        'testSettings = test9999.OpenSubKey("TestSettings", True)
        'testSettings.DeleteValue("password")

        ' Verify the deletion.
        'Console.WriteLine(CType(testSettings.GetValue(
        '"password", "Password not found."), String))
        'testSettings.Close()

        ' Delete or close the new subkey.
        'Software.Close()
        Console.Write(vbCrLf & "Delete newly created " &
            "registry key? (Y/N) ")
        If Char.ToUpper(Convert.ToChar(Console.Read())) = "Y"c Then
            Software.DeleteSubKeyTree("BusqLey")
            Console.WriteLine(vbCrLf & "Registry key {0} deleted.",
                BusqLey.Name)
        Else
            Console.WriteLine(vbCrLf & "Registry key {0} closed.",
                BusqLey.ToString())
            BusqLey.Close()
        End If

    End Sub
End Class