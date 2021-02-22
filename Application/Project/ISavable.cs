namespace Valax321.DialogueEditor.Project
{
    /// <summary>
    /// Interface for savable data.
    /// </summary>
    public interface ISaveable
    {
        /// <summary>
        /// Does this object require re-save?
        /// </summary>
        bool IsDirty { get; }

        /// <summary>
        /// Marks this object as dirty so it will be saved on the next save request.
        /// </summary>
        /// <returns></returns>
        bool MarkDirty();
    }
}