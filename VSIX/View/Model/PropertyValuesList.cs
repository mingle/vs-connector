//
// Copyright � 2010, 2011 ThoughtWorks, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at:
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
//

using System.Collections.Generic;

namespace ThoughtWorks.VisualStudio
{
    /// <summary>
    /// List decorated with a leading value indicating "not set"
    /// </summary>
    public class PropertyValuesList : List<string>
    {
        /// <summary>
        /// Constructs a new PropertyValuesList
        /// </summary>
        /// <param name="propertyValueDetails"></param>
        public PropertyValuesList(IEnumerable<string> propertyValueDetails)
        {
            Add(Resources.ItemNotSet);
            foreach(var p in propertyValueDetails) Add(p);
        }
    }
}