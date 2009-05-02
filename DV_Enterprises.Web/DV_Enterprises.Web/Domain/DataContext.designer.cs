﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DV_Enterprises.Web.Domain
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="ASPNETDB")]
	public partial class DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertSection(Section instance);
    partial void UpdateSection(Section instance);
    partial void DeleteSection(Section instance);
    partial void InsertGreenhouse(Greenhouse instance);
    partial void UpdateGreenhouse(Greenhouse instance);
    partial void DeleteGreenhouse(Greenhouse instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    #endregion
		
		public DataContext() : 
				base(global::DV_Enterprises.Web.Properties.Settings.Default.ASPNETDBConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Section> Sections
		{
			get
			{
				return this.GetTable<Section>();
			}
		}
		
		public System.Data.Linq.Table<Greenhouse> Greenhouses
		{
			get
			{
				return this.GetTable<Greenhouse>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
	}
	
	[Table(Name="dbo.aspnet_Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ApplicationId;
		
		private System.Guid _UserId;
		
		private string _UserName;
		
		private string _LoweredUserName;
		
		private string _MobileAlias;
		
		private bool _IsAnonymous;
		
		private System.DateTime _LastActivityDate;
		
		private EntitySet<Section> _Sections;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnApplicationIdChanging(System.Guid value);
    partial void OnApplicationIdChanged();
    partial void OnUserIdChanging(System.Guid value);
    partial void OnUserIdChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnLoweredUserNameChanging(string value);
    partial void OnLoweredUserNameChanged();
    partial void OnMobileAliasChanging(string value);
    partial void OnMobileAliasChanged();
    partial void OnIsAnonymousChanging(bool value);
    partial void OnIsAnonymousChanged();
    partial void OnLastActivityDateChanging(System.DateTime value);
    partial void OnLastActivityDateChanged();
    #endregion
		
		public User()
		{
			this._Sections = new EntitySet<Section>(new Action<Section>(this.attach_Sections), new Action<Section>(this.detach_Sections));
			OnCreated();
		}
		
		[Column(Storage="_ApplicationId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ApplicationId
		{
			get
			{
				return this._ApplicationId;
			}
			set
			{
				if ((this._ApplicationId != value))
				{
					this.OnApplicationIdChanging(value);
					this.SendPropertyChanging();
					this._ApplicationId = value;
					this.SendPropertyChanged("ApplicationId");
					this.OnApplicationIdChanged();
				}
			}
		}
		
		[Column(Storage="_UserId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[Column(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[Column(Storage="_LoweredUserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string LoweredUserName
		{
			get
			{
				return this._LoweredUserName;
			}
			set
			{
				if ((this._LoweredUserName != value))
				{
					this.OnLoweredUserNameChanging(value);
					this.SendPropertyChanging();
					this._LoweredUserName = value;
					this.SendPropertyChanged("LoweredUserName");
					this.OnLoweredUserNameChanged();
				}
			}
		}
		
		[Column(Storage="_MobileAlias", DbType="NVarChar(16)")]
		public string MobileAlias
		{
			get
			{
				return this._MobileAlias;
			}
			set
			{
				if ((this._MobileAlias != value))
				{
					this.OnMobileAliasChanging(value);
					this.SendPropertyChanging();
					this._MobileAlias = value;
					this.SendPropertyChanged("MobileAlias");
					this.OnMobileAliasChanged();
				}
			}
		}
		
		[Column(Storage="_IsAnonymous", DbType="Bit NOT NULL")]
		public bool IsAnonymous
		{
			get
			{
				return this._IsAnonymous;
			}
			set
			{
				if ((this._IsAnonymous != value))
				{
					this.OnIsAnonymousChanging(value);
					this.SendPropertyChanging();
					this._IsAnonymous = value;
					this.SendPropertyChanged("IsAnonymous");
					this.OnIsAnonymousChanged();
				}
			}
		}
		
		[Column(Storage="_LastActivityDate", DbType="DateTime NOT NULL")]
		public System.DateTime LastActivityDate
		{
			get
			{
				return this._LastActivityDate;
			}
			set
			{
				if ((this._LastActivityDate != value))
				{
					this.OnLastActivityDateChanging(value);
					this.SendPropertyChanging();
					this._LastActivityDate = value;
					this.SendPropertyChanged("LastActivityDate");
					this.OnLastActivityDateChanged();
				}
			}
		}
		
		[Association(Name="User_Section", Storage="_Sections", OtherKey="UserId")]
		public EntitySet<Section> Sections
		{
			get
			{
				return this._Sections;
			}
			set
			{
				this._Sections.Assign(value);
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
		
		private void attach_Sections(Section entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Sections(Section entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[Table(Name="dbo.dvent_Section")]
	public partial class Section : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SectionId;
		
		private int _GreenhouseId;
		
		private int _EnviromentId;
		
		private int _CropId;
		
		private string _Name;
		
		private System.Guid _UserId;
		
		private EntityRef<User> _User;
		
		private EntityRef<Greenhouse> _Greenhouse;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSectionIdChanging(int value);
    partial void OnSectionIdChanged();
    partial void OnGreenhouseIdChanging(int value);
    partial void OnGreenhouseIdChanged();
    partial void OnEnviromentIdChanging(int value);
    partial void OnEnviromentIdChanged();
    partial void OnCropIdChanging(int value);
    partial void OnCropIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUserIdChanging(System.Guid value);
    partial void OnUserIdChanged();
    #endregion
		
		public Section()
		{
			this._User = default(EntityRef<User>);
			this._Greenhouse = default(EntityRef<Greenhouse>);
			OnCreated();
		}
		
		[Column(Storage="_SectionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SectionId
		{
			get
			{
				return this._SectionId;
			}
			set
			{
				if ((this._SectionId != value))
				{
					this.OnSectionIdChanging(value);
					this.SendPropertyChanging();
					this._SectionId = value;
					this.SendPropertyChanged("SectionId");
					this.OnSectionIdChanged();
				}
			}
		}
		
		[Column(Storage="_GreenhouseId", DbType="Int NOT NULL")]
		public int GreenhouseId
		{
			get
			{
				return this._GreenhouseId;
			}
			set
			{
				if ((this._GreenhouseId != value))
				{
					if (this._Greenhouse.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGreenhouseIdChanging(value);
					this.SendPropertyChanging();
					this._GreenhouseId = value;
					this.SendPropertyChanged("GreenhouseId");
					this.OnGreenhouseIdChanged();
				}
			}
		}
		
		[Column(Storage="_EnviromentId", DbType="Int NOT NULL")]
		public int EnviromentId
		{
			get
			{
				return this._EnviromentId;
			}
			set
			{
				if ((this._EnviromentId != value))
				{
					this.OnEnviromentIdChanging(value);
					this.SendPropertyChanging();
					this._EnviromentId = value;
					this.SendPropertyChanged("EnviromentId");
					this.OnEnviromentIdChanged();
				}
			}
		}
		
		[Column(Storage="_CropId", DbType="Int NOT NULL")]
		public int CropId
		{
			get
			{
				return this._CropId;
			}
			set
			{
				if ((this._CropId != value))
				{
					this.OnCropIdChanging(value);
					this.SendPropertyChanging();
					this._CropId = value;
					this.SendPropertyChanged("CropId");
					this.OnCropIdChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_UserId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[Association(Name="User_Section", Storage="_User", ThisKey="UserId", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Sections.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Sections.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(System.Guid);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[Association(Name="Greenhouse_Section", Storage="_Greenhouse", ThisKey="GreenhouseId", IsForeignKey=true)]
		public Greenhouse Greenhouse
		{
			get
			{
				return this._Greenhouse.Entity;
			}
			set
			{
				Greenhouse previousValue = this._Greenhouse.Entity;
				if (((previousValue != value) 
							|| (this._Greenhouse.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Greenhouse.Entity = null;
						previousValue.Sections.Remove(this);
					}
					this._Greenhouse.Entity = value;
					if ((value != null))
					{
						value.Sections.Add(this);
						this._GreenhouseId = value.GreenhouseId;
					}
					else
					{
						this._GreenhouseId = default(int);
					}
					this.SendPropertyChanged("Greenhouse");
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
	
	[Table(Name="dbo.dvent_Greenhouse")]
	public partial class Greenhouse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GreenhouseId;
		
		private int _LocationId;
		
		private EntitySet<Section> _Sections;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGreenhouseIdChanging(int value);
    partial void OnGreenhouseIdChanged();
    partial void OnLocationIdChanging(int value);
    partial void OnLocationIdChanged();
    #endregion
		
		public Greenhouse()
		{
			this._Sections = new EntitySet<Section>(new Action<Section>(this.attach_Sections), new Action<Section>(this.detach_Sections));
			OnCreated();
		}
		
		[Column(Storage="_GreenhouseId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int GreenhouseId
		{
			get
			{
				return this._GreenhouseId;
			}
			set
			{
				if ((this._GreenhouseId != value))
				{
					this.OnGreenhouseIdChanging(value);
					this.SendPropertyChanging();
					this._GreenhouseId = value;
					this.SendPropertyChanged("GreenhouseId");
					this.OnGreenhouseIdChanged();
				}
			}
		}
		
		[Column(Storage="_LocationId", DbType="Int NOT NULL")]
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
		
		[Association(Name="Greenhouse_Section", Storage="_Sections", OtherKey="GreenhouseId")]
		public EntitySet<Section> Sections
		{
			get
			{
				return this._Sections;
			}
			set
			{
				this._Sections.Assign(value);
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
		
		private void attach_Sections(Section entity)
		{
			this.SendPropertyChanging();
			entity.Greenhouse = this;
		}
		
		private void detach_Sections(Section entity)
		{
			this.SendPropertyChanging();
			entity.Greenhouse = null;
		}
	}
	
	[Table(Name="dbo.dvent_Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _Name;
		
		private string _Description;
		
		private decimal _Price;
		
		private bool _Active;
		
		private EntitySet<Image> _ProductImages;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnActiveChanging(bool value);
    partial void OnActiveChanged();
    #endregion
		
		public Product()
		{
			this._ProductImages = new EntitySet<Image>(new Action<Image>(this.attach_ProductImages), new Action<Image>(this.detach_ProductImages));
			OnCreated();
		}
		
		[Column(Storage="_ProductID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_Description", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_Price", DbType="Decimal(18,2) NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[Column(Storage="_Active", DbType="Bit NOT NULL")]
		public bool Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[Association(Name="Product_ProductImage", Storage="_ProductImages", OtherKey="ProductId")]
		public EntitySet<Image> Images
		{
			get
			{
				return this._ProductImages;
			}
			set
			{
				this._ProductImages.Assign(value);
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
		
		private void attach_ProductImages(Image entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_ProductImages(Image entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[Table(Name="dbo.dvent_ProductImage")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductImageId;
		
		private string _Path;
		
		private string _Caption;
		
		private int _ProductId;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductImageIdChanging(int value);
    partial void OnProductImageIdChanged();
    partial void OnPathChanging(string value);
    partial void OnPathChanged();
    partial void OnCaptionChanging(string value);
    partial void OnCaptionChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    #endregion
		
		public Image()
		{
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[Column(Storage="_ProductImageId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProductImageId
		{
			get
			{
				return this._ProductImageId;
			}
			set
			{
				if ((this._ProductImageId != value))
				{
					this.OnProductImageIdChanging(value);
					this.SendPropertyChanging();
					this._ProductImageId = value;
					this.SendPropertyChanged("ProductImageId");
					this.OnProductImageIdChanged();
				}
			}
		}
		
		[Column(Storage="_Path", DbType="NVarChar(50)")]
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				if ((this._Path != value))
				{
					this.OnPathChanging(value);
					this.SendPropertyChanging();
					this._Path = value;
					this.SendPropertyChanged("Path");
					this.OnPathChanged();
				}
			}
		}
		
		[Column(Storage="_Caption", DbType="NVarChar(50)")]
		public string Caption
		{
			get
			{
				return this._Caption;
			}
			set
			{
				if ((this._Caption != value))
				{
					this.OnCaptionChanging(value);
					this.SendPropertyChanging();
					this._Caption = value;
					this.SendPropertyChanged("Caption");
					this.OnCaptionChanged();
				}
			}
		}
		
		[Column(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[Association(Name="Product_ProductImage", Storage="_Product", ThisKey="ProductId", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Images.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Images.Add(this);
						this._ProductId = value.ProductID;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("Product");
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
}
#pragma warning restore 1591
