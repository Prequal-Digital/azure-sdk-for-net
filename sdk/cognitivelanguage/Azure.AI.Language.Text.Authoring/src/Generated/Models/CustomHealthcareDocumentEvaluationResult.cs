// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring.Models
{
    /// <summary> Represents the document evaluation result for a custom entity recognition project. </summary>
    public partial class CustomHealthcareDocumentEvaluationResult : DocumentEvaluationResult
    {
        /// <summary> Initializes a new instance of <see cref="CustomHealthcareDocumentEvaluationResult"/>. </summary>
        /// <param name="location"> Represents the document path. </param>
        /// <param name="language"> Represents the document language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <param name="customHealthcareResult"> Represents the evaluation prediction for entity recognition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="language"/> or <paramref name="customHealthcareResult"/> is null. </exception>
        internal CustomHealthcareDocumentEvaluationResult(string location, string language, DocumentHealthcareEvaluationResult customHealthcareResult) : base(location, language)
        {
            Argument.AssertNotNull(location, nameof(location));
            Argument.AssertNotNull(language, nameof(language));
            Argument.AssertNotNull(customHealthcareResult, nameof(customHealthcareResult));

            ProjectKind = ProjectKind.CustomHealthcare;
            CustomHealthcareResult = customHealthcareResult;
        }

        /// <summary> Initializes a new instance of <see cref="CustomHealthcareDocumentEvaluationResult"/>. </summary>
        /// <param name="projectKind"> Represents the project kind. </param>
        /// <param name="location"> Represents the document path. </param>
        /// <param name="language"> Represents the document language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="customHealthcareResult"> Represents the evaluation prediction for entity recognition. </param>
        internal CustomHealthcareDocumentEvaluationResult(ProjectKind projectKind, string location, string language, IDictionary<string, BinaryData> serializedAdditionalRawData, DocumentHealthcareEvaluationResult customHealthcareResult) : base(projectKind, location, language, serializedAdditionalRawData)
        {
            CustomHealthcareResult = customHealthcareResult;
        }

        /// <summary> Initializes a new instance of <see cref="CustomHealthcareDocumentEvaluationResult"/> for deserialization. </summary>
        internal CustomHealthcareDocumentEvaluationResult()
        {
        }

        /// <summary> Represents the evaluation prediction for entity recognition. </summary>
        public DocumentHealthcareEvaluationResult CustomHealthcareResult { get; }
    }
}
