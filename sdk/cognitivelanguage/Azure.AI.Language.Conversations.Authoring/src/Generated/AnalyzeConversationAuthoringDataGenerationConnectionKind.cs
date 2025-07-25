// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents the connection kind for Azure OpenAI deployment. </summary>
    public readonly partial struct AnalyzeConversationAuthoringDataGenerationConnectionKind : IEquatable<AnalyzeConversationAuthoringDataGenerationConnectionKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationAuthoringDataGenerationConnectionKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnalyzeConversationAuthoringDataGenerationConnectionKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureOpenAIValue = "AzureOpenAI";

        /// <summary> AzureOpenAI. </summary>
        public static AnalyzeConversationAuthoringDataGenerationConnectionKind AzureOpenAI { get; } = new AnalyzeConversationAuthoringDataGenerationConnectionKind(AzureOpenAIValue);
        /// <summary> Determines if two <see cref="AnalyzeConversationAuthoringDataGenerationConnectionKind"/> values are the same. </summary>
        public static bool operator ==(AnalyzeConversationAuthoringDataGenerationConnectionKind left, AnalyzeConversationAuthoringDataGenerationConnectionKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnalyzeConversationAuthoringDataGenerationConnectionKind"/> values are not the same. </summary>
        public static bool operator !=(AnalyzeConversationAuthoringDataGenerationConnectionKind left, AnalyzeConversationAuthoringDataGenerationConnectionKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AnalyzeConversationAuthoringDataGenerationConnectionKind"/>. </summary>
        public static implicit operator AnalyzeConversationAuthoringDataGenerationConnectionKind(string value) => new AnalyzeConversationAuthoringDataGenerationConnectionKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnalyzeConversationAuthoringDataGenerationConnectionKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnalyzeConversationAuthoringDataGenerationConnectionKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
