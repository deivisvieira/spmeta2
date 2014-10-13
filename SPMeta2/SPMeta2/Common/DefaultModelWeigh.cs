﻿using SPMeta2.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPMeta2.Common
{
    /// <summary>
    /// Indicates default model ordering while provision process.
    /// For instance, fields are to be provisioned before content types, workflow definitions before list definitions, etc.
    /// </summary>
    public static class DefaultModelWeigh
    {
        #region static

        static DefaultModelWeigh()
        {
            Weighs = new List<ModelWeigh>();

            // site
            Weighs.Add(new ModelWeigh(
                typeof(SiteDefinition),
                new[]{
                     typeof(FeatureDefinition),
                     typeof(FieldDefinition),
                     typeof(ContentTypeDefinition),
                     typeof(WebDefinition)
                }));

            // web
            Weighs.Add(new ModelWeigh(
                typeof(WebDefinition),
                new[]{
                     typeof(FeatureDefinition),
                     typeof(SP2013WorkflowDefinition),
                     typeof(ListDefinition)
                }));

            // list
            Weighs.Add(new ModelWeigh(
                typeof(ListDefinition),
                new[]{
                     typeof(ContentTypeLinkDefinition),
                     typeof(SP2013WorkflowSubscriptionDefinition),
                     typeof(FolderDefinition),
                     typeof(ListViewDefinition),
                     typeof(ModuleFileDefinition),
                }));
        }

        #endregion

        #region properties

        public static List<ModelWeigh> Weighs { get; set; }

        #endregion
    }
}