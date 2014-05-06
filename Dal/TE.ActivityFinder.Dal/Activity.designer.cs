﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Te.ActivityFinder.Dal
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Te.ActivityFinder")]
	public partial class ActivityDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertActivity(Activity instance);
    partial void UpdateActivity(Activity instance);
    partial void DeleteActivity(Activity instance);
    partial void InsertActivityCategory(ActivityCategory instance);
    partial void UpdateActivityCategory(ActivityCategory instance);
    partial void DeleteActivityCategory(ActivityCategory instance);
    partial void InsertActivityType(ActivityType instance);
    partial void UpdateActivityType(ActivityType instance);
    partial void DeleteActivityType(ActivityType instance);
    #endregion
		
		public ActivityDataContext() : 
				base(global::Te.ActivityFinder.Dal.Properties.Settings.Default.Te_ActivityFinderConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ActivityDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ActivityDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ActivityDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ActivityDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Activity> Activities
		{
			get
			{
				return this.GetTable<Activity>();
			}
		}
		
		public System.Data.Linq.Table<ActivityCategory> ActivityCategories
		{
			get
			{
				return this.GetTable<ActivityCategory>();
			}
		}
		
		public System.Data.Linq.Table<ActivityType> ActivityTypes
		{
			get
			{
				return this.GetTable<ActivityType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Activity")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Activity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ActivityId;
		
		private int _ActivityTypeId;
		
		private int _ActivityCategoryId;
		
		private int _LocationId;
		
		private string _Name;
		
		private System.DateTime _StartDT;
		
		private System.DateTime _EndDT;
		
		private bool _IsActive;
		
		private EntityRef<ActivityCategory> _ActivityCategory;
		
		private EntityRef<ActivityType> _ActivityType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActivityIdChanging(int value);
    partial void OnActivityIdChanged();
    partial void OnActivityTypeIdChanging(int value);
    partial void OnActivityTypeIdChanged();
    partial void OnActivityCategoryIdChanging(int value);
    partial void OnActivityCategoryIdChanged();
    partial void OnLocationIdChanging(int value);
    partial void OnLocationIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnStartDTChanging(System.DateTime value);
    partial void OnStartDTChanged();
    partial void OnEndDTChanging(System.DateTime value);
    partial void OnEndDTChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public Activity()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int ActivityId
		{
			get
			{
				return this._ActivityId;
			}
			set
			{
				if ((this._ActivityId != value))
				{
					this.OnActivityIdChanging(value);
					this.SendPropertyChanging();
					this._ActivityId = value;
					this.SendPropertyChanged("ActivityId");
					this.OnActivityIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityTypeId", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public int ActivityTypeId
		{
			get
			{
				return this._ActivityTypeId;
			}
			set
			{
				if ((this._ActivityTypeId != value))
				{
					if (this._ActivityType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnActivityTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ActivityTypeId = value;
					this.SendPropertyChanged("ActivityTypeId");
					this.OnActivityTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityCategoryId", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public int ActivityCategoryId
		{
			get
			{
				return this._ActivityCategoryId;
			}
			set
			{
				if ((this._ActivityCategoryId != value))
				{
					if (this._ActivityCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnActivityCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._ActivityCategoryId = value;
					this.SendPropertyChanged("ActivityCategoryId");
					this.OnActivityCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationId", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public int LocationId
		{
			get
			{
				return this._LocationId;
			}
			set
			{
				if ((this._LocationId != value))
				{
					this.OnLocationIdChanging(value);
					this.SendPropertyChanging();
					this._LocationId = value;
					this.SendPropertyChanged("LocationId");
					this.OnLocationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDT", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public System.DateTime StartDT
		{
			get
			{
				return this._StartDT;
			}
			set
			{
				if ((this._StartDT != value))
				{
					this.OnStartDTChanging(value);
					this.SendPropertyChanging();
					this._StartDT = value;
					this.SendPropertyChanged("StartDT");
					this.OnStartDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDT", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public System.DateTime EndDT
		{
			get
			{
				return this._EndDT;
			}
			set
			{
				if ((this._EndDT != value))
				{
					this.OnEndDTChanging(value);
					this.SendPropertyChanging();
					this._EndDT = value;
					this.SendPropertyChanged("EndDT");
					this.OnEndDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ActivityCategory_Activity", Storage="_ActivityCategory", ThisKey="ActivityCategoryId", OtherKey="ActivityCategoryId", IsForeignKey=true)]
		public ActivityCategory ActivityCategory
		{
			get
			{
				return this._ActivityCategory.Entity;
			}
			set
			{
				ActivityCategory previousValue = this._ActivityCategory.Entity;
				if (((previousValue != value) 
							|| (this._ActivityCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ActivityCategory.Entity = null;
						previousValue.Activities.Remove(this);
					}
					this._ActivityCategory.Entity = value;
					if ((value != null))
					{
						value.Activities.Add(this);
						this._ActivityCategoryId = value.ActivityCategoryId;
					}
					else
					{
						this._ActivityCategoryId = default(int);
					}
					this.SendPropertyChanged("ActivityCategory");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ActivityType_Activity", Storage="_ActivityType", ThisKey="ActivityTypeId", OtherKey="ActivityTypeId", IsForeignKey=true)]
		public ActivityType ActivityType
		{
			get
			{
				return this._ActivityType.Entity;
			}
			set
			{
				ActivityType previousValue = this._ActivityType.Entity;
				if (((previousValue != value) 
							|| (this._ActivityType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ActivityType.Entity = null;
						previousValue.Activities.Remove(this);
					}
					this._ActivityType.Entity = value;
					if ((value != null))
					{
						value.Activities.Add(this);
						this._ActivityTypeId = value.ActivityTypeId;
					}
					else
					{
						this._ActivityTypeId = default(int);
					}
					this.SendPropertyChanged("ActivityType");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._ActivityCategory = default(EntityRef<ActivityCategory>);
			this._ActivityType = default(EntityRef<ActivityType>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ActivityCategory")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class ActivityCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ActivityCategoryId;
		
		private string _Name;
		
		private bool _IsActive;
		
		private EntitySet<Activity> _Activities;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActivityCategoryIdChanging(int value);
    partial void OnActivityCategoryIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public ActivityCategory()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityCategoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int ActivityCategoryId
		{
			get
			{
				return this._ActivityCategoryId;
			}
			set
			{
				if ((this._ActivityCategoryId != value))
				{
					this.OnActivityCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._ActivityCategoryId = value;
					this.SendPropertyChanged("ActivityCategoryId");
					this.OnActivityCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ActivityCategory_Activity", Storage="_Activities", ThisKey="ActivityCategoryId", OtherKey="ActivityCategoryId")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4, EmitDefaultValue=false)]
		public EntitySet<Activity> Activities
		{
			get
			{
				if ((this.serializing 
							&& (this._Activities.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Activities;
			}
			set
			{
				this._Activities.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Activities(Activity entity)
		{
			this.SendPropertyChanging();
			entity.ActivityCategory = this;
		}
		
		private void detach_Activities(Activity entity)
		{
			this.SendPropertyChanging();
			entity.ActivityCategory = null;
		}
		
		private void Initialize()
		{
			this._Activities = new EntitySet<Activity>(new Action<Activity>(this.attach_Activities), new Action<Activity>(this.detach_Activities));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ActivityType")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class ActivityType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ActivityTypeId;
		
		private string _Type;
		
		private bool _IsActive;
		
		private EntitySet<Activity> _Activities;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActivityTypeIdChanging(int value);
    partial void OnActivityTypeIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnIsActiveChanging(bool value);
    partial void OnIsActiveChanged();
    #endregion
		
		public ActivityType()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityTypeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int ActivityTypeId
		{
			get
			{
				return this._ActivityTypeId;
			}
			set
			{
				if ((this._ActivityTypeId != value))
				{
					this.OnActivityTypeIdChanging(value);
					this.SendPropertyChanging();
					this._ActivityTypeId = value;
					this.SendPropertyChanged("ActivityTypeId");
					this.OnActivityTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public bool IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ActivityType_Activity", Storage="_Activities", ThisKey="ActivityTypeId", OtherKey="ActivityTypeId")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4, EmitDefaultValue=false)]
		public EntitySet<Activity> Activities
		{
			get
			{
				if ((this.serializing 
							&& (this._Activities.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Activities;
			}
			set
			{
				this._Activities.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Activities(Activity entity)
		{
			this.SendPropertyChanging();
			entity.ActivityType = this;
		}
		
		private void detach_Activities(Activity entity)
		{
			this.SendPropertyChanging();
			entity.ActivityType = null;
		}
		
		private void Initialize()
		{
			this._Activities = new EntitySet<Activity>(new Action<Activity>(this.attach_Activities), new Action<Activity>(this.detach_Activities));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
}
#pragma warning restore 1591