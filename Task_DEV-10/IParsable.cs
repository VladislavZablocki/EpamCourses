namespace task_DEV_10
{
    /// <summary>
    /// Interface with method parse
    /// </summary>
    interface IParsable
    {
        /// <summary>
        /// parse file to any class
        /// </summary>
        /// <param name="pathToFile">path to file</param>
        /// <returns>object of file</returns>
        object Parse(string pathToFile);
    }
}
