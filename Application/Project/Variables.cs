using System.Collections.Generic;

namespace Valax321.DialogueEditor.Project
{
    public class Variables
    {
        private static readonly VariableComparer _comparer = new VariableComparer();

        public SortedSet<Variable> Vars { get; set; } = new SortedSet<Variable>(_comparer);

        public Variables()
        {
            Vars.Add(new Variable
            {
                Name = "Test Variable",
                VarType = Variable.Type.Boolean,
                DefaultValue = false.ToString()
            });
        }
    }
}