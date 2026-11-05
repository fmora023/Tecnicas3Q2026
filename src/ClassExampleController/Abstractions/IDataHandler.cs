namespace ClassExampleController.Abstractions
{
    /// <summary>
    /// Interface for data handlers, which defines the contract for classes that handle data operations.
    /// </summary>
    /// <typeparam name="T">The type to be processed.</typeparam>
    public interface IDataHandler<T>
    {
        /// <summary>
        /// Saves the data.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="data">The data.</param>
        /// <returns>true if succeded, otherwise false.</returns>
        public bool SaveData(string filename, List<T> data);

        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns>the list with the elements loaded from the file.</returns>
        public List<T> LoadData(string filename);
    }
}
