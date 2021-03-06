// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary> Report for a custom model training document. </summary>
    public partial class TrainingDocumentInfo
    {
        /// <summary> Initializes a new instance of TrainingDocumentInfo. </summary>
        /// <param name="documentName"> Training document name. </param>
        /// <param name="pageCount"> Total number of pages trained. </param>
        /// <param name="errors"> List of errors. </param>
        /// <param name="status"> Status of the training operation. </param>
        internal TrainingDocumentInfo(string documentName, int pageCount, IEnumerable<FormRecognizerError> errors, TrainingStatus status)
        {
            if (documentName == null)
            {
                throw new ArgumentNullException(nameof(documentName));
            }
            if (errors == null)
            {
                throw new ArgumentNullException(nameof(errors));
            }

            DocumentName = documentName;
            PageCount = pageCount;
            Errors = errors.ToArray();
            Status = status;
        }

        /// <summary> Initializes a new instance of TrainingDocumentInfo. </summary>
        /// <param name="documentName"> Training document name. </param>
        /// <param name="pageCount"> Total number of pages trained. </param>
        /// <param name="errors"> List of errors. </param>
        /// <param name="status"> Status of the training operation. </param>
        internal TrainingDocumentInfo(string documentName, int pageCount, IReadOnlyList<FormRecognizerError> errors, TrainingStatus status)
        {
            DocumentName = documentName;
            PageCount = pageCount;
            Errors = errors;
            Status = status;
        }

        /// <summary> Training document name. </summary>
        public string DocumentName { get; }
        /// <summary> List of errors. </summary>
        public IReadOnlyList<FormRecognizerError> Errors { get; }
        /// <summary> Status of the training operation. </summary>
        public TrainingStatus Status { get; }
    }
}
