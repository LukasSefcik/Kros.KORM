﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kros.KORM.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kros.KORM.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The binary operator &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string BinaryOperatorIsNotSupported {
            get {
                return ResourceManager.GetString("BinaryOperatorIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t call &apos;{0}&apos; if you configured column name or converter..
        /// </summary>
        internal static string CannotCallMethod {
            get {
                return ResourceManager.GetString("CannotCallMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t call multiple time method &apos;{0}&apos;..
        /// </summary>
        internal static string CannotCallMultipleTime {
            get {
                return ResourceManager.GetString("CannotCallMultipleTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot configure anything else if you are call &apos;{0}&apos; or &apos;{1}&apos;.
        /// </summary>
        internal static string CannotConfigureAnythingElse {
            get {
                return ResourceManager.GetString("CannotConfigureAnythingElse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t materialize source value type &apos;{0}&apos; to destination type &apos;{1}&apos; without defined converter..
        /// </summary>
        internal static string CannotMaterializeSourceValue {
            get {
                return ResourceManager.GetString("CannotMaterializeSourceValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a failure to open the database connection at the time the primary keys are generated. Try add &apos;Persist Security Info=TRUE&apos; to the connection string..
        /// </summary>
        internal static string CannotOpenConnectionWhenGeneratingPrimaryKeys {
            get {
                return ResourceManager.GetString("CannotOpenConnectionWhenGeneratingPrimaryKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Primary key of the model is composite. All of its columns must have {0} set to {1}..
        /// </summary>
        internal static string CompositePrimaryKeyCanNotHaveAutoIncrementColumn {
            get {
                return ResourceManager.GetString("CompositePrimaryKeyCanNotHaveAutoIncrementColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Primary key of the model is composite. All of its columns must have unique order..
        /// </summary>
        internal static string CompositePrimaryKeyMustHaveOrderedColumns {
            get {
                return ResourceManager.GetString("CompositePrimaryKeyMustHaveOrderedColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Primary key of the model is composite. The name of the key must be the same for all its columns..
        /// </summary>
        internal static string CompositePrimaryKeyMustHaveSameNameInAllColumns {
            get {
                return ResourceManager.GetString("CompositePrimaryKeyMustHaveSameNameInAllColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration is not allowed if the Build method has already been called..
        /// </summary>
        internal static string ConfigurationIsNotAllowed {
            get {
                return ResourceManager.GetString("ConfigurationIsNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The constant for &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string ConstantIsNotSupported {
            get {
                return ResourceManager.GetString("ConstantIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Converter type must implement implement IConverter interface..
        /// </summary>
        internal static string ConverterTypeIsNotIConverter {
            get {
                return ResourceManager.GetString("ConverterTypeIsNotIConverter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string is not set..
        /// </summary>
        internal static string Error_ConnectionStringNotSet {
            get {
                return ResourceManager.GetString("Error_ConnectionStringNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KORM provider is not set..
        /// </summary>
        internal static string Error_KormProviderNotSet {
            get {
                return ResourceManager.GetString("Error_KormProviderNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add item (hash code = {0}). This item already exists in collection {1}..
        /// </summary>
        internal static string ExistingItemCannotBeAdded {
            get {
                return ResourceManager.GetString("ExistingItemCannotBeAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete item (hash code = {0}). This item already exists in collection {1}..
        /// </summary>
        internal static string ExistingItemCannotBeDeleted {
            get {
                return ResourceManager.GetString("ExistingItemCannotBeDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot edit item (hash code = {0}). This item already exists in collection {1}..
        /// </summary>
        internal static string ExistingItemCannotBeEdited {
            get {
                return ResourceManager.GetString("ExistingItemCannotBeEdited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot delete item with Id = &apos;{0}&apos;. This item with this Id already exists in collection..
        /// </summary>
        internal static string ExistingItemIdCannotBeDeleted {
            get {
                return ResourceManager.GetString("ExistingItemIdCannotBeDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} can be applied only once..
        /// </summary>
        internal static string ExpressionCanBeAppliedOnlyOnce {
            get {
                return ResourceManager.GetString("ExpressionCanBeAppliedOnlyOnce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid type of id parameter. Property which represent primary key is type of &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidIdParameterType {
            get {
                return ResourceManager.GetString("InvalidIdParameterType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Table {0} has none, or composite primary key. Primary key must be one column only..
        /// </summary>
        internal static string InvalidPrimaryKeyForBulkUpdate {
            get {
                return ResourceManager.GetString("InvalidPrimaryKeyForBulkUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inner reader is already set. It can be set only once..
        /// </summary>
        internal static string LimitOffsetDataReaderInnerReaderAlreadySet {
            get {
                return ResourceManager.GetString("LimitOffsetDataReaderInnerReaderAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The member &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string MemberIsNotSupported {
            get {
                return ResourceManager.GetString("MemberIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string MethodIsNotSupported {
            get {
                return ResourceManager.GetString("MethodIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method {0} is not supported when entity has composite primary key..
        /// </summary>
        internal static string MethodNotSupportedForCompositePrimaryKey {
            get {
                return ResourceManager.GetString("MethodNotSupportedForCompositePrimaryKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method {0} is not supported when entity does not have primary key..
        /// </summary>
        internal static string MethodNotSupportedWhenNoPrimaryKey {
            get {
                return ResourceManager.GetString("MethodNotSupportedWhenNoPrimaryKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[__KormMigrationsHistory](
        ///    [MigrationId] [bigint] NOT NULL,
        ///    [MigrationName] [nvarchar](255) NOT NULL,
        ///    [ProductInfo] [nvarchar](255) NOT NULL,
        ///    [Updated] [datetime2] NULL,
        ///    CONSTRAINT [PK___KormMigrationsHistory] PRIMARY KEY CLUSTERED
        ///    (
        ///        [MigrationId] ASC
        ///    )
        ///) ON [PRIMARY]
        ///.
        /// </summary>
        internal static string MigrationsHistoryTableScript {
            get {
                return ResourceManager.GetString("MigrationsHistoryTableScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ModelBuilder instance ({0}) does not have method {1}({2})..
        /// </summary>
        internal static string MissongMethodInModelBuilder {
            get {
                return ResourceManager.GetString("MissongMethodInModelBuilder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot execute query. There are more parameters than values in the query..
        /// </summary>
        internal static string MoreParametersThanValues {
            get {
                return ResourceManager.GetString("MoreParametersThanValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot execute query. There are more values than parameters in the query..
        /// </summary>
        internal static string MoreValuesThanParameters {
            get {
                return ResourceManager.GetString("MoreValuesThanParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property NestedTransaction.CommandTimeout is readonly..
        /// </summary>
        internal static string NestedTransactionCommandTimeoutIsReadonly {
            get {
                return ResourceManager.GetString("NestedTransactionCommandTimeoutIsReadonly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Injection configuration for property &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string NoInjectionConfigurationForProperty {
            get {
                return ResourceManager.GetString("NoInjectionConfigurationForProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing a non generic result is not supported..
        /// </summary>
        internal static string NonGenericExecuteNotSupported {
            get {
                return ResourceManager.GetString("NonGenericExecuteNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a non generic query is not supported..
        /// </summary>
        internal static string NonGenericQueryNotSupported {
            get {
                return ResourceManager.GetString("NonGenericQueryNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one of arguments {0} and {1} must be true, otherwise the use of this converter makes no sense..
        /// </summary>
        internal static string NullAndTrimStringConverter_InvalidArguments {
            get {
                return ResourceManager.GetString("NullAndTrimStringConverter_InvalidArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data type of the parameter must be set, when its value is NULL. Parameter name: {0}..
        /// </summary>
        internal static string ParameterDataTypeNotSet {
            get {
                return ResourceManager.GetString("ParameterDataTypeNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider &apos;{0}&apos; does not support inserting values into table which model &apos;{1}&apos; has set primary key as Identity..
        /// </summary>
        internal static string ProviderDoesNotSupportIdentity {
            get {
                return ResourceManager.GetString("ProviderDoesNotSupportIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string QueryGeneratorMethodNotSupported {
            get {
                return ResourceManager.GetString("QueryGeneratorMethodNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get data type for column [{0}].[{1}]. Column [{1}] does not exist in table [{0}]..
        /// </summary>
        internal static string QueryProviderCouldNotGetDataTypeForColumn {
            get {
                return ResourceManager.GetString("QueryProviderCouldNotGetDataTypeForColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get schema for table [{0}]. Table does not exists..
        /// </summary>
        internal static string QueryProviderCouldNotGetTableSchema {
            get {
                return ResourceManager.GetString("QueryProviderCouldNotGetTableSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QueryProviderFactory for connection type &apos;{0}&apos; is not registered..
        /// </summary>
        internal static string QueryProviderFactoryNotRegisteredForConnection {
            get {
                return ResourceManager.GetString("QueryProviderFactoryNotRegisteredForConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QueryProviderFactory for provider &apos;{0}&apos; is not registered..
        /// </summary>
        internal static string QueryProviderFactoryNotRegisteredForProvider {
            get {
                return ResourceManager.GetString("QueryProviderFactoryNotRegisteredForProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result type must be generic type IEnumerable&lt;T&gt;..
        /// </summary>
        internal static string ResultMustBeGenericIEnumerable {
            get {
                return ResourceManager.GetString("ResultMustBeGenericIEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Script &apos;{0}&apos; doesn&apos;t exist in assembly &apos;{1}&apos;..
        /// </summary>
        internal static string ScriptDoesNotExist {
            get {
                return ResourceManager.GetString("ScriptDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When Skip method is used, OrderBy must be specified..
        /// </summary>
        internal static string SkipWithoutOrderByInQuery {
            get {
                return ResourceManager.GetString("SkipWithoutOrderByInQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This call of Skip() method is not supported..
        /// </summary>
        internal static string ThisCallOfSkipMethodIsNotSupported {
            get {
                return ResourceManager.GetString("ThisCallOfSkipMethodIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This call of Take() method is not supported..
        /// </summary>
        internal static string ThisCallOfTakeMethodIsNotSupported {
            get {
                return ResourceManager.GetString("ThisCallOfTakeMethodIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trying to set column mapping &quot;{0}&quot; for property &quot;{1}&quot; of entity &quot;{2}&quot;. Column mapping is already set as &quot;{3}&quot;..
        /// </summary>
        internal static string ThrowHelper_ColumnMappingAlreadyConfigured {
            get {
                return ResourceManager.GetString("ThrowHelper_ColumnMappingAlreadyConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trying to set converter &quot;{0}&quot; for property &quot;{1}&quot; of entity &quot;{2}&quot;. Converter is already set as &quot;{3}&quot;..
        /// </summary>
        internal static string ThrowHelper_ConverterAlreadyConfigured {
            get {
                return ResourceManager.GetString("ThrowHelper_ConverterAlreadyConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trying to set converter &quot;{0}&quot; for properties of type &quot;{1}&quot; of entity &quot;{2}&quot;. Converter is already set as &quot;{3}&quot;..
        /// </summary>
        internal static string ThrowHelper_ConverterForTypeAlreadyConfigured {
            get {
                return ResourceManager.GetString("ThrowHelper_ConverterForTypeAlreadyConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &quot;{0}&quot; of entity &quot;{1}&quot; was already configured..
        /// </summary>
        internal static string ThrowHelper_PropertyAlreadyConfigured {
            get {
                return ResourceManager.GetString("ThrowHelper_PropertyAlreadyConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type must be Enum type..
        /// </summary>
        internal static string TypeMustBeEnumType {
            get {
                return ResourceManager.GetString("TypeMustBeEnumType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The unary operator &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string UnaryOperatorIsNotSupported {
            get {
                return ResourceManager.GetString("UnaryOperatorIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; can be call only one time..
        /// </summary>
        internal static string UseConnectionCanBeCallOnlyOne {
            get {
                return ResourceManager.GetString("UseConnectionCanBeCallOnlyOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; must be call before &apos;{1}&apos;.
        /// </summary>
        internal static string UseConnectionMustBeCall {
            get {
                return ResourceManager.GetString("UseConnectionMustBeCall", resourceCulture);
            }
        }
    }
}
