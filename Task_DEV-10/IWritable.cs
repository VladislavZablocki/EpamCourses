namespace task_DEV_10
{
    /// <summary>
    /// Interface with method Write
    /// </summary>
    interface IWritable
    {
        /// <summary>
        /// Write data of class to file
        /// </summary>
        /// <param name="objectOfClass">class</param>
        /// <param name="pathToFile">path</param>
        void Write(object objectOfClass,string pathToFile);
    }
}
