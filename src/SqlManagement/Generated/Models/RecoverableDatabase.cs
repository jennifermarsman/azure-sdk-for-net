// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Recoverable Azure SQL Database.
    /// </summary>
    public partial class RecoverableDatabase
    {
        private string _edition;
        
        /// <summary>
        /// Optional. Gets the edition of the database.
        /// </summary>
        public string Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }
        
        private string _entityId;
        
        /// <summary>
        /// Optional. Gets the entity ID of the database.
        /// </summary>
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }
        
        private DateTime _lastAvailableBackupDate;
        
        /// <summary>
        /// Optional. Gets the last available backup date for this database.
        /// </summary>
        public DateTime LastAvailableBackupDate
        {
            get { return this._lastAvailableBackupDate; }
            set { this._lastAvailableBackupDate = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets the name of the database.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _serverName;
        
        /// <summary>
        /// Optional. Gets the name of the Azure SQL Database Server where the
        /// database resided.
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecoverableDatabase class.
        /// </summary>
        public RecoverableDatabase()
        {
        }
    }
}
