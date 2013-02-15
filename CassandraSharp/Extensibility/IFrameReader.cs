﻿// cassandra-sharp - a .NET client for Apache Cassandra
// Copyright (c) 2011-2013 Pierre Chalamet
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace CassandraSharp.Extensibility
{
    using System;
    using System.Collections.Generic;

    public interface IFrameReader : IDisposable
    {
        MessageOpcodes MessageOpcode { get; }

        byte StreamId { get; }

        Guid? TraceId { get; }

        Exception ResponseException { get; }

        byte ReadByte();

        short ReadShort();

        int ReadInt();

        string ReadString();

        string[] ReadStringList();

        byte[] ReadBytes();

        byte[] ReadShortBytes();

        Dictionary<string, string[]> ReadStringMultimap();
    }
}