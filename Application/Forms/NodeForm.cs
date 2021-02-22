using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valax321.DialogueEditor.Forms
{
    public partial class NodeForm : Form
    {
        private DialogueContext context = new DialogueContext();

        public NodeForm()
        {
            InitializeComponent();
        }

        private void NodeForm_Load(object sender, EventArgs e)
        {
            nodeCanvas.Context = context;
        }
    }
}
