Public Class frmExamples
    Dim api_username As String = "john.doe@domain.com"
    Dim api_password As String = "johnspassword"

    Private Sub btnGetServersInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetServersInfo.Click
        'SOAP Objects
        Dim soap As New vms.VoIPms_Service
        Dim input As New vms.getServersInfoInput
        Dim output As New Object

        'XML Elements
        Dim result_status As Xml.XmlElement
        Dim result_pops As Xml.XmlElement
        Dim pops As Xml.XmlElement
        Dim pop As Xml.XmlElement

        'String Vars
        Dim status As String
        Dim str_pops As String = ""

        'Fill Input Object
        input.api_username = api_username
        input.api_password = api_password
        input.server_pop = txtServerPOP.Text

        'Request Info
        output = soap.getServersInfo(input)

        'Get status
        result_status = output(1)
        status = result_status.ChildNodes(1).InnerText

        If status = "success" Then
            'Get POPs
            result_pops = output(2)
            pops = result_pops.ChildNodes(1)

            For i As Integer = 0 To pops.ChildNodes.Count - 1
                'Get POP
                pop = pops.ChildNodes(i)

                For j As Integer = 0 To pop.ChildNodes.Count - 1
                    'Get Data from POP
                    str_pops = str_pops + pop.ChildNodes(j).ChildNodes(0).InnerText + " => "
                    str_pops = str_pops + pop.ChildNodes(j).ChildNodes(1).InnerText + vbCrLf
                Next

                str_pops = str_pops + vbCrLf
            Next

            MsgBox(str_pops)
        Else
            MsgBox(status)
        End If
    End Sub

    Private Sub btnGetDIDsInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetDIDsInfo.Click
        'SOAP Objects
        Dim soap As New vms.VoIPms_Service
        Dim input As New vms.getDIDsInfoInput
        Dim output As New Object

        'XML Elements
        Dim result_status As Xml.XmlElement
        Dim result_dids As Xml.XmlElement
        Dim dids As Xml.XmlElement
        Dim did As Xml.XmlElement

        'String Vars
        Dim status As String
        Dim str_dids As String = ""

        'Fill Input Object
        input.api_username = api_username
        input.api_password = api_password
        input.client = txtClient.Text
        input.did = txtDID.Text

        'Request Info
        output = soap.getDIDsInfo(input)

        'Get status
        result_status = output(1)
        status = result_status.ChildNodes(1).InnerText

        If status = "success" Then
            'Get DIDs
            result_dids = output(2)
            dids = result_dids.ChildNodes(1)

            For i As Integer = 0 To dids.ChildNodes.Count - 1
                'Get DID
                did = dids.ChildNodes(i)

                For j As Integer = 0 To did.ChildNodes.Count - 1
                    'Get Data from DID
                    str_dids = str_dids + did.ChildNodes(j).ChildNodes(0).InnerText + " => "
                    str_dids = str_dids + did.ChildNodes(j).ChildNodes(1).InnerText + vbCrLf
                Next

                str_dids = str_dids + vbCrLf
            Next

            MsgBox(str_dids)
        Else
            MsgBox(status)
        End If
    End Sub

    Private Sub btnGetBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetBalance.Click
        'SOAP Objects
        Dim soap As New vms.VoIPms_Service
        Dim input As New vms.getBalanceInput
        Dim output As New Object

        'XML Elements
        Dim result_status As Xml.XmlElement
        Dim result_balance As Xml.XmlElement
        Dim balance As Xml.XmlElement

        'String Vars
        Dim status As String
        Dim str_balance As String = ""

        'Fill Input Object
        input.api_username = api_username
        input.api_password = api_password
        input.advanced = chkAdvanced.Checked

        'Request Info
        output = soap.getBalance(input)

        'Get status
        result_status = output(1)
        status = result_status.ChildNodes(1).InnerText

        If status = "success" Then
            'Get Balance
            result_balance = output(2)
            balance = result_balance.ChildNodes(1)

            For i As Integer = 0 To balance.ChildNodes.Count - 1
                'Get Data from Balance
                str_balance = str_balance + balance.ChildNodes(i).ChildNodes(0).InnerText + " => "
                str_balance = str_balance + balance.ChildNodes(i).ChildNodes(1).InnerText + vbCrLf
            Next

            MsgBox(str_balance)
        Else
            MsgBox(status)
        End If
    End Sub
End Class