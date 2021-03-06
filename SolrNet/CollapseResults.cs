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

using System.Collections.Generic;

namespace SolrNet {
    /// <summary>
    /// Collapse results
    /// <see href="https://issues.apache.org/jira/browse/SOLR-236"/>
    /// </summary>
    public class CollapseResults {

        /// <summary>
        /// &amp;collapse.field=
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Collapsed document.ids and their counts
        /// </summary>
        public ICollection<CollapsedDocument> CollapsedDocuments { get; set; }

        ///<summary>
        /// Initializer
        ///</summary>
        public CollapseResults() {
            CollapsedDocuments = new List<CollapsedDocument>();
        }
    }
}