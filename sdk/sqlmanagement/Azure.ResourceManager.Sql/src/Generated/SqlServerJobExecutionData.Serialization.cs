// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerJobExecutionData : IUtf8JsonSerializable, IJsonModel<SqlServerJobExecutionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerJobExecutionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlServerJobExecutionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerJobExecutionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerJobExecutionData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(JobVersion))
            {
                writer.WritePropertyName("jobVersion"u8);
                writer.WriteNumberValue(JobVersion.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StepName))
            {
                writer.WritePropertyName("stepName"u8);
                writer.WriteStringValue(StepName);
            }
            if (options.Format != "W" && Optional.IsDefined(StepId))
            {
                writer.WritePropertyName("stepId"u8);
                writer.WriteNumberValue(StepId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(JobExecutionId))
            {
                writer.WritePropertyName("jobExecutionId"u8);
                writer.WriteStringValue(JobExecutionId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Lifecycle))
            {
                writer.WritePropertyName("lifecycle"u8);
                writer.WriteStringValue(Lifecycle.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreateOn))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreateOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(CurrentAttempts))
            {
                writer.WritePropertyName("currentAttempts"u8);
                writer.WriteNumberValue(CurrentAttempts.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentAttemptStartOn))
            {
                writer.WritePropertyName("currentAttemptStartTime"u8);
                writer.WriteStringValue(CurrentAttemptStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastMessage))
            {
                writer.WritePropertyName("lastMessage"u8);
                writer.WriteStringValue(LastMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteObjectValue(Target, options);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SqlServerJobExecutionData IJsonModel<SqlServerJobExecutionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerJobExecutionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerJobExecutionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerJobExecutionData(document.RootElement, options);
        }

        internal static SqlServerJobExecutionData DeserializeSqlServerJobExecutionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? jobVersion = default;
            string stepName = default;
            int? stepId = default;
            Guid? jobExecutionId = default;
            JobExecutionLifecycle? lifecycle = default;
            JobExecutionProvisioningState? provisioningState = default;
            DateTimeOffset? createTime = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            int? currentAttempts = default;
            DateTimeOffset? currentAttemptStartTime = default;
            string lastMessage = default;
            JobExecutionTarget target = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("jobVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobVersion = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("stepName"u8))
                        {
                            stepName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("stepId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stepId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("jobExecutionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            jobExecutionId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("lifecycle"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lifecycle = new JobExecutionLifecycle(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new JobExecutionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("currentAttempts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentAttempts = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentAttemptStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentAttemptStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastMessage"u8))
                        {
                            lastMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            target = JobExecutionTarget.DeserializeJobExecutionTarget(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlServerJobExecutionData(
                id,
                name,
                type,
                systemData,
                jobVersion,
                stepName,
                stepId,
                jobExecutionId,
                lifecycle,
                provisioningState,
                createTime,
                startTime,
                endTime,
                currentAttempts,
                currentAttemptStartTime,
                lastMessage,
                target,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (Optional.IsDefined(Name) || hasPropertyOverride)
            {
                builder.Append("  name: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (Optional.IsDefined(Id) || hasPropertyOverride)
            {
                builder.Append("  id: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (Optional.IsDefined(SystemData) || hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobVersion), out propertyOverride);
            if (Optional.IsDefined(JobVersion) || hasPropertyOverride)
            {
                builder.Append("    jobVersion: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{JobVersion.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StepName), out propertyOverride);
            if (Optional.IsDefined(StepName) || hasPropertyOverride)
            {
                builder.Append("    stepName: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (StepName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StepName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StepName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StepId), out propertyOverride);
            if (Optional.IsDefined(StepId) || hasPropertyOverride)
            {
                builder.Append("    stepId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{StepId.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobExecutionId), out propertyOverride);
            if (Optional.IsDefined(JobExecutionId) || hasPropertyOverride)
            {
                builder.Append("    jobExecutionId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{JobExecutionId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Lifecycle), out propertyOverride);
            if (Optional.IsDefined(Lifecycle) || hasPropertyOverride)
            {
                builder.Append("    lifecycle: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Lifecycle.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (Optional.IsDefined(ProvisioningState) || hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreateOn), out propertyOverride);
            if (Optional.IsDefined(CreateOn) || hasPropertyOverride)
            {
                builder.Append("    createTime: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(CreateOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartOn), out propertyOverride);
            if (Optional.IsDefined(StartOn) || hasPropertyOverride)
            {
                builder.Append("    startTime: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndOn), out propertyOverride);
            if (Optional.IsDefined(EndOn) || hasPropertyOverride)
            {
                builder.Append("    endTime: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(EndOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentAttempts), out propertyOverride);
            if (Optional.IsDefined(CurrentAttempts) || hasPropertyOverride)
            {
                builder.Append("    currentAttempts: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{CurrentAttempts.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentAttemptStartOn), out propertyOverride);
            if (Optional.IsDefined(CurrentAttemptStartOn) || hasPropertyOverride)
            {
                builder.Append("    currentAttemptStartTime: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(CurrentAttemptStartOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastMessage), out propertyOverride);
            if (Optional.IsDefined(LastMessage) || hasPropertyOverride)
            {
                builder.Append("    lastMessage: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (LastMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastMessage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Target), out propertyOverride);
            if (Optional.IsDefined(Target) || hasPropertyOverride)
            {
                builder.Append("    target: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, Target, options, 4, false, "    target: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SqlServerJobExecutionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerJobExecutionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerJobExecutionData)} does not support writing '{options.Format}' format.");
            }
        }

        SqlServerJobExecutionData IPersistableModel<SqlServerJobExecutionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerJobExecutionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerJobExecutionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerJobExecutionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerJobExecutionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
