﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScripter.TypeScript
{
	public class TsProperty : TsObject
	{
		#region Properties
		public bool Optional
		{
			get;
			set;
		}

		public TsType Type
		{
			get;
			set;
		}
		#endregion

		#region Creation
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">The interface name</param>
		public TsProperty(TsName name, TsType type)
			: base(name)
		{
			this.Type = type;
			this.Optional = false;
		}
		#endregion
	}
}
