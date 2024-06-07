﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



Namespace Microsoft.ServiceModel.Samples

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.ServiceModel.Samples", ConfigurationName:="Microsoft.ServiceModel.Samples.ICalculator")> _
    Public Interface ICalculator

        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculator/Add", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculator/AddResponse")> _
        Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double

        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculator/Subtract", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculator/SubtractResponse")> _
        Function Subtract(ByVal n1 As Double, ByVal n2 As Double) As Double

        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculator/Multiply", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculator/MultiplyResponse")> _
        Function Multiply(ByVal n1 As Double, ByVal n2 As Double) As Double

        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculator/Divide", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculator/DivideResponse")> _
        Function Divide(ByVal n1 As Double, ByVal n2 As Double) As Double
    End Interface

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
    Public Interface ICalculatorChannel
        Inherits Microsoft.ServiceModel.Samples.ICalculator, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
    Partial Public Class CalculatorClient
        Inherits System.ServiceModel.ClientBase(Of Microsoft.ServiceModel.Samples.ICalculator)
        Implements Microsoft.ServiceModel.Samples.ICalculator

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub

        Public Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double Implements Microsoft.ServiceModel.Samples.ICalculator.Add
            Return MyBase.Channel.Add(n1, n2)
        End Function

        Public Function Subtract(ByVal n1 As Double, ByVal n2 As Double) As Double Implements Microsoft.ServiceModel.Samples.ICalculator.Subtract
            Return MyBase.Channel.Subtract(n1, n2)
        End Function

        Public Function Multiply(ByVal n1 As Double, ByVal n2 As Double) As Double Implements Microsoft.ServiceModel.Samples.ICalculator.Multiply
            Return MyBase.Channel.Multiply(n1, n2)
        End Function

        Public Function Divide(ByVal n1 As Double, ByVal n2 As Double) As Double Implements Microsoft.ServiceModel.Samples.ICalculator.Divide
            Return MyBase.Channel.Divide(n1, n2)
        End Function
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.ServiceModel.Samples", ConfigurationName:="Microsoft.ServiceModel.Samples.ICalculatorSession", SessionMode:=System.ServiceModel.SessionMode.Required)> _
    Public Interface ICalculatorSession

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/Clear")> _
        Sub Clear()

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/AddTo")> _
        Sub AddTo(ByVal n As Double)

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/SubtractFrom")> _
        Sub SubtractFrom(ByVal n As Double)

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/MultiplyBy")> _
        Sub MultiplyBy(ByVal n As Double)

        <System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/DivideBy")> _
        Sub DivideBy(ByVal n As Double)

        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/Result", ReplyAction:="http://Microsoft.ServiceModel.Samples/ICalculatorSession/ResultResponse")> _
        Function Result() As Double
    End Interface

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
    Public Interface ICalculatorSessionChannel
        Inherits Microsoft.ServiceModel.Samples.ICalculatorSession, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
    Partial Public Class CalculatorSessionClient
        Inherits System.ServiceModel.ClientBase(Of Microsoft.ServiceModel.Samples.ICalculatorSession)
        Implements Microsoft.ServiceModel.Samples.ICalculatorSession

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub

        Public Sub Clear() Implements Microsoft.ServiceModel.Samples.ICalculatorSession.Clear
            MyBase.Channel.Clear()
        End Sub

        Public Sub AddTo(ByVal n As Double) Implements Microsoft.ServiceModel.Samples.ICalculatorSession.AddTo
            MyBase.Channel.AddTo(n)
        End Sub

        Public Sub SubtractFrom(ByVal n As Double) Implements Microsoft.ServiceModel.Samples.ICalculatorSession.SubtractFrom
            MyBase.Channel.SubtractFrom(n)
        End Sub

        Public Sub MultiplyBy(ByVal n As Double) Implements Microsoft.ServiceModel.Samples.ICalculatorSession.MultiplyBy
            MyBase.Channel.MultiplyBy(n)
        End Sub

        Public Sub DivideBy(ByVal n As Double) Implements Microsoft.ServiceModel.Samples.ICalculatorSession.DivideBy
            MyBase.Channel.DivideBy(n)
        End Sub

        Public Function Result() As Double Implements Microsoft.ServiceModel.Samples.ICalculatorSession.Result
            Return MyBase.Channel.Result
        End Function
    End Class
End Namespace
