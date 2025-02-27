// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SelfHelp
{
    public partial class TroubleshooterResource : IJsonModel<TroubleshooterResourceData>
    {
        void IJsonModel<TroubleshooterResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TroubleshooterResourceData>)Data).Write(writer, options);

        TroubleshooterResourceData IJsonModel<TroubleshooterResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TroubleshooterResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TroubleshooterResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        TroubleshooterResourceData IPersistableModel<TroubleshooterResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TroubleshooterResourceData>(data, options);

        string IPersistableModel<TroubleshooterResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TroubleshooterResourceData>)Data).GetFormatFromOptions(options);
    }
}
