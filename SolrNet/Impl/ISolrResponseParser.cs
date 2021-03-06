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

using System.Xml;
using System.Xml.Linq;

namespace SolrNet.Impl {
    /// <summary>
    /// Parses a chunk of a query response
    /// </summary>
    /// <typeparam name="T">Document type</typeparam>
    public interface ISolrResponseParser<T> {
        /// <summary>
        /// Parses a chunk of a query response into the results object
        /// </summary>
        /// <param name="xml">query response</param>
        /// <param name="results">results object</param>
        void Parse(XDocument xml, SolrQueryResults<T> results);
    }
}