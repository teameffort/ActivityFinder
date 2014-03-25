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

namespace TE.ActivityFinder.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TE.ActivityFinder.DB")]
	public partial class ActivityDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertact_Activity(act_Activity instance);
    partial void Updateact_Activity(act_Activity instance);
    partial void Deleteact_Activity(act_Activity instance);
    partial void Insertact_ActivityType(act_ActivityType instance);
    partial void Updateact_ActivityType(act_ActivityType instance);
    partial void Deleteact_ActivityType(act_ActivityType instance);
    partial void Insertloc_Location(loc_Location instance);
    partial void Updateloc_Location(loc_Location instance);
    partial void Deleteloc_Location(loc_Location instance);
    #endregion
		
		public ActivityDataContext() : 
				base(global::TE.ActivityFinder.DAL.Properties.Settings.Default.TE_ActivityFinder_DBConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<act_Activity> act_Activities
		{
			get
			{
				return this.GetTable<act_Activity>();
			}
		}
		
		public System.Data.Linq.Table<act_ActivityType> act_ActivityTypes
		{
			get
			{
				return this.GetTable<act_ActivityType>();
			}
		}
		
		public System.Data.Linq.Table<loc_Location> loc_Locations
		{
			get
			{
				return this.GetTable<loc_Location>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.act_GetActivities")]
		public ISingleResult<act_GetActivitiesResult> act_GetActivities()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<act_GetActivitiesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.loc_InsLocation")]
		public int loc_InsLocation([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="VarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Latitude", DbType="VarChar(50)")] string latitude, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Longitude", DbType="VarChar(50)")] string longitude)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, latitude, longitude);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.act_Activity")]
	public partial class act_Activity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ActivityId;
		
		private int _ActivityTypeId;
		
		private int _LocationId;
		
		private string _Name;
		
		private System.DateTime _StartDT;
		
		private System.DateTime _EndDT;
		
		private bool _IsActive;
		
		private EntityRef<act_ActivityType> _act_ActivityType;
		
		private EntityRef<loc_Location> _loc_Location;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActivityIdChanging(int value);
    partial void OnActivityIdChanged();
    partial void OnActivityTypeIdChanging(int value);
    partial void OnActivityTypeIdChanged();
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
		
		public act_Activity()
		{
			this._act_ActivityType = default(EntityRef<act_ActivityType>);
			this._loc_Location = default(EntityRef<loc_Location>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					if (this._act_ActivityType.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationId", DbType="Int NOT NULL")]
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
					if (this._loc_Location.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLocationIdChanging(value);
					this.SendPropertyChanging();
					this._LocationId = value;
					this.SendPropertyChanged("LocationId");
					this.OnLocationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="act_ActivityType_act_Activity", Storage="_act_ActivityType", ThisKey="ActivityTypeId", OtherKey="ActivityTypeId", IsForeignKey=true)]
		public act_ActivityType act_ActivityType
		{
			get
			{
				return this._act_ActivityType.Entity;
			}
			set
			{
				act_ActivityType previousValue = this._act_ActivityType.Entity;
				if (((previousValue != value) 
							|| (this._act_ActivityType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._act_ActivityType.Entity = null;
						previousValue.act_Activities.Remove(this);
					}
					this._act_ActivityType.Entity = value;
					if ((value != null))
					{
						value.act_Activities.Add(this);
						this._ActivityTypeId = value.ActivityTypeId;
					}
					else
					{
						this._ActivityTypeId = default(int);
					}
					this.SendPropertyChanged("act_ActivityType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="loc_Location_act_Activity", Storage="_loc_Location", ThisKey="LocationId", OtherKey="LocationId", IsForeignKey=true)]
		public loc_Location loc_Location
		{
			get
			{
				return this._loc_Location.Entity;
			}
			set
			{
				loc_Location previousValue = this._loc_Location.Entity;
				if (((previousValue != value) 
							|| (this._loc_Location.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._loc_Location.Entity = null;
						previousValue.act_Activities.Remove(this);
					}
					this._loc_Location.Entity = value;
					if ((value != null))
					{
						value.act_Activities.Add(this);
						this._LocationId = value.LocationId;
					}
					else
					{
						this._LocationId = default(int);
					}
					this.SendPropertyChanged("loc_Location");
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.act_ActivityType")]
	public partial class act_ActivityType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ActivityTypeId;
		
		private string _Type;
		
		private EntitySet<act_Activity> _act_Activities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActivityTypeIdChanging(int value);
    partial void OnActivityTypeIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    #endregion
		
		public act_ActivityType()
		{
			this._act_Activities = new EntitySet<act_Activity>(new Action<act_Activity>(this.attach_act_Activities), new Action<act_Activity>(this.detach_act_Activities));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityTypeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="act_ActivityType_act_Activity", Storage="_act_Activities", ThisKey="ActivityTypeId", OtherKey="ActivityTypeId")]
		public EntitySet<act_Activity> act_Activities
		{
			get
			{
				return this._act_Activities;
			}
			set
			{
				this._act_Activities.Assign(value);
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
		
		private void attach_act_Activities(act_Activity entity)
		{
			this.SendPropertyChanging();
			entity.act_ActivityType = this;
		}
		
		private void detach_act_Activities(act_Activity entity)
		{
			this.SendPropertyChanging();
			entity.act_ActivityType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.loc_Location")]
	public partial class loc_Location : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LocationId;
		
		private string _Name;
		
		private string _Latitude;
		
		private string _Longitude;
		
		private EntitySet<act_Activity> _act_Activities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLocationIdChanging(int value);
    partial void OnLocationIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLatitudeChanging(string value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(string value);
    partial void OnLongitudeChanged();
    #endregion
		
		public loc_Location()
		{
			this._act_Activities = new EntitySet<act_Activity>(new Action<act_Activity>(this.attach_act_Activities), new Action<act_Activity>(this.detach_act_Activities));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="loc_Location_act_Activity", Storage="_act_Activities", ThisKey="LocationId", OtherKey="LocationId")]
		public EntitySet<act_Activity> act_Activities
		{
			get
			{
				return this._act_Activities;
			}
			set
			{
				this._act_Activities.Assign(value);
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
		
		private void attach_act_Activities(act_Activity entity)
		{
			this.SendPropertyChanging();
			entity.loc_Location = this;
		}
		
		private void detach_act_Activities(act_Activity entity)
		{
			this.SendPropertyChanging();
			entity.loc_Location = null;
		}
	}
	
	public partial class act_GetActivitiesResult
	{
		
		private int _ActivityId;
		
		private int _ActivityTypeId;
		
		private int _LocationId;
		
		private string _Name;
		
		private System.DateTime _StartDT;
		
		private System.DateTime _EndDT;
		
		private bool _IsActive;
		
		public act_GetActivitiesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityId", DbType="Int NOT NULL")]
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
					this._ActivityId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityTypeId", DbType="Int NOT NULL")]
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
					this._ActivityTypeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationId", DbType="Int NOT NULL")]
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
					this._LocationId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDT", DbType="DateTime NOT NULL")]
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
					this._StartDT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDT", DbType="DateTime NOT NULL")]
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
					this._EndDT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit NOT NULL")]
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
					this._IsActive = value;
				}
			}
		}
	}
}
#pragma warning restore 1591