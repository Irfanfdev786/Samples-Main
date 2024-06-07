﻿'----------------------------------------------------------------
' Copyright (c) Microsoft Corporation.  All rights reserved.
'----------------------------------------------------------------
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1434
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports Microsoft.VisualBasic
Imports System

Namespace Microsoft.Samples.Discovery
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), System.ServiceModel.ServiceContractAttribute(Namespace := "http://Microsoft.Samples.Discovery", ConfigurationName := "ICalculatorService")> _
	Public Interface ICalculatorService

		<System.ServiceModel.OperationContractAttribute(ProtectionLevel := System.Net.Security.ProtectionLevel.EncryptAndSign, Action := "http://Microsoft.Samples.Discovery/ICalculatorService/Add", ReplyAction := "http://Microsoft.Samples.Discovery/ICalculatorService/AddResponse")> _
		Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double

		<System.ServiceModel.OperationContractAttribute(ProtectionLevel := System.Net.Security.ProtectionLevel.EncryptAndSign, Action := "http://Microsoft.Samples.Discovery/ICalculatorService/Subtract", ReplyAction := "http://Microsoft.Samples.Discovery/ICalculatorService/SubtractResponse")> _
		Function Subtract(ByVal n1 As Double, ByVal n2 As Double) As Double

		<System.ServiceModel.OperationContractAttribute(ProtectionLevel := System.Net.Security.ProtectionLevel.EncryptAndSign, Action := "http://Microsoft.Samples.Discovery/ICalculatorService/Multiply", ReplyAction := "http://Microsoft.Samples.Discovery/ICalculatorService/MultiplyResponse")> _
		Function Multiply(ByVal n1 As Double, ByVal n2 As Double) As Double

		<System.ServiceModel.OperationContractAttribute(ProtectionLevel := System.Net.Security.ProtectionLevel.EncryptAndSign, Action := "http://Microsoft.Samples.Discovery/ICalculatorService/Divide", ReplyAction := "http://Microsoft.Samples.Discovery/ICalculatorService/DivideResponse")> _
		Function Divide(ByVal n1 As Double, ByVal n2 As Double) As Double
	End Interface

	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
	Public Interface ICalculatorServiceChannel
	Inherits ICalculatorService, System.ServiceModel.IClientChannel
	End Interface

	<System.Diagnostics.DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
	Partial Public Class CalculatorServiceClient
		Inherits System.ServiceModel.ClientBase(Of ICalculatorService)
		Implements ICalculatorService

		Public Sub New()
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

		Public Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ICalculatorService.Add
			Return MyBase.Channel.Add(n1, n2)
		End Function

		Public Function Subtract(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ICalculatorService.Subtract
			Return MyBase.Channel.Subtract(n1, n2)
		End Function

		Public Function Multiply(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ICalculatorService.Multiply
			Return MyBase.Channel.Multiply(n1, n2)
		End Function

		Public Function Divide(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ICalculatorService.Divide
			Return MyBase.Channel.Divide(n1, n2)
		End Function
	End Class
End Namespace
