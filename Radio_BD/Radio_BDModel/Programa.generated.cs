#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using Radio_BDModel;

namespace Radio_BDModel	
{
	public partial class Programa
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private string _nome_programa;
		public virtual string Nome_programa
		{
			get
			{
				return this._nome_programa;
			}
			set
			{
				this._nome_programa = value;
			}
		}
		
		private DateTime? _hora;
		public virtual DateTime? Hora
		{
			get
			{
				return this._hora;
			}
			set
			{
				this._hora = value;
			}
		}
		
		private string _apresentador;
		public virtual string Apresentador
		{
			get
			{
				return this._apresentador;
			}
			set
			{
				this._apresentador = value;
			}
		}
		
		private string _descricao;
		public virtual string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				this._descricao = value;
			}
		}
		
		private IList<Avaliacao> _avaliacaos = new List<Avaliacao>();
		public virtual IList<Avaliacao> Avaliacaos
		{
			get
			{
				return this._avaliacaos;
			}
		}
		
	}
}
#pragma warning restore 1591
