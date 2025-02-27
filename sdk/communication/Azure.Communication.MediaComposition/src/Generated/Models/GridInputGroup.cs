// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Configure grid-based input group to be used in custom layouts. </summary>
    public partial class GridInputGroup : InputGroup
    {
        /// <summary> Initializes a new instance of <see cref="GridInputGroup"/>. </summary>
        /// <param name="inputIds"> Input and input group ids to be included in this input group. </param>
        /// <param name="rows"> Number of rows. </param>
        /// <param name="columns"> Number of columns. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputIds"/> is null. </exception>
        public GridInputGroup(IEnumerable<IList<string>> inputIds, int rows, int columns)
        {
            Argument.AssertNotNull(inputIds, nameof(inputIds));

            InputIds = inputIds.ToList();
            Rows = rows;
            Columns = columns;
            Kind = InputGroupType.GridBased;
        }

        /// <summary> Initializes a new instance of <see cref="GridInputGroup"/>. </summary>
        /// <param name="kind"> Kind of input group. </param>
        /// <param name="position"> The (x,y) position on scene or input group. </param>
        /// <param name="width"> The width of the input group container. Can be defined as pixels or percentage. </param>
        /// <param name="height"> The height of the input group container. Can be defined as pixels or percentage. </param>
        /// <param name="layer"> The layer this input group should appear on. </param>
        /// <param name="scalingMode"> The scaling mode for the view of a video stream in a cell. </param>
        /// <param name="inputIds"> Input and input group ids to be included in this input group. </param>
        /// <param name="rows"> Number of rows. </param>
        /// <param name="columns"> Number of columns. </param>
        internal GridInputGroup(InputGroupType kind, InputPosition position, string width, string height, string layer, ScalingMode? scalingMode, IList<IList<string>> inputIds, int rows, int columns) : base(kind, position, width, height, layer, scalingMode)
        {
            InputIds = inputIds;
            Rows = rows;
            Columns = columns;
            Kind = kind;
        }

        /// <summary> Input and input group ids to be included in this input group. </summary>
        public IList<IList<string>> InputIds { get; }
        /// <summary> Number of rows. </summary>
        public int Rows { get; set; }
        /// <summary> Number of columns. </summary>
        public int Columns { get; set; }
    }
}
