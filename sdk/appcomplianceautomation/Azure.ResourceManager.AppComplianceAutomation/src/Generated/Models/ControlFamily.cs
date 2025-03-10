// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> A class represent the control family. </summary>
    public partial class ControlFamily
    {
        /// <summary> Initializes a new instance of ControlFamily. </summary>
        internal ControlFamily()
        {
            Controls = new ChangeTrackingList<Control>();
        }

        /// <summary> Initializes a new instance of ControlFamily. </summary>
        /// <param name="familyName"> The name of the control family. e.g. &quot;Malware Protection - Anti-Virus&quot;. </param>
        /// <param name="familyType"> The control family type. </param>
        /// <param name="familyStatus"> Control family status. </param>
        /// <param name="controls"> List of controls. </param>
        internal ControlFamily(string familyName, ControlFamilyType? familyType, ControlFamilyStatus? familyStatus, IReadOnlyList<Control> controls)
        {
            FamilyName = familyName;
            FamilyType = familyType;
            FamilyStatus = familyStatus;
            Controls = controls;
        }

        /// <summary> The name of the control family. e.g. &quot;Malware Protection - Anti-Virus&quot;. </summary>
        public string FamilyName { get; }
        /// <summary> The control family type. </summary>
        public ControlFamilyType? FamilyType { get; }
        /// <summary> Control family status. </summary>
        public ControlFamilyStatus? FamilyStatus { get; }
        /// <summary> List of controls. </summary>
        public IReadOnlyList<Control> Controls { get; }
    }
}
