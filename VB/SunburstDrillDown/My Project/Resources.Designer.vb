﻿Imports System

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
    Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

'        internal Resources()
'        {
'        }

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property

        ''' <summary>
        '''   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        '''&lt;ArrayOfTypeInfo xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        '''  &lt;TypeInfo&gt;
        '''    &lt;Namespace&gt;Commands&lt;/Namespace&gt;
        '''    &lt;TypesCount&gt;99&lt;/TypesCount&gt;
        '''    &lt;NestedNamespaces&gt;
        '''      &lt;TypeInfo&gt;
        '''        &lt;Namespace&gt;Internal&lt;/Namespace&gt;
        '''        &lt;TypesCount&gt;18&lt;/TypesCount&gt;
        '''        &lt;NestedNamespaces /&gt;
        '''      &lt;/TypeInfo&gt;
        '''      &lt;TypeInfo&gt;
        '''        &lt;Namespace&gt;Ribbon&lt;/Namespace&gt;
        '''        &lt;TypesCount&gt;12&lt;/TypesCount&gt;
        '''        &lt;NestedNamespace [rest of string was truncated]&quot;;.
        ''' </summary>
        Friend ReadOnly Property XtraBarsTypes() As String
            Get
                Return ResourceManager.GetString("XtraBarsTypes", resourceCulture)
            End Get
        End Property
    End Module
End Namespace