﻿using SPMeta2.Attributes;
using SPMeta2.Attributes.Regression;
using System;
using System.Collections.ObjectModel;

namespace SPMeta2.Definitions
{
    /// <summary>
    /// Allows to define and deploy list view.
    /// </summary>
    /// 

    [SPObjectTypeAttribute(SPObjectModelType.SSOM, "Microsoft.SharePoint.SPView", "Microsoft.SharePoint")]
    [SPObjectTypeAttribute(SPObjectModelType.CSOM, "Microsoft.SharePoint.Client.View", "Microsoft.SharePoint.Client")]

    [RootHostAttribute(typeof(WebDefinition))]
    [ParentHostAttribute(typeof(ListDefinition))]

    [Serializable]
    public class ListViewDefinition : DefinitionBase
    {
        #region contructors

        public ListViewDefinition()
        {
            Fields = new Collection<string>();
            IsPaged = true;
            RowLimit = 30;
        }

        #endregion

        #region properties

        /// <summary>
        /// Title of the target list view.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// RowLimit of the target list view.
        /// </summary>
        public int RowLimit { get; set; }

        /// <summary>
        /// CAML Query of the target list view.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// IsPaged flag of the target list view.
        /// </summary>
        public bool IsPaged { get; set; }

        /// <summary>
        /// ISDefault flag of the target list view.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Set of the internal field names of the target list view.
        /// </summary>
        public Collection<string> Fields { get; set; }

        #endregion

        #region methods

        public override string ToString()
        {
            return string.Format("Title:[{0}] IsDefault:[{1}] Query:[{2}]", Title, IsDefault, Query);
        }

        #endregion
    }
}
