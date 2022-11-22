﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bai09_PGBT
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLLuong")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDonVi(DonVi instance);
    partial void UpdateDonVi(DonVi instance);
    partial void DeleteDonVi(DonVi instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLLuongConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DonVi> DonVis
		{
			get
			{
				return this.GetTable<DonVi>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonVi")]
	public partial class DonVi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonVi;
		
		private string _TenDonVi;
		
		private EntitySet<NhanVien> _NhanViens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonViChanging(int value);
    partial void OnMaDonViChanged();
    partial void OnTenDonViChanging(string value);
    partial void OnTenDonViChanged();
    #endregion
		
		public DonVi()
		{
			this._NhanViens = new EntitySet<NhanVien>(new Action<NhanVien>(this.attach_NhanViens), new Action<NhanVien>(this.detach_NhanViens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDonVi
		{
			get
			{
				return this._MaDonVi;
			}
			set
			{
				if ((this._MaDonVi != value))
				{
					this.OnMaDonViChanging(value);
					this.SendPropertyChanging();
					this._MaDonVi = value;
					this.SendPropertyChanged("MaDonVi");
					this.OnMaDonViChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDonVi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenDonVi
		{
			get
			{
				return this._TenDonVi;
			}
			set
			{
				if ((this._TenDonVi != value))
				{
					this.OnTenDonViChanging(value);
					this.SendPropertyChanging();
					this._TenDonVi = value;
					this.SendPropertyChanged("TenDonVi");
					this.OnTenDonViChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonVi_NhanVien", Storage="_NhanViens", ThisKey="MaDonVi", OtherKey="MaDonVi")]
		public EntitySet<NhanVien> NhanViens
		{
			get
			{
				return this._NhanViens;
			}
			set
			{
				this._NhanViens.Assign(value);
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
		
		private void attach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.DonVi = this;
		}
		
		private void detach_NhanViens(NhanVien entity)
		{
			this.SendPropertyChanging();
			entity.DonVi = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Ma;
		
		private string _HoTen;
		
		private System.DateTime _NgaySinh;
		
		private string _GioiTinh;
		
		private System.Nullable<double> _Hesluong;
		
		private System.Nullable<int> _MaDonVi;
		
		private EntityRef<DonVi> _DonVi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChanging(int value);
    partial void OnMaChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(System.DateTime value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnHesluongChanging(System.Nullable<double> value);
    partial void OnHesluongChanged();
    partial void OnMaDonViChanging(System.Nullable<int> value);
    partial void OnMaDonViChanged();
    #endregion
		
		public NhanVien()
		{
			this._DonVi = default(EntityRef<DonVi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ma", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Ma
		{
			get
			{
				return this._Ma;
			}
			set
			{
				if ((this._Ma != value))
				{
					this.OnMaChanging(value);
					this.SendPropertyChanging();
					this._Ma = value;
					this.SendPropertyChanged("Ma");
					this.OnMaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hesluong", DbType="Float")]
		public System.Nullable<double> Hesluong
		{
			get
			{
				return this._Hesluong;
			}
			set
			{
				if ((this._Hesluong != value))
				{
					this.OnHesluongChanging(value);
					this.SendPropertyChanging();
					this._Hesluong = value;
					this.SendPropertyChanged("Hesluong");
					this.OnHesluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonVi", DbType="Int")]
		public System.Nullable<int> MaDonVi
		{
			get
			{
				return this._MaDonVi;
			}
			set
			{
				if ((this._MaDonVi != value))
				{
					if (this._DonVi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDonViChanging(value);
					this.SendPropertyChanging();
					this._MaDonVi = value;
					this.SendPropertyChanged("MaDonVi");
					this.OnMaDonViChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonVi_NhanVien", Storage="_DonVi", ThisKey="MaDonVi", OtherKey="MaDonVi", IsForeignKey=true, DeleteRule="CASCADE")]
		public DonVi DonVi
		{
			get
			{
				return this._DonVi.Entity;
			}
			set
			{
				DonVi previousValue = this._DonVi.Entity;
				if (((previousValue != value) 
							|| (this._DonVi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonVi.Entity = null;
						previousValue.NhanViens.Remove(this);
					}
					this._DonVi.Entity = value;
					if ((value != null))
					{
						value.NhanViens.Add(this);
						this._MaDonVi = value.MaDonVi;
					}
					else
					{
						this._MaDonVi = default(Nullable<int>);
					}
					this.SendPropertyChanged("DonVi");
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
