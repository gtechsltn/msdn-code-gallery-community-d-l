﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports __Photo = LightSwitchApplication.Photo

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class Photo
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __Photo, __Photo.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the Photo entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Photo))
            MyBase.New(entitySet)
            
            __Photo.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Photo_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Photo_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return Global.LightSwitchApplication.Application.Current
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(Me.Details.EntitySet.Details.DataService.Details.DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
    
        #Region "Public Properties"
    
        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Id As Integer
            Get
                Return __Photo.DetailsClass.GetValue(Me, __Photo.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __Photo.DetailsClass.SetValue(Me, __Photo.DetailsClass.PropertySetProperties.Id, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property RowVersion As Byte()
            Get
                Return __Photo.DetailsClass.GetValue(Me, __Photo.DetailsClass.PropertySetProperties.RowVersion)
            End Get
            Set
                __Photo.DetailsClass.SetValue(Me, __Photo.DetailsClass.PropertySetProperties.RowVersion, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Picture As Byte()
            Get
                Return __Photo.DetailsClass.GetValue(Me, __Photo.DetailsClass.PropertySetProperties.Picture)
            End Get
            Set
                __Photo.DetailsClass.SetValue(Me, __Photo.DetailsClass.PropertySetProperties.Picture, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Picture_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Picture_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Picture_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Caption As String
            Get
                Return __Photo.DetailsClass.GetValue(Me, __Photo.DetailsClass.PropertySetProperties.Caption)
            End Get
            Set
                __Photo.DetailsClass.SetValue(Me, __Photo.DetailsClass.PropertySetProperties.Caption, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Caption_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Caption_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Caption_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Appointment As Global.LightSwitchApplication.Appointment
            Get
                Return __Photo.DetailsClass.GetValue(Me, __Photo.DetailsClass.PropertySetProperties.Appointment)
            End Get
            Set
                __Photo.DetailsClass.SetValue(Me, __Photo.DetailsClass.PropertySetProperties.Appointment, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Appointment_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Appointment_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Appointment_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __Photo, _
                __Photo.DetailsClass, _
                __Photo.DetailsClass.IImplementation, _
                __Photo.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Photo, __Photo.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Photo, __Photo.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __Photo.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __PhotoEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Photo, __Photo.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Photo, __Photo.DetailsClass).Entry( _
                    AddressOf __Photo.DetailsClass.__Photo_CreateNew, _
                    AddressOf __Photo.DetailsClass.__Photo_Created, _
                    AddressOf __Photo.DetailsClass.__Photo_AllowSaveWithErrors)
            Private Shared Function __Photo_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Photo)) As __Photo
                Return New __Photo(es)
            End Function
            Private Shared Sub __Photo_Created(e As __Photo)
                e.Photo_Created()
            End Sub
            Private Shared Function __Photo_AllowSaveWithErrors(e As __Photo) As Boolean
                Dim result As Boolean = False
                e.Photo_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Photo, __Photo.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Photo, __Photo.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __Photo.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __Photo, __Photo.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Photo.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Photo.DetailsClass.PropertySetProperties.RowVersion),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property Picture As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Photo.DetailsClass.PropertySetProperties.Picture),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property Caption As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Photo.DetailsClass.PropertySetProperties.Caption),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Appointment As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Photo, __Photo.DetailsClass, Global.LightSwitchApplication.Appointment)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Photo.DetailsClass.PropertySetProperties.Appointment),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Photo, __Photo.DetailsClass, Global.LightSwitchApplication.Appointment))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property RowVersion As Byte()
                Shadows Property Picture As Byte()
                Shadows Property Caption As String
                Shadows Property Appointment As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Photo.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Integer).Data), d As __Photo.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __Photo) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __Photo, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __Photo.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __Photo.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __Photo)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()).Entry( _
                        "RowVersion", _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._RowVersion_Stub, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._RowVersion_Validate, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged)
                Private Shared Sub _RowVersion_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Photo.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()).Data), d As __Photo.DetailsClass, sf As Object)
                    c(d, d._RowVersion, sf)
                End Sub
                Private Shared Function _RowVersion_ComputeIsReadOnly(e As __Photo) As Boolean
                    Dim result As Boolean = False
                    e.RowVersion_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RowVersion_Validate(e As __Photo, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RowVersion_Validate(r)
                End Sub
                Private Shared Function _RowVersion_GetImplementationValue(d As __Photo.DetailsClass) As Byte()
                    Return d.ImplementationEntity.RowVersion
                End Function
                Private Shared Sub _RowVersion_SetImplementationValue(d As __Photo.DetailsClass, v As Byte())
                    d.ImplementationEntity.RowVersion = v
                End Sub
                Private Shared Sub _RowVersion_OnValueChanged(e As __Photo)
                    e.RowVersion_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Picture As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()).Entry( _
                        "Picture", _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Picture_Stub, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Picture_ComputeIsReadOnly, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Picture_Validate, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Picture_GetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Picture_SetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Picture_OnValueChanged)
                Private Shared Sub _Picture_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Photo.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()).Data), d As __Photo.DetailsClass, sf As Object)
                    c(d, d._Picture, sf)
                End Sub
                Private Shared Function _Picture_ComputeIsReadOnly(e As __Photo) As Boolean
                    Dim result As Boolean = False
                    e.Picture_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Picture_Validate(e As __Photo, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Picture_Validate(r)
                End Sub
                Private Shared Function _Picture_GetImplementationValue(d As __Photo.DetailsClass) As Byte()
                    Return d.ImplementationEntity.Picture
                End Function
                Private Shared Sub _Picture_SetImplementationValue(d As __Photo.DetailsClass, v As Byte())
                    d.ImplementationEntity.Picture = v
                End Sub
                Private Shared Sub _Picture_OnValueChanged(e As __Photo)
                    e.Picture_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Caption As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, String).Entry( _
                        "Caption", _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Caption_Stub, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Caption_ComputeIsReadOnly, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Caption_Validate, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Caption_GetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Caption_SetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Caption_OnValueChanged)
                Private Shared Sub _Caption_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Photo.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, String).Data), d As __Photo.DetailsClass, sf As Object)
                    c(d, d._Caption, sf)
                End Sub
                Private Shared Function _Caption_ComputeIsReadOnly(e As __Photo) As Boolean
                    Dim result As Boolean = False
                    e.Caption_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Caption_Validate(e As __Photo, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Caption_Validate(r)
                End Sub
                Private Shared Function _Caption_GetImplementationValue(d As __Photo.DetailsClass) As String
                    Return d.ImplementationEntity.Caption
                End Function
                Private Shared Sub _Caption_SetImplementationValue(d As __Photo.DetailsClass, v As String)
                    d.ImplementationEntity.Caption = v
                End Sub
                Private Shared Sub _Caption_OnValueChanged(e As __Photo)
                    e.Caption_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Appointment As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Photo, __Photo.DetailsClass, Global.LightSwitchApplication.Appointment).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Photo, __Photo.DetailsClass, Global.LightSwitchApplication.Appointment).Entry( _
                        "Appointment", _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Appointment_Stub, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Appointment_ComputeIsReadOnly, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Appointment_Validate, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Appointment_GetCoreImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Appointment_GetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Appointment_SetImplementationValue, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Appointment_Refresh, _
                        AddressOf __Photo.DetailsClass.PropertySetProperties._Appointment_OnValueChanged)
                Private Shared Sub _Appointment_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Photo.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Photo, __Photo.DetailsClass, Global.LightSwitchApplication.Appointment).Data), d As __Photo.DetailsClass, sf As Object)
                    c(d, d._Appointment, sf)
                End Sub
                Private Shared Function _Appointment_ComputeIsReadOnly(e As __Photo) As Boolean
                    Dim result As Boolean = False
                    e.Appointment_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Appointment_Validate(e As __Photo, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Appointment_Validate(r)
                End Sub
                Private Shared Function _Appointment_GetCoreImplementationValue(d as __Photo.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.Appointment
                End Function
                Private Shared Function _Appointment_GetImplementationValue(d as __Photo.DetailsClass) As Global.LightSwitchApplication.Appointment
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.Appointment, Global.LightSwitchApplication.Appointment.DetailsClass)(__Photo.DetailsClass.PropertySetProperties.Appointment, d._Appointment)
                End Function
                Private Shared Sub _Appointment_SetImplementationValue(d As __Photo.DetailsClass, v As Global.LightSwitchApplication.Appointment)
                    d.SetImplementationValue(__Photo.DetailsClass.PropertySetProperties.Appointment, d._Appointment, Sub(i, ev) i.Appointment = ev, v)
                End Sub
                Private Shared Sub _Appointment_Refresh(d As __Photo.DetailsClass)
                    d.RefreshNavigationProperty(__Photo.DetailsClass.PropertySetProperties.Appointment, d._Appointment)
                End Sub
                Private Shared Sub _Appointment_OnValueChanged(e As __Photo)
                    e.Appointment_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Picture As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Caption As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Photo, __Photo.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Appointment As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Photo, __Photo.DetailsClass, Global.LightSwitchApplication.Appointment).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
