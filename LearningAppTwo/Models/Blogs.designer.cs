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

namespace LearningAppTwo.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Blog")]
	public partial class BlogsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBlog(Blog instance);
    partial void UpdateBlog(Blog instance);
    partial void DeleteBlog(Blog instance);
    #endregion
		
		public BlogsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BlogsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BlogsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Blog> Blogs
		{
			get
			{
				return this.GetTable<Blog>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Blog")]
	public partial class Blog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _BlogTitle;
		
		private string _BlogContent;
		
		private System.DateTime _BlogPostDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnBlogTitleChanging(string value);
    partial void OnBlogTitleChanged();
    partial void OnBlogContentChanging(string value);
    partial void OnBlogContentChanged();
    partial void OnBlogPostDateChanging(System.DateTime value);
    partial void OnBlogPostDateChanged();
    #endregion
		
		public Blog()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogTitle", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string BlogTitle
		{
			get
			{
				return this._BlogTitle;
			}
			set
			{
				if ((this._BlogTitle != value))
				{
					this.OnBlogTitleChanging(value);
					this.SendPropertyChanging();
					this._BlogTitle = value;
					this.SendPropertyChanged("BlogTitle");
					this.OnBlogTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogContent", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string BlogContent
		{
			get
			{
				return this._BlogContent;
			}
			set
			{
				if ((this._BlogContent != value))
				{
					this.OnBlogContentChanging(value);
					this.SendPropertyChanging();
					this._BlogContent = value;
					this.SendPropertyChanged("BlogContent");
					this.OnBlogContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BlogPostDate", DbType="DateTime NOT NULL")]
		public System.DateTime BlogPostDate
		{
			get
			{
				return this._BlogPostDate;
			}
			set
			{
				if ((this._BlogPostDate != value))
				{
					this.OnBlogPostDateChanging(value);
					this.SendPropertyChanging();
					this._BlogPostDate = value;
					this.SendPropertyChanged("BlogPostDate");
					this.OnBlogPostDateChanged();
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
