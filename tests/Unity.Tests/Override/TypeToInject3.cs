// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
namespace Unity.Tests.Override
{
    public class TypeToInject3 : IInterfaceForTypesToInject
    {
        public TypeToInject3(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
}