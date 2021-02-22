using System;
using NodeEditor;

namespace Valax321.DialogueEditor
{
    public class DialogueContext : INodesContext
    {
        public NodeVisual CurrentProcessingNode { get; set; }
        public event Action<string, NodeVisual, FeedbackType, object, bool> FeedbackInfo;

        [Node("Start", "Control", "Control", "Start node for dialogue execution", true, true)]
        public void StartNode()
        {

        }

        [Node("Say", "Control", "Control", "Says something")]
        public void SayNode()
        {

        }
    }
}