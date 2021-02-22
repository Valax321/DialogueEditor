using System;
using System.CodeDom;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Valax321.DialogueEditor.Project
{
    public class Variable
    {
        public enum Type
        {
            Boolean,
            Integer,
            Float,
            String,
            Guid
        }

        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Type VarType { get; set; }

        public string DefaultValue { get; set; }
    }

    public class VariableComparer : IComparer<Variable>
    {
        public int Compare(Variable x, Variable y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
}