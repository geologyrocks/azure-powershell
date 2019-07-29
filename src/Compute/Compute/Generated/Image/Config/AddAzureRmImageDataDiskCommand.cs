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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Add, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ImageDataDisk", SupportsShouldProcess = true)]
    [OutputType(typeof(PSImage))]
    public partial class AddAzureRmImageDataDiskCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSImage Image { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public int Lun { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string BlobUri { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public CachingTypes? Caching { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public int DiskSizeGB { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS")]
        public string StorageAccountType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string SnapshotId { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string ManagedDiskId { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("Image", "Add"))
            {
                Run();
            }
        }

        private void Run()
        {
            // StorageProfile
            if (this.Image.StorageProfile == null)
            {
                this.Image.StorageProfile = new ImageStorageProfile();
            }

            // DataDisks
            if (this.Image.StorageProfile.DataDisks == null)
            {
                this.Image.StorageProfile.DataDisks = new List<ImageDataDisk>();
            }

            var vDataDisks = new ImageDataDisk();

            vDataDisks.Lun = this.Lun;
            vDataDisks.BlobUri = this.IsParameterBound(c => c.BlobUri) ? this.BlobUri : null;
            vDataDisks.Caching = this.IsParameterBound(c => c.Caching) ? this.Caching : (CachingTypes?)null;
            vDataDisks.DiskSizeGB = this.IsParameterBound(c => c.DiskSizeGB) ? this.DiskSizeGB : (int?)null;
            vDataDisks.StorageAccountType = this.IsParameterBound(c => c.StorageAccountType) ? this.StorageAccountType : null;
            if (this.IsParameterBound(c => c.SnapshotId))
            {
                // Snapshot
                vDataDisks.Snapshot = new SubResource();
                vDataDisks.Snapshot.Id = this.SnapshotId;
            }
            if (this.IsParameterBound(c => c.ManagedDiskId))
            {
                // ManagedDisk
                vDataDisks.ManagedDisk = new SubResource();
                vDataDisks.ManagedDisk.Id = this.ManagedDiskId;
            }
            this.Image.StorageProfile.DataDisks.Add(vDataDisks);
            WriteObject(this.Image);
        }
    }
}