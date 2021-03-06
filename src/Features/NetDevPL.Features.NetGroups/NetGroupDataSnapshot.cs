﻿// -------------------------------------------------------------------------------------------------------------------
// <copyright company="Gemotial" file="NetGroup.cs" project="NetDevPL.Features.NetGroups" date="2016-09-29 23:06">
// 
// </copyright>
// -------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace NetDevPL.Features.NetGroups
{
    /// <summary>
    ///     State of .net groups data in Poland at certain date
    /// </summary>
    public class NetGroupDataSnapshot
    {
        /// <summary>
        ///     Actual .net groups
        /// </summary>
        public ICollection<NetGroup> Groups { get; set; }

        /// <summary>
        ///     Date when snapshot was taken
        /// </summary>
        public DateTime SnapshotDate { get; set; }

        public static NetGroupDataSnapshot Create()
        {
            return new NetGroupDataSnapshot {SnapshotDate = DateTime.Now};
        }
    }
}