﻿#region license
// Copyright (c) 2007-2010 Mauricio Scheffer
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;

namespace SolrNet.Attributes {
    /// <summary>
    /// Marks a property as unique key. By default the field name is the property name.
    /// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class SolrUniqueKeyAttribute : SolrFieldAttribute {
        /// <summary>
        /// Marks a property as unique key. By default the field name is the property name.
        /// </summary>
		public SolrUniqueKeyAttribute() {}

        /// <summary>
        /// Marks a property as unique key.
        /// </summary>
        /// <param name="fieldName"></param>
		public SolrUniqueKeyAttribute(string fieldName) : base(fieldName) {}
	}
}