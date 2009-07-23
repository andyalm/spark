﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4918
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CachingViewHunks.Models
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="NORTHWND")]
	public partial class NorthwindDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertEmployeeTerritory(EmployeeTerritory instance);
    partial void UpdateEmployeeTerritory(EmployeeTerritory instance);
    partial void DeleteEmployeeTerritory(EmployeeTerritory instance);
    partial void InsertTerritory(Territory instance);
    partial void UpdateTerritory(Territory instance);
    partial void DeleteTerritory(Territory instance);
    partial void InsertRegion(Region instance);
    partial void UpdateRegion(Region instance);
    partial void DeleteRegion(Region instance);
    #endregion
		
		public NorthwindDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<EmployeeTerritory> EmployeeTerritories
		{
			get
			{
				return this.GetTable<EmployeeTerritory>();
			}
		}
		
		public System.Data.Linq.Table<Territory> Territories
		{
			get
			{
				return this.GetTable<Territory>();
			}
		}
		
		public System.Data.Linq.Table<Region> Regions
		{
			get
			{
				return this.GetTable<Region>();
			}
		}
	}
	
	[Table(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _Title;
		
		private string _TitleOfCourtesy;
		
		private System.Nullable<System.DateTime> _BirthDate;
		
		private System.Nullable<System.DateTime> _HireDate;
		
		private string _Address;
		
		private string _City;
		
		private string _Region;
		
		private string _PostalCode;
		
		private string _Country;
		
		private string _HomePhone;
		
		private string _Extension;
		
		private System.Data.Linq.Binary _Photo;
		
		private string _Notes;
		
		private System.Nullable<int> _ReportsTo;
		
		private string _PhotoPath;
		
		private EntitySet<Employee> _Employees;
		
		private EntitySet<EmployeeTerritory> _EmployeeTerritories;
		
		private EntityRef<Employee> _Employee1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnTitleOfCourtesyChanging(string value);
    partial void OnTitleOfCourtesyChanged();
    partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthDateChanged();
    partial void OnHireDateChanging(System.Nullable<System.DateTime> value);
    partial void OnHireDateChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnRegionChanging(string value);
    partial void OnRegionChanged();
    partial void OnPostalCodeChanging(string value);
    partial void OnPostalCodeChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnHomePhoneChanging(string value);
    partial void OnHomePhoneChanged();
    partial void OnExtensionChanging(string value);
    partial void OnExtensionChanged();
    partial void OnPhotoChanging(System.Data.Linq.Binary value);
    partial void OnPhotoChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    partial void OnReportsToChanging(System.Nullable<int> value);
    partial void OnReportsToChanged();
    partial void OnPhotoPathChanging(string value);
    partial void OnPhotoPathChanged();
    #endregion
		
		public Employee()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			this._EmployeeTerritories = new EntitySet<EmployeeTerritory>(new Action<EmployeeTerritory>(this.attach_EmployeeTerritories), new Action<EmployeeTerritory>(this.detach_EmployeeTerritories));
			this._Employee1 = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[Column(Storage="_EmployeeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[Column(Storage="_LastName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_FirstName", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_Title", DbType="NVarChar(30)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_TitleOfCourtesy", DbType="NVarChar(25)")]
		public string TitleOfCourtesy
		{
			get
			{
				return this._TitleOfCourtesy;
			}
			set
			{
				if ((this._TitleOfCourtesy != value))
				{
					this.OnTitleOfCourtesyChanging(value);
					this.SendPropertyChanging();
					this._TitleOfCourtesy = value;
					this.SendPropertyChanged("TitleOfCourtesy");
					this.OnTitleOfCourtesyChanged();
				}
			}
		}
		
		[Column(Storage="_BirthDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[Column(Storage="_HireDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> HireDate
		{
			get
			{
				return this._HireDate;
			}
			set
			{
				if ((this._HireDate != value))
				{
					this.OnHireDateChanging(value);
					this.SendPropertyChanging();
					this._HireDate = value;
					this.SendPropertyChanged("HireDate");
					this.OnHireDateChanged();
				}
			}
		}
		
		[Column(Storage="_Address", DbType="NVarChar(60)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[Column(Storage="_City", DbType="NVarChar(15)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[Column(Storage="_Region", DbType="NVarChar(15)")]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this.OnRegionChanging(value);
					this.SendPropertyChanging();
					this._Region = value;
					this.SendPropertyChanged("Region");
					this.OnRegionChanged();
				}
			}
		}
		
		[Column(Storage="_PostalCode", DbType="NVarChar(10)")]
		public string PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this.OnPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._PostalCode = value;
					this.SendPropertyChanged("PostalCode");
					this.OnPostalCodeChanged();
				}
			}
		}
		
		[Column(Storage="_Country", DbType="NVarChar(15)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[Column(Storage="_HomePhone", DbType="NVarChar(24)")]
		public string HomePhone
		{
			get
			{
				return this._HomePhone;
			}
			set
			{
				if ((this._HomePhone != value))
				{
					this.OnHomePhoneChanging(value);
					this.SendPropertyChanging();
					this._HomePhone = value;
					this.SendPropertyChanged("HomePhone");
					this.OnHomePhoneChanged();
				}
			}
		}
		
		[Column(Storage="_Extension", DbType="NVarChar(4)")]
		public string Extension
		{
			get
			{
				return this._Extension;
			}
			set
			{
				if ((this._Extension != value))
				{
					this.OnExtensionChanging(value);
					this.SendPropertyChanging();
					this._Extension = value;
					this.SendPropertyChanged("Extension");
					this.OnExtensionChanged();
				}
			}
		}
		
		[Column(Storage="_Photo", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[Column(Storage="_Notes", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		[Column(Storage="_ReportsTo", DbType="Int")]
		public System.Nullable<int> ReportsTo
		{
			get
			{
				return this._ReportsTo;
			}
			set
			{
				if ((this._ReportsTo != value))
				{
					if (this._Employee1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnReportsToChanging(value);
					this.SendPropertyChanging();
					this._ReportsTo = value;
					this.SendPropertyChanged("ReportsTo");
					this.OnReportsToChanged();
				}
			}
		}
		
		[Column(Storage="_PhotoPath", DbType="NVarChar(255)")]
		public string PhotoPath
		{
			get
			{
				return this._PhotoPath;
			}
			set
			{
				if ((this._PhotoPath != value))
				{
					this.OnPhotoPathChanging(value);
					this.SendPropertyChanging();
					this._PhotoPath = value;
					this.SendPropertyChanged("PhotoPath");
					this.OnPhotoPathChanged();
				}
			}
		}
		
		[Association(Name="Employee_Employee", Storage="_Employees", ThisKey="EmployeeID", OtherKey="ReportsTo")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
			}
		}
		
		[Association(Name="Employee_EmployeeTerritory", Storage="_EmployeeTerritories", ThisKey="EmployeeID", OtherKey="EmployeeID")]
		public EntitySet<EmployeeTerritory> EmployeeTerritories
		{
			get
			{
				return this._EmployeeTerritories;
			}
			set
			{
				this._EmployeeTerritories.Assign(value);
			}
		}
		
		[Association(Name="Employee_Employee", Storage="_Employee1", ThisKey="ReportsTo", OtherKey="EmployeeID", IsForeignKey=true)]
		public Employee ReportsToEmployee
		{
			get
			{
				return this._Employee1.Entity;
			}
			set
			{
				Employee previousValue = this._Employee1.Entity;
				if (((previousValue != value) 
							|| (this._Employee1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee1.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Employee1.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._ReportsTo = value.EmployeeID;
					}
					else
					{
						this._ReportsTo = default(Nullable<int>);
					}
					this.SendPropertyChanged("ReportsToEmployee");
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
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.ReportsToEmployee = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.ReportsToEmployee = null;
		}
		
		private void attach_EmployeeTerritories(EmployeeTerritory entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_EmployeeTerritories(EmployeeTerritory entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[Table(Name="dbo.EmployeeTerritories")]
	public partial class EmployeeTerritory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeID;
		
		private string _TerritoryID;
		
		private EntityRef<Employee> _Employee;
		
		private EntityRef<Territory> _Territory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    partial void OnTerritoryIDChanging(string value);
    partial void OnTerritoryIDChanged();
    #endregion
		
		public EmployeeTerritory()
		{
			this._Employee = default(EntityRef<Employee>);
			this._Territory = default(EntityRef<Territory>);
			OnCreated();
		}
		
		[Column(Storage="_EmployeeID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[Column(Storage="_TerritoryID", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TerritoryID
		{
			get
			{
				return this._TerritoryID;
			}
			set
			{
				if ((this._TerritoryID != value))
				{
					if (this._Territory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTerritoryIDChanging(value);
					this.SendPropertyChanging();
					this._TerritoryID = value;
					this.SendPropertyChanged("TerritoryID");
					this.OnTerritoryIDChanged();
				}
			}
		}
		
		[Association(Name="Employee_EmployeeTerritory", Storage="_Employee", ThisKey="EmployeeID", OtherKey="EmployeeID", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.EmployeeTerritories.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.EmployeeTerritories.Add(this);
						this._EmployeeID = value.EmployeeID;
					}
					else
					{
						this._EmployeeID = default(int);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		[Association(Name="Territory_EmployeeTerritory", Storage="_Territory", ThisKey="TerritoryID", OtherKey="TerritoryID", IsForeignKey=true)]
		public Territory Territory
		{
			get
			{
				return this._Territory.Entity;
			}
			set
			{
				Territory previousValue = this._Territory.Entity;
				if (((previousValue != value) 
							|| (this._Territory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Territory.Entity = null;
						previousValue.EmployeeTerritories.Remove(this);
					}
					this._Territory.Entity = value;
					if ((value != null))
					{
						value.EmployeeTerritories.Add(this);
						this._TerritoryID = value.TerritoryID;
					}
					else
					{
						this._TerritoryID = default(string);
					}
					this.SendPropertyChanged("Territory");
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
	
	[Table(Name="dbo.Territories")]
	public partial class Territory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TerritoryID;
		
		private string _TerritoryDescription;
		
		private int _RegionID;
		
		private EntitySet<EmployeeTerritory> _EmployeeTerritories;
		
		private EntityRef<Region> _Region;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTerritoryIDChanging(string value);
    partial void OnTerritoryIDChanged();
    partial void OnTerritoryDescriptionChanging(string value);
    partial void OnTerritoryDescriptionChanged();
    partial void OnRegionIDChanging(int value);
    partial void OnRegionIDChanged();
    #endregion
		
		public Territory()
		{
			this._EmployeeTerritories = new EntitySet<EmployeeTerritory>(new Action<EmployeeTerritory>(this.attach_EmployeeTerritories), new Action<EmployeeTerritory>(this.detach_EmployeeTerritories));
			this._Region = default(EntityRef<Region>);
			OnCreated();
		}
		
		[Column(Storage="_TerritoryID", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TerritoryID
		{
			get
			{
				return this._TerritoryID;
			}
			set
			{
				if ((this._TerritoryID != value))
				{
					this.OnTerritoryIDChanging(value);
					this.SendPropertyChanging();
					this._TerritoryID = value;
					this.SendPropertyChanged("TerritoryID");
					this.OnTerritoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_TerritoryDescription", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string TerritoryDescription
		{
			get
			{
				return this._TerritoryDescription;
			}
			set
			{
				if ((this._TerritoryDescription != value))
				{
					this.OnTerritoryDescriptionChanging(value);
					this.SendPropertyChanging();
					this._TerritoryDescription = value;
					this.SendPropertyChanged("TerritoryDescription");
					this.OnTerritoryDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_RegionID", DbType="Int NOT NULL")]
		public int RegionID
		{
			get
			{
				return this._RegionID;
			}
			set
			{
				if ((this._RegionID != value))
				{
					if (this._Region.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRegionIDChanging(value);
					this.SendPropertyChanging();
					this._RegionID = value;
					this.SendPropertyChanged("RegionID");
					this.OnRegionIDChanged();
				}
			}
		}
		
		[Association(Name="Territory_EmployeeTerritory", Storage="_EmployeeTerritories", ThisKey="TerritoryID", OtherKey="TerritoryID")]
		public EntitySet<EmployeeTerritory> EmployeeTerritories
		{
			get
			{
				return this._EmployeeTerritories;
			}
			set
			{
				this._EmployeeTerritories.Assign(value);
			}
		}
		
		[Association(Name="Region_Territory", Storage="_Region", ThisKey="RegionID", OtherKey="RegionID", IsForeignKey=true)]
		public Region Region
		{
			get
			{
				return this._Region.Entity;
			}
			set
			{
				Region previousValue = this._Region.Entity;
				if (((previousValue != value) 
							|| (this._Region.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Region.Entity = null;
						previousValue.Territories.Remove(this);
					}
					this._Region.Entity = value;
					if ((value != null))
					{
						value.Territories.Add(this);
						this._RegionID = value.RegionID;
					}
					else
					{
						this._RegionID = default(int);
					}
					this.SendPropertyChanged("Region");
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
		
		private void attach_EmployeeTerritories(EmployeeTerritory entity)
		{
			this.SendPropertyChanging();
			entity.Territory = this;
		}
		
		private void detach_EmployeeTerritories(EmployeeTerritory entity)
		{
			this.SendPropertyChanging();
			entity.Territory = null;
		}
	}
	
	[Table(Name="dbo.Region")]
	public partial class Region : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RegionID;
		
		private string _RegionDescription;
		
		private EntitySet<Territory> _Territories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRegionIDChanging(int value);
    partial void OnRegionIDChanged();
    partial void OnRegionDescriptionChanging(string value);
    partial void OnRegionDescriptionChanged();
    #endregion
		
		public Region()
		{
			this._Territories = new EntitySet<Territory>(new Action<Territory>(this.attach_Territories), new Action<Territory>(this.detach_Territories));
			OnCreated();
		}
		
		[Column(Storage="_RegionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RegionID
		{
			get
			{
				return this._RegionID;
			}
			set
			{
				if ((this._RegionID != value))
				{
					this.OnRegionIDChanging(value);
					this.SendPropertyChanging();
					this._RegionID = value;
					this.SendPropertyChanged("RegionID");
					this.OnRegionIDChanged();
				}
			}
		}
		
		[Column(Storage="_RegionDescription", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string RegionDescription
		{
			get
			{
				return this._RegionDescription;
			}
			set
			{
				if ((this._RegionDescription != value))
				{
					this.OnRegionDescriptionChanging(value);
					this.SendPropertyChanging();
					this._RegionDescription = value;
					this.SendPropertyChanged("RegionDescription");
					this.OnRegionDescriptionChanged();
				}
			}
		}
		
		[Association(Name="Region_Territory", Storage="_Territories", ThisKey="RegionID", OtherKey="RegionID")]
		public EntitySet<Territory> Territories
		{
			get
			{
				return this._Territories;
			}
			set
			{
				this._Territories.Assign(value);
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
		
		private void attach_Territories(Territory entity)
		{
			this.SendPropertyChanging();
			entity.Region = this;
		}
		
		private void detach_Territories(Territory entity)
		{
			this.SendPropertyChanging();
			entity.Region = null;
		}
	}
}
#pragma warning restore 1591