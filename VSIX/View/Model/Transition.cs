#region Copyright � 2010, 2011,2012, 2013 ThoughtWorks, Inc.

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

#endregion

using System.Collections.Generic;
using System.Linq;
using ThoughtWorksMingleLib;

namespace ThoughtWorks.VisualStudio
{
    /// <summary>
    /// A Transition as exposed by the ViewModel
    /// </summary>
    public class Transition
    {
        private readonly MingleTransition _transition;
        private readonly ViewModel _model;

        /// <summary>
        /// Constructs a new Transition
        /// </summary>
        /// <param name="model"> </param>
        /// <param name="transition"></param>
        public Transition(ViewModel model, MingleTransition transition)
        {
            _transition = transition;
            _model = model;
        }

        /// <summary>
        /// Transition name
        /// </summary>
        public string Name
        {
            get { return _transition.Name; }
            set { _transition.Name = value; }
        }

        /// <summary>
        /// Transition Id
        /// </summary>
        public int Id
        {
            get { return _transition.Id; }
            set { _transition.Id = value; }
        }

        /// <summary>
        /// Does the transition require a comment
        /// </summary>
        public bool RequireComment
        {
            get { return _transition.RequireComment; }
            set { _transition.RequireComment = value; }
        }

        /// <summary>
        /// Card type name
        /// </summary>
        public string CardTypeName
        {
            get { return _transition.CardTypeName; }
            set { _transition.CardTypeName = value; }
        }

        /// <summary>
        /// Updates a card with this transition
        /// </summary>
        /// <param name="number"></param>
        public void Update(int number)
        {
            _transition.Update(number);
        }

        /// <summary>
        /// Returns a list of CardProperty that are required to execute this transition.
        /// </summary>
        public IEnumerable<CardProperty> RequireUserInput
        {
            get
            {
                return _transition.RequiredUserInput.Select(p => new CardProperty(_model, p)).ToList();
            }
        }
    }
}