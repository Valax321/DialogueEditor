using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using NLog;
using Valax321.DialogueEditor.Properties;

namespace Valax321.DialogueEditor.Project
{
    /// <summary>
    /// Class that manages dialogue project stuff
    /// </summary>
    public class DialogueProject : ISaveable
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        public static DialogueProject FromJson(string path)
        {
            if (path.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(path));

            if (!File.Exists(path))
                throw new FileNotFoundException("Could not find project file", path);

            try
            {
                using (var fs = File.OpenText(path))
                {
                    Logger.Info($"Loading project main file {path}");
                    var proj = JsonConvert.DeserializeObject<DialogueProject>(fs.ReadToEnd());
                    proj._isDirty = false;
                    return proj;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(Strings.ProjectLoadFailedMessage, ex.Message), 
                    Strings.ProjectLoadFailedMessage, 
                    MessageBoxButtons.OK);
                return null;
            }
        }

        [JsonIgnore]
        public string Path { get; set; }

        public Variables Globals { get; } = new Variables();

        public void SaveToFile(string path)
        {
            if (path.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(path));

            var result = DialogResult.Retry;
            do
            {
                try
                {
                    Logger.Info($"Saving project to {path}");
                    using (var fs = File.OpenWrite(path))
                    {
                        using (var sw = new StreamWriter(fs))
                        {
                            sw.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
                            _isDirty = false;
                        }
                    }

                    // TODO: write all project subfiles too

                    result = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    result = MessageBox.Show(string.Format(Strings.ProjectSaveFailedMessage, ex.Message),
                        Strings.ProjectSaveFailedCaption, MessageBoxButtons.RetryCancel);
                }
            } 
            while (result == DialogResult.Retry);
        }

        // TODO: check all dependencies for dirty flag
        [JsonIgnore]
        public bool IsDirty => _isDirty;
        private bool _isDirty = true;

        public bool MarkDirty()
        {
            if (_isDirty)
                return false;

            _isDirty = true;
            return true;
        }
    }
}