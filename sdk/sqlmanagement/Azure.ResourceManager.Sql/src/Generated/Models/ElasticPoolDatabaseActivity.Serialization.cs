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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolDatabaseActivity : IUtf8JsonSerializable, IJsonModel<ElasticPoolDatabaseActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticPoolDatabaseActivity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ElasticPoolDatabaseActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolDatabaseActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolDatabaseActivity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            if (options.Format != "W" && Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorSeverity))
            {
                writer.WritePropertyName("errorSeverity"u8);
                writer.WriteNumberValue(ErrorSeverity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedElasticPoolName))
            {
                writer.WritePropertyName("requestedElasticPoolName"u8);
                writer.WriteStringValue(RequestedElasticPoolName);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentElasticPoolName))
            {
                writer.WritePropertyName("currentElasticPoolName"u8);
                writer.WriteStringValue(CurrentElasticPoolName);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentServiceObjective))
            {
                writer.WritePropertyName("currentServiceObjective"u8);
                writer.WriteStringValue(CurrentServiceObjective);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedServiceObjective))
            {
                writer.WritePropertyName("requestedServiceObjective"u8);
                writer.WriteStringValue(RequestedServiceObjective);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
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

        ElasticPoolDatabaseActivity IJsonModel<ElasticPoolDatabaseActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolDatabaseActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolDatabaseActivity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolDatabaseActivity(document.RootElement, options);
        }

        internal static ElasticPoolDatabaseActivity DeserializeElasticPoolDatabaseActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string databaseName = default;
            DateTimeOffset? endTime = default;
            int? errorCode = default;
            string errorMessage = default;
            int? errorSeverity = default;
            string operation = default;
            Guid? operationId = default;
            int? percentComplete = default;
            string requestedElasticPoolName = default;
            string currentElasticPoolName = default;
            string currentServiceObjective = default;
            string requestedServiceObjective = default;
            string serverName = default;
            DateTimeOffset? startTime = default;
            string state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
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
                        if (property0.NameEquals("errorCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorSeverity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorSeverity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("operation"u8))
                        {
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedElasticPoolName"u8))
                        {
                            requestedElasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentElasticPoolName"u8))
                        {
                            currentElasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentServiceObjective"u8))
                        {
                            currentServiceObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedServiceObjective"u8))
                        {
                            requestedServiceObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
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
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
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
            return new ElasticPoolDatabaseActivity(
                id,
                name,
                type,
                systemData,
                location,
                databaseName,
                endTime,
                errorCode,
                errorMessage,
                errorSeverity,
                operation,
                operationId,
                percentComplete,
                requestedElasticPoolName,
                currentElasticPoolName,
                currentServiceObjective,
                requestedServiceObjective,
                serverName,
                startTime,
                state,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (Optional.IsDefined(Location) || hasPropertyOverride)
            {
                builder.Append("  location: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{Location.Value.ToString()}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseName), out propertyOverride);
            if (Optional.IsDefined(DatabaseName) || hasPropertyOverride)
            {
                builder.Append("    databaseName: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (DatabaseName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DatabaseName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DatabaseName}'");
                    }
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorCode), out propertyOverride);
            if (Optional.IsDefined(ErrorCode) || hasPropertyOverride)
            {
                builder.Append("    errorCode: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{ErrorCode.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorMessage), out propertyOverride);
            if (Optional.IsDefined(ErrorMessage) || hasPropertyOverride)
            {
                builder.Append("    errorMessage: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ErrorMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ErrorMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ErrorMessage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorSeverity), out propertyOverride);
            if (Optional.IsDefined(ErrorSeverity) || hasPropertyOverride)
            {
                builder.Append("    errorSeverity: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{ErrorSeverity.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Operation), out propertyOverride);
            if (Optional.IsDefined(Operation) || hasPropertyOverride)
            {
                builder.Append("    operation: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Operation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Operation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Operation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OperationId), out propertyOverride);
            if (Optional.IsDefined(OperationId) || hasPropertyOverride)
            {
                builder.Append("    operationId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{OperationId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PercentComplete), out propertyOverride);
            if (Optional.IsDefined(PercentComplete) || hasPropertyOverride)
            {
                builder.Append("    percentComplete: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{PercentComplete.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequestedElasticPoolName), out propertyOverride);
            if (Optional.IsDefined(RequestedElasticPoolName) || hasPropertyOverride)
            {
                builder.Append("    requestedElasticPoolName: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (RequestedElasticPoolName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RequestedElasticPoolName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RequestedElasticPoolName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentElasticPoolName), out propertyOverride);
            if (Optional.IsDefined(CurrentElasticPoolName) || hasPropertyOverride)
            {
                builder.Append("    currentElasticPoolName: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (CurrentElasticPoolName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CurrentElasticPoolName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CurrentElasticPoolName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentServiceObjective), out propertyOverride);
            if (Optional.IsDefined(CurrentServiceObjective) || hasPropertyOverride)
            {
                builder.Append("    currentServiceObjective: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (CurrentServiceObjective.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CurrentServiceObjective}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CurrentServiceObjective}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequestedServiceObjective), out propertyOverride);
            if (Optional.IsDefined(RequestedServiceObjective) || hasPropertyOverride)
            {
                builder.Append("    requestedServiceObjective: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (RequestedServiceObjective.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RequestedServiceObjective}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RequestedServiceObjective}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServerName), out propertyOverride);
            if (Optional.IsDefined(ServerName) || hasPropertyOverride)
            {
                builder.Append("    serverName: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ServerName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ServerName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ServerName}'");
                    }
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(State), out propertyOverride);
            if (Optional.IsDefined(State) || hasPropertyOverride)
            {
                builder.Append("    state: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (State.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{State}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{State}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ElasticPoolDatabaseActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolDatabaseActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolDatabaseActivity)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticPoolDatabaseActivity IPersistableModel<ElasticPoolDatabaseActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolDatabaseActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticPoolDatabaseActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolDatabaseActivity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticPoolDatabaseActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
