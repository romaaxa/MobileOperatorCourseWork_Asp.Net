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

namespace PhoneStation
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class ClientDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertclient(client instance);
    partial void Updateclient(client instance);
    partial void Deleteclient(client instance);
    #endregion
		
		public ClientDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ClientDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClientDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<client> clients
		{
			get
			{
				return this.GetTable<client>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.client")]
	public partial class client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Surname;
		
		private string _Name;
		
		private string _Operator;
		
		private System.Nullable<int> _intspeed;
		
		private string _sumofoperator;
		
		private System.Nullable<int> _numberphone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnOperatorChanging(string value);
    partial void OnOperatorChanged();
    partial void OnintspeedChanging(System.Nullable<int> value);
    partial void OnintspeedChanged();
    partial void OnsumofoperatorChanging(string value);
    partial void OnsumofoperatorChanged();
    partial void OnnumberphoneChanging(System.Nullable<int> value);
    partial void OnnumberphoneChanged();
    #endregion
		
		public client()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Operator", DbType="NVarChar(50)")]
		public string Operator
		{
			get
			{
				return this._Operator;
			}
			set
			{
				if ((this._Operator != value))
				{
					this.OnOperatorChanging(value);
					this.SendPropertyChanging();
					this._Operator = value;
					this.SendPropertyChanged("Operator");
					this.OnOperatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intspeed", DbType="Int")]
		public System.Nullable<int> intspeed
		{
			get
			{
				return this._intspeed;
			}
			set
			{
				if ((this._intspeed != value))
				{
					this.OnintspeedChanging(value);
					this.SendPropertyChanging();
					this._intspeed = value;
					this.SendPropertyChanged("intspeed");
					this.OnintspeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sumofoperator", DbType="NVarChar(50)")]
		public string sumofoperator
		{
			get
			{
				return this._sumofoperator;
			}
			set
			{
				if ((this._sumofoperator != value))
				{
					this.OnsumofoperatorChanging(value);
					this.SendPropertyChanging();
					this._sumofoperator = value;
					this.SendPropertyChanged("sumofoperator");
					this.OnsumofoperatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numberphone", DbType="Int")]
		public System.Nullable<int> numberphone
		{
			get
			{
				return this._numberphone;
			}
			set
			{
				if ((this._numberphone != value))
				{
					this.OnnumberphoneChanging(value);
					this.SendPropertyChanging();
					this._numberphone = value;
					this.SendPropertyChanged("numberphone");
					this.OnnumberphoneChanged();
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
